using DemoOybek.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoOybek.Web.Controllers
{
    public class VadimController : Controller
    {
        private readonly IAuthService authenticationService;
        public VadimController(IAuthService authService)
        {
            authenticationService = authService ?? throw new ArgumentNullException(nameof(authService));
        }
        public IActionResult GetView()
        {
            return View();
        }

        public IActionResult GetMessage()
        {
            return Content("Some text");
        }

        public IActionResult GetJson()
        {
            return Json(new
            {
                Message = "This is JSON",
                Exists = authenticationService != null
            });
        }
    }
}
