using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Infra.DataSource;
using ContratoLocacao.Infra.FuncoesGenericas;
using ContratoLocacao.Entidades;

namespace ContratoLocacao.Infra.Persistencia
{
    public class ContratoRepositorio : OperacoesGenericas<Contrato>
    {
        public Contrato Contrato(int idContrato)
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Contratos
                       .Where(c => c.IdContrato == idContrato)
                       .FirstOrDefault();
            }
        }
    }
}
