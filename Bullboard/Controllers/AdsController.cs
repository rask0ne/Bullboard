using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bullboard.Models;
using Bullboard.Services;
using Microsoft.AspNet.Identity;

namespace Bullboard.Controllers
{
    /// <summary>
    /// Ads controller
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class AdsController : Controller
    {
        /// <summary>
        /// The database
        /// </summary>
        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>View</returns>
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.UserId = HttpContext.User.Identity.GetUserId();
            var pages = db.Ads.Include(a => a.Author);
            ViewBag.CategoryList = db.Categories.ToList();
            ViewBag.subCategoriesList = db.SubCategories.Where(x => x.CategoryId == 1).ToList();
            return View(pages.ToList());
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult DeleteOutdatedAds()
        {
            var ads = db.Ads.ToList();
            var adsToDelete = 
                ads.Where(x => x.EditDate.AddDays(14) < DateTime.Now);
            db.Ads.RemoveRange(adsToDelete);
            db.SaveChanges();
            return new EmptyResult();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<PartialViewResult> RenderAds(string searchString, string minPrice, string maxPrice,
            string type, string category, string subCategory)
        {
            ViewBag.UserId = HttpContext.User.Identity.GetUserId();
            var pages = await Search.GetAds(searchString, minPrice, maxPrice, type, category, subCategory);
            ViewBag.searchString = searchString;
            var categories = db.Categories.ToList();
            ViewBag.CategoryList = categories;
            return PartialView("RenderAds", pages);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<PartialViewResult> UpdateAds(string searchString, string minPrice, string maxPrice,
            string type, string category, string subCategory)
        {
            ViewBag.UserId = HttpContext.User.Identity.GetUserId();
            var pages = await Search.GetAds(searchString, minPrice, maxPrice, type, category, subCategory);
            ViewBag.searchString = searchString;
            ViewBag.CategoryList = db.Categories.ToList();
            ViewBag.subCategoriesList = db.SubCategories.Where(x => x.Name == subCategory).ToList();
            return PartialView("UpdateAds", pages);
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Create()
        {
            ViewBag.CategoryList = db.Categories.ToList();
            ViewBag.subCategoriesList = db.SubCategories.Where(x => x.CategoryId == 1).ToList();
            return View();
        }

        /// <summary>
        /// Creates the specified ad.
        /// </summary>
        /// <param name="ad">The ad.</param>
        /// <returns>View</returns>
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,AuthorId,CreationDate,Price,Type,Category,Subcategory")] Ad ad,
            string category, string subcategory)
        {
            if (ModelState.IsValid)
            {
                ad.AuthorId = User.Identity.GetUserId();
                ad.CategoryId = db.Categories.FirstOrDefault(x => x.Name == category).CategoryId;
                //ad.SubCategoryId = db.SubCategories.FirstOrDefault(x => x.Name == subcategory).SubCategoryId;
                ad.CreationDate = DateTime.Now;
                ad.EditDate = DateTime.Now;
                db.Ads.Add(ad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ad);
        }

        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>View</returns>
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ad ad = db.Ads.Find(id);

            if (ad == null)
            {
                return HttpNotFound();
            }
            else if (HttpContext.User.IsInRole("Admin") || HttpContext.User.Identity.GetUserId() == ad.AuthorId)
            {
                ViewBag.CategoryList = db.Categories.ToList();
                return View(ad);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Edits the specified ad.
        /// </summary>
        /// <param name="ad">The ad.</param>
        /// <returns>View</returns>
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,AuthorId,CreationDate,Price,Type,Category,Subcategory")] Ad ad,
            string category, string subcategory)
        {
            if (ModelState.IsValid)
            {
                ad.AuthorId = User.Identity.GetUserId();
                ad.CategoryId = db.Categories.FirstOrDefault(x => x.Name == category).CategoryId;
                ad.SubCategoryId = db.SubCategories.FirstOrDefault(x => x.Name == subcategory).SubCategoryId;
                ad.EditDate = DateTime.Now;
                db.Entry(ad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ad);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>View</returns>
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ad ad = db.Ads.Find(id);

            if (ad == null)
            {
                return HttpNotFound();
            }
            else if (HttpContext.User.IsInRole("Admin") || HttpContext.User.Identity.GetUserId() == ad.AuthorId)
            {
                return View(ad);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        /// <summary>
        /// Deletes the confirmed.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>View</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Ad ad = db.Ads.Find(id);
            if (HttpContext.User.IsInRole("Admin") || HttpContext.User.Identity.GetUserId() == ad.AuthorId)
            {
                db.Ads.Remove(ad);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ActionResult ChangeCulture(string lang)
        {
            string returnUrl = Request.UrlReferrer.AbsolutePath;

            List<string> cultures = new List<string>() { "ru", "en" };
            if (!cultures.Contains(lang))
            {
                lang = "en";
            }
            HttpCookie cookie = Request.Cookies["lang"];
            if (cookie != null)
                cookie.Value = lang;
            else
            {
                cookie = new HttpCookie("lang");
                cookie.HttpOnly = false;
                cookie.Value = lang;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);
            return Redirect(returnUrl);
        }


        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
