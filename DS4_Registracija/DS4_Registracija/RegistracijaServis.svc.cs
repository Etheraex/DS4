using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Registracija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RegistracijaServis : IRegistracijaServis
    {
        public void RegistrujVozilo(Vlasnik v, Vozilo z)
        {
            LogBook.LogBookInstance().Dodaj(v, z);
        }

        public Dictionary<Vlasnik, List<Vozilo>> VratiSve()
        {
            return LogBook.LogBookInstance().Evidencija;
        }

        public List<Vlasnik> VratiVlasnike(string model)
        {
            return LogBook.LogBookInstance().VratiVlasnike(model);
        }

        public List<Vozilo> VratiVozila(Vlasnik v)
        {
            return LogBook.LogBookInstance().Evidencija
                                        .Where(x => (x.Key.JMBG == v.JMBG))
                                        .SelectMany(y => y.Value).ToList();
        }

        IRegistracijaCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IRegistracijaCallback>();
            }
        }
    }
}
