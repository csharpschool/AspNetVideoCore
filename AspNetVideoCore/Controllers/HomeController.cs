using AspNetVideoCore.Services;
using Microsoft.AspNetCore.Mvc;

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
            var model = _videos.GetAll();

            return View(model);
        }
    }
}
