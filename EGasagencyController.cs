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

    public class EGasagencyController : ApiController
    {

        EGasagencyDAL dal = new EGasagencyDAL();

        [HttpGet]

        [Route("api/EGasAgency/{gno}")]

        public EGasEL GetEGas(int gno)
        {
            return dal.SelectByID(gno);
        }

        [HttpGet]

        public IEnumerable<GasAgency>Get()
        {
            return dal.GetAllGasAgencies();
        }

    }
}
