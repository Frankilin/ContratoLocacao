using System.Collections.Generic;
using System.Linq;
using ContratoLocacao.Infra.DataSource;
using ContratoLocacao.Infra.FuncoesGenericas;
using ContratoLocacao.Entidades;
using System.Data.Entity;


namespace ContratoLocacao.Infra.Persistencia
{
    public class ContratoRepositorio : OperacoesGenericas<Contrato>
    {
        //public List<Contrato> Contrato()
        //{
        //    using (Conexao cc = new Conexao())
        //    {
        //           var Joins = cc.Contrato
        //                    .Join(cc.FiadorContrato, fc => fc.IdContrato, c => c.IdContrato, (fc, c) => new { fc, c })// Join FiadorContrato
        //                    .Join(cc.Fiador, f => f.IdFiador, fc => fc.IdFiador, (f, fc) => new { f, fc })//Join Fiador
        //                    .Join(cc.LocatarioContrato, lc => lc.IdContrato, c => c.IdContrato, (lc, c) => new { lc, c }) //Join com LocatatioContrato
        //                    .Join(cc.Locatario, l => l.IdLocatario, lc => lc.IdLocatario, (l, lc) => new { l, lc })// Join com Locatario
        //                    .Join(cc.Imovel, i => i.IdImovel, c => c.IdImovel, (i, c) => new { i, c })
        //                    .Select(x => new
        //                    {
        //                        NomeImovel      = x.i.NomeImovel,
        //                        NomeLocatario   = x.l.NomeLocatario,
        //                        NomeFiador      = x.f.NomeFiador

        //                    }).AsQueryable();

        //        var resultado = Joins.ToList();

        //        return resultado;
                
        //        /*
        //        JOIN FiadorContrato		FC	ON FC.IdContrato = C.IdContrato
        //        JOIN Fiador				F	ON F.IdFiador = FC.IdFiador

        //        JOIN LocatarioContrato	lc	ON lc.IdContrato = c.IdContrato
        //        JOIN Locatario			L	ON lc.IdLocatario = l.IdLocatario
        //        */
        //    }
        //}
    }
}
