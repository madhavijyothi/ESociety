using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntityLayer
{
    [DataContract]
   
   public  class EDoctorEL
    {

        [DataMember]

        public int Appid  { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string time{ get; set; }
        [DataMember]
        public string Dat { get; set; }
        [DataMember]
        public string category { get; set; }
        [DataMember]
        public string mobileno { get; set; }
    }
}



   

   
     