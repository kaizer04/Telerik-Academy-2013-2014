namespace DifferentContexts
{
    using NorthwindDataModel.Data;
 
    public class Program
    {
        public static void Main()
        {
            using (NorthwindEntities dbFirst = new NorthwindEntities())
            {
                using (NorthwindEntities dbSecond = new NorthwindEntities())
                {
                    dbFirst.Customers.Add(new Customer() { CustomerID = "aaaaaa", CompanyName = "CONFLICTTEST" });
                    dbSecond.Customers.Add(new Customer() { CustomerID = "bbbbbbb", CompanyName = "CONFLICTTEST2" });
                    dbSecond.SaveChanges();
                    dbFirst.SaveChanges();
                    dbSecond.SaveChanges();
                }
            }
        }
    }
}