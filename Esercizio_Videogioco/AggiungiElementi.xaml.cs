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
    }
}
