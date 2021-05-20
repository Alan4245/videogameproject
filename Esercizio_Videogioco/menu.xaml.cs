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
    /// Logica di interazione per menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        Videogioco videogiocolocale;
        public menu()
        {
            InitializeComponent();
            videogiocolocale = new Videogioco();
            Avviamento();
            btnDebugging.Visibility = Visibility.Hidden; //rimuovere questa riga per abilitare il menu per il debugging.
        }

        public menu(Videogioco videogioco)
        {
            InitializeComponent();
            videogiocolocale = videogioco;
            btnDebugging.Visibility = Visibility.Hidden; //rimuovere questa riga per abilitare il menu per il debugging.
        }

        public void Avviamento()
        {

            try
            {
                videogiocolocale = Deserializzazione();
            }catch(Exception ex)
            {
                MessageBox.Show("Impossibile caricare la lista di elementi del videogioco: " + ex.Message);
            }

        }

        public Videogioco Deserializzazione()
        {
            Videogioco nuovoVideogioco = new Videogioco();

            if (!File.Exists("videogioco.xml"))
                throw new FileNotFoundException("File non esistente");

            XmlSerializer serializer = new XmlSerializer(typeof(Videogioco));

            using (Stream reader = new FileStream("videogioco.xml", FileMode.Open))
            {
                nuovoVideogioco = (Videogioco)serializer.Deserialize(reader);
            }

            return nuovoVideogioco;
        }

        private void Btn_CreaPersonaggio_Click(object sender, RoutedEventArgs e)
        {

            CreaPersonaggio schermataCreazioni = new CreaPersonaggio(videogiocolocale);
            schermataCreazioni.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AggiungiElementi nuovoAggiungiElementi = new AggiungiElementi(videogiocolocale);
            nuovoAggiungiElementi.Show();
            this.Close();
        }

        private void Btn_Negozio_Click(object sender, RoutedEventArgs e)
        {
            Negozio schermatanegozio = new Negozio(videogiocolocale);
            schermatanegozio.Show();
            this.Close();
        }

        private void Btn_Gioca_Click(object sender, RoutedEventArgs e)
        {

            Gioca schermataGioca = new Gioca(videogiocolocale);
            schermataGioca.Show();
            this.Close();

        }
    }
}
