using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace EntityLayer
{
    [DataContract]

   public class ServiceProviderEL
        {
           [DataMember]
        public string Service { get; set; }
        [DataMember]
        public string Availablity { get; set; }
  
        [DataMember]
       public int Charges{ get; set; }
        [DataMember]
            public string Description { get; set; }
        [DataMember]
        public int SPID { get; set; }
        [DataMember]
            public string OpeningTime { get; set; }
       
            [DataMember]
            public string   ClosingTime { get; set; }

        }
    }
