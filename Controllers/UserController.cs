using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadExcel.Models;

namespace ReadExcel.Controllers
{
    public class UserController : Controller
    {
        // Default GET Method
        [HttpGet]
        public IActionResult Index()
        {
            return View(new List<UserModel>());
        }
    }
}