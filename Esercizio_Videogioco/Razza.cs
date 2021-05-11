using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Esercizio_Videogioco
{
    [XmlRoot(ElementName = "Razza")]
    public class Razza : IEquatable<Razza>
    {
        private string _nome;
        private List<Categoria> _categorieArmi;
        private string _id;
        private double _lp;
        private string _imgPath;

        public Razza()
        {
            _categorieArmi = new List<Categoria>();
        }

        public Razza(string id, string nome, List<Categoria> cat, double lp, string imgPath)
        {
            try
            {
                ID = id;
                Nome = nome;
                CategorieArmi = cat;
                LifePoints = lp;
                ImgPath = imgPath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [XmlElement(ElementName = "CategorieArmi")]

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

        [XmlElement(ElementName = "ImgPath")]
        public string ImgPath
        {
            get
            {
                return _imgPath;
            }
            set
            {
                _imgPath = value;
            }
        }

        [XmlAttribute(AttributeName = "ID")]
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
        [XmlElement(ElementName = "Nome")]
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
        [XmlElement(ElementName = "LifePoints")]
        public double LifePoints
        {
            get
            {
                return _lp;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Life point troppo bassi");
                _lp = value;
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