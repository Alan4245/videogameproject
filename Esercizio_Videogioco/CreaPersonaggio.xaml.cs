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
    /// Logica di interazione per CreaPersonaggio.xaml
    /// </summary>
    public partial class CreaPersonaggio : Window
    {
        public Videogioco v;
        public CreaPersonaggio(Videogioco videogioco)
        {
            InitializeComponent();
            v = videogioco;
            RiempiElementi();
        }

        private void RiempiElementi()
        {
            Combo_Tipo_Personaggio.Items.Clear();
            lstAltriPersonaggi.Items.Clear();
            foreach (Razza r in v.Razze)
            {
                Combo_Tipo_Personaggio.Items.Add(r.Nome);
            }

            foreach (Personaggio p in v.Personaggi)
            {
                lstAltriPersonaggi.Items.Add(p.Nome);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Combo_Tipo_Personaggio.SelectedIndex < 0)
                    throw new Exception("Razza non selezionata");
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                    throw new Exception("Il nome non è valido");
                Personaggio p = new Personaggio(txtNome.Text, v.Razze[Combo_Tipo_Personaggio.SelectedIndex]);
                v.AggiungiPersonaggio(p);
                Serializza();
                menu nuovomenu = new menu(v);
                nuovomenu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Combo_Tipo_Personaggio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Combo_Tipo_Personaggio.SelectedIndex >= 0)
            {
                try
                {
                    Razza razzaCorrente = v.Razze[Combo_Tipo_Personaggio.SelectedIndex];
                    Uri uriImg = new Uri(razzaCorrente.ImgPath, UriKind.Relative);
                    ImageSource img = new BitmapImage(uriImg);
                    Img_Personaggio.Source = img;
                }catch(Exception ex)
                {
                    MessageBox.Show("Impossibile visionare l'anteprima: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Impossibile vedere l'anteprima");
            }
        }

        public void Serializza()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Videogioco));
            TextWriter writer = new StreamWriter("videogioco.xml");
            serializer.Serialize(writer, v);

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            menu nuovoMenu = new menu(v);
            nuovoMenu.Show();
            this.Close();


        }
    }
}
