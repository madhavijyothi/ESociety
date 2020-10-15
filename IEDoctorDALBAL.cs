using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;




namespace IDatabase
{
    public  interface IEDoctorDALBAL
    {
        EDoctorEL SelectByID(int appid);

        string InsertNewAppointments(EDoctorEL el);
    }
}
