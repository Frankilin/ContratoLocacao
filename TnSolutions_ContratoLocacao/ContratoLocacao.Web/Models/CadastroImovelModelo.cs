using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ContratoLocacao.Web.Models
{
    public class CadastroImovelModelo
    {
        [Required(ErrorMessage = "Informe o nome do Imóvel")]
        [Display(Name = "Nome do Imóvel")]
        public string NomeImovel { get; set; }


        [Required(ErrorMessage = "Informe o nome endereço do Imóvel")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }


        public string Complemento { get; set; }


        [Required(ErrorMessage = "Informe o número do Imóvel")]
        [Display(Name = "Número")]
        public string Numero { get; set; }


        [Required(ErrorMessage = "Informe o Bairro")]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Informe o Estado")]
        public string Estado { get; set; }


        [Required(ErrorMessage = "Informe a Cidade")]
        public string Cidade { get; set; }


        [DisplayFormat(DataFormatString ="{00.000-000}")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        public Boolean Ativo { get; set; }
    }
}