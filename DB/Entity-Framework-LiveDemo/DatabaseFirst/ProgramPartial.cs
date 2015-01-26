using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class ProgramPartial
    {
        static void Main(string[] args)
        {
            //var db = new TelerikAcademyEntities();

            //var allTowns = db.Towns.ToList();

            //var allAdresses = db.Addresses.Where(a => a.AddressText.StartsWith("1"));

            //var allAdresses = db.Addresses
            //        .Where(a => a.AddressText.StartsWith("1"))
            //        .OrderBy(a => a.AddressText)
            //        .Select(a =>
            //            new 
            //            { 
            //                TownName = a.Town.Name,
            //                AdressText = a.AddressID
            //            });

            //foreach (var town in allTowns)
            //{
            //    Console.WriteLine(town.Name);
            //}

            //foreach (var adress in allAdresses)
            //{
            //    //Console.WriteLine(adress.AddressText);
            //    Console.WriteLine(adress.TownName);
            //}

            //Find by ID
            //using (var db2 = new TelerikAcademyEntities())
            //{
            //    //var address = db2.Addresses.Find(3);
            //    //var address = db2.Addresses.FirstOrDefault(a => a.AddressID == 3);
            //    var address = db2.Addresses.OrderBy(a => a.AddressText).ThenBy(a => a.Employees.Count());
                
            //    //Console.WriteLine(address.AddressText);
            //    Console.WriteLine(address);

            //    //use partial classes
            //    db2.Projects.First().TimeSinceBeginning();
            //}

            //magic - not use
            //using (var db3 = new TelerikAcademyEntities())
            //{
            //    //var result = db3.Database.SqlQuery<Town>("SELECT * FROM Towns");
            //    ////result allways is a collection
            //    //foreach (var town in result)
            //    //{
            //    //    Console.WriteLine(town.Name);
            //    //}

            //    var queryFormat = string.Format("SELECT * FROM {0}", "Town");
            //    db3.Database.SqlQuery<Town>(queryFormat);
            //}

            
            using (var db = new TelerikAcademyEntities())
            {
                ////JOIN TABLE
                //var results = db.Addresses.Join(
                //    db.Towns,
                //    a => a.TownID,
                //    t => t.TownID,
                //    (a, t) => new
                //    {
                //        Address = a.AddressText,
                //        Town = t.Name
                //    });
                //foreach (var result in results)
                //{
                //    Console.WriteLine(result.Address + " " + result.Town);
                //}

                //GROUP
                var groupedByDep = db.Employees.GroupBy(e => e.DepartmentID);
                foreach (var group in groupedByDep)
                {
                    Console.WriteLine(group.First().Department.Name.ToUpper());
                    foreach (var emp in group)
                    {
                        Console.WriteLine(emp.FirstName);
                    }
                }
            }
        }
    }
}
