using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContratoLocacao.Web.Models
{
    public class ListaContratoModelo
    {
        public int Codigo { get; set; }

        [Display(Name = "Imóvel")]
        public string Imovel { get; set; }

        [Display(Name = "Locatário")]
        public string Locatario { get; set; }

    
        public string Fiador { get; set; }

        [Display(Name = "Valor da locação")]
        public decimal ValorLocacao { get; set; }

        [Display(Name = "Prazo Locação")]
        public string PeriodoLocacao { get; set; }

        [Display(Name = "Data Início")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data Fim")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataFim { get; set; }

    }
}