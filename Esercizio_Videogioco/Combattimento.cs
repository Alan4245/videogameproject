using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Combattimento
    {
        private Personaggio _personaggio1;
        private Personaggio _personaggio2;
        private Arma _arma1;
        private Arma _arma2;

        public Personaggio Personaggio1
        {
            get => default;
            set
            {
            }
        }

        public Personaggio Personaggio2
        {
            get => default;
            set
            {
            }
        }

        public Arma Arma1
        {
            get => default;
            set
            {
            }
        }

        public Arma Arma2
        {
            get => default;
            set
            {
            }
        }

        public double CalcolaDanni()
        {
            throw new System.NotImplementedException();
        }

        public double AssegnaExp()
        {
            throw new System.NotImplementedException();
        }

        public int AssegnaDenaro()
        {
            throw new System.NotImplementedException();
        }

        public void AssegnaVittoria()
        {
            throw new System.NotImplementedException();
        }
    }
}