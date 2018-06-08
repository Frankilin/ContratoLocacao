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
    public class TipoGarantiaNegocio
    {
        public TipoGarantia NovoTipoGarantia(TipoGarantia tg)
        {
            try
            {   
                if (tg.Descricao == null)
                {
                    throw new Exception("Ops! Preencha o campo tipo garantia");
                }
                else
                {
                    TipoGarantiaRepositorio tgr = new TipoGarantiaRepositorio();
                    tgr.Insert(tg);
                    return tg;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<TipoGarantia> TodosTiposGarantia()
        {
            try
            {
                TipoGarantiaRepositorio tgr = new TipoGarantiaRepositorio();

                List<TipoGarantia> tg = tgr.Todos();
                if (tg == null)
                {
                    throw new Exception("Nenhum tipo garantia Selecionado");
                }
                return tg;
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public SelectList ListaTiposGarantiaDropDownList()
        {
            try
            {
                List<TipoGarantia> tmp = this.TodosTiposGarantia();
                var itens = new List<SelectListItem>();

                foreach (TipoGarantia tg in tmp)
                {
                    itens.Add(new SelectListItem { Value = tg.IdTipoGarantia.ToString(), Text = tg.Descricao });
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
