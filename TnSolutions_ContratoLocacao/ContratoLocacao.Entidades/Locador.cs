using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class Locador
    {
        public int IdLocador { get; set; }
        public string NomeLocador { get; set; }
        public string RgLocador { get; set; }
        public string CPFLocador { get; set; }
        public string CNPJLocador { get; set; }
        public string EnderecoLocador { get; set; }
        public string TelFixoLocador { get; set; }
        public string CelularLocador { get; set; }
        public Boolean Padrao { get; set; }//Se for Padrão, ele sempre pega ele.
        public Boolean Ativo { get; set; }

        public DateTime DataInclusao { get; set; }
        public Nullable<DateTime> DataAlteracao { get; set; }

        //public int IdLocadorContrato { get; set; }

        #region Relacionamento
            public virtual List<Contrato> Contratos { get; set; }
             
            public virtual List<ImovelLocador> ImovelLocador { get; set; }
        #endregion
    }
}
