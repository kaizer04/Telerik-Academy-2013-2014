﻿namespace BasicUsage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    
    using System.Data;
    using System.Data.Entity;

    using NorthwindDataModel.Data;
    
    public class Program
    {
        public static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();
            using (db)
            {
                var customers =
                from c in db.Customers
                where c.City == "London"
                select c;
                foreach (var customer in customers)
                {
                    Console.WriteLine("{0} from -> {1}", customer.ContactName, customer.City);
                }
            }
        }
    }
}