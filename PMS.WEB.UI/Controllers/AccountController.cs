using Microsoft.AspNetCore.Mvc;
using PMS.Interface.Result;
using PMS.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.WEB.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Result<LoginViewModel> result = new Result<LoginViewModel>(new LoginViewModel());
                return View(result);
            }
        }
    }
}
