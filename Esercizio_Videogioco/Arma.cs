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

        public Arma(string descrizione, string nome, double puntiDanno, Categoria categoria, int expRichiesta, int moneteRichieste, bool seComprata)
        {
            Descrizione = descrizione;
            Nome = nome;
            PuntiDanno = puntiDanno;
            Categoria = categoria;
            ExpRichiesta = expRichiesta;
            MoneteRichieste = moneteRichieste;
            SeComprata = seComprata;
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
            get;
            set;
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
        [XmlElement(ElementName = "SeComprata")]
        public bool SeComprata
        {
            get;
            set;
        }
        public bool IsComprata()
        {
            if (SeComprata == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}