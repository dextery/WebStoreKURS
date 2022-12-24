using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.ViewModels;

namespace WebStoreKURS.Controllers
{
	[ApiExplorerSettings(IgnoreApi = true)]
	public class HomeController : Controller
    {
        private readonly IAllParts _partRep;

        public HomeController(IAllParts partRep)
        {
            _partRep = partRep;
        }

        public ViewResult TopSellers ()
        {
            var homeParts = new HomeViewModel
            {
                favParts = _partRep.FavParts
            };
            return View(homeParts);
        }
    }
}
