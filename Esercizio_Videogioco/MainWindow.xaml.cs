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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Xml.Serialization;

namespace Esercizio_Videogioco
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Inizio_Copy_Click(object sender, RoutedEventArgs e)
        {
            menu nuovoMenu = new menu();
            nuovoMenu.Show();
            this.Close();
        }
    }
}
