using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2_DPA_FirstMVC.Web.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   

    public IActionResult Login(string email, string password)
    {
        if (email=="19100188@ue.edu.pe" && password =="12345678")
        {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
        }
        return RedirectToAction("Index");
    }
    }
}
