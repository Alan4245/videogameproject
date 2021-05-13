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
        public Combattimento(Personaggio p1, Personaggio p2, Arma arma1, Arma arma2, ImageSource imgSfondo, Videogioco videogioco)
        {
            InitializeComponent();
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
        }

        public void SostituisciPersonaggio(Personaggio personaggio)
        {
            foreach(Personaggio p in _videogiocolocale.Personaggi)
            {
                if (p.Nome == personaggio.Nome)
                {
                    p.Exp = personaggio.Exp;
                    p.Monete = personaggio.Monete;
                }
                    
            }
        }

        private void btn_INIZIA_Click(object sender, RoutedEventArgs e)
        {

            Combattimentoclass classeCombattimento = new Combattimentoclass(ref p11, ref p22, arma11, arma22);
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

            MessageBox.Show("Il vincitore è " + classeCombattimento.Vincitore.Nome);

            SostituisciPersonaggio(p11);
            SostituisciPersonaggio(p22);
            Serializza();
            menu schermataMenu = new menu(_videogiocolocale);
            schermataMenu.Show();
            this.Close();
        }

        public void Serializza()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Videogioco));
            TextWriter writer = new StreamWriter("videogioco.xml");
            serializer.Serialize(writer, _videogiocolocale);

        }
    }
}
