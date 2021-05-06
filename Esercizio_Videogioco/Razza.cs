using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Razza
    {
        private string _nome;
        private List<Categoria> _categorieArmi;
        private string _id;

        public Razza()
        {
            throw new System.NotImplementedException();
        }

        public List<Categoria> CategorieArmi
        {
            get => default;
            set
            {
            }
        }

        public string ID
        {
            get => default;
            set
            {
            }
        }

        public string Nome
        {
            get => default;
            set
            {
            }
        }
    }
}