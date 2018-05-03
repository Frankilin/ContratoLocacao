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
                if(L.NomeLocador == null)
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
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
