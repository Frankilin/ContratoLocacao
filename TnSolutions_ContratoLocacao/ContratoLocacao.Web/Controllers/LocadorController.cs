using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContratoLocacao.Entidades;
using ContratoLocacao.Web.Models;
using ContratoLocacao.RNegocios;

namespace ContratoLocacao.Web.Controllers
{
    public class LocadorController : Controller
    {
        // GET: Locador
        public ActionResult NovoLocador()
        {
            try
            {
                ImovelNegocios ing = new ImovelNegocios();
                var modelo = new CadastroLocadorModelo();

                modelo.ImovelSelecionado = ing.ListaTodosImoveisDropDownList();
                
                return View(modelo);

            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost]
        public ActionResult NovoLocador(CadastroLocadorModelo modelo)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Locador ld = new Locador();
                    
                    ld.NomeLocador = modelo.NomeLocador;
                    ld.RgLocador = modelo.RgLocador;
                    ld.CPFLocador = modelo.CPFLocador;
                    ld.EnderecoLocador = modelo.EnderecoLocador;
                    ld.TelFixoLocador = modelo.TelFixoLocador;
                    ld.CelularLocador = modelo.CelularLocador;
                    
                    //Passando os parametros para ImovelLocador
                    ImovelLocador il = new ImovelLocador();
                    il.IdImovel = modelo.IdImovel;
                    il.IdLocador = 4; // criar um campo Hiden no modelo e resgatar o ID através dele.

                    LocadorNegocio ln = new LocadorNegocio();
                    ImovelLocadorNegocio iln = new ImovelLocadorNegocio();
                    ld = ln.NovoLocador(ld);
                    il = iln.NovoImovelLocador(il);

                    TempData["Mensagem"] = "Locador cadastrado com sucesso!";
                    TempData["Resposta"] = "Sucesso";
                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
            }
            return RedirectToAction("NovoLocador", "Locador");
        }


    }
}