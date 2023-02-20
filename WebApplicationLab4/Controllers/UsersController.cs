using Microsoft.AspNetCore.Mvc;
using WebApplicationLab4.Models;

namespace WebApplicationLab4.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult BHView()
        {
            return View(uc.BhannonTables.ToList());
        }
    } //Brendan Hannon CPS-3330-01 Spring 2023 Lab 4
}
