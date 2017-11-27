using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Bullboard.Models;

namespace Bullboard.Services
{
    public static class Search
    {
        private static readonly ApplicationDbContext Db = new ApplicationDbContext();

        public async static Task<List<Ad>> GetAds(string searchString, string minPrice, string maxPrice,
            string type, string category, string subCategory)
        {
            List<Ad> ads = await Db.Ads.ToListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                string[] searchWords = searchString.Split(' ');
                foreach (var item in searchWords)
                {
                    ads = ads.Where(x => x.Title.Contains(item) || x.Description.Contains(item)).ToList();
                }
            }
            if (!String.IsNullOrEmpty(minPrice))
            {
                ads = ads.Where(x => x.Price > Convert.ToDecimal(minPrice)).ToList();
            }
            if (!String.IsNullOrEmpty(maxPrice))
            {
                ads = ads.Where(x => x.Price < Convert.ToDecimal(maxPrice)).ToList();
            }
            if (!String.IsNullOrEmpty(type))
            {
                if (type != "Any")
                {
                    ads = ads.Where(x => x.Type == type).ToList();
                }
            }
            if (!String.IsNullOrEmpty(category))
            {
                ads = ads.Where(x => x.CategoryId == Db.Categories.FirstOrDefault(i => i.Name == category).CategoryId).ToList();
            }
            if (!String.IsNullOrEmpty(subCategory))
            {
                ads = ads.Where(x => x.SubCategoryId == Db.SubCategories.FirstOrDefault(i => i.Name == subCategory).SubCategoryId).ToList();
            }
            return ads;
        }
    }
}