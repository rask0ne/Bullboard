using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bullboard.Models;

namespace Bullboard.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext Db = new ApplicationDbContext();

        [AllowAnonymous]
        [HttpPost]
        public JsonResult GetSubCategories(string categoryName)
        {
            var category = Db.Categories.FirstOrDefault(x => x.Name == categoryName);
            var subCategoriesList = Db.SubCategories.Where(x => x.CategoryId == category.CategoryId);
            return Json(subCategoriesList, JsonRequestBehavior.AllowGet);
        }
    }
}