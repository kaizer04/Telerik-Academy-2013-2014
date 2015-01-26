namespace CustomerDAO
{
    using NorthwindDataModel.Data;
    
    public class Program
    {
        public static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();
            using (db)
            {
                //DAO.AddCustomer("ZZZWW", "Company");
                //DAO.UpdateCustomer("ZZZWW", "NewCompanyName");
                DAO.DeleteCustomer("ZZZWW");
            }
        }
    }
}