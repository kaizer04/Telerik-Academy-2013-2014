namespace BookStore.Importer
{
    using System.Linq;
    
    using BookStore.Data;

    public class Program
    {
        public static void Main()
        {
            var db = new BookStoreDbContext();

            db.Authors.Any();
        }
    }
}
