using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class TipoGarantia
    {
        public int IdTipoGarantia { get; set; }
        public string Descricao { get; set; }

        #region Relacionamento
            public virtual List<Contratos> Contrato { get; set; }
        #endregion
    }
}
