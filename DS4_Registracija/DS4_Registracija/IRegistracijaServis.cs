using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Registracija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://DS4_Registracija", SessionMode = SessionMode.Required,
                 CallbackContract = typeof(IRegistracijaCallback))]
    public interface IRegistracijaServis
    {
        [OperationContract]
        void RegistrujVozilo(Vlasnik v, Vozilo z);

        [OperationContract]
        List<Vozilo> VratiVozila(Vlasnik v);

        [OperationContract]
        List<Vlasnik> VratiVlasnike(string marka);

        [OperationContract]
        Dictionary<Vlasnik, List<Vozilo>> VratiSve();

        [OperationContract(IsOneWay = true)]
        void Poruka(string message);
        // TODO: Add your service operations here
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
}
