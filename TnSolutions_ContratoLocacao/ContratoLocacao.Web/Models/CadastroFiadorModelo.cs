using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ContratoLocacao.Entidades;

namespace ContratoLocacao.Web.Models
{
    public class CadastroFiadorModelo
    {
        //Nome Fiador
        [Required(ErrorMessage = "Informe o Nome do Fiador")]
        [Display(Name = "Nome Fiador")]
        public string NomeFiador { get; set; }

        //RG
        [Required(ErrorMessage ="Informe o RG do Fiador")]
        [Display(Name = "RG")]
        public string RGFiador { get; set; }

        //CPF
        [Required(ErrorMessage = "Informe o CPF do Fiador")]
        [Display(Name = "CPF")]
        public string CPFFiador { get; set; }

        //Celular
        [Required(ErrorMessage = "Informe o Celular do Fiador")]
        [Display(Name = "Celular")]
        public string CelularFiador { get; set; }

    }
}