using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Esercizio_Videogioco
{
    public class Razza : IEquatable<Razza>
    {
        private string _nome;
        private List<Categoria> _categorieArmi;
        private string _id;

        public Razza()
        {

        }

        public Razza(string id, string nome, List<Categoria> cat)
        {
            try
            {
                ID = id;
                Nome = nome;
                CategorieArmi = cat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categoria> CategorieArmi
        {
            get
            {
                return _categorieArmi;
            }
            set
            {
                _categorieArmi = value;
            }
        }

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Id razza non valido");
                _id = value;
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
                    throw new Exception("Nome razza non valido");
                _nome = value;
            }
        }

        public bool Equals(Razza other)
        {
            if (this.ID == other.ID)
                return true;
            return false;
        }
    }
}