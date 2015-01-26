using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class News : System.Web.UI.Page
    {
        public NewsDbContext dbContext;

        public News()
        {
            this.dbContext = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSystem.Models.Category> ListViewCategories_GetData()
        {
            // var sortArticlesInCategory = this.dbContext.Articles.OrderByDescending(a => a.Likes).ToArray();

            return this.dbContext.Categories;
        }

        public IEnumerable<NewsSystem.Models.Article> Repeater_GetData()
        {
            var sortArticles = this.dbContext.Articles.OrderByDescending(a => a.Likes).ToArray();

            var popularArticles = new List<Article>();

            for (int i = 0; i < 3; i++)
            {
                popularArticles.Add(sortArticles[i]);
            }

            return popularArticles;
        }
    }
}