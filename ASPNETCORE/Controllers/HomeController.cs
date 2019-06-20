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
        public IActionResult Index()
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