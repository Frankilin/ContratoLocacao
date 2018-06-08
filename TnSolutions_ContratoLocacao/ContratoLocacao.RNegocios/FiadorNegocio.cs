using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Infra.Persistencia;
using ContratoLocacao.Entidades;
using System.Web.Mvc;

namespace ContratoLocacao.RNegocios
{
    public class FiadorNegocio
    {
        public Fiador NovoFiador(Fiador F)
        {
            try
            {
                FiadorRepositorio fr = new FiadorRepositorio();

                F.DataCadastro = DateTime.Now;

                fr.Insert(F);
                return F;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Fiador> TodosFiadores()
        {
            try
            {
                FiadorRepositorio fr = new FiadorRepositorio();
                List<Fiador> f =  fr.Todos();

                if(f == null)
                {
                    throw new Exception("Nenhum fiador selecionado");
                }
                return f;
            }
            catch (Exception e)
            {

                throw e;
            }
        }



        public SelectList ListaTodosFiadorDropDownList()
        {
            try
            {
                List<Fiador> tmp = this.TodosFiadores();
                var itens = new List<SelectListItem>();

                foreach (Fiador f in tmp)
                {
                    itens.Add(new SelectListItem { Value = f.IdFiador.ToString(), Text = f.NomeFiador });
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
