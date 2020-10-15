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
    public class EGuardDAL : IEGuardDALBAL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();


        public EGuardEL SelectByID(int sn)
        {
            //throw new NotImplementedException();

         EGuardEL el = new EGuardEL();
            try
            {
                var res = db.guards.Where(x => x.SN== sn).SingleOrDefault();
                //var re
                if (res == null)
                {
                    throw new Exception("Invalid Id");
                }
                else
                {
                    //el.SPID = (int)res.SPID;
                    el.SN = res.SN;
                    el.Name = res.Name;
                    el.Contact = res.Contact;
                    el.Checkin = res.Checkin;                
                    el.Checkout = res.Checkout;
                    el.blockno = res.blockno;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }

        public IEnumerable<guard> GetAlLGuards()
        {
            try
            {
                return db.guards.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string InsertNewGuards(EGuardEL el)
        {
            try
            {
           guard newrow = new guard();
                //    newrow.SPID= el.SPID;
                newrow.SN = el.SN;
                newrow.Name = el.Name;
                newrow.Contact = el.Contact;
                newrow.Checkout = el.Checkout;
                newrow.Checkin = el.Checkin;
                //newrow.Contact = el.A;
                newrow.blockno = el.blockno;
              

                db.guards.Add(newrow);

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

 

