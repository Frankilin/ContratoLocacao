using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoLocacao.Entidades
{
    public class Fiador
    {
        public int IdFiador { get; set; }
        public string NomeFiador { get; set; }
        public string RgFiador { get; set; }
        public string CPFfiador { get; set; }
        public string CNPJFiador { get; set; }
        public string CelularFiador { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual List<FiadorContrato> FiadorContrato { get; set; }

    }
}
