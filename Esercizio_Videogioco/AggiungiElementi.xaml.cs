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
    /// Logica di interazione per AggiungiElementi.xaml
    /// </summary>
    public partial class AggiungiElementi : Window
    {
        Videogioco videogiocolocale;
        public AggiungiElementi(Videogioco videogioco)
        {
            InitializeComponent();
            videogiocolocale = videogioco;
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {

            string id = inputCategoriaID.Text;
            string nome = inputCategoriaNOME.Text;
            Categoria nuovaCat = new Categoria(id, nome);
            videogiocolocale.AggiungiCategoria(nuovaCat);

        }

        private void btnRazza_Click(object sender, RoutedEventArgs e)
        {
            string id = inputRazzaID.Text;
            string nome = inputRazzaNOME.Text;
            double lp = double.Parse(inputRazzaLP.Text);
            List<Categoria> categorieRazza = new List<Categoria>();
            foreach(Categoria cat in videogiocolocale.Categorie)
            {
                categorieRazza.Add(cat);
            }
            Razza nuovaRazza = new Razza(id, nome, categorieRazza, lp);
            videogiocolocale.AggiungiRazza(nuovaRazza);
        }

        private void btnArma_Click(object sender, RoutedEventArgs e)
        {

            string descrizione = inputArmaDESCRIZIONE.Text;
            string nome = inputArmaNOME.Text;
            double puntiDanno = double.Parse(inputArmaPUNTIDANNO.Text);
            int expSblocco = int.Parse(inputArmaEXP.Text);
            int costoDenaro = int.Parse(inputArmaMONETE.Text);
            Random r = new Random();
            int k = videogiocolocale.Categorie.Count;
            Categoria cat = videogiocolocale.Categorie.ElementAt<Categoria>(k);
            Arma nuovaArma = new Arma(descrizione, nome, puntiDanno, cat, expSblocco, costoDenaro);
            videogiocolocale.AggiungiArma(nuovaArma);

        }

        private void btnPanic_Click(object sender, RoutedEventArgs e)
        {
            menu nuovoMenu = new menu(videogiocolocale);
            Serializza();
            nuovoMenu.Show();
            this.Close();
        }

        public void Serializza()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Videogioco));
            TextWriter writer = new StreamWriter("videogioco.xml");
            serializer.Serialize(writer, videogiocolocale);

        }
    }
}
