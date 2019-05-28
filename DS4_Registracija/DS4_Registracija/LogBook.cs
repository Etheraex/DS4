using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace DS4_Registracija
{
    public class LogBook
    {
        public Dictionary<Vlasnik, List<Vozilo>> Evidencija;
        private static object obj = new object();

        private LogBook()
        {
            Evidencija = new Dictionary<Vlasnik, List<Vozilo>>();
            #region PrviVlasnik
            Evidencija.Add(new Vlasnik()
            {
                Ime = "Misa",
                Prezime = "Misic",
                JMBG = "1"
            },
            new List<Vozilo>()
            {
                new Vozilo()
                {
                    Marka = "Skoda",
                    Boja = Color.Red,
                    Model = "Fabia"
                },
                new Vozilo()
                {
                    Marka = "Porsche",
                    Boja = Color.Black,
                    Model = "Carrera"
                },
                new Vozilo()
                {
                    Marka = "Yugo",
                    Boja = Color.Red,
                    Model = "45"
                }
            });
            #endregion
            #region DrugiVlasnik
            Evidencija.Add(new Vlasnik()
            {
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "2"
            },
            new List<Vozilo>()
            {
                new Vozilo()
                {
                    Marka = "Skoda",
                    Boja = Color.Red,
                    Model = "Fabia"
                },
                new Vozilo()
                {
                    Marka = "Ford",
                    Boja = Color.Black,
                    Model = "Focus"
                }
            });
            #endregion
            #region TreciVlasnik
            Evidencija.Add(new Vlasnik()
            {
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "3"
            },
            new List<Vozilo>()
            {
                new Vozilo()
                {
                    Marka = "Golf",
                    Boja = Color.Red,
                    Model = "3"
                },
                new Vozilo()
                {
                    Marka = "Ford",
                    Boja = Color.Black,
                    Model = "Focus"
                }
            });
            #endregion
        }

        private static LogBook _instance;
        public static LogBook LogBookInstance()
        {
            if(_instance == null)
            {
                lock (obj)
                    if (_instance == null)
                        _instance = new LogBook();
            }
            return _instance;
        }

        public void Dodaj(Vlasnik v, Vozilo z)
        {
            foreach(Vlasnik vl in Evidencija.Keys)
                if(vl.JMBG == v.JMBG)
                {
                    Evidencija[vl].Add(z);
                    return;
                }
            Evidencija.Add(v, new List<Vozilo>() { z });
        }

        public List<Vlasnik> VratiVlasnike(string model)
        {
            var tmp = new List<Vlasnik>();
            foreach (var i in Evidencija.Keys)
                foreach (var j in Evidencija[i])
                    if (j.Model == model)
                        tmp.Add(i);
            return tmp;
        }
    }
}