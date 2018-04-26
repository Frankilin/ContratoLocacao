using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class FiadorContrato
    {
        public int IdFiadorContrato { get; set; }
        public int IdFiador { get; set; }
        public int IdContrato { get; set; }
        public int IdLocatario { get; set; }

        #region Relacionamento
            public virtual Contratos Contratos { get; set; }
            public virtual Fiador Fiador { get; set; }
            public virtual Locatario Locatario { get; set; }
        #endregion
    }
}
