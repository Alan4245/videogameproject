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

        public Personaggio()
        {
            Armi = new List<Arma>();
        }

        public Personaggio(string nome, Razza razza)
        {
            try
            {
                Nome = nome;
                Razza = razza;

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

        public bool SeComprato
        {
            get; set;
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

        public override string ToString()
        {
            return Nome + " - " + Razza.Nome;
        }
    }
}