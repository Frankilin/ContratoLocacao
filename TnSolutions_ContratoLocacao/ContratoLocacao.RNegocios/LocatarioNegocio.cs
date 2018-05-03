using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.Persistencia;
using ContratoLocacao.Infra.DataSource;

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
    }
}
