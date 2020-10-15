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
    public class EServiceDAL : IEServiceDALBAL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();

        public ServiceProviderEL SelectByID(int spid)
        {
            ServiceProviderEL el = new ServiceProviderEL();
            try
            {
                var res = db.ServiceProviders.Where(x => x.SPID == spid).SingleOrDefault();
                //var re
              if (res == null)
                {
                   throw new Exception("Invalid Id");
                }
                else
                {
                    //el.SPID = (int)res.SPID;
                    el.Service = res.Service;
                    el.Availablity = res.Availablity;
                    el.Charges = (int)res.Charges;
                    el.Description = res.Description;
                    el.OpeningTime = res.OpeningTime;
                    el.ClosingTime = res.ClosingTime;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }

        public IEnumerable<ServiceProvider> GetAllServices()
        {
            try
            {
                return db.ServiceProviders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        public string InsertNewProvider(ServiceProviderEL el)
        {
            try
            {
                ServiceProvider newrow = new ServiceProvider();
            //    newrow.SPID= el.SPID;
                newrow.Service = el.Service;
                newrow.Availablity = el.Availablity;
                newrow.Charges = el.Charges;
                newrow.Description = el.Description;
                newrow.OpeningTime = el.OpeningTime;
                newrow.ClosingTime = el.ClosingTime;
                // newrow.ClosingTime = closingTime;
                db.ServiceProviders.Add(newrow);
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

    

