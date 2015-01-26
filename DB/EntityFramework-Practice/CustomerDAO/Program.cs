
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDAO
{
    class Program
    {
        static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();
            using (db)
            {
                DAO.AddCustomer("testtttt", "StamatCompany");
                //DAO.UpdateCustomer("ZZZWW", "NewCompanyName");
                //DAO.DeleteCustomer("ZZZWW");
            }
        }
    }
}
