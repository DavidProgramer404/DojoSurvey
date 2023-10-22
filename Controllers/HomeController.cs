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
            ViewBag.Iname = name;
            ViewBag.Ilocation = location;
            ViewBag.Ifavorite = favorite;
            ViewBag.IComment = comment;
            return View();
        }
    }
}