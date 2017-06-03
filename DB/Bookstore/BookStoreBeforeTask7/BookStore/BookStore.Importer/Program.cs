namespace BookStore.Importer
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    
    using BookStore.Data;
    using BookStore.Models;
    
    
    public class Program
    {
        private static BookStoreDbContext db;

        public static void Main()
        {
            db = new BookStoreDbContext();

            ////BACHKA - XML
            //var xmlBooks = XElement.Load(@"..\..\..\complex-import.xml");

            
            //var books = xmlBooks.Elements();

            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Value);
            //}

            var xmlBooks = XElement.Load(@"..\..\..\complex-import.xml").Elements();

            foreach (var xmlBook in xmlBooks)
            {
                var currentBook = new Book();
                currentBook.Title = xmlBook.Element("title").Value;
                //Console.WriteLine(currentBook.Title);

                var isbn = xmlBook.Element("isbn");
                if (isbn != null)
                {
                    var bookExists = db.Books.Any(b => b.ISBN == isbn.Value);
                    if (bookExists)
                    {
                        throw new ArgumentException("ISBN already exists");
                    }

                    currentBook.ISBN = isbn.Value;
                }

                var price = xmlBook.Element("price");
                if (price != null)
                {
                    currentBook.Price = decimal.Parse(price.Value);
                }

                var webSite = xmlBook.Element("web-site");
                if (webSite != null)
                {
                    currentBook.WebSite = webSite.Value;
                }

                var xmlAuthors = xmlBook.Element("authors");
                if (xmlAuthors != null)
                {
                    foreach (var xmlAuthor in xmlAuthors.Elements("author"))
                    {
                        var authorName = xmlAuthor.Value;
                        currentBook.Authors.Add(GetAuthor(authorName));
                    }
                }

                var xmlReviews = xmlBook.Element("reviews");
                if (xmlReviews != null)
                {
                    foreach (var xmlReview in xmlReviews.Elements("review"))
                    {
                        var reviewDate = xmlReview.Attribute("date");
                        var authorName = xmlReview.Attribute("author");
                        
                        var review = new Review
                        {
                            Content = xmlReview.Value,
                            CreateOn = reviewDate == null ? DateTime.Now : DateTime.Parse(reviewDate.Value)
                        };

                        if (authorName != null)
                        {
                            review.Author = GetAuthor(authorName.Value);
                        }

                        currentBook.Reviews.Add(review);
                    }
                }

                db.Books.Add(currentBook);
                db.SaveChanges();
            }
        }

        public static Author GetAuthor(string authorName)
        {
            var author = db.Authors.FirstOrDefault(a => a.Name == authorName);
            if (author == null)
            {
                author = new Author
                {
                    Name = authorName
                };
            }

            return author;
        }
    }
}
