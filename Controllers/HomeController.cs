using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class DojoSurvey : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string location, string favorite, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.favorite = favorite;
            ViewBag.Comment = comment;
            return View();
        }
    }
}