﻿namespace BookStore.Importer
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
            //Task6
            //Import();
            Search();
        }

        public static void Search()
        { 
            var xmlQueries = XElement.Load(@"..\..\..\reviews-queries.xml").Elements();
            //Create XML
            var result = new XElement("search-results");

            foreach (var xmlQuery in xmlQueries)
            {
                //BACHKA
                //Console.WriteLine(xmlQuery.Value);

                var queryInReviews = db.Reviews.AsQueryable();

                if (xmlQuery.Attribute("type").Value == "by-period")
                {
                    var startDate = DateTime.Parse(xmlQuery.Element("start-date").Value);
                    var endDate = DateTime.Parse(xmlQuery.Element("end-date").Value);

                    queryInReviews = queryInReviews.Where(r => startDate <= r.CreateOn && r.CreateOn <= endDate);
                }
                else if (xmlQuery.Attribute("type").Value == "by-author")
                {
                    var authorName = xmlQuery.Element("author-name").Value;

                    queryInReviews = queryInReviews.Where(r => r.Author.Name == authorName);
                }

                var resultSet = queryInReviews
                    .OrderBy(r => r.CreateOn)
                    .ThenBy(r => r.Content)
                    .Select(r => new
                    {
                        Date = r.CreateOn,
                        Content = r.Content,
                        Book = new
                        {
                            Title = r.Book.Title,
                            Authors = r.Book.Authors
                                .OrderBy(a => a.Name)
                                .Select(a => a.Name),
                            ISBN = r.Book.ISBN,
                            URL = r.Book.WebSite
                        }
                    })
                    .ToList();

                //cw bez ToList - Bachka
                //Console.WriteLine(resultSet);

                //create XML continue
                var xmlResultSet = new XElement("result-set");
                foreach (var reviewInResult in resultSet)
                {
                    var xmlReview = new XElement("review");
                    //var dateElement = new XElement
                    xmlReview.Add(new XElement("date", reviewInResult.Date.ToString("d-MMM-yyyy")));
                    xmlReview.Add(new XElement("content", reviewInResult.Content));

                    xmlResultSet.Add(xmlReview);
                }
                
                result.Add(xmlResultSet);
            }

            result.Save(@"..\..\..\reviews-search-results.xml");
        }

        public static void Import()
        {
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
