using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem.Admin
{
    public partial class EditArticles : System.Web.UI.Page
    {
        public NewsDbContext dbContext;

        public EditArticles()
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
        public IQueryable<NewsSystem.Models.Article> ListViewArticles_GetData()
        {
            return this.dbContext.Articles.OrderBy(a => a.ID);
        }
    }
}