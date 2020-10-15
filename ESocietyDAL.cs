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
    public class ESocietyDAL : IESocietyDALBAL
    {
        ESocietyDBEntities db = new ESocietyDBEntities();

        public ESocietyEL SelectByID(int smid)
        {
            ESocietyEL el = new ESocietyEL();
            try
            {
                var res = db.SocietyMemberInfoes.Where(x => x.SMID == smid).SingleOrDefault();
                if (res == null)
                {
                    throw new Exception("Invalid Id");
                }
                else
                {
                    el.SMID = res.SMID;
                    el.Password = res.Password;
                    el.Name = res.Name;
                    el.Address = res.Address;
                    el.Email = res.Email;
                    el.ContactNumber = res.ContactNumber;
                    el.AccountType = res.AccountType;
                    el.HouseNo = res.HouseNo;
                    el.BusinessName = res.BusinessName;
                    el.Rent = (long)res.Rent;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return el;
        }

        public string InsertNewMember(ESocietyEL el)
        {
            try
            {
                SocietyMemberInfo newrow = new SocietyMemberInfo();
                newrow.Password = Membership.GeneratePassword(8, 0);
                newrow.Name = el.Name;
                newrow.Address = el.Address;
                newrow.Email = el.Email;
                newrow.ContactNumber = el.ContactNumber;
                newrow.AccountType = el.AccountType;
                newrow.HouseNo = el.HouseNo;
                newrow.BusinessName = el.BusinessName;
                newrow.Rent = el.Rent;
                db.SocietyMemberInfoes.Add(newrow);
                 db.SaveChanges();
                
               // return "Member not inserted";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "Member not inserted";
        }

        public string UpdatePassword(int SMID,string NewPassword)
        {
            try
            {
                var res = db.SocietyMemberInfoes.Where(x => x.SMID == SMID).SingleOrDefault();
                if (res == null)
                {
                    return "Invalid SMID";
                }
                else
                {
                   res.Password = NewPassword;
                   var op = db.SaveChanges();
                    if (op > 0)
                        return "Password Updated";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "Unable to update password";
        }

        public IEnumerable<SocietyMemberInfo> GetAllMembers()
        {
            
            try
            {
                return db.SocietyMemberInfoes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
