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

namespace Esercizio_Videogioco
{
    /// <summary>
    /// Logica di interazione per Gioca.xaml
    /// </summary>
    public partial class Gioca : Window
    {
        private Videogioco _videogiocolocale;
        private ImageSource _img;
        private Uri _uriImg;
        public Gioca(Videogioco videogioco)
        {
            InitializeComponent();
            _videogiocolocale = videogioco;
            Inizializza();
        }

        public void Inizializza()
        {
            foreach(Personaggio p in _videogiocolocale.Personaggi)
            {
                Combo_Personaggio1.Items.Add(p);
                Combo_Personaggio2.Items.Add(p);
            }

            ComboSfondo.Items.Add("7ZONE");
            ComboSfondo.Items.Add("CIMITERO");
            ComboSfondo.Items.Add("DINOSAURI");
            ComboSfondo.Items.Add("GIGANTI");
            ComboSfondo.Items.Add("PALUDE MAGICA");
            ComboSfondo.Items.Add("CLASSICO");
            ComboSfondo.Items.Add("LA LATRINA DI SHREK");
            ComboSfondo.Items.Add("POKEMON");

        }

        private void ComboSfondo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (ComboSfondo.SelectedIndex)
            {
                case 0: _uriImg = new Uri("imgsfondi/Sfondo7Zone.png", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 1:
                    _uriImg = new Uri("imgsfondi/SfondoCimitero.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 2:
                    _uriImg = new Uri("imgsfondi/SfondoDino.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 3:
                    _uriImg = new Uri("imgsfondi/SfondoGigante.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 4:
                    _uriImg = new Uri("imgsfondi/SfondoMago.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 5:
                    _uriImg = new Uri("imgsfondi/SfondoNormale.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 6:
                    _uriImg = new Uri("imgsfondi/SfondoOrco.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                case 7:
                    _uriImg = new Uri("imgsfondi/SfondoPokemon.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
                default:
                    _uriImg = new Uri("imgsfondi/SfondoNormale.jpg", UriKind.Relative);
                    _img = new BitmapImage(_uriImg);
                    Img_Sfondo.Source = _img;
                    break;
            }

        }

        private void Combo_Personaggio1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Personaggio p = Combo_Personaggio1.SelectedItem as Personaggio;
            foreach (Arma arma in p.Armi)
            {
                Combo_Arma_Personaggio1.Items.Add(arma);
            }
        }

        private void Combo_Personaggio2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Personaggio p = Combo_Personaggio2.SelectedItem as Personaggio;
            foreach (Arma arma in p.Armi)
            {
                Combo_Arma_Personaggio2.Items.Add(arma);
            }
        }
    }
}
