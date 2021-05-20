using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Media;

namespace Esercizio_Videogioco
{
    /// <summary>
    /// Logica di interazione per Combattimento.xaml
    /// </summary>
    public partial class Combattimento : Window
    {
        private Personaggio p11;
        private Personaggio p22;
        private Videogioco _videogiocolocale;
        private Uri _uriImg;
        private Uri _uriImg2;
        private ImageSource _img;
        private ImageSource _img2;
        private Arma arma11;
        private Arma arma22;

        private int vita1;
        private int vita2;
        private Thread prog1;
        private Thread prog2;
        private Thread muoviPrimo;
        private Thread muoviSecondo;
        private int margine1 = 32;
        private int margine2 = 611;
        Combattimentoclass classeCombattimento;
        SoundPlayer splayer;

        public Combattimento(Personaggio p1, Personaggio p2, Arma arma1, Arma arma2, ImageSource imgSfondo, Videogioco videogioco)
        {
            InitializeComponent();
            btn_INIZIA.IsEnabled = true;
            p11 = p1;
            p22 = p2;
            arma11 = arma1;
            arma22 = arma2;
            NomePersonaggio1.Content = p11.Nome;
            NomePersonaggio2.Content = p22.Nome;
            _uriImg = new Uri(p1.Razza.ImgPath, UriKind.Relative);
            _img = new BitmapImage(_uriImg);
            _uriImg2 = new Uri(p2.Razza.ImgPath, UriKind.Relative);
            _img2 = new BitmapImage(_uriImg2);
            ImgPersonaggio1.Source = _img;
            ImgPersonaggio2.Source = _img2;
            Sfondo.Source = imgSfondo;
            _videogiocolocale = videogioco;
            splayer = new SoundPlayer(@"WAV\easteregg.wav");

            prog1 = new Thread(new ThreadStart(AbbassaBarra1));
            prog2 = new Thread(new ThreadStart(AbbassaBarra2));
            muoviPrimo = new Thread(new ThreadStart(Muovi1));
            muoviSecondo = new Thread(new ThreadStart(Muovi2));
            ImgPersonaggio1.Margin = new Thickness(margine1, 146, 0, 0);
            ImgPersonaggio2.Margin = new Thickness(margine2, 146, 0, 0);
            ImgPersonaggio1.Visibility = Visibility.Visible;
            ImgPersonaggio2.Visibility = Visibility.Visible;
        }

        public void SostituisciPersonaggio(Personaggio personaggio)
        {
            foreach (Personaggio p in _videogiocolocale.Personaggi)
            {
                if (p.Nome == personaggio.Nome)
                {
                    p.Exp = personaggio.Exp;
                    p.Monete = personaggio.Monete;
                }

            }
        }

        private void AbbassaBarra1()
        {
            muoviSecondo.Join();
            muoviPrimo.Join();
            this.Dispatcher.BeginInvoke(new Action(() =>
            {

                ProgressPersonaggio1.Value = 100;

            }));

            int v1 = 100;

            while (v1 > vita1)
            {
                v1 -= 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    ProgressPersonaggio1.Value = v1;

                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(50));
            }


            if (Vincitore == classeCombattimento.Personaggio2.Nome)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    ImgPersonaggio1.Visibility = Visibility.Hidden;

                }));
            }
        }

        private void AbbassaBarra2()
        {
            muoviSecondo.Join();
            muoviPrimo.Join();
            this.Dispatcher.BeginInvoke(new Action(() =>
            {

                ProgressPersonaggio2.Value = 100;


            }));

            int v2 = 100;

            while (v2 > vita2)
            {
                v2 -= 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    ProgressPersonaggio2.Value = v2;


                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(50));
            }
            if (Vincitore == classeCombattimento.Personaggio1.Nome)
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    ImgPersonaggio2.Visibility = Visibility.Hidden;

                }));
            }
        }



        private void Muovi1()
        {
            int nuovo = margine1;
            while (nuovo < 321)
            {
                nuovo += 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    ImgPersonaggio1.Margin = new Thickness(nuovo, 146, 0, 0);

                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(5));
            }
        }

        private void Muovi2()
        {
            int nuovo = margine2;
            while (nuovo > 321)
            {
                nuovo -= 1;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {

                    ImgPersonaggio2.Margin = new Thickness(nuovo, 146, 0, 0);

                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(5));
            }
        }

        private string Vincitore;

        private void Concludi()
        {
            if (Vincitore == "Pareggio")
                MessageBox.Show("È un pareggio");
            else
                MessageBox.Show("Il vincitore è " + Vincitore);

            SostituisciPersonaggio(p11);
            SostituisciPersonaggio(p22);
            Serializza();
            menu schermataMenu = new menu(_videogiocolocale);
            schermataMenu.Show();
            splayer.Stop();
            this.Close();
        }

        private void btn_INIZIA_Click(object sender, RoutedEventArgs e)
        {
            btn_INIZIA.IsEnabled = false;
            if(p11.Nome.ToLower() == "rwondo" || p22.Nome.ToLower() == "rwondo")
            {
                splayer.Play();
            }

            classeCombattimento = new Combattimentoclass(ref p11, ref p22, arma11, arma22);

            classeCombattimento.AssegnaVittoria();
            if (p11.Nome == classeCombattimento.Vincitore.Nome)
            {
                p11.Exp += classeCombattimento.AssegnaExp(true);
                p22.Exp += classeCombattimento.AssegnaExp(false);
                p11.Monete += classeCombattimento.AssegnaDenaro(true);
                p22.Monete += classeCombattimento.AssegnaDenaro(false);

            }
            else
            {
                p11.Exp += classeCombattimento.AssegnaExp(false);
                p22.Exp += classeCombattimento.AssegnaExp(true);
                p11.Monete += classeCombattimento.AssegnaDenaro(false);
                p22.Monete += classeCombattimento.AssegnaDenaro(true);
            }

            double d1 = classeCombattimento.Arma1.PuntiDanno;
            double d2 = classeCombattimento.Arma2.PuntiDanno;
            double p1 = classeCombattimento.Personaggio1.Razza.LifePoints;
            double p2 = classeCombattimento.Personaggio2.Razza.LifePoints;

            while (p1 > 0 && p2 > 0)
            {
                p1 -= d2;
                p2 -= d1;
            }

            if (p1 < 0)
            {
                p1 = 0;
            }
            if (p2 < 0)
            {
                p2 = 0;
            }


            vita1 = (int)((p1 * 100) / classeCombattimento.Personaggio1.Razza.LifePoints);
            vita2 = (int)((p2 * 100) / classeCombattimento.Personaggio2.Razza.LifePoints);
            Vincitore = classeCombattimento.Vincitore.Nome;

            muoviPrimo.Start();
            muoviSecondo.Start();

            prog1.Start();
            prog2.Start();



            Concludi();
        }

        public void Serializza()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Videogioco));
            TextWriter writer = new StreamWriter("videogioco.xml");
            serializer.Serialize(writer, _videogiocolocale);

        }
    }
}
