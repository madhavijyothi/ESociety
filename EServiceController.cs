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

    public class EServiceController : ApiController
    {
        EServiceDAL dal = new EServiceDAL ();

        [HttpGet]
        [Route("api/EService/{spid}")]
        public ServiceProviderEL GetAllProviders(int spid)
        {
            return dal.SelectByID(spid);
        }

        [HttpGet]
        public IEnumerable<ServiceProvider> Get()
        {
            return dal.GetAllServices();
        }

        [HttpPost]
        public string Post([FromBody] ServiceProviderEL el)
        {
            return dal.InsertNewProvider(el);
        }

        
    }
}

