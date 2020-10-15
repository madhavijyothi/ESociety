using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace EntityLayer
{
    [DataContract]

  public class EGasEL
    {

            [DataMember]
            public int Gno { get; set; }

            [DataMember]
            public string Gname { get; set; }

            [DataMember]
            public string Email { get; set; }

            [DataMember]
            public long  Phnno { get; set; }

            [DataMember]
            public string gasagen { get; set; }

            [DataMember]
            public String applydate { get; set; }

            [DataMember]
            public string address { get; set; }


        }
    }
