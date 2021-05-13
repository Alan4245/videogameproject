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
using System.Xml.Serialization;
using System.IO;

namespace Esercizio_Videogioco
{
    /// <summary>
    /// Logica di interazione per Negozio.xaml
    /// </summary>
    public partial class Negozio : Window
    {
        private Negozioclass _negozio;
        private Videogioco _videogioco;
        private List<Arma> _armiAbilitate;
        private List<Arma> _armiPossedute;
        public Negozio(Videogioco videogiocoattuale)
        {
            InitializeComponent();
            _negozio = new Negozioclass(videogiocoattuale);
            _videogioco = videogiocoattuale;
            Inizializzazione();
        }

        public void Inizializzazione()
        {
            btnCompra.IsEnabled = false;
            foreach (Personaggio personaggio in _videogioco.Personaggi)
            {
                ComboPersonaggio.Items.Add(personaggio);
            }
        }

        private void ComboPersonaggio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Personaggio p = ComboPersonaggio.SelectedItem as Personaggio;
            NomePersonaggioScelto.Content = p.Nome;
            Soldi.Content = p.Monete + " $";
            Livello.Content = "LVL. " + p.Exp / 100;
            ProgressLivello.Value = p.Exp % 100;
            PercentualeProgressBar.Content = p.Exp % 100 + "%";
            _armiPossedute = _negozio.OttieniArmiPossedute(p);
            _armiAbilitate = _negozio.OttieniArmiAbilitatePersonaggio(p);
            btnCompra.IsEnabled = false;
            ComboArma.Items.Clear();
            foreach(Arma arma in _armiAbilitate)
            {
                ComboArma.Items.Add(arma);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            menu nuovoMenu = new menu(_videogioco);
            nuovoMenu.Show();
            this.Close();

        }

        private void ComboArma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboArma.SelectedIndex >= 0)
            {
                Personaggio p = ComboPersonaggio.SelectedItem as Personaggio;
                Arma arma = ComboArma.SelectedItem as Arma;
                NomeArma.Content = arma.Nome;
                Descrizione.Content = arma.Descrizione;
                Uri uriImg = new Uri(arma.ImgPath, UriKind.Relative);
                ImageSource img = new BitmapImage(uriImg);
                Img_Arma.Source = img;
                LivelloRichiesto.Content = "LVL. SBLOCCO: " + arma.ExpRichiesta / 100;
                SoldiRichiesti.Content = "COSTO: " + arma.MoneteRichieste + " $";
                btnCompra.IsEnabled = true;
                foreach (Arma armaPersonaggio in p.Armi)
                {
                    if (armaPersonaggio.Nome == arma.Nome)
                    {
                        NomeArma.Content = arma.Nome + " - POSSEDUTA";
                        btnCompra.IsEnabled = false;
                    }
                        
                }
            }

        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {
            Personaggio p = ComboPersonaggio.SelectedItem as Personaggio;
            Arma arma = ComboArma.SelectedItem as Arma;
            if (p.Monete >= arma.MoneteRichieste && p.Exp >= arma.ExpRichiesta)
            {
                p.Monete = p.Monete - arma.MoneteRichieste;
                p.AggiungiArma(arma);

                btnCompra.IsEnabled = false;

                ComboArma.Items.Clear();
                foreach (Arma arma2 in _armiAbilitate)
                {
                    ComboArma.Items.Add(arma2);
                }
                Soldi.Content = p.Monete + " $";
                NomeArma.Content = arma.Nome + " - POSSEDUTA";
                _videogioco.RimuoviPersonaggio(p);
                _videogioco.AggiungiPersonaggio(p);
                Serializza();
            }
            else if(p.Monete < arma.MoneteRichieste && p.Exp < arma.ExpRichiesta)
            {
                MessageBox.Show("Non hai raggiunto l'esperienza necessaria e sei anche povero!");
            }
            else if (p.Monete >= arma.MoneteRichieste)
            {
                MessageBox.Show("Non hai raggiunto l'esperienza necessaria!");
            }
            else
            {
                MessageBox.Show("Non hai sufficienti monete!");
            }

        }

        public void Serializza()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Videogioco));
            TextWriter writer = new StreamWriter("videogioco.xml");
            serializer.Serialize(writer, _videogioco);

        }
    }
}
