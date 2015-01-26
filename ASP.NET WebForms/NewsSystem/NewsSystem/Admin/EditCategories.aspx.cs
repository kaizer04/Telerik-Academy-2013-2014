using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem.Admin
{
    public partial class EditCategories : System.Web.UI.Page
    {
        public NewsDbContext dbContext;

        public EditCategories()
        {
            this.dbContext = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //var data = this.dbContext.Categories.ToList();
            //this.ListViewCategories.DataSource = data;
            //this.ListViewCategories.DataBind();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSystem.Models.Category> ListViewCategories_GetData()
        {
            return this.dbContext.Categories.OrderBy(c => c.ID);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_DeleteItem(int ID)
        {
            Category item = this.dbContext.Categories.Find(ID);
            this.dbContext.Categories.Remove(item);
            this.dbContext.SaveChanges();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewCategories_UpdateItem(int ID)
        {
            Category item = dbContext.Categories.Find(ID);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", ID));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                dbContext.SaveChanges();

            }
        }

        public void ListViewCategories_InsertItem()
        {
            var item = new Category();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                dbContext.Categories.Add(item);
                dbContext.SaveChanges();

            }
        }
    }
}