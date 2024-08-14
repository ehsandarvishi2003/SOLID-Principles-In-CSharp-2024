using OCP.Open_Closed_Prinsiple.CommonTypes;
using OCP.Open_Closed_Prinsiple.Good.TypeHandeler;

namespace OCP.OpenClosePrensiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reportHandler = new ReportGeneratorHandler();

            var excelReport = new ReportInfo("Excel", "Some Excel Data");
            var pdfReport = new ReportInfo("PDF", "Some PDF Data");

            string excelReportPath = reportHandler.HandleReportGeneration(excelReport);
            string pdfReportPath = reportHandler.HandleReportGeneration(pdfReport);

            Console.WriteLine(excelReportPath); // Output: Path_to_Excel_Report.xlsx
            Console.WriteLine(pdfReportPath);   // Output: Path_to_PDF_Report.pdf
        }
    }
}
