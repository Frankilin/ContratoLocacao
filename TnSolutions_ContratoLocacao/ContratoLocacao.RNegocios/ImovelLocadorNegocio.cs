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
    public class ImovelLocadorNegocio
    {
        public ImovelLocador NovoImovelLocador(ImovelLocador IL)
        {
            try
            {
                ImovelLocadorRepositorio ilr = new ImovelLocadorRepositorio();
                ilr.Insert(IL);
                return IL;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
