using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Aukcija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAudicijaServis
    {
        [OperationContract]
        void PrijaviKlijenta(Klijent k);
        [OperationContract]
        Eksponat VratiEksponat();
        [OperationContract]
        bool Odustani(int k);
        [OperationContract]
        int PovecajCenu(int k);

        [OperationContract]
        List<Klijent> VratiKlijente();
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Klijent
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Prezime { get; set; }
    }

    [DataContract]
    public class Eksponat
    {
        [DataMember]
        public string Naziv { get; set; }
        [DataMember]
        public double TrenutnaCena { get; set; }
        [DataMember]
        public int KupacId { get; set; }
    }
}
