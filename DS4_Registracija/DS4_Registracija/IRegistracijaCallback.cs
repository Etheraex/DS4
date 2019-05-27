using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace DS4_Registracija
{
    public interface IRegistracijaCallback
    {
        [OperationContract(IsOneWay = true)]
        void Obavesti(string message);
    }
}