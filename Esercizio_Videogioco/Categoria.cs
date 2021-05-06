using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Esercizio_Videogioco
{
    public class Categoria : IEquatable<Categoria>
    {
        private string _id;
        private string _nome;

        public Categoria()
        {

        }

        public Categoria(string i, string n)
        {
            try
            {
                ID = i;
                Nome = n;
            }
            catch (Exception ex)
            {
                throw ex;
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
                    throw new Exception("Id categoria non valido");
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
                    throw new Exception("Nome categoria non valido");
                _nome = value;
            }
        }

        public bool Equals(Categoria other)
        {
            if (this.ID == other.ID)
                return true;
            return false;
        }
    }
}