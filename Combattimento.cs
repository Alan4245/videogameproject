using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Combattimentoclass
    {
        private Personaggio _personaggio1;
        private Personaggio _personaggio2;
        private Personaggio _vincitore;
        private Arma _arma1;
        private Arma _arma2;

        public Combattimentoclass(ref Personaggio p1, ref Personaggio p2, Arma a1, Arma a2)
        {
            try
            {
                Personaggio1 = p1;
                Personaggio2 = p2;
                Arma1 = a1;
                Arma2 = a2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Personaggio Personaggio1
        {
            get
            {
                return _personaggio1;
            }
            set
            {
                if (value == Personaggio2)
                    throw new Exception("I due personaggi non possono essere uguali");
                _personaggio1 = value;
            }
        }

        public Personaggio Personaggio2
        {
            get
            {
                return _personaggio2;
            }
            set
            {
                if (value == Personaggio1)
                    throw new Exception("I due personaggi non possono essere uguali");
                _personaggio2 = value;
            }
        }

        private Personaggio Vincitore
        {
            get
            {
                return _vincitore;
            }
            set
            {
                _vincitore = value;
            }
        }

        public Arma Arma1
        {
            get
            {
                return _arma1;
            }
            set
            {
                _arma1 = value;
            }
        }

        public Arma Arma2
        {
            get
            {
                return _arma2;
            }
            set
            {
                _arma2 = value;
            }
        }

        public void AssegnaVittoria()
        {
            double d1 = Arma1.PuntiDanno;
            double d2 = Arma2.PuntiDanno;
            double p1 = Personaggio1.Razza.LifePoints;
            double p2 = Personaggio2.Razza.LifePoints;

            while (p1 <= 0 || p2 <= 0)
            {
                p1 -= d2;
                p2 -= d1;
            }

            if (p1 < p2)
                Vincitore = Personaggio2;
            else if (p1 > p2)
                Vincitore = Personaggio1;
            else if (p1 == p2)
                throw new Exception("Pareggio");
        }

        public int AssegnaExp()
        {
            int xp = 0;
            if (Vincitore == Personaggio1)
            {
                xp = (int)(10 + (Personaggio2.Razza.LifePoints - Arma1.PuntiDanno));
            }
            else
            {
                xp = (int)(10 + (Personaggio1.Razza.LifePoints - Arma2.PuntiDanno));
            }
            return xp;
        }

        public int AssegnaDenaro()
        {
            return 10;
        }
    }
}
