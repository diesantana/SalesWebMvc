using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DeparmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Deparment> list = new List<Deparment>();
            list.Add(new Deparment() { Id = 1, Name = "Electronics" });
            list.Add(new Deparment() { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
