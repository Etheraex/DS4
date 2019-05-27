using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS4_Registracija_Client.RegistracijaServis;

namespace DS4_Registracija_Client
{
    public class RegistracijaCallbackHandler : IRegistracijaServisCallback
    {
        public void Obavesti(string message)
        {
            Form1.ShowMessage(message);
        }
    }
}
