using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _422_431_432_433_434.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Comment()
        {
            return View();
        }

        public IActionResult EditComment()
        {
            return View();
        }
        public IActionResult DeleteComment()
        {
            return View();
        }
    }
}
