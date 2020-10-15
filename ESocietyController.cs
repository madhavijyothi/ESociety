using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DALEF;
using System.Web.Http.Cors;

namespace ServiceLayerWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    
    public class ESocietyController : ApiController
    {
        ESocietyDAL dal = new ESocietyDAL();

        [HttpGet]
        [Route("api/ESociety/{smid}")]
        public ESocietyEL Get(int smid)
        {
            return dal.SelectByID(smid);
        }

        [HttpGet]
        public IEnumerable<SocietyMemberInfo>Get()
        {
            return dal.GetAllMembers();
        }

        [HttpPost]
        public string Post([FromBody] ESocietyEL el)
        {
            return dal.InsertNewMember(el);
        }

        [HttpPut]
        public string Update(int SMID,string NewPassword)
        {
            return dal.UpdatePassword(SMID,NewPassword);
        }
    }
}
