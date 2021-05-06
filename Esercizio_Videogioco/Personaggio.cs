using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Esercizio_Videogioco
{
    public class Personaggio
    {
        private string _nome;
        private int _exp;
        private Razza _razza;
        private int _monete;
        private List<Arma> _armi;
        private int _expRichiesta;
        private int _moneteRichieste;
        private double _puntiVita;

        public Personaggio()
        {
            Armi = new List<Arma>();
        }

        public Personaggio(string nome, Razza razza, int expRich, int moneteRich, double lifePoints)
        {
            try
            {
                Nome = nome;
                Razza = razza;
                ExpRichiesta = expRich;
                MoneteRichieste = moneteRich;
                PuntiVita = lifePoints;

                Armi = new List<Arma>();
                Exp = 0;
                Monete = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Nome personaggio non valido");
                _nome = value;
            }
        }

        public int Exp
        {
            get
            {
                return _exp;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Valore esperienza personaggio non valido");
                _exp = value;
            }
        }

        public int Monete
        {
            get
            {
                return _monete;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Valore monete personaggio non valido");
                _monete = value;
            }
        }

        public List<Arma> Armi
        {
            get
            {
                return _armi;
            }
            set
            {
                _armi = value;
            }
        }

        public Razza Razza
        {
            get
            {
                return _razza;
            }
            set
            {
                _razza = value;
            }
        }

        public int ExpRichiesta
        {
            get
            {
                return _expRichiesta;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Valore esperienza richiesta personaggio non valido");
                _expRichiesta = value;
            }
        }

        public int MoneteRichieste
        {
            get
            {
                return _moneteRichieste;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Valore monete richieste personaggio non valido");
                _moneteRichieste = value;
            }
        }

        public bool SeComprato
        {
            get; set;
        }

        public double PuntiVita
        {
            get
            {
                return _puntiVita;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Valore punti vita non valido");
                _puntiVita = value;
            }
        }

        public void AggiungiArma(Arma a)
        {
            foreach (Arma b in Armi)
            {
                if (b.GetID() == a.GetID())
                {
                    throw new Exception("Arma già aggiunta");
                }
            }
            Armi.Add(a);
        }

        public void RimuoviArma(Arma a)
        {
            foreach (Arma b in Armi)
            {
                if (b.GetID() == a.GetID())
                {
                    Armi.Remove(a);
                    return;
                }
            }
            throw new Exception("Arma mai aggiunta");
        }
    }
}