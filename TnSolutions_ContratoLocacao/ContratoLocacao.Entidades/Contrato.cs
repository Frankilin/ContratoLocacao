using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Html;
using ContratoLocacao.Entidades.Enum;

namespace ContratoLocacao.Entidades
{
    public class Contrato
    {
        public int IdContrato { get; set; }

        public decimal ValorLocacao { get; set; }

        public DateTime DataCadastro { get; set; }

        public string DataLimitePagamento { get; set; }

        public string PrazoLocacao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public string ReajusteACada { get; set; }

        public int IdTipoGarantia { get; set; }//Fiador/Calção/Seguro de fiança locativa.

        //public InclusoNoContrato.tipoInclusoContrato  InclusoNoContrato { get; set; }
        public FimQueSeDestina.FimQueSeDestinaImovel FimQueSeDestinaImovel { get; set; }

        public int IdLocador { get; set; }//Relacionamento com Locador
        
        public int IdImovel { get; set; }



        #region Relacionamentos
            public virtual List<LocatarioContrato> LocatarioContrato { get; set; }
            public virtual List<FiadorContrato> FiadorContrato { get; set; }
            public virtual Locador Locador { get; set; }
            public virtual Imovel Imovel { get; set; }
            public virtual TipoGarantia TipoGarantia { get; set; }
        #endregion
    }
}
