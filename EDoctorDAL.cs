using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class EDoctorDAL : IEDoctorDALBAL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();



        public EDoctorEL SelectByID(int appid)
        {
            //  throw new NotImplementedException();
            EDoctorEL el = new EDoctorEL();
            try
            {
                var res = db.DoctorsAppointments.Where(x => x.Appid == appid).SingleOrDefault();
                //var re
                if (res == null)
                {
                    throw new Exception("Invalid Id");
                }
                else
                {
                    el.Appid = res.Appid;
                    el.Name = res.Name;
                    el.time = res.time;
                    el.Dat = res.Dat;
                    el.category = res.category;
                    el.mobileno = res.mobileno;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }
        public IEnumerable<DoctorsAppointment> GetAllAppointments()
        {
            try
            {
                return db.DoctorsAppointments.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public string InsertNewAppointments(EDoctorEL el)
        {
            try
            {
                DoctorsAppointment newrow = new DoctorsAppointment();
                //    newrow.SPID= el.SPID;
                newrow.Appid = el.Appid;
                newrow.Name = el.Name;
                newrow.time = el.time;
                newrow.Dat = el.Dat;
                newrow.category = el.category;
                newrow.mobileno = el.mobileno;

                db.DoctorsAppointments.Add(newrow);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "Service Provider inserted";
        }

    }

     
    }