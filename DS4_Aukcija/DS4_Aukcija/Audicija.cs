using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DS4_Aukcija
{
    public class Audicija
    {
        public Dictionary<Klijent, List<Eksponat>> Klijenti { get; set; }
        public List<Eksponat> Eksponati { get; set; }
        public int TrenutniEksponat { get; set; }
        private static object _obj = new object();

        private Audicija()
        {
            Eksponati = new List<Eksponat>() { new Eksponat() { Naziv = "Vaza"}, new Eksponat() { Naziv = "Casa" }, new Eksponat() { Naziv = "Solja" } };
            Klijenti = new Dictionary<Klijent, List<Eksponat>>();
        }

        private static Audicija _instance;
        public static Audicija GetInstance()
        {
            if(_instance == null)
            {
                lock (_obj)
                    if (_instance == null)
                        _instance = new Audicija();
            }
            return _instance;
        }
    }
}