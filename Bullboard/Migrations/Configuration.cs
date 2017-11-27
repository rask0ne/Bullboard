using Bullboard.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Bullboard.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bullboard.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bullboard.Models.ApplicationDbContext context)
        {
            context.Roles.AddOrUpdate(new IdentityRole()
            {
                Id = "Admin",
                Name = "Admin"
            });

            context.Categories.AddOrUpdate( new Category()
            {
                CategoryId = 1,
                Name = "Fashion & Style"
            }, new Category()
            {
                CategoryId = 2,
                Name = "Housing"
            }, new Category()
            {
                CategoryId = 3,
                Name = "Realty"
            }, new Category()
            {
                CategoryId = 4,
                Name = "All for moms & babies"
            }, new Category()
            {
                CategoryId = 5,
                Name = "Auto & transport"
            }, new Category()
            {
                CategoryId = 6,
                Name = "Hobbies, sports & tourism"
            }, new Category()
            {
                CategoryId = 7,
                Name = "Repair and construction"
            }, new Category()
            {
                CategoryId = 8,
                Name = "Electronics"
            }, new Category()
            {
                CategoryId = 9,
                Name = "Garden"
            }, new Category()
            {
                CategoryId = 10,
                Name = "Entertainment & Wedding"
            }, new Category()
            {
                CategoryId = 11,
                Name = "Work, business and study"
            }, new Category()
            {
                CategoryId = 12,
                Name = "Service"
            });

            context.SubCategories.AddOrUpdate(new SubCategory()
            {               
                Name = "Men's Clothing",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Women's clothing",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Men's shoes",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Women's shoes",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Accessories and watches",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Cosmetics and perfumery",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Repair of clothes, sewing, dry cleaning",
                CategoryId = 1
            }, new SubCategory()
            {
                Name = "Clothes for pregnant women",
                CategoryId = 1
                //----------------------------------------------Housing--------------------------
            }, new SubCategory()
            {
                Name = "Furniture and interior",
                CategoryId = 2
            }, new SubCategory()
            {
                Name = "Household goods",
                CategoryId = 2
            }, new SubCategory()
            {
                Name = "Crockery and cutlery",
                CategoryId = 2
            }, new SubCategory()
            {
                Name = "Houseplants",
                CategoryId = 2
            }, new SubCategory()
            {
                Name = "Appliances",
                CategoryId = 2
            }, new SubCategory()
            {
                Name = "Domestic services",
                CategoryId = 2
            }, new SubCategory()
            {
                Name = "Repair of furniture",
                CategoryId = 2
                //----------------------------------------------Realty-----------------------------------
            }, new SubCategory()
            {
                Name = "Apartments",
                CategoryId = 3
            }, new SubCategory()
            {
                Name = "Rooms",
                CategoryId = 3
            }, new SubCategory()
            {
                Name = "Houses, cottages, cottages",
                CategoryId = 3
            }, new SubCategory()
            {
                Name = "Garages and parking",
                CategoryId = 3
                //--------------------------------------------All for moms & babies------------------------------
            }, new SubCategory()
            {
                Name = "Clothes up to 1 year old",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Clothing for girls",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Clothes for boys",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Cribs, playpen, stools",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Walkers, chaise lounges, swings",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Carriages",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Feeding and care",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Toys and books",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Goods for moms",
                CategoryId = 4
            }, new SubCategory()
            {
                Name = "Clothes for pregnant women",
                CategoryId = 4
                //--------------------------------------------------Auto & transport---------------
            }, new SubCategory()
            {
                Name = "Cars",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Trucks and buses",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Motorcycles and Motorcycles",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Tractors and agricultural machinery",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Special machinery",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Trailers and semitrailers",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Water transport",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Car Seats and Boosters",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Tires and wheels",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Spare parts, consumables, chemistry",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Other for cars and vehicles",
                CategoryId = 5
            }, new SubCategory()
            {
                Name = "Accessories",
                CategoryId = 5
                //------------------------------------------------Hobbies, sports & tourism-------------------
            }, new SubCategory()
            {
                Name = "CD, DVD, records",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Antiques and Collections",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Books and magazines",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Musical instruments",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Hunting and fishing",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Tourist goods",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Needlework",
                CategoryId = 6
            }, new SubCategory()
            { 
                Name = "Sports goods",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Bicycles",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Tourist services",
                CategoryId = 6
            }, new SubCategory()
            {
                Name = "Other hobbies, sports and tourism",
                CategoryId = 6
                //-----------------------------------------------Repair and construction-------------------------
            }, new SubCategory()
            {
                Name = "Building tools",
                CategoryId = 7
            }, new SubCategory()
            {
                Name = "Plumbing",
                CategoryId = 7
            }, new SubCategory()
            {
                Name = "Building materials",
                CategoryId = 7
            }, new SubCategory()
            {
                Name = "Decoration Materials",
                CategoryId = 7
            }, new SubCategory()
            {
                Name = "Windows and doors",
                CategoryId = 7
            }, new SubCategory()
            {
                Name = "Other for repair and construction",
                CategoryId = 7
            }, new SubCategory()
            {
                Name = "Services in construction and repair",
                CategoryId = 7
                //---------------------------------------------------------Electronics------------------------
            }, new SubCategory()
            {
                Name = "Audio equipment",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Computers and accessories",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "TV and video equipment",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Photography and optics",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Games and consoles",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Phones",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Office equipment",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Tablets and e-books",
                CategoryId = 8
            }, new SubCategory()
            {
                Name = "Appliances",
                CategoryId = 8
                //---------------------------------------------------------Garden---------------------------
            }, new SubCategory()
            {
                Name = "Garden furniture and barbecues",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Garden plants, seedlings and seeds",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Gardening equipment and tools",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Greenhouses",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Garden Accessories",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Fertilizers and agrochemistry",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Everything for the beekeeper",
                CategoryId = 9
            }, new SubCategory()
            {
                Name = "Other for the garden",
                CategoryId = 9
                //----------------------------------------------------------Wedding-----------------------
            }, new SubCategory()
            {
                Name = "Wedding Dresses",
                CategoryId = 10
            }, new SubCategory()
            {
                Name = "Wedding Costumes",
                CategoryId = 10
            }, new SubCategory()
            {
                Name = "Wedding shoes",
                CategoryId = 10
            }, new SubCategory()
            {
                Name = "Wedding accessories",
                CategoryId = 10
            }, new SubCategory()
            {
                Name = "Gifts and Holiday Goods",
                CategoryId = 10
            }, new SubCategory()
            {
                Name = "Carnival costumes",
                CategoryId = 10
            }, new SubCategory()
            {
                Name = "Services for celebrations",
                CategoryId = 10
                //------------------------------------------------------Work, business and study--------------
            }, new SubCategory()
            {
                Name = "Careers",
                CategoryId = 11
            }, new SubCategory()
            {
                Name = "Workmanship",
                CategoryId = 11
            }, new SubCategory()
            {
                Name = "Machines and equipment",
                CategoryId = 11
            }, new SubCategory()
            {
                Name = "Education",
                CategoryId = 11
            }, new SubCategory()
            {
                Name = "Stationery",
                CategoryId = 11
            }, new SubCategory()
            {
                Name = "School Costumes",
                CategoryId = 11 
                //--------------------------------------------------------Services---------------------------
            }, new SubCategory()
            {
                Name = "Services for cars",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Domestic services",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Computer services, internet",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Beauty and health",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Nanny and nurse",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Translation and interpreting services",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Transportation of passengers and cargoes",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Advertising, printing",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Services in construction and repair",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Repair of furniture",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Repair of clothes, sewing, dry cleaning",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Garden, accomplishment",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Services for animals",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Photo and video",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Legal services and insurance",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Tourist services",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Services for celebrations",
                CategoryId = 12

            }, new SubCategory()
            {
                Name = "Other services",
                CategoryId = 12

            });
        }
    }
}
