using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ContratoLocacao.Entidades.Enum;

namespace ContratoLocacao.Web.Models
{
    public class InclusaoContratoModelo
    {
        //Locador
        [Display(Name = "Locador")]
        public int IdLocador { get; set; }
        public SelectList LocadorSelecionado  { get; set; }
        
        //Locatário
        [Display(Name = "Locatário")]
        public int IdLocatario { get; set; }
        public SelectList LocatarioSelecionado { get; set; }
        
        //Fiador
        [Display(Name = "Fiador")]
        public int IdFiador { get; set; }
        public SelectList FiadorSelecionado { get; set; }
        
        //Imovel
        [Required(ErrorMessage = "Informe o imóvel que irá locar.")]
        [Display(Name = "Imóvel")]
        public int IdImovel { get; set; }
        public SelectList ImovelSelecionado { get; set; }

        //Valor
        [Required(ErrorMessage = "Informe o valor da locação.")]
        [Display(Name = "Valor da Locação")]
        public float ValorLocacao { get; set; }

        //Pagamento
        [Required(ErrorMessage = "Informe o dia do pagamento")]
        [Display(Name = "Pagamento")]
        public int DiaPagamento { get; set; }

        //Prazo Locação
        [Required(ErrorMessage = "Informe o prazo de locação.")]
        [Display(Name = "Prazo de Locação")]
        public int PrazoLocacao { get; set; }


        //Reajuste
        [Required(ErrorMessage = "Informe se haverá reajuste.")]
        [Display(Name = "Reajuste a cada")]
        public int ReajusteACada { get; set; }


        //Data Inicio
        [Required(ErrorMessage = "Informe a data de inicio.")]
        [Display(Name = "Data Inicio")]
        public DateTime DataInicio { get; set; }

        //Data Fim
        [Required(ErrorMessage = "Informe a data Final.")]
        [Display(Name = "Data Final")]
        public DateTime DataFim { get; set; }


        public class EnumFimQueSeDestina
        {
            public FimQueSeDestina.FimQueSeDestinaImovel FimQueSeDestina { get; set; }
            public bool IsSelected { get; set; }
        }


        //Fim que se destina
        public List<EnumFimQueSeDestina> CheckBoxItems { get; set; }
    }   
}