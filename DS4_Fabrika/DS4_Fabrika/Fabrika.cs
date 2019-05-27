using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DS4_Fabrika
{
    public class Fabrika
    {
        public Bazen Bazen { get; private set; }
        public double Gustina { get; private set; }
        public double Zapremina { get; private set; }
        private static object _obj = new object();
        public List<string> log { get; private set; }

        private Fabrika()
        {
            log = new List<string>();
            Bazen = new Bazen(20, 3, 4);
            Gustina = 0;
            Zapremina = 0;
        }

        public bool Flasiraj(double zapremina)
        {
            if (Zapremina < zapremina)
            {
                log.Add("Pokusaj flasiranja: " + zapremina);
                return false;
            }
            Zapremina -= zapremina;
            log.Add("Flasirana kolicina: " + zapremina);
            return true;
        }

        public void IsprazniSistem()
        {
            Zapremina = 0;
            Gustina = 0;
            log.Add("Sistem ispraznjen");
        }

        public Stanje PrikaziStanje()
        {
            var tmp = new Stanje();
            if (Zapremina == 0)
                tmp.Zauzece = 0;
            else
                tmp.Zauzece = Zapremina / Bazen.Zapremina;
            tmp.Gustina = Gustina;
            return tmp;
        }

        public bool DodajSastojak(string naziv, double zapremina, double gustina)
        {
            if (Zapremina + zapremina > Bazen.Zapremina)
            {
                log.Add("Pokusaj dodavanja sastojka: " + naziv + " ali je bazen pun!");
                return false;
            }
            Zapremina += zapremina;
            Gustina += gustina;
            log.Add("Dodat sastojak: " + naziv);
            return true;
        }

        public List<string> VratiLog()
        {
            return log;
        }

        private static Fabrika _instance;
        public static Fabrika FabrikaInstance()
        {
            if (_instance == null)
            {
                lock (_obj)
                    if (_instance == null)
                        _instance = new Fabrika();
            }
            return _instance;
        }

    }

    public class Bazen
    {
        public double Height { get; }
        public double Width { get; }
        public double Depth { get; }

        public Bazen(double x, double y, double z)
        {
            Height = x;
            Width = y;
            Depth = z;
        }

        public double Zapremina
        {
            get
            {
                return Height * Width * Depth;
            }
        }
    }
}