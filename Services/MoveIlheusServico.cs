using Microsoft.EntityFrameworkCore;
using MoveIlheus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveIlheus.Services
{
    public class MoveIlheusServico
    {
        //private MoveIlheusContexto contexto = new MoveIlheusContexto();
        private readonly MoveIlheusContexto contexto;

        public MoveIlheusServico(MoveIlheusContexto _context)
        {
            contexto = _context;
        }
        
        public MoveIlheusServico()
        {
        }
        
        public Formulario ObterFormulariòParaEditar()
        {
            return contexto.Forms.Include("Paginas.Restricoes.RestricoesConteudosPagina").Include("Paginas.Conteudos.Opcoes").Include("Paginas.Conteudos.Restricoes").Include("Paginas.Conteudos.ConteudosDesenhos.Opcoes").FirstOrDefault();
        }

        public ResultProcessing SalvarFormulario(Formulario formulario)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                if (formulario.Id == 0)
                {
                    contexto.Forms.Add(formulario);
                    contexto.SaveChanges();
                    result.Id = formulario.Id;
                }
                else
                {
                    contexto.Entry(formulario).State = EntityState.Modified;
                    contexto.SaveChanges();
                }
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing SalvarPagina(Pagina pagina)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                if (pagina.Id == 0)
                {
                    contexto.Pages.Add(pagina);
                    contexto.SaveChanges();
                    result.Id = pagina.Id;
                }
                else
                {
                    var paginaDB = contexto.Pages.Include("Restricoes.RestricoesConteudosPagina").FirstOrDefault(x => x.Id == pagina.Id);

                    paginaDB.Dimensao = pagina.Dimensao;
                    paginaDB.Final = pagina.Final;
                    paginaDB.ProximaPaginaId = pagina.ProximaPaginaId;
                    paginaDB.Sequencia = pagina.Sequencia;
                    paginaDB.Titulo = pagina.Titulo;
                    paginaDB.Latitude = pagina.Latitude;
                    paginaDB.Longitude = pagina.Longitude;
                    paginaDB.ZoomLevel = pagina.ZoomLevel;

                    if (pagina.Restricoes == null)
                        pagina.Restricoes = new List<RestricaoPagina>();

                    for (int i = 0; i < paginaDB.Restricoes.Count; i++)
                    {
                        var restricaoNova = pagina.Restricoes.FirstOrDefault(x => x.Id == paginaDB.Restricoes[i].Id);
                        if (restricaoNova == null)
                        {
                            contexto.PageRestrictions.Remove(paginaDB.Restricoes[i]);
                            i--;
                        }
                        else
                        {
                            paginaDB.Restricoes[i].Nome = restricaoNova.Nome;
                            paginaDB.Restricoes[i].ProximaPaginaId = restricaoNova.ProximaPaginaId;

                            if (paginaDB.Restricoes[i].RestricoesConteudosPagina != null)
                                contexto.ContentsRestrictionsPage.RemoveRange(paginaDB.Restricoes[i].RestricoesConteudosPagina);
                            if (restricaoNova.RestricoesConteudosPagina != null)
                                paginaDB.Restricoes[i].RestricoesConteudosPagina.AddRange(restricaoNova.RestricoesConteudosPagina);

                            contexto.Entry(paginaDB.Restricoes[i]).State = EntityState.Modified;
                        }
                    }

                    foreach (var restricao in pagina.Restricoes)
                    {
                        if (restricao.Id == 0)
                            paginaDB.Restricoes.Add(restricao);
                    }

                    contexto.Entry(paginaDB).State = EntityState.Modified;

                    contexto.SaveChanges();

                    result.Ids = paginaDB.Restricoes.Select(x => x.Id).ToList();
                }
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing SalvarConteudo(Conteudo conteudo)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                if (conteudo.Id == 0)
                {
                    contexto.Contents.Add(conteudo);
                    contexto.SaveChanges();
                    result.Id = conteudo.Id;
                    if (conteudo.Opcoes != null)
                        result.Ids = conteudo.Opcoes.Select(x => x.Id).ToList();

                    if (conteudo.Restricoes != null)
                        result.Ids2 = conteudo.Restricoes.Select(x => x.Id).ToList();
                }
                else
                {
                    var conteudoDB = contexto.Contents.Include(x => x.Opcoes).Include(x => x.Restricoes).FirstOrDefault(x => x.Id == conteudo.Id);
                    conteudoDB.Texto = conteudo.Texto;
                    conteudoDB.Valor = conteudo.Valor;
                    conteudoDB.Obrigatorio = conteudo.Obrigatorio;
                    conteudoDB.MensagemNovoDesenho = conteudo.MensagemNovoDesenho;
                    conteudoDB.TituloConteudosDesenho = conteudo.TituloConteudosDesenho;

                    if (conteudo.Opcoes == null)
                        conteudo.Opcoes = new List<Opcao>();
                    for (int i = 0; i < conteudoDB.Opcoes.Count; i++)
                    {
                        var opcaoNovo = conteudo.Opcoes.FirstOrDefault(x => x.Id == conteudoDB.Opcoes[i].Id);
                        if (opcaoNovo == null)
                        {
                            contexto.Options.Remove(conteudoDB.Opcoes[i]);
                            i--;
                        }
                        else
                        {
                            conteudoDB.Opcoes[i].Texto = opcaoNovo.Texto;
                            conteudoDB.Opcoes[i].Valor = opcaoNovo.Valor;
                            contexto.Entry(conteudoDB.Opcoes[i]).State = EntityState.Modified;
                        }
                    }
                    foreach (var opcao in conteudo.Opcoes)
                    {
                        if (opcao.Id == 0)
                            conteudoDB.Opcoes.Add(opcao);
                    }

                    if (conteudo.Restricoes == null)
                        conteudo.Restricoes = new List<RestricaoConteudo>();
                    for (int i = 0; i < conteudoDB.Restricoes.Count; i++)
                    {
                        var restricaoNovo = conteudo.Restricoes.FirstOrDefault(x => x.Id == conteudoDB.Restricoes[i].Id);
                        if (restricaoNovo == null)
                        {
                            contexto.ContentRestrictions.Remove(conteudoDB.Restricoes[i]);
                            i--;
                        }
                        else
                        {
                            conteudoDB.Restricoes[i].Nome = restricaoNovo.Nome;
                            contexto.Entry(conteudoDB.Restricoes[i]).State = EntityState.Modified;
                        }
                    }
                    foreach (var restricao in conteudo.Restricoes)
                    {
                        if (restricao.Id == 0)
                            conteudoDB.Restricoes.Add(restricao);
                    }

                    contexto.Entry(conteudoDB).State = EntityState.Modified;
                    contexto.SaveChanges();

                    result.Ids = conteudoDB.Opcoes.Select(x => x.Id).ToList();
                    if (conteudo.Opcoes != null)
                        result.Ids = conteudo.Opcoes.Select(x => x.Id).ToList();
                    if (conteudo.Restricoes != null)
                        result.Ids2 = conteudo.Restricoes.Select(x => x.Id).ToList();
                }
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing AtualizarSequenciaConteudos(List<Conteudo> conteudos)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                foreach (var conteudo in conteudos)
                {
                    contexto.Entry(conteudo).State = EntityState.Modified;
                }
                contexto.SaveChanges();

                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing SalvarRespostas(Respondente respondente)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                contexto.Respondents.Add(respondente);
                //contexto.Respostas.AddRange(respostas);
                //contexto.SaveChanges();

                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing ExcluirPagina(int id)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                var pagina = contexto.Pages.Include("Conteudos.ConteudosDesenhos.Opcoes").FirstOrDefault(x => x.Id == id);

                var paginas = contexto.Pages.Where(x => x.ProximaPaginaId == pagina.Id).ToList();
                foreach(var p in paginas)
                {
                    p.ProximaPagina = null;
                    p.ProximaPaginaId = null;
                    contexto.Entry(p).State = EntityState.Modified;
                }
                
                if (pagina.Conteudos != null)
                {
                    foreach(var c in pagina.Conteudos)
                    {
                        if(c.Tipo == TipoConteudo.DrawMarker || c.Tipo == TipoConteudo.DrawLine || c.Tipo == TipoConteudo.DrawPolygon)
                        {
                            contexto.DrawingsContents.RemoveRange(c.ConteudosDesenhos);
                        }
                        if(c.Opcoes != null)
                            contexto.Options.RemoveRange(c.Opcoes);
                    }
                }
                contexto.Pages.Remove(pagina);
                contexto.SaveChanges();

                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing ExcluirConteudo(int id)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                var conteudo = contexto.Contents.FirstOrDefault(x => x.Id == id);

                var restricoesConteudos = contexto.ContentRestrictions.Where(x => x.ConteudoAlvoId == conteudo.Id).ToList();
                contexto.ContentRestrictions.RemoveRange(restricoesConteudos);

                var restricoesPaginas = contexto.ContentsRestrictionsPage.Where(x => x.ConteudoId == conteudo.Id).ToList();
                contexto.ContentsRestrictionsPage.RemoveRange(restricoesPaginas);

                var conteudosDesenho = contexto.DrawingsContents.Where(x => x.ConteudoId == conteudo.Id).ToList();
                //contexto.ConteudosDesenhos.RemoveRange(conteudosDesenho);
                foreach (var item in conteudosDesenho)
                {
                    var opcoesCD = contexto.Options.Where(x => x.ConteudoDesenhoId == item.Id).ToList();
                    contexto.Options.RemoveRange(opcoesCD);
                }

                var opcoes = contexto.Options.Where(x => x.ConteudoId == conteudo.Id).ToList();
                contexto.Options.RemoveRange(opcoes);

                contexto.Contents.Remove(conteudo);

                contexto.SaveChanges();

                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }




        public ResultProcessing SalvarConteudoDesenho(ConteudoDesenho conteudo)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                if (conteudo.Id == 0)
                {
                    contexto.DrawingsContents.Add(conteudo);
                    contexto.SaveChanges();
                    result.Id = conteudo.Id;
                    if (conteudo.Opcoes != null)
                        result.Ids = conteudo.Opcoes.Select(x => x.Id).ToList();

                }
                else
                {
                    var conteudoDB = contexto.DrawingsContents.Include(x => x.Opcoes).FirstOrDefault(x => x.Id == conteudo.Id);
                    conteudoDB.Texto = conteudo.Texto;
                    conteudoDB.Valor = conteudo.Valor;

                    if (conteudo.Opcoes == null)
                        conteudo.Opcoes = new List<Opcao>();
                    for (int i = 0; i < conteudoDB.Opcoes.Count; i++)
                    {
                        var opcaoNovo = conteudo.Opcoes.FirstOrDefault(x => x.Id == conteudoDB.Opcoes[i].Id);
                        if (opcaoNovo == null)
                        {
                            contexto.Options.Remove(conteudoDB.Opcoes[i]);
                            i--;
                        }
                        else
                        {
                            conteudoDB.Opcoes[i].Texto = opcaoNovo.Texto;
                            conteudoDB.Opcoes[i].Valor = opcaoNovo.Valor;
                            contexto.Entry(conteudoDB.Opcoes[i]).State = EntityState.Modified;
                        }
                    }
                    foreach (var opcao in conteudo.Opcoes)
                    {
                        if (opcao.Id == 0)
                            conteudoDB.Opcoes.Add(opcao);
                    }

                    contexto.Entry(conteudoDB).State = EntityState.Modified;
                    contexto.SaveChanges();

                    result.Ids = conteudoDB.Opcoes.Select(x => x.Id).ToList();
                    if (conteudo.Opcoes != null)
                        result.Ids = conteudo.Opcoes.Select(x => x.Id).ToList();
                }
                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing ExcluirConteudoDesenho(int id)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                var conteudo = contexto.DrawingsContents.FirstOrDefault(x => x.Id == id);

                contexto.DrawingsContents.Remove(conteudo);

                contexto.SaveChanges();

                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }

        public ResultProcessing AtualizarSequenciaConteudosDesenhos(List<ConteudoDesenho> conteudos)
        {
            ResultProcessing result = new ResultProcessing();
            result.Success = true;
            try
            {
                foreach (var conteudo in conteudos)
                {
                    contexto.Entry(conteudo).State = EntityState.Modified;
                }
                contexto.SaveChanges();

                return result;
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Message = e.Message;
                return result;
            }
        }


        public object GerarGraficos(int idConteudo, string texto, int valor, int opcaoId)
        {
            int qtdIgual = 0;
            var qtdTotal = contexto.Answers.Count(x => x.ConteudoId == idConteudo);
            if(texto != null)
            {
                qtdIgual = contexto.Answers.Count(x => x.ConteudoId == idConteudo && x.Texto == texto);
            }
            else if(valor != null)
            {
                qtdIgual = contexto.Answers.Count(x => x.ConteudoId == idConteudo && x.Valor == valor);
            }
            else if (opcaoId != null)
            {
                qtdIgual = contexto.Answers.Count(x => x.ConteudoId == idConteudo && x.OpcaoId == opcaoId);
            }

            return new { qtdTotal, qtdIgual };
        }

    }
}