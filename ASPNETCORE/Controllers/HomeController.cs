using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCOREMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [HttpGet]
        public IActionResult Index(HomeModel formulario)
        {
            CarregarListaDeDados();
            return View();
        }

        public void CarregarListaDeDados()
            {
                HomeModel objhomeModel = new HomeModel();
            ViewBag.Lista = objhomeModel.Getall();
            }
    }
}