using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Aukcija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AudicijaServis : IAudicijaServis
    {
        public bool Odustani(int k)
        {
            if(Audicija.GetInstance().Klijenti.Remove(Audicija.GetInstance().Klijenti.Select(x => x.Key).
                                                                Where(x => x.Id == k).FirstOrDefault()))
                return true;
            return false;
        }

        public int PovecajCenu(int k)
        {
            foreach(Klijent kl in Audicija.GetInstance().Klijenti.Keys)
                if (kl.Id == k)
                {
                    Audicija.GetInstance().Eksponati[Audicija.GetInstance().TrenutniEksponat].KupacId = k;
                    Audicija.GetInstance().Eksponati[Audicija.GetInstance().TrenutniEksponat].TrenutnaCena += 500;
                    if (Audicija.GetInstance().Eksponati[Audicija.GetInstance().TrenutniEksponat].TrenutnaCena > 2500)
                    {
                        Audicija.GetInstance().TrenutniEksponat++;
                        return 1;
                    }
                    return 2;
                }
            return 3;
        }

        public void PrijaviKlijenta(Klijent k)
        {
            if (Audicija.GetInstance().Klijenti.ContainsKey(k))
                Audicija.GetInstance().Klijenti[k].Add(Audicija.GetInstance().Eksponati[Audicija.GetInstance().TrenutniEksponat]);
            else
                Audicija.GetInstance().Klijenti.Add(k,new List<Eksponat>() { Audicija.GetInstance().Eksponati[Audicija.GetInstance().TrenutniEksponat] });
        }

        public Eksponat VratiEksponat()
        {
            return Audicija.GetInstance().Eksponati[Audicija.GetInstance().TrenutniEksponat];
        }

        public List<Klijent> VratiKlijente()
        {
            return Audicija.GetInstance().Klijenti.Keys.ToList();
        }
    }
}
