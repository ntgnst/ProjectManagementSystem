using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PMS.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
