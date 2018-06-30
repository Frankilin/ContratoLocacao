using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;

namespace ContratoLocacao.RNegocios
{
    public class LocatarioContratoNegocio
    {
      
        public LocatarioContrato NovoLocatarioContrato(LocatarioContrato LC)
        {
            try
            {
                LocatarioContratoRepositorio lcr = new LocatarioContratoRepositorio();
                lcr.Insert(LC);
                return LC;
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }


    }
}
