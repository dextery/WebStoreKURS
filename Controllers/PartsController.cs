using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;
using WebStoreKURS.ViewModels;

namespace WebStoreKURS.Controllers
{
    public class PartsController : Controller
    {
        private readonly IAllParts allParts;
        private readonly IPartsCategory allCategories; 

        public PartsController(IAllParts iallparts, IPartsCategory ipartscat) // передача интерфейсов сюда равнозначна передаче класса с которым он связан (startup.cs)
        {
            allParts = iallparts;
            allCategories = ipartscat;
        }
        [Route("Parts/List")]
        [Route("Parts/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Parts> parts = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                parts = allParts.AllParts.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("gpu", category, StringComparison.OrdinalIgnoreCase))
                {
                    parts = allParts.AllParts.Where(i => i.Category.categoryname.Equals("Графическая карта")).OrderBy(i => i.id);
                }
                else if (string.Equals("processor", category, StringComparison.OrdinalIgnoreCase))
                {
                    parts = allParts.AllParts.Where(i => i.Category.categoryname.Equals("Процессор")).OrderBy(i => i.id);
                }
                else if (string.Equals("ram", category, StringComparison.OrdinalIgnoreCase))
                {
                    parts = allParts.AllParts.Where(i => i.Category.categoryname.Equals("Оперативная память")).OrderBy(i => i.id);
                }

                currCategory = _category;

            }
            var partObj = new PartsListViewModel
            {
                AllParts = parts,
                currCategory = currCategory
            };

            ViewBag.Title = "Список товаров";

            return View(partObj);
        }

    }
}
