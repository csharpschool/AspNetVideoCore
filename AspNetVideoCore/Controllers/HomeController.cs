using AspNetVideoCore.Models;
using AspNetVideoCore.Services;
using AspNetVideoCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AspNetVideoCore.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData _videos;
        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(video =>
                new VideoViewModel
                {
                    Id = video.Id,
                    Title = video.Title,
                    Genre = video.Genre.ToString()
                });

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);

            if (model == null) return RedirectToAction("Index");

            return View(new VideoViewModel
                {
                    Id = model.Id,
                    Title = model.Title,
                    Genre = model.Genre.ToString()
            }
            );
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(VideoEditViewModel model)
        {
            return View();
        }

    }
}
