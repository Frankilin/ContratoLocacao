using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContratoLocacao.Entidades;
using ContratoLocacao.Entidades.Enum;
using ContratoLocacao.Web.Models;
using ContratoLocacao.RNegocios;
using static ContratoLocacao.Web.Models.InclusaoContratoModelo;
using static ContratoLocacao.Entidades.Enum.FimQueSeDestina;

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
                    
                    //Instancia um novo contrato
                    Contrato c = new Contrato();

                    //Valor do contrato 
                    c.ValorLocacao = modelo.ValorLocacao;
                    
                    //Data limite de pagamento 
                    c.DataLimitePagamento = modelo.DiaPagamento;
                    
                    //Prazo da locação
                    c.PrazoLocacao = modelo.PrazoLocacao;

                    //Data inicio
                    c.DataInicio = modelo.DataInicio;

                    //Data Fim
                    c.DataFim = modelo.DataFim;

                    //Reajuste
                    c.ReajusteACada = modelo.ReajusteACada;
                     
                    //Locador
                    c.IdLocador = modelo.IdLocador;

                    //Imóvel
                    c.IdImovel = modelo.IdImovel;
                    
                    //Instanciando Tipo Garantia
                    c.IdTipoGarantia = modelo.IdTipoGarantia;

                    //Fim a que se destina o imóvel
                    c.FimQueSeDestinaImovel = modelo.UtilizacaoImovel;

                    //Gravalção na tabela contrato
                    ContratoNegocio cn = new ContratoNegocio();
                    c = cn.NovoContrato(c);


                    //Gravando na tabela Locatario contrato
                    LocatarioContrato loc = new LocatarioContrato();
                    LocatarioContratoNegocio lcn = new LocatarioContratoNegocio();
                    loc.IdLocatario = modelo.IdLocatario;
                    loc.IdContrato = c.IdContrato;
                    loc = lcn.NovoLocatarioContrato(loc);

                    //Gravando na tabela Fiador contrato
                    FiadorContrato fc = new FiadorContrato();
                    FiadorContratoNegocio fcn = new FiadorContratoNegocio();
                    fc.IdFiador = modelo.IdFiador;
                    fc.IdContrato = c.IdContrato;
                    fc.IdLocatario = modelo.IdLocatario;
                    fc = fcn.NovoFiadorContratoNegocio(fc);


                    //EnumFimQueSeDestina model = new EnumFimQueSeDestina();
                    //modelo.CheckBoxItems = new List<EnumFimQueSeDestina>();
                    //c.FimQueSeDestinaImovel = model.;
                    //LocatarioContratoNegocio lcn = new LocatarioContratoNegocio();
                    //l = lcn.NovoLocatario(l);

                    TempData["Mensagem"] = "Contrato cadastrado com sucesso!";
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




        public ActionResult ListaContratos()
        {
            List<ListaContratoModelo> lista = new List<ListaContratoModelo>();

            try
            {
                ContratoNegocio cn = new ContratoNegocio();
                List<Contrato> c = cn.TodosContratos();
                foreach (Contrato co in c)
                {
                    ListaContratoModelo lcm = new ListaContratoModelo();
                    Imovel i = new Imovel();
                    Locatario l = new Locatario();
                    Fiador f = new Fiador();

                    lcm.Codigo = co.IdContrato;
                    lcm.Imovel = i.NomeImovel;
                    lcm.Locatario = l.NomeLocatario;
                    lcm.Fiador = f.NomeFiador;
                    lcm.ValorLocacao = co.ValorLocacao;
                    lcm.PeriodoLocacao = co.PrazoLocacao;
                    lcm.DataInicio = co.DataInicio;
                    lcm.DataFim = co.DataFim;

                    lista.Add(lcm);
                }

             
                return View(lista);
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = "Erro: " + e.Message;
                TempData["Resposta"] = "Falha";
                return RedirectToAction("Novo", "Home");
            }
        }

    }
}