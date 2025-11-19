using Microsoft.AspNetCore.Mvc;
using Lab11.Models;
using Lab11.Services;

namespace Lab11.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly IGetData _getData;
        public CalcServiceController(IGetData getData)
        {
            _getData = getData;
        }

        public IActionResult PassUsingModel()
        {
            ViewData["BodyClass"] = "calc-page";
            var data = _getData.Generate();
            return View("PassUsingModel", data);
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["BodyClass"] = "calc-page";
            ViewData["data"] = _getData.Generate();
            return View("PassUsingViewData");
        }

        public IActionResult PassUsingViewBag()
        {
            ViewData["BodyClass"] = "calc-page";
            ViewBag.data = _getData.Generate();
            return View("PassUsingViewBag");
        }

        public IActionResult AccessServiceDirectly()
        {
            ViewData["BodyClass"] = "calc-page";
            return View("AccessServiceDirectly");
        }
    }
}