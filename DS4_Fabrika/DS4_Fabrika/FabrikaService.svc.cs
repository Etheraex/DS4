using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Fabrika
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FabrikaService : IFabrikaService
    {
        public bool DodajSastojak(string naziv, double zapremina, double gustina)
        {
            if (Fabrika.FabrikaInstance().DodajSastojak(naziv, zapremina, gustina))
                return true;
            return false;
        }

        public bool Flasiraj(double zapremina)
        {
            if (Fabrika.FabrikaInstance().Flasiraj(zapremina))
                return true;
            return false;
        }

        public void IsprazniSistem()
        {
            Fabrika.FabrikaInstance().IsprazniSistem();
        }

        public Stanje PrikaziStanje()
        {
            return Fabrika.FabrikaInstance().PrikaziStanje();
        }

        public List<string> VratiPromene()
        {
            return Fabrika.FabrikaInstance().VratiLog();
        }
    }
}
