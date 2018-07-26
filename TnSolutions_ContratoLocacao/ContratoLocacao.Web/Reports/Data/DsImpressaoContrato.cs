using ContratoLocacao.Entidades;
using ContratoLocacao.Infra.FuncoesGenericas;
using ContratoLocacao.Infra.Persistencia;
using System.Data;
namespace ContratoLocacao.Web.Reports.Data
{


    partial class DsImpressaoContrato 
    {
        public static  DsImpressaoContrato ObterRelatorio()
        {
            var ds = new DsImpressaoContrato();

            ContratoRepositorio cr = new ContratoRepositorio();
            //ds.PR_IMPRESSAO_CONTRATO.NewPR_IMPRESSAO_CONTRATORow();
            //ds.PR_IMPRESSAO_CONTRATO.NomeFiadorColumn.Table.Rows[0].ToString();

            //ds.PR_IMPRESSAO_CONTRATO.NewPR_IMPRESSAO_CONTRATORow(   
            //                               string NomeLocador,
            //                                string CelularLocador,
            //                                string EnderecoLocador,
            //                                string RgLocador,
            //                                string CPFLocador,
            //                                string NomeLocatario, 
            //                                string RgLocatario,
            //                                string NomeLocatario,
            //                                string RgLocatario,
            //                                string EnderecoLocatario,
            //                                string CelularLocatario,
            //                                string CPFLocatario, 
            //                                string Descricao,
            //                                string NomeFiador,
            //                                string RgFiador,
            //                                string CPFfiador,
            //                                string CelularFiador,
            //                                string NomeImovel,
            //                                string Endereco,
            //                                string Complemento,
            //                                string Bairro,
            //                                string Cidade,
            //                                string Estado,
            //                                string FIMQUESEDESTINA,
            //                                decimal ValorLocacao,
            //                                string DataLimitePagamento,
            //                                string PrazoLocacao,
            //                                string ReajustACada
            //                                ));

            return ds;

        }
    }
}
