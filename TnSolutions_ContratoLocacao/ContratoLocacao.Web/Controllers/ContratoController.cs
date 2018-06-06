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
    public class ContratoController : Controller
    {
        // GET: Contrato
        public ActionResult NovoContrato()
        {
            try
            {
                LocadorNegocio lng = new LocadorNegocio();
                LocatarioNegocio lctn = new LocatarioNegocio(); 
                var modelo = new InclusaoContratoModelo();

                modelo.LocadorSelecionado = lng.ListaTodosLocadoresDropDownList();
                modelo.LocatarioSelecionado = lctn.ListaTodosLocatariosDropDownList();
                
                return View(modelo);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}