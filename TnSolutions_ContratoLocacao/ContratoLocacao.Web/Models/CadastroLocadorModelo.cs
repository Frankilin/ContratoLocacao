using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ContratoLocacao.Entidades;

namespace ContratoLocacao.Web.Models
{
    public class CadastroLocadorModelo
    {
        //Nome Locador
        [Required(ErrorMessage = "Informe o Nome do Locador")]
        [Display(Name = "Nome Locador")]
        public string NomeLocador { get; set; }
        
        //RG
        [Required(ErrorMessage = "Informe o RG do Locador")]
        [Display(Name = "RG")]
        public string RgLocador { get; set; }

        //CPF
        [Required(ErrorMessage = "Informe o CPF do Locador")]
        [Display(Name = "CPF")]
        public string CPFLocador { get; set; }

        ////CNPJ
        //[Required(ErrorMessage = "Informe o CNPJ do Locador")]
        //[Display(Name = "CNPJ")]
        //public string CNPJLocador { get; set; }

        //Endereço
        [Required(ErrorMessage = "Informe o Endereço do Locador")]
        [Display(Name = "Endereço")]
        public string EnderecoLocador { get; set; }

        //Fixo
        [Required(ErrorMessage = "Informe o Telefone do Locador")]
        [Display(Name = "Telefone Fixo")]
        public string TelFixoLocador { get; set; }

        //Celular
        [Required(ErrorMessage = "Informe o Celular do Locador")]
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public string CelularLocador { get; set; }

        //Imovel
        [Required(ErrorMessage = "Informe o imóvel que pertence ao locador.")]
        [Display(Name = "Imóvel")]
        public int IdImovel { get; set; }
        public SelectList ImovelSelecionado { get; set; }
    }
}