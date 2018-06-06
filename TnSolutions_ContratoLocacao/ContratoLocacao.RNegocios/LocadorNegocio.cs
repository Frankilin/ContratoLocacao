using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;
using System.Web.Mvc;
  

namespace ContratoLocacao.RNegocios
{
    public class LocadorNegocio 
    {
        public Locador NovoLocador(Locador L)
        {
            try
            {
                if (L.NomeLocador == null)
                {
                    throw new Exception("Informe o nome do Locador");
                }
                L.Ativo = true;
                L.DataInclusao = DateTime.Now;
                L.DataAlteracao = null;
                L.Padrao = true;

                LocadorRepositorio lr = new LocadorRepositorio();
                lr.Insert(L);
                return L;


                ImovelLocadorRepositorio ir = new ImovelLocadorRepositorio();

                foreach (ImovelLocador il in L.ImovelLocador)
                {
                    il.IdLocador = L.IdLocador;
                    ir.Insert(il);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<Locador> TodosLocadores()
        {
            try
            {
                LocadorRepositorio lr = new LocadorRepositorio();

                List<Locador> l = lr.Todos();
                if (l == null)
                {
                    throw new Exception("Nenhum Locador Selecionado");
                }
                return l;
            }
            catch (Exception e)
            {

                throw e;
            }
        }




        public SelectList ListaTodosLocadoresDropDownList()
        {
            try
            {
                List<Locador> tmp = this.TodosLocadores();
                var itens = new List<SelectListItem>();

                foreach (Locador l in tmp)
                {
                    itens.Add(new SelectListItem { Value = l.IdLocador.ToString(), Text = l.NomeLocador});
                }

                SelectList sli = new SelectList(itens, "Value", "Text");
                return sli;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
