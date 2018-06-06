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
    public class ImovelLocadorRepositorio : OperacoesGenericas<ImovelLocador>
    {
        public ImovelLocador ImovelLocador(int IdImovel)
        {
            using (Conexao cc = new Conexao())
            {
                return cc.ImovelLocador
                        .Where(il => il.IdImovel == IdImovel)
                        .FirstOrDefault();
            }
        }


        public override List<ImovelLocador> Todos()
        {
            using (Conexao cc = new Conexao())
            {
                return cc.ImovelLocador
                    .ToList();
            }
        }
    }
}
