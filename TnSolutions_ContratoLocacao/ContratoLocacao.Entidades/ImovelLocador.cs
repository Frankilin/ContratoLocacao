using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class ImovelLocador
    {
        public int IdImovelLocador { get; set; }
        public int IdLocador { get; set; }
        public int IdImovel { get; set; }

        #region Relacionamento
            public virtual Imovel Imovel  { get; set; }
            public virtual Locador Locador { get; set; }
        #endregion
    }
}
