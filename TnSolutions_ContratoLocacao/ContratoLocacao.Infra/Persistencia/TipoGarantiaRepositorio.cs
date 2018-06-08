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
    public class TipoGarantiaRepositorio : OperacoesGenericas<TipoGarantia>
    {
        public List<TipoGarantia> TipoGarantia(int IdGarantia)
        {
            using (Conexao cc = new Conexao())
            {
                return cc.TipoGarantia
                        .Where(tg => tg.IdTipoGarantia == IdGarantia)
                        .ToList();
            }
        }
    }
}
