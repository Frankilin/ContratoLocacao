using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class LocatarioContrato
    {
        public int IdLocatarioContrato { get; set; }
        public int IdLocatario { get; set; }
        public int IdContrato { get; set; }//Chave estrangeira do contrato
        
        #region Relacionamentos
        public virtual Contratos Contratos { get; set; }
        public virtual Locatario Locatario { get; set; }
        #endregion
    }
}
