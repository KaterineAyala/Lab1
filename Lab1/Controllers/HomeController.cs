using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public int Laboratorio { get; private set; }
        public int Parcial { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Periodo1(Acciones acciones)
        {
            if (acciones.Laboratorio > 10 || acciones.Parcial > 10)
            {
                return View("NoMayores");
            }

            Double resultado = ((acciones.Laboratorio * 0.40) + (acciones.Parcial * 0.60)) /3;
            String nombre = acciones.Nombre;

            ViewBag.Nombre = acciones.Nombre;
            ViewBag.DatoN1V = acciones.Laboratorio;
            ViewBag.DatoN2V = acciones.Parcial;

            ViewBag.VariableAEnviarNombre = nombre;
            ViewBag.VariableAEnviar1 = resultado;

            return View();
        }

        public IActionResult NoMayores()
        {
            return View();
        }

        public IActionResult Periodo2(Acciones acciones)
        {
            if (acciones.Laboratorio > 10 || acciones.Parcial > 10)
            {
                return View("NoMayores");
            }

            Double resultado = ((acciones.Laboratorio * 0.40) + (acciones.Parcial * 0.60)) / 3;
            String nombre = acciones.Nombre;

            ViewBag.Nombre = acciones.Nombre;
            ViewBag.DatoN1V = acciones.Laboratorio;
            ViewBag.DatoN2V = acciones.Parcial;

            ViewBag.VariableAEnviarNombre = nombre;
            ViewBag.VariableAEnviar2 = resultado;


            return View();
        }

        public IActionResult Periodo3(Acciones acciones)
        {
            if (acciones.Laboratorio > 10 || Parcial > 10)
            {
                return View("NoMayores");
            }

            Double resultado = ((acciones.Laboratorio * 0.40) + (acciones.Parcial * 0.60)) / 3;
            String nombre = acciones.Nombre;

            ViewBag.Nombre = acciones.Nombre;
            ViewBag.DatoN1V = acciones.Laboratorio;
            ViewBag.DatoN2V = acciones.Parcial;

            ViewBag.VariableAEnviarNombre = nombre;
            ViewBag.VariableAEnviar3 = resultado;



            return View();
        }
    }
}