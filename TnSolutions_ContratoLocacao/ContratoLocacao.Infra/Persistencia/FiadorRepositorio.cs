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
    public class FiadorRepositorio : OperacoesGenericas<Fiador>
    {
        public Fiador Fiador(int IdFiador)
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Fiador
                        .Where(f => f.IdFiador == IdFiador)
                        .FirstOrDefault();
            }
        }
    }
}
