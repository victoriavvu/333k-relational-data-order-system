using Microsoft.AspNetCore.Mvc;
using Vu_Victoria_HW5.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


using Vu_Victoria_HW5.DAL;
using System.Linq;

//TODO: Upddate this namespace to match your project name
namespace Vu_Victoria_HW5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
