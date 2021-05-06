using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Videogioco
    {
        private List<Razza> _razze;
        private List<Personaggio> _personaggi;
        private List<Arma> _armi;
        private List<Categoria> _categorie;

        public Videogioco()
        {
            Razze = new List<Razza>();
            Personaggi = new List<Personaggio>();
            Armi = new List<Arma>();
            Categorie = new List<Categoria>();
        }

        public Videogioco(List<Razza> r, List<Categoria> c, List<Personaggio> p, List<Arma> a)
        {
            Razze = r;
            Personaggi = p;
            Armi = a;
            Categorie = c;
        }

        public List<Razza> Razze
        {
            get
            {
                return _razze;
            }
            set
            {
                _razze = value;
            }
        }

        public List<Personaggio> Personaggi
        {
            get
            {
                return _personaggi;
            }
            set
            {
                _personaggi = value;
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

        public List<Categoria> Categorie
        {
            get
            {
                return _categorie;
            }
            set
            {
                _categorie = value;
            }
        }

        public void AggiungiArma(Arma a)
        {
            foreach (Arma b in Armi)
            {
                if (b.Equals(a))
                {
                    throw new Exception("Arma già esistente");
                }
            }

            Armi.Add(a);
        }

        public void AggiungiCategoria(Categoria a)
        {
            foreach (Categoria b in Categorie)
            {
                if (b.ID == a.ID)
                {
                    throw new Exception("Categoria già esistente");
                }
            }

            Categorie.Add(a);
        }

        public void AggiungiPersonaggio(Personaggio a)
        {
            foreach (Personaggio b in Personaggi)
            {
                if (b.Nome == a.Nome)
                {
                    throw new Exception("Personaggio già esistente");
                }
            }

            Personaggi.Add(a);
        }

        public void AggiungiRazza(Razza a)
        {
            foreach (Razza b in Razze)
            {
                if (b.ID == a.ID)
                {
                    throw new Exception("Razza già esistente");
                }
            }

            Razze.Add(a);
        }

        public void RimuoviArma(Arma a)
        {
            foreach (Arma b in Armi)
            {
                if (b.Equals(a))
                {
                    Armi.Remove(b);
                    return;
                }
            }
            throw new Exception("Razza non esistente");
        }

        public void RimuoviCategoria(Categoria a)
        {
            foreach (Categoria b in Categorie)
            {
                if (b.ID == a.ID)
                {
                    Categorie.Remove(b);
                    return;
                }
            }
            throw new Exception("Razza non esistente");
        }

        public void RimuoviPersonaggio(Personaggio a)
        {
            foreach (Personaggio b in Personaggi)
            {
                if (b.Nome == a.Nome)
                {
                    Personaggi.Remove(b);
                    return;
                }
            }
            throw new Exception("Razza non esistente");
        }

        public void RimuoviRazza(Razza a)
        {
            foreach (Razza b in Razze)
            {
                if (b.ID == a.ID)
                {
                    Razze.Remove(b);
                    return;
                }
            }
            throw new Exception("Razza non esistente");
        }
    }
}