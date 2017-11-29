using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        private IProductRepository repo;
        public NavController(IProductRepository repository)
        {
            repo = repository;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repo.Products.Select(x => x.Category).Distinct().OrderBy(x => x);
            return PartialView(categories);
        }


        //public string menu()
        //{
        //    return "Hello from NavController";
        //}
    }
}