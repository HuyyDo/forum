using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _422_431_432_433_434.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult SignIN()
        {
            return View();
        }
        public IActionResult Validate()
        {
            return View();
        }
        public IActionResult EditAccount()
        {
            return View();
        }

        public IActionResult AssignRole(AccountsController accounts)
        {
            return View();
        }

        public IActionResult SearchAccount()
        {
            return View();
        }



    }
}
