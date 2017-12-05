using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ComicsCSharp.Models;

namespace ComicsCSharp.Controllers
{
    public class ComicsController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.comics = ComicsData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Comic comic)
        {
            if (ModelState.IsValid)
            {
                ComicsData.Add(comic);
                return Redirect("/Comics");
            }
            // else
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] removedComics)
        {
            foreach(int comicId in removedComics)
            {
                ComicsData.RemoveById(comicId);
            }
            return Redirect("/Comics");
        }
    }
}
