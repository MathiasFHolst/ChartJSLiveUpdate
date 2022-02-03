using ChartJSLive.Classes;
using ChartJSLive.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChartJSLive.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View("Chart", DataAccess.GetViewData());
        }

        public ViewData GetNewData()
        {
            return DataAccess.GetViewData();
        }
    }
}
