using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem.Admin
{
    public partial class EditCategories : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public EditCategories()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var data = this.dbContext.Categories.ToList();
            this.ListViewCategories.DataSource = data;
            this.ListViewCategories.DataBind();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<LibrarySystem.Models.Category> ListViewCategory_GetData()
        {
            return null;
        }
    }
}