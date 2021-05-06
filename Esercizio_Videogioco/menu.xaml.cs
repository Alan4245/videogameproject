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
        Videogioco videogioco;
        public menu()
        {
            InitializeComponent();
            videogioco = new Videogioco();
            Avviamento();
        }

        public menu(List<Personaggio> personaggi, List<Razza> razze, List<Arma> armi, List<Categoria> categorie)
        {
            InitializeComponent();
        }

        public void Avviamento()
        {

            try
            {
                videogioco.Personaggi = DeserializzazionePersonaggi();
            }catch(Exception ex)
            {
                MessageBox.Show("Impossibile caricare la lista di personaggi: " + ex.Message);
            }

        }

        public List<Personaggio> DeserializzazionePersonaggi()
        {
            List<Personaggio> personaggi = new List<Personaggio>();

            if (!File.Exists("personaggi.xml"))
                throw new FileNotFoundException("File non esistente");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Personaggio>));

            using (Stream reader = new FileStream("personaggi.xml", FileMode.Open))
            {
                personaggi = (List<Personaggio>)serializer.Deserialize(reader);
            }

            return personaggi;
        }


    }
}
