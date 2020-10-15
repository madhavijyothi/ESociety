using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntityLayer
{
    [DataContract]

    public class ESocietyEL
    {
        [DataMember]
        public int SMID { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public long ContactNumber { get; set; }

        [DataMember]
        public string AccountType { get; set; }

        [DataMember]
        public string HouseNo { get; set; }

        [DataMember]
        public string BusinessName { get; set; }

        [DataMember]
        public long Rent { get; set; }

    }

}
