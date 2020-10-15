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

    public class EGuardController : ApiController
    {
        EGuardDAL dal = new EGuardDAL();

        [HttpGet]

        [Route("api/EGuard/{sn}")]
        public EGuardEL GetEGuard(int sn)
        {
            return dal.SelectByID(sn);
        }

        [HttpGet]
        public IEnumerable<guard> Get()
        {
            return dal.GetAlLGuards();
        }
        [HttpPost]
        public string Post([FromBody] EGuardEL el)
        {
            return dal.InsertNewGuards(el);
        }
    }
}
