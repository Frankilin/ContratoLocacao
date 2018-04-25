using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class Imovel
    {
        public int IdImovel { get; set; }
        public string NomeImovel { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        //public int TipoDoImovel { get; set; }//Casa,Apartamento
        // public string FimQueSeDestina { get; set; }//Ex: Residência, Veraneio
        public Boolean Ativo { get; set; }

        #region Relacionamento
        public virtual List<Contratos> Contratos { get; set; }
        #endregion
    }
}
