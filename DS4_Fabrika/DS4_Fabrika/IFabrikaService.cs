using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Fabrika
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFabrikaService
    {
        [OperationContract]
        bool DodajSastojak(string naziv, double zapremina, double gustina);

        [OperationContract]
        bool Flasiraj(double zapremina);

        [OperationContract]
        void IsprazniSistem();

        [OperationContract]
        Stanje PrikaziStanje();

        [OperationContract]
        List<string> VratiPromene();
        // TODO: Add your service operations here
    }

    [DataContract]
    public class Stanje
    {
        [DataMember]
        public double Zauzece { get; set; }

        [DataMember]
        public double Gustina { get; set; }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
