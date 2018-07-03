using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;



namespace ContratoLocacao.Web.Controllers
{
    public class RPTContratoController : Controller
    {
        // GET: RPTContrato
        public ActionResult ImpressaoContrato()
        {
            var ds = Reports.Data.DsImpressaoContrato.ObterRelatorio();


            var viewer = new Microsoft.Reporting.WebForms.ReportViewer();
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\Rpt\Rpt_ImpressaoContrato.rdlc";
            viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("dsDetalhe1", (System.Data.DataTable) ds.PR_IMPRESSAO_CONTRATO));

            viewer.SizeToReportContent = true;
            viewer.Width = System.Web.UI.WebControls.Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;
            return View();
        }
    }
}