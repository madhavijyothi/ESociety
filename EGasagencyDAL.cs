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
   public class EGasagencyDAL : IGasDALBAL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();

        public EGasEL SelectByID(int gno)
        {
            //   throw new NotImplementedException();
            EGasEL el = new EGasEL();
            try
            {
                var res = db.GasAgencies.Where(x => x.Gno == gno).SingleOrDefault();
                //var re
                if (res == null)
                {
                    throw new Exception("Invalid Id");
                }
                else
                {
                    //el.SPID = (int)res.SPID;
                    el.Gno = res.Gno;
                    el.Gname = res.Gname;
                    el.gasagen = res.gasagen;
                    el.Email = res.Email;
                    el.Phnno = res.Phnno;
                    el.address = res.address;
                    el.applydate = res.applydate;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }

        public IEnumerable<GasAgency> GetAllGasAgencies()
        {
            try
            {
                return db.GasAgencies.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string InsertNewGas(EGasEL el)
        {
            try
            {
                GasAgency newrow = new GasAgency();
                //    newrow.SPID= el.SPID;
                newrow.Gno = el.Gno;
                newrow.Gname = el.Gname;
                newrow.gasagen = el.gasagen;
                newrow.Email = el.Email;
                newrow.Phnno = el.Phnno;
                newrow.address = el.address;
                newrow.applydate = el.applydate;

                db.GasAgencies.Add(newrow);

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


    

