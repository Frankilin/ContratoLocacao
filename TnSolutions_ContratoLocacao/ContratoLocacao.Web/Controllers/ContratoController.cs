﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContratoLocacao.Entidades;
using ContratoLocacao.Entidades.Enum;
using ContratoLocacao.Web.Models;
using ContratoLocacao.RNegocios;
using static ContratoLocacao.Web.Models.InclusaoContratoModelo;

namespace ContratoLocacao.Web.Controllers
{
    public class ContratoController : Controller
    {
        // GET: Contrato
        public ActionResult NovoContrato()
        {
            try
            {
                //Instanciando a camada de negócio para exibir os DropdownList
                LocadorNegocio lng = new LocadorNegocio();
                LocatarioNegocio lctn = new LocatarioNegocio();
                FiadorNegocio fn = new FiadorNegocio();
                ImovelNegocios ine = new ImovelNegocios();
                TipoGarantiaNegocio tgn = new TipoGarantiaNegocio();
                FimQueSeDestina.FimQueSeDestinaImovel fdi = new FimQueSeDestina.FimQueSeDestinaImovel();


                //Criando uma variavel que recebe o modelo
                var modelo = new InclusaoContratoModelo();

                //Exibição do DropDownList Na tela para o usuário
                modelo.LocadorSelecionado = lng.ListaTodosLocadoresDropDownList();
                modelo.LocatarioSelecionado = lctn.ListaTodosLocatariosDropDownList();
                modelo.FiadorSelecionado = fn.ListaTodosFiadorDropDownList();
                modelo.ImovelSelecionado = ine.ListaTodosImoveisDropDownList();
                modelo.TipoGarantiaSelecionado = tgn.ListaTiposGarantiaDropDownList();
                //modelo.UtilizacaoImovel


                //EnumFimQueSeDestina model = new EnumFimQueSeDestina();
                //modelo.CheckBoxItems = new List<EnumFimQueSeDestina>();
                //modelo.CheckBoxItems.Add(new EnumFimQueSeDestina() { FimQueSeDestina = Entidades.Enum.FimQueSeDestina.FimQueSeDestinaImovel.Comercial, IsSelected = false });
                //modelo.CheckBoxItems.Add(new EnumFimQueSeDestina() { FimQueSeDestina = Entidades.Enum.FimQueSeDestina.FimQueSeDestinaImovel.Residencia, IsSelected = false });
                //modelo.CheckBoxItems.Add(new EnumFimQueSeDestina() { FimQueSeDestina = Entidades.Enum.FimQueSeDestina.FimQueSeDestinaImovel.Veraneio, IsSelected = false });


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
        public ActionResult NovoContrato(InclusaoContratoModelo modelo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contrato c = new Contrato();

                    //Vem do contrato 
                    c.ValorIncluidoNoContrato = modelo.ValorLocacao.ToString();
                    c.DataLimitePagamento = modelo.DiaPagamento;
                    c.PrazoLocacao = modelo.PrazoLocacao;
                    c.ReajusteACada = modelo.ReajusteACada;
                    c.DataInicio = modelo.DataInicio;
                    c.DataFim = modelo.DataFim;


                    //Fim a que se destina o imóvel

                    //EnumFimQueSeDestina model = new EnumFimQueSeDestina();
                    //modelo.CheckBoxItems = new List<EnumFimQueSeDestina>();
                    //c.FimQueSeDestinaImovel = model.;

                    //Gravando o valores DropDownList

                    c.IdLocador = modelo.IdLocador;
                    Locatario l = new Locatario();
                    l.IdLocatario = modelo.IdLocatario;

                    ContratoNegocio cn = new ContratoNegocio();
                    c = cn.NovoContrato(c);

                    //LocatarioContratoNegocio lcn = new LocatarioContratoNegocio();
                    //l = lcn.NovoLocatario(l);

                    TempData["Mensagem"] = "Locador cadastrado com sucesso!";
                    TempData["Resposta"] = "Sucesso";
                }
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
            }
            return RedirectToAction("NovoContrato", "Contrato");
        }

    }
}