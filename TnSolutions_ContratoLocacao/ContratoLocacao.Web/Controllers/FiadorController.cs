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
    public class FiadorController : Controller
    {
        // GET: Fiador
        public ActionResult NovoFiador()
        {
            try
            {
                LocadorNegocio ln = new LocadorNegocio();
                var model = new CadastroFiadorModelo();
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
        public ActionResult NovoFiador(CadastroFiadorModelo modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Fiador f = new Fiador();
                    f.NomeFiador = modelo.NomeFiador;
                    f.RgFiador = modelo.RGFiador;
                    f.CPFfiador = modelo.CPFFiador;
                    f.CelularFiador = modelo.CelularFiador;

                    FiadorNegocio fn = new FiadorNegocio();
                    f = fn.NovoFiador(f);

                    TempData["Mensagem"] = "Locatário cadastrado com sucesso!";
                    TempData["Resposta"] = "Sucesso";

                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
            }
            return RedirectToAction("NovoFiador", "Fiador");
        }
    }
}