using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class Locatario
    {
        public int IdLocatario { get; set; }
        public string NomeLocatario { get; set; }
        public string RgLocatario { get; set; }
        public string CPFLocatario { get; set; }
        public string CNPJLocatario { get; set; }
        public string EnderecoLocatario { get; set; }
        public string CelularLocatario { get; set; }
        public Boolean Ativo { get; set; }
        public int TipoGarantia { get; set; }//Fiador/Calção/Seguro de fiança locativa.

        #region Relacionamento
        public virtual List<FiadorContrato> FiadorContrato { get; set; }
        #endregion
    }
}
