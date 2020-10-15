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
    public class EBusinessDAL : BusinessOutletEL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();

        public BusinessOutletEL SelectByID(int bno)
        {
            BusinessOutletEL el = new BusinessOutletEL();
            try
            {
                var res = db.BusinessOutlets.Where(x => x.Bno == bno).SingleOrDefault();
                //var re
                if (res == null)
                {
                    throw new Exception("Invalid Id");
                }
                else
                {
                    el.Bno = res.Bno;
                    el.BusinessOutletType = res.BusinessOutletType;
                    el.ContactUs = res.ContactUs;
                    el.Address = res.Address;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }

        public IEnumerable<BusinessOutlet> GetBusinessOutlets()
        {
            try
            {
                return db.BusinessOutlets.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string InsertNewBusiness(BusinessOutletEL el)
        {
            try
            {
                BusinessOutlet newrow = new BusinessOutlet();
                //    newrow.SPID= el.SPID;
                newrow.Bno = el.Bno;
                newrow.ContactUs = el.ContactUs;
                newrow.BusinessOutletType = el.BusinessOutletType;
                newrow.Address = el.Address;

                db.BusinessOutlets.Add(newrow);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "B Inlet inserted";
        }




    }




}
