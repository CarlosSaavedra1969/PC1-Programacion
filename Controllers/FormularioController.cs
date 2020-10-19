using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1_Programacion.Models;

using PC1_Programacion.Data;

namespace PC1_Programacion.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;
        private readonly DatabaseContext _context;

        public FormularioController(ILogger<FormularioController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
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
             _context.Add(objFormulario);
             _context.SaveChanges();
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