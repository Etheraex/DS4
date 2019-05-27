using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DS4_Registracija
{
    [DataContract]
    public class Vozilo
    {
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Marka { get; set; }
        [DataMember]
        public Color Boja { get; set; }
    }
}