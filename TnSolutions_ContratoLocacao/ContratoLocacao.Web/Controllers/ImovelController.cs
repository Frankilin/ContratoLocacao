using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContratoLocacao.Entidades;
using ContratoLocacao.Web.Models;
using System.Web.Mvc;
using ContratoLocacao.RNegocios;

namespace ContratoLocacao.Web.Controllers
{
    public class ImovelController  : Controller
    {

        public ActionResult NovoImovel()
        {
            try
            {
                ImovelNegocios In = new ImovelNegocios();

                var model = new CadastroImovelModelo();

                return View(model);
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost]
        public ActionResult NovoImovel(CadastroImovelModelo modelo)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Imovel i = new Imovel();

                    i.NomeImovel    = modelo.NomeImovel;
                    i.Endereco      = modelo.Endereco;
                    i.Complemento   = modelo.Complemento;
                    i.Numero        = modelo.Numero;
                    i.Bairro        = modelo.Bairro;
                    i.Estado        = modelo.Estado;
                    i.Cidade        = modelo.Cidade;
                    i.Cep           = modelo.Cep;
                   
                    ImovelNegocios imn = new ImovelNegocios();
                    i = imn.NovoImovel(i);

                    TempData["Mensagem"] = "Imóvel cadastrado com sucesso!";
                    TempData["Resposta"] = "Sucesso";

                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
            }
            return RedirectToAction("NovoImovel", "Imovel");
        }
    }
}