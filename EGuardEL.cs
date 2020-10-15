using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntityLayer
{

        [DataContract]
     public class EGuardEL
    {
        [DataMember]
        public int SN { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string blockno { get; set; }
        [DataMember]
        public long Contact { get; set; }
        [DataMember]
        public string Checkin { get; set; }

        [DataMember]
        public string Checkout { get; set; }
    }
}






