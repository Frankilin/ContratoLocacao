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
                LocadorNegocio ln = new LocadorNegocio();
                var modelo = new CadastroLocadorModelo();

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
                    Imovel i = new Imovel();

                    ld.NomeLocador = modelo.NomeLocador;
                    ld.RgLocador = modelo.RgLocador;
                    ld.CPFLocador = modelo.CPFLocador;
                    ld.EnderecoLocador = modelo.EnderecoLocador;
                    ld.TelFixoLocador = modelo.TelFixoLocador;
                    ld.CelularLocador = modelo.CelularLocador;

                    //Recebendo o Id do imóvel através do modelo
                    i.IdImovel = modelo.ImovelSelecionado;

                    ImovelNegocios ing = new ImovelNegocios();
                    i = ing.NovoImovel(i);
                    i.IdLocador = ld.IdLocador;
                    
                    LocadorNegocio ln = new LocadorNegocio();
                    ld = ln.NovoLocador(ld);

                    TempData["Mensagem"] = "Imóvel cadastrado com sucesso!";
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