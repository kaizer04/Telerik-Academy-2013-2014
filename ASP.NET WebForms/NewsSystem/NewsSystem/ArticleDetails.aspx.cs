using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class ArticleDetails : System.Web.UI.Page
    {
        public NewsDbContext dbContext;

        public ArticleDetails()
        {
            this.dbContext = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public NewsSystem.Models.Article FormViewArticleDetails_GetItem([QueryString("id")]int? articleID)
        {
            if (articleID == null)
            {
                Response.Redirect("~/");
            }

            var article = this.dbContext.Articles.FirstOrDefault(a => a.ID == articleID);

            return article;
        }
    }
}