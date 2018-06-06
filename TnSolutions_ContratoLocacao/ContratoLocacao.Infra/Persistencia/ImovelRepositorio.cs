using System.Collections.Generic;
using System.Linq;
using ContratoLocacao.Infra.DataSource;
using ContratoLocacao.Infra.FuncoesGenericas;
using ContratoLocacao.Entidades;

namespace ContratoLocacao.Infra.Persistencia
{
    public class ImovelRepositorio : OperacoesGenericas<Imovel>
    {
        public List<Imovel> ImovelLocador(int IdImovel)
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Imovel
                        .Where(i => i.IdImovel == IdImovel)
                        .ToList();
            }
        }


        public override List<Imovel> Todos()
        {
            using (Conexao cc = new Conexao())
            {
                return cc.Imovel
                    .OrderBy(i => i.NomeImovel)
                    .ToList();
            }
        }

    }
}
