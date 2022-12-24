using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdditionController : Controller
    {
        private readonly AppDBContent appDBContent;
        private readonly IAllParts allParts;
        private readonly IPartsCategory allCategories;

        public AdditionController(AppDBContent app, IAllParts allparts, IPartsCategory ipartscat) 
        {
            appDBContent = app;
            allParts = allparts;
            allCategories = ipartscat;
        }
        [HttpGet]
        [Authorize]
        public IActionResult addPart()
        {
            return View();
        }
        
        [HttpPost]
        [Authorize]
        public IActionResult addPart(Parts part)
        {
            Parts partToAdd = new Parts();
            partToAdd.name = part.name;
            partToAdd.isavailable = part.isavailable;
            partToAdd.isFavourite = part.isFavourite;
            partToAdd.shortDesc = part.shortDesc;
            partToAdd.longDesc = part.longDesc;
            partToAdd.price = part.price;
            partToAdd.img = part.img;
            partToAdd.categoryID = part.categoryID;

            IEnumerable<Categories> categories = null;
            categories = allCategories.AllCategories.OrderBy(i => i.id);
            switch(partToAdd.categoryID)
            {
                case 1:
                    partToAdd.Category = allCategories.AllCategories.ElementAt(0);
                    break;
                case 2:
                    partToAdd.Category = appDBContent.Category.ElementAt(1);
                    break;
                case 3:
                    partToAdd.Category = appDBContent.Category.ElementAt(2);
                    break;
                
            }
            if (partToAdd.categoryID!=null&& partToAdd.Category != null)
            {
                appDBContent.Part.Add(partToAdd);
                appDBContent.SaveChanges();
                return RedirectToAction("Completion");
            }
            else
            {
                return RedirectToAction("Failure");
            }
            return View(partToAdd);
        }

        public IActionResult Completion()
        {
            ViewBag.Message = "Действие завершено";
            return View();
        }
        public IActionResult Failure()
        {
            ViewBag.Message = "Что-то пошло не так!";
            return View();
        }
    }
}
