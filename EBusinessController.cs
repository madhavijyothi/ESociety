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

    public class EBusinessController : ApiController
    {
        EBusinessDAL dal = new EBusinessDAL();

        [HttpGet]
        [Route("api/EBusiness/{bno}")]
        public BusinessOutletEL GetBusiness(int bno)
        {
            return dal.SelectByID(bno);
        }



        [HttpGet]
        public IEnumerable<BusinessOutlet> Get()
        {
            return dal.GetBusinessOutlets();
        }


        [HttpPost]
        public string Post([FromBody] BusinessOutletEL el)
        {
            return dal.InsertNewBusiness(el);
        }


    }
}
