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

namespace Esercizio_Videogioco
{
    /// <summary>
    /// Logica di interazione per Negozio.xaml
    /// </summary>
    public partial class Negozio : Window
    {
        Videogioco v;
        Personaggio acquirente;
        Arma arma;
        public Negozio(Videogioco videogioco)
        {
            InitializeComponent();
            v = videogioco;
            RiempiCmbEArma();
        }

        public void RiempiCmbEArma()
        {
            cmbPersonaggi.Items.Clear();
            foreach(Personaggio p in v.Personaggi)
            {
                cmbPersonaggi.Items.Add(p.Nome);
            }
        }

        private void cmbPersonaggi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbPersonaggi.SelectedIndex >= 0)
            {
                acquirente = v.Personaggi[cmbPersonaggi.SelectedIndex];
                lblSaldo.Content = ("Saldo: $" + acquirente.Monete);

                
                foreach(Arma a in v.Armi)
                {
                    if (acquirente.Razza.CategorieArmi.Contains(a.Categoria))
                    {
                        //setta immagine in base alla categoria
                        arma = a;
                        break;
                    }
                }

                lblArma.Content = arma.Nome;
                btnAcquista.Content = "$" + arma.MoneteRichieste;
            }
        }

        private void btnAcquista_Click(object sender, RoutedEventArgs e)
        {
            if (arma.MoneteRichieste <= acquirente.Monete)
            {
                v.Personaggi[cmbPersonaggi.SelectedIndex].Monete -= arma.MoneteRichieste;
                v.Personaggi[cmbPersonaggi.SelectedIndex].AggiungiArma(arma);
                btnAcquista.Content = "Comprata!";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            menu n = new menu(v);
            n.Show();
            this.Close();
        }
    }
}
