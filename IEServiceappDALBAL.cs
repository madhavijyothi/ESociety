using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
  public  interface IEServiceappDALBAL
    {
        EServiceAppoEL SelectByID(int sid);

        string InsertNewServi(EServiceAppoEL el);
    }
}

    