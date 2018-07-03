using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.FuncoesGenericas;
using System.Data;
namespace ContratoLocacao.Web.Reports.Data
{


    partial class DsImpressaoContrato
    {
        public static  DsImpressaoContrato ObterRelatorio()
        {
            var ds = new DsImpressaoContrato();

            ds.PR_IMPRESSAO_CONTRATO.NomeLocadorColumn.ToString();


            return ds;

        }
    }
}
