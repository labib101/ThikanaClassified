using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThikanaClassified.DatabaseModels;
using ThikanaClassifieds.Utilities;

namespace ThikanaClassified.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private ClassifiedDbContext Context = new ClassifiedDbContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category CategorytoAdd)
        {
            if (ModelState.IsValid)
            {
                var x = FileUploader.FileUpload(this.ControllerContext).FirstOrDefault();
                if (x != null && x.Length > 0)
                {
                    CategorytoAdd.CategoryPicture = x;
                }
               Context.Categories.Add(CategorytoAdd);
                Context.SaveChanges();
            }

            return View("Index");
        }
        private void CategoryIDDropDownList(object selectedCategory = null)
        {
            var categoryIdQuery = from d in Context.Categories
                                  orderby d.CategoryName
                                  select d;
            ViewBag.CategoryId = new SelectList(categoryIdQuery, "CategoryID", "CategoryName", selectedCategory);
        }
        public ActionResult CreateItem()
        {
            CategoryIDDropDownList();
            return View();
        }

    }
}
