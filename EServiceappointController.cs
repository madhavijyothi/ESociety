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

    public class EServiceappointController : ApiController
    {
      EServiceappDAL dal = new EServiceappDAL();

        [HttpGet]

        [Route("api/EServiceappoint/{sid}")]
        public EServiceAppoEL GetServiceAppoEL(int sid)
        {
            return dal.SelectByID(sid );
        }

        [HttpGet]
        public IEnumerable<ServiceAppoint> Get()
        {
            return dal.GetAllServiceAppoints();
        }


    }
}
