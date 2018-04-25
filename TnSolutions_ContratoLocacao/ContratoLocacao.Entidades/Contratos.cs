using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class Contratos
    {
        public int IdContrato { get; set; }
        public float ValorLocacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string ValorIncluidoNoContrato { get; set; }
        public string TipoInclusoContrato { get; set; }//Ex: Incluso - Condominio, água, Luz
        public string DataLimitePagamento { get; set; }
        public string PrazoLocacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string ReajusteACada { get; set; }

        public int IdLocador { get; set; }//Relacionamento com Locador
        
        public int IdImovel { get; set; }//Objeto da locação



        #region Relacionamentos
            public virtual List<LocatarioContrato> LocatarioContrato { get; set; }
            public virtual List<FiadorContrato> FiadorContrato { get; set; }
            public virtual Locador Locador { get; set; }
            public virtual Imovel Imovel { get; set; }
        #endregion
    }
}
