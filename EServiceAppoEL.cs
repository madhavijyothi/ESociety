using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntityLayer
{

    [DataContract]

    public class EServiceAppoEL
    {
            [DataMember]

            public int SID { get; set; }

            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string contactno { get; set; }

            [DataMember]
            public string Address { get; set; }
        }
}
