using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace EntityLayer
{
    [DataContract]
    public class BusinessOutletEL
    {
        [DataMember]
        public int Bno { get; set; }

        [DataMember]
        public string BusinessOutletType { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public long ContactUs { get; set; }

    }
}