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
        //private void CategoryIDDropDownList(object selectedCategory = null)
        //{
        //    var categoryIdQuery = from d in Context.Categories
        //                          orderby d.CategoryID
        //                          select d;
        //    ViewBag.CategoryId = new SelectList(categoryIdQuery, "CategoryID", "CategoryName", selectedCategory);
        //}


        public ActionResult CreateItem()
        {
            //CategoryIDDropDownList();
            return View();
        }

        [HttpPost]
        public ActionResult CreateItem(ItemDB itemdb)
        {
            if (ModelState.IsValid)
            {
                var files = this.HttpContext.Request.Files;
                itemdb.PostedDate = DateTime.Now;
                Context.Items.Add(itemdb);
                var x = FileUploader.FileUpload(this.ControllerContext);
                foreach (var item in x)
                {
                    //db.Classifieds_Item_Image.Add(new Models.Classifieds_Item_Image() { Classifieds_Items = citems, Classifieds_Item_Image1 = item });
                    Context.Images.Add(new ItemPicture() {ItemDB = itemdb, PictureName = item});
                }
                Context.SaveChanges();
            }
            //CategoryIDDropDownList();
            return View();
        }

    }
}
