using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Esercizio_Videogioco
{
    [XmlRoot(ElementName = "Arma")]
    public class Arma
    {
        private string _nome;
        private double _puntiDanno;
        private string _descrizione;
        private Guid  _id;
        private int _moneteRichieste;
        private int _expRichiesta;
        private Categoria _categoria;
        private string _imgPath;

        public Arma(string descrizione, string nome, double puntiDanno, Categoria categoria, int expRichiesta, int moneteRichieste, string imgPath)
        {
            Descrizione = descrizione;
            Nome = nome;
            PuntiDanno = puntiDanno;
            Categoria = categoria;
            ExpRichiesta = expRichiesta;
            MoneteRichieste = moneteRichieste;
            ImgPath = imgPath;
            _id = Guid.NewGuid();
        }

        public Arma()
        {
            _id = Guid.NewGuid();
        }

        [XmlElement(ElementName = "Descrizione")]
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception();
                }
                else
                {
                    _descrizione = value;
                }
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

        public Guid GetID()
            {
                return _id;
            }

        [XmlAttribute(AttributeName = "Nome")]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception();
                }
                else
                {
                    _nome = value;
                }
            }
        }
        [XmlElement(ElementName = "PuntiDanno")]
        public double PuntiDanno
        {
            get => _puntiDanno;
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _puntiDanno = value;
                }
            }
        }
        [XmlElement(ElementName = "Categoria")]
        public Categoria Categoria
        {
            get => _categoria;
            set
            {
                _categoria = value;
            }
        }
        [XmlElement(ElementName = "ExpRichiesta")]
        public int ExpRichiesta
        {
            get => _expRichiesta;
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _expRichiesta = value;
                }
            }
        }
        [XmlElement(ElementName = "MoneteRichieste")]
        public int MoneteRichieste
        {
            get => _moneteRichieste;
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _moneteRichieste = value;
                }
            }
        }

        public override string ToString()
        {
            return Nome + " - " + Categoria;
        }
    }
}