using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;
using ContratoLocacao.Infra.DataSource;
using System.Web.Mvc;

namespace ContratoLocacao.RNegocios
{
    public class LocatarioNegocio
    {
        public Locatario NovoLocatario(Locatario L)
        {
            try
            {
                //Verifica se o locatario está em branco
                if(L.NomeLocatario == null)
                {
                    throw new Exception("Ops! Preencha o campo Nome Locatário");
                } else
                {
                    LocatarioRepositorio lr = new LocatarioRepositorio();
                    L.Ativo = true;
                    L.DataInclusao = DateTime.Now;
                    L.DataAlteracao = null;
                    L.CNPJLocatario = null;

                    lr.Insert(L);
                    return L;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public List<Locatario> TodosLocatarios()
        {
            try
            {
                LocatarioRepositorio lr = new LocatarioRepositorio();

                List<Locatario> l = lr.Todos();
                if (l == null)
                {
                    throw new Exception("Nenhum Locatário Selecionado");
                }
                return l;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        

        public SelectList ListaTodosLocatariosDropDownList()
        {
            try
            {
                List<Locatario> tmp = this.TodosLocatarios();
                var itens = new List<SelectListItem>();

                foreach (Locatario l in tmp)
                {
                    itens.Add(new SelectListItem { Value = l.IdLocatario.ToString(), Text = l.NomeLocatario });
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
