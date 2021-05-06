using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercizio_Videogioco
{
    public class Combattimento
    {
        private Personaggio _personaggio1;
        private Personaggio _personaggio2;
        private Arma _arma1;
        private Arma _arma2;
        private double _puntiVita1, _puntiVita2;
        Random rnd; // utilizzato per rigenerazione salute

        private Personaggio _vincitore;
        private int _turno;


        public Combattimento(Personaggio p1,Personaggio p2, Arma a1,Arma a2)
        {
            try
            {
                Personaggio1 = p1;
                Personaggio2 = p2;
                Arma1 = a1;
                Arma2 = a2;

                Vincitore = null;
                PuntiVita1 = Personaggio1.PuntiVita;
                PuntiVita2 = Personaggio2.PuntiVita;
                rnd = new Random();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public Personaggio Personaggio1
        {
            get
            {
                return _personaggio1;
            }
            private set
            {
                try
                {
                    _personaggio1 = value;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Personaggio Personaggio2
        {
            get
            {
                return _personaggio2;
            }
            private set
            {
                try
                {
                    _personaggio2 = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        //verifica del set per controllare legittimità del possesso dell'arma del personaggio1
        public Arma Arma1
        {
            get
            {
                return _arma1;
            }
            private set
            {
                try
                {
                    _arma1 = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        //verifica del set per controllare legittimità del possesso dell'arma del personaggio2
        public Arma Arma2
        {
            get
            {
                return _arma2;
            }
            private set
            {
                try
                {
                    _arma2 = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Personaggio Vincitore
        {
            get
            {
                return _vincitore;
            }
            private set
            {
                try
                {
                    if (value != Personaggio1 || value != Personaggio2)
                        throw new Exception("personaggio non esistente nel combattimento");
                    _vincitore = value;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public int Turno
        {
            get
            {
                return _turno;
            }
            private set
            {
                try
                {
                    if (value != 0 || value != 1)
                        throw new Exception("numero turno non valido");
                    _turno = value;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public double PuntiVita1
        {
            get
            {
                return _puntiVita1;
            }
            set
            {
                try
                {
                    if (value > Personaggio1.PuntiVita)
                        throw new Exception("punti vita inseriti non validi");
                    _puntiVita1 = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public double PuntiVita2
        {
            get
            {
                return _puntiVita2;
            }
            set
            {
                try
                {
                    if (value > Personaggio2.PuntiVita)
                        throw new Exception("punti vita inseriti non validi");
                    _puntiVita2 = value;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }



        //metodi del combattimento
        //è stata presa la decisione di far gestire alla classe chi dovesse fare la mossa e di fare il cambio del turno dopo
        public void Attacca()
        {
            try
            {
                if (Turno == 0)
                {
                    PuntiVita2 -= Arma1.PuntiDanno;
                }
                else if (Turno == 1)
                {
                    PuntiVita1 -= Arma2.PuntiDanno;
                }

                Cambioturno();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void RigeneraSalute()
        {
            try
            {
                int percentualeSaluteGuadagnata = rnd.Next(5, 18);//percentuale di salute guadagnata compresa tra 5% e 17% 
                double puntiVitaT;
                if (Turno == 0)
                {
                    puntiVitaT = Personaggio1.PuntiVita;
                    puntiVitaT = (double)(puntiVitaT / 100) * percentualeSaluteGuadagnata;
                    PuntiVita1 += puntiVitaT;
                }
                else if (Turno == 1)
                {
                    puntiVitaT = Personaggio2.PuntiVita;
                    puntiVitaT = (double)(puntiVitaT / 100) * percentualeSaluteGuadagnata;
                    PuntiVita1 += puntiVitaT;
                }
                Cambioturno();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        //da definire
        public void AttivaAbilitàSpeciale()
        {
            throw new System.NotImplementedException();
        }
        
        //gestione turno della grafica
        private void Cambioturno()
        {
            if (Turno == 0)
                Turno = 1;
            else if (Turno == 1)
                Turno = 0;
        }

        //gestione vantaggi e svantaggi


        public int AssegnaExp()
        {
            int xp = 0;
            if (Vincitore == Personaggio1)
            {
                xp = (int)(10 + (Personaggio2.Razza.LifePoints - Arma1.PuntiDanno));
            }
            else
            {
                xp = (int)(10 + (Personaggio1.Razza.LifePoints - Arma2.PuntiDanno));
            }
            return xp;
        }

        public int AssegnaDenaro()
        {
            return 10;
        }

        public bool VerificaFinePartita()
        {
            if (Personaggio1.PuntiVita <= 0)
            {
                Vincitore = Personaggio1;
                return true;
            } 
            else if (Personaggio2.PuntiVita <= 0)
            {
                Vincitore = Personaggio2;
                return true;
            }
            return false;
                
        }

        //metodo necessario?
        public void TerminaPartita()
        {
            throw new System.NotImplementedException();
        }
    }
}
