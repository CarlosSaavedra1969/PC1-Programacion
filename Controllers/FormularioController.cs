using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1_Programacion.Models;

namespace PC1_Programacion.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }
        public IActionResult Formulario()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      
      [HttpPost]
        public IActionResult formulario( Formulario objFormulario){
         if(ModelState.IsValid)
         {
             //grabar
             objFormulario.Respuesta="Se registraron sus datos en la Base de Datos.";
         }else
         {
             //rechazar
             objFormulario.Respuesta="Rellene, su viejita prra.";
         }
         return View("formulario",objFormulario);
        }
    }
    }