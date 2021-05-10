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
            Soldi.Content = p.Monete;
            Livello.Content = "LVL. " + p.Exp / 100;
            ProgressLivello.Value = p.Exp % 100;
            PercentualeProgressBar.Content = p.Exp % 100 + "%";
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            menu nuovoMenu = new menu(_videogioco);
            nuovoMenu.Show();
            this.Close();

        }
    }
}
