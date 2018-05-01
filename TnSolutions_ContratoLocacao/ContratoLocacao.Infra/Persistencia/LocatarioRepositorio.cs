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
    public class LocatarioRepositorio : OperacoesGenericas<Locatario>
    {

        public List<Locatario> Locatario(int IdLocatario)
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Locatario
                        .Where(l => l.IdLocatario == IdLocatario)
                        .ToList();
            }
        }

        public override List<Locatario> Todos()
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Locatario
                    .OrderBy(l => l.NomeLocatario)
                    .ToList();
            }
        }
    }
}
