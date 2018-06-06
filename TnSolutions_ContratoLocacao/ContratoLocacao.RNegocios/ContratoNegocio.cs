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
    public class ContratoNegocio
    {
        public Contrato NovoContrato(Contrato C)
        {
            try
            {
                ContratoRepositorio cr = new ContratoRepositorio();

                C.DataCadastro = DateTime.Now;

                cr.Insert(C);
                return C;
            }
            catch (Exception e)
            {

                throw e;
            }
        }



        public List<Contrato> TodosContratos()
        {
            try
            {
                ContratoRepositorio cr = new ContratoRepositorio();

                List<Contrato>c  = cr.Todos();
                if (c == null)
                {
                    throw new Exception("Nenhum contrato Selecionado");
                }
                return c;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
