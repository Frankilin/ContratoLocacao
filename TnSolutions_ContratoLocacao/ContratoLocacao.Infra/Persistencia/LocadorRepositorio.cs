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
    public class LocadorRepositorio : OperacoesGenericas<Locador>
    {
        public override List<Locador> Todos()
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Locador
                    .OrderBy(l => l.NomeLocador)
                    .ToList();
            }
        }
    }
}
