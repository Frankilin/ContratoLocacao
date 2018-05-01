using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class Locatario
    {
        public int IdLocatario { get; set; }
        public string NomeLocatario { get; set; }
        public string RgLocatario { get; set; }
        public string CPFLocatario { get; set; }
        public string CNPJLocatario { get; set; }
        public string EnderecoLocatario { get; set; }
        public string CelularLocatario { get; set; }
        public Boolean Ativo { get; set; }
        public string EmailLocatario { get; set; }
        
        public DateTime DataInclusao { get; set; }
        public Nullable<DateTime>DataAlteracao { get; set; }
        

        #region Relacionamento
            public virtual List<FiadorContrato> FiadorContrato { get; set; }
            public virtual List<LocatarioContrato> LocatarioContrato { get; set; }
        #endregion
    }
}
