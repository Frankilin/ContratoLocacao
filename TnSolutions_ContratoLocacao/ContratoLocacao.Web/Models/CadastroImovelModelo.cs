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
        //Nome Imovel 
        [Required(ErrorMessage = "Informe o nome do Imóvel")]
        [Display(Name = "Nome do Imóvel")]
        public string NomeImovel { get; set; }

        //Endereço 
        [Required(ErrorMessage = "Informe o nome endereço do Imóvel")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        //Complemento
        public string Complemento { get; set; }

        //Numero
        [Required(ErrorMessage = "Informe o número do Imóvel")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        //Bairro
        [Required(ErrorMessage = "Informe o Bairro")]
        public string Bairro { get; set; }


        //Estado
        [Required(ErrorMessage = "Informe o Estado")]
        public string Estado { get; set; }

        //Cidade
        [Required(ErrorMessage = "Informe a Cidade")]
        public string Cidade { get; set; }
        
        //CEP
        [DisplayFormat(DataFormatString ="{00.000-000}")]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }
        
    }
}