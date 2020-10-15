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
   public class EServiceappDAL : IEServiceappDALBAL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();



        public EServiceAppoEL SelectByID(int sid)
        {
            //  throw new NotImplementedException();

            EServiceAppoEL el = new EServiceAppoEL();
            try
            {
                var res = db.ServiceAppoints.Where(x => x.SID == sid).SingleOrDefault();
                //var re
                if (res == null)
                {
                    throw new Exception("Invalid Id");
                }
                else
                {
                    //el.SPID = (int)res.SPID;
                    el.SID = res.SID;
                    el.name = res.name;
                    el.contactno = res.contactno;
                    el.Address = res.Address;


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }


        public IEnumerable<ServiceAppoint> GetAllServiceAppoints()
        {
            try
            {
                return db.ServiceAppoints.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string InsertNewServi(EServiceAppoEL el)
        {
            //throw new NotImplementedException();
            try
            {
                ServiceAppoint newrow = new ServiceAppoint();
                //    newrow.SPID= el.SPID;
                newrow.SID = el.SID;
                newrow.name = el.name;
                newrow.contactno = el.contactno;
                newrow.Address = el.Address;

             db.ServiceAppoints.Add(newrow);

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



