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
    public class LocatarioController : Controller
    {
        // GET: Locatario
        public ActionResult NovoLocatario()
        {
            try
            {
                LocatarioNegocio In = new LocatarioNegocio();

                var model = new CadastroLocatarioModelo();

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
        public ActionResult NovoLocatario(CadastroLocatarioModelo modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Locatario l = new Locatario();

                    l.NomeLocatario = modelo.NomeLocatario;
                    l.RgLocatario = modelo.RgLocatario;
                    l.CPFLocatario = modelo.CPFLocatario;
                    l.CNPJLocatario = modelo.CNPJLocatario;
                    l.EnderecoLocatario = modelo.EnderecoLocatario;
                    l.CelularLocatario = modelo.CelularLocatario;
                    l.EmailLocatario = modelo.EmailLocatario;

                    LocatarioNegocio ln = new LocatarioNegocio();
                    l =  ln.NovoLocatario(l);

                    TempData["Mensagem"] = "Locatário cadastrado com sucesso!";
                    TempData["Resposta"] = "Sucesso";
                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
            }
            return RedirectToAction("NovoLocatario", "Locatario");
        }
    }
}