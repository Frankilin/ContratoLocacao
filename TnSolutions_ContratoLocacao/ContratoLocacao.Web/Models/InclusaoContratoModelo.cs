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
        //DropdownList Locador
        [Display(Name = "Locador")]
        public int IdLocador { get; set; }
        public SelectList LocadorSelecionado  { get; set; }

        //DropdownList Locatário
        [Display(Name = "Locatário")]
        public int IdLocatario { get; set; }
        public SelectList LocatarioSelecionado { get; set; }

        
        //DropdownList TipoGarantia
        [Display(Name = "Garantia")]
        public int IdTipoGarantia { get; set; }
        public SelectList TipoGarantiaSelecionado { get; set; }

       
        //DropdownList Fiador
        [Display(Name = "Fiador")]
        public int IdFiador { get; set; }
        public SelectList FiadorSelecionado { get; set; }

        
        
        //DropdownList Imovel
        [Required(ErrorMessage = "Informe o imóvel que irá alugar.")]
        [Display(Name = "Imóvel")]
        public int IdImovel { get; set; }
        public SelectList ImovelSelecionado { get; set; }

        
        /* DADOS DO CONTRATO*/

        //Valor
        [Required(ErrorMessage = "Informe o valor da locação.")]
        [Display(Name = "Valor da Locação")]
        public float ValorLocacao { get; set; }

        //Pagamento
        [Required(ErrorMessage = "Informe o dia do pagamento")]
        [Display(Name = "Pagamento")]
        public string DiaPagamento { get; set; }

        //Prazo Locação
        [Required(ErrorMessage = "Informe o prazo de locação.")]
        [Display(Name = "Prazo de Locação")]
        public string PrazoLocacao { get; set; }


        //Reajuste
        [Required(ErrorMessage = "Informe se haverá reajuste.")]
        [Display(Name = "Reajuste a cada")]
        public string ReajusteACada { get; set; }


        //Data Inicio
        [Required(ErrorMessage = "Informe a data de inicio.")]
        [Display(Name = "Data Inicio")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataInicio { get; set; }

        //Data Fim
        [Required(ErrorMessage = "Informe a data Final.")]
        [Display(Name = "Data Final")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
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