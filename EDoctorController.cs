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

    public class EDoctorController : ApiController
    {
        EDoctorDAL dal = new EDoctorDAL ();

        [HttpGet]
        [Route("api/EDoctor/{appid}")]
        public EDoctorEL GetEDoctor(int appid)
        {
            return dal.SelectByID(appid);
        }



        [HttpGet]
        public IEnumerable<DoctorsAppointment> Get()
        {
            return dal.GetAllAppointments();
        }


     

    }
}

