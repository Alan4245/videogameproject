using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Negozioclass
    {
        private Videogioco _videogiocolocale;
        public Negozioclass(Videogioco videogioco)
        {
            _videogiocolocale = videogioco;
        }


        public void AggiungiArmaPersonaggio()
        {
            throw new System.NotImplementedException();
        }

        public void VendiArmaPersonaggio()
        {
            throw new System.NotImplementedException();
        }

        public void RitornaExp()
        {
            throw new System.NotImplementedException();
        }

        public void RitornaDenaro()
        {
            throw new System.NotImplementedException();
        }

        public List<Arma> OttieniArmiAbilitatePersonaggio(Personaggio p)
        {
            List<Arma> armiAbilitate = new List<Arma>();
            foreach(Arma arma in _videogiocolocale.Armi)
            {
                foreach(Categoria cat in p.Razza.CategorieArmi)
                {
                    if (arma.Categoria.Equals(cat))
                        armiAbilitate.Add(arma);
                }
            }
            return armiAbilitate;
        }

        public List<Arma> OttieniArmiPossedute(Personaggio p)
        {
            return p.Armi;
        }
    }
}