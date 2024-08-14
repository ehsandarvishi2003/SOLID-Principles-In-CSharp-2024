using OCP.Open_Closed_Prinsiple.Bad;
using OCP.Open_Closed_Prinsiple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Open_Closed_Prinsiple.Good.TypeHandeler
{
    // Handler for selecting the appropriate Report Generation Helper
    public class ReportGeneratorHandler
    {
        private readonly Dictionary<string, IReportGenerator> reportHelpers;

        public ReportGeneratorHandler()
        {
            // Initialize the dictionary with different report generation helpers
            reportHelpers = new Dictionary<string, IReportGenerator> //IReportGenerator get Report type and data of Report
            {
                { "Excel", new ExcelReportGenerationHelper() },
                { "PDF", new PdfReportGenerationHelper() },
                { "Word",new WordReportGenerationHelper() },
                { "XML", new XmlReportGenerationHelper()}
                //Dictionary <TKey,TValue> 
            };
        }

        public string HandleReportGeneration(ReportInfo report)
        {
            //The out keyword means that if the TryGetValue method succeeds in finding the value for the key, 
            //this value will be stored in the helper variable.

            if (reportHelpers.TryGetValue(report.ReportType, out var helper))
            {
                return helper.GenerateReport(report);
            }
            else
            {
                throw new NotSupportedException($"Unsupported report type: {report.ReportType}");
            }
        }
    }
}
