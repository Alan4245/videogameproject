using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Personaggio : IComparable<Personaggio>
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
            throw new System.NotImplementedException();
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Il nome inserito non è valido");
                }

                Nome = value;
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
                if(value < 0 && value > _exp)
                {
                    throw new Exception("L'esperienza inserita non è valida");
                }

                Exp = value;
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
                {
                    throw new Exception("Le monete inserite non sono valide");
                }

                Monete = value;
            }
        }

        public List<Arma> Armi
        {
            get => default;
            set
            {
            }
        }

        public Razza Razza
        {
            get => default;
            set
            {
            }
        }

        public int ExpRichiesta
        {
            get => default;
            set
            {
            }
        }

        public int MoneteRichieste
        {
            get => default;
            set
            {
            }
        }

        public bool SeComprato
        {
            get => default;
            set
            {
            }
        }

        public double PuntiVita
        {
            get => default;
            set
            {
            }
        }

        public void AggiungiArma()
        {
            throw new System.NotImplementedException();
        }

        public int CompareTo(Personaggio other)
        {
            throw new NotImplementedException();
        }

        public void RimuoviArma()
        {
            throw new System.NotImplementedException();
        }

        public bool IsComprato()
        {
            throw new System.NotImplementedException();
        }
    }
}