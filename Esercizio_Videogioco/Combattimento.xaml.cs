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
    /// Logica di interazione per Combattimento.xaml
    /// </summary>
    public partial class Combattimento : Window
    {
        private Personaggio p11;
        private Personaggio p22;
        private Videogioco _videogiocolocale;
        public Combattimento(Personaggio p1, Personaggio p2, Arma arma1, Arma arma2, ImageSource imgSfondo, Videogioco videogioco)
        {
            InitializeComponent();
            p11 = p1;
            p22 = p2;

            Combattimentoclass classeCombattimento = new Combattimentoclass(ref p11, ref p22, arma1, arma2);
            classeCombattimento.AssegnaVittoria();
            if(p11.Nome == classeCombattimento.Vincitore.Nome)
            {
                p11.Exp += classeCombattimento.AssegnaExp(true);
                p22.Exp += classeCombattimento.AssegnaExp(false);
                p11.Monete += classeCombattimento.AssegnaDenaro(true);
                p22.Monete += classeCombattimento.AssegnaDenaro(false);

            }
            else
            {
                p11.Exp += classeCombattimento.AssegnaExp(false);
                p22.Exp += classeCombattimento.AssegnaExp(true);
                p11.Monete += classeCombattimento.AssegnaDenaro(false);
                p22.Monete += classeCombattimento.AssegnaDenaro(true);
            }

            MessageBox.Show("Il vincitore è " + classeCombattimento.Vincitore.Nome);
        }

        public void SostituisciPersonaggio(Personaggio personaggio)
        {
            foreach(Personaggio p in _videogiocolocale.Personaggi)
            {
                if (p.Nome == personaggio.Nome)
                {
                    p.Exp = personaggio.Exp;
                    p.Monete = personaggio.Monete;
                }
                    
            }
        }
    }
}
