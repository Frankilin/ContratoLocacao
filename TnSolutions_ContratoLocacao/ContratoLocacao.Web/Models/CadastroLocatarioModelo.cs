using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace ContratoLocacao.Web.Models
{
    public class CadastroLocatarioModelo
    {
        //Nome Locatatio
        [Required(ErrorMessage ="Informe o Nome do Locatário")]
        [Display(Name ="Nome Locatário")]
        public string NomeLocatario { get; set; }

        //RG
        [Required(ErrorMessage = "Informe o RG do Locatário")]
        [Display(Name = "RG")]
        public string RgLocatario { get; set; }

        //CPF
        [Required(ErrorMessage = "Informe o CPF do Locatário")]
        [Display(Name = "CPF")]
        public string CPFLocatario { get; set; }

        //CNPJ
        [Required(ErrorMessage = "Informe o CNPJ do Locatário")]
        [Display(Name = "CNPJ")]
        public string CNPJLocatario { get; set; }

        //Endereço
        [Required(ErrorMessage = "Informe o Endereço do Locatário")]
        [Display(Name = "Endereço")]
        public string EnderecoLocatario { get; set; }

        //Celular
        [Required(ErrorMessage = "Informe o Celular do Locatário")]
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public string CelularLocatario { get; set; }

        //Email
        [Required(ErrorMessage = "Informe o E-mail do Locatário")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string EmailLocatario { get; set; }

        ////Garantia
        //[Required(ErrorMessage = "Informe o Endereço do Locatário")]
        //[Display(Name = "Endereço")]
        //public int TipoGarantia { get; set; }
    }
}