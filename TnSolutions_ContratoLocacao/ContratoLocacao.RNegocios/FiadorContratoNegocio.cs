using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.RNegocios
{
    public class FiadorContratoNegocio
    {
        public FiadorContrato NovoFiadorContratoNegocio(FiadorContrato FC)
        {
            try
            {
                FiadorContratoRepositorio fcr = new FiadorContratoRepositorio();
                fcr.Insert(FC);
                return FC;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
