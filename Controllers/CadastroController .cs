﻿using Microsoft.AspNetCore.Mvc;
using MoveIlheus.Models;
using MoveIlheus.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveIlheus.Controllers
{
    public class CadastroController : Controller
    {
        MoveIlheusServico servico = new MoveIlheusServico();
        public ActionResult Index()
        {
            var formulario = servico.ObterFormulariòParaEditar();
            return View(formulario);
        }
        
        public JsonResult Teste(Formulario formulario)
        {
            return Json(new { success = true, message = "Uma mensagem", additionalData = new { primeiro = 1, segundo = 2 }, id = 7 });
        }

        public JsonResult ObterFormulariòParaEditar()
        {
            var formulario = servico.ObterFormulariòParaEditar();
            var retorno = JsonConvert.SerializeObject(formulario,
                Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });

            return Json(new { success = formulario != null, data = retorno });
        }

        public JsonResult SalvarFormulario(Formulario formulario)
        {
            var result = servico.SalvarFormulario(formulario);

            return Json(result);
        }

        public JsonResult SalvarPagina(Pagina pagina)
        {
            pagina.Restricoes = null;
            pagina.Conteudos = null;
            var result = servico.SalvarPagina(pagina);
            
            return Json(result);
        }

        public JsonResult SalvarNovaPagina(Pagina pagina)
        {
            var result = servico.SalvarPagina(pagina);

            return Json(result);
        }

        public JsonResult SalvarConfiguracaoPagina(Pagina pagina)
        {
            //if(pagina.Conteudos != null)
            //pagina.Conteudos.Clear();
            pagina.Conteudos = null;

            var result = servico.SalvarPagina(pagina);

            return Json(result);
        }

        public JsonResult SalvarConteudo(Conteudo conteudo)
        {
            var result = servico.SalvarConteudo(conteudo);

            return Json(result);
        }

        public JsonResult AtualizarSequenciaConteudos(List<Conteudo> conteudos)
        {
            var result = servico.AtualizarSequenciaConteudos(conteudos);

            return Json(result);
        }

        public JsonResult ExcluirPagina(Pagina pagina)
        {
            //conteudo.Restricoes = null;
            var result = servico.ExcluirPagina(pagina.Id);

            return Json(result);
        }

        public JsonResult ExcluirConteudo(Conteudo conteudo)
        {
            //conteudo.Restricoes = null;
            var result = servico.ExcluirConteudo(conteudo.Id);

            return Json(result);
        }

        //[HttpPost]
        //public JsonResult FinalizarFormulario(List<Resposta> respostas)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var resultado = servico.SalvarRespostas(respostas);
        //        if (resultado.Success)
        //        {
        //            resultado.Message = "Formulário Finalizado";
        //        }
        //        return Json(new { success = resultado.Success, message = resultado.Message, id = resultado.Id });
        //    }
        //    return Json(new { success = false, message = "Ocorreu um Erro" });
        //}

        public JsonResult ExcluirConteudoDesenho(ConteudoDesenho conteudo)
        {
            //conteudo.Restricoes = null;
            var result = servico.ExcluirConteudoDesenho(conteudo.Id);

            return Json(result);
        }

        public JsonResult SalvarConteudoDesenho(ConteudoDesenho conteudo)
        {
            var result = servico.SalvarConteudoDesenho(conteudo);

            return Json(result);
        }

        public JsonResult AtualizarSequenciaConteudosDesenhos(List<ConteudoDesenho> conteudos)
        {
            var result = servico.AtualizarSequenciaConteudosDesenhos(conteudos);

            return Json(result);
        }

    }
}