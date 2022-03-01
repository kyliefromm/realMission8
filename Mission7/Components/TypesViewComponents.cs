using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;
using WaterProject.Models;
//own model and own words could be named anyting
namespace WaterProject.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IBookRepository repo { get; set; }

        public CategoryViewComponent(IBookRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["Cateogry"];
            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return View(types);
        }
    }


}
