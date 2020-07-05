using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.WEB.ViewModel;

namespace Presentation.WEB.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IServices service;

        public RegistroController(IServices service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearRegistro([Bind("Cliente")] RegistroVM registroVM)
        {
            var cliente = registroVM.Cliente;
            var seGuardo = service.Guardar(cliente);

            if(seGuardo != null)
            {
                RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
