using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoveIlheus.Models;
using MoveIlheus.Services;

namespace MoveIlheus.Controllers
{
    public class HomeController : Controller
    {
        private readonly MoveIlheusContexto _context = new MoveIlheusContexto();
        MoveIlheusServico servico;

        public HomeController(MoveIlheusContexto context)
        {
            _context = context;
            servico = new MoveIlheusServico(context);
        }

        public IActionResult Index()
        {
            var formulario = servico.ObterFormulariòParaEditar();
            return View(formulario);
            //return View();
        }

        public JsonResult FinalizarFormulario(Respondente respondente, DateTime inicio, DateTime fim)
        {
            respondente.Duracao = fim - inicio;
            var result = servico.SalvarRespostas(respondente);

            return Json(result);
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
    }
}
