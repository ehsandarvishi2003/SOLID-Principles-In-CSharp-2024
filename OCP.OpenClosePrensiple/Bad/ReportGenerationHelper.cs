using OCP.Open_Closed_Prinsiple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Open_Closed_Prinsiple.Bad
{
    public class ReportGenerationHelper
    {
        public string GenerateReport(ReportInfo report)
        {
            string generatedPath = string.Empty;

            if (report.ReportType == "EXCEL")
            {
                // Logic to generate Excel file
                // ....  
                generatedPath = @"%appdata%\Info\Report.xls";
            }
            else if (report.ReportType == "PDF")
            {
                // Logic to generate PDF file
                // ....  
                generatedPath = @"%appdata%\Info\Report.pdf";
            }
            else if (report.ReportType == "WORD")
            {
                // Logic to generate WORD file
                // ....  
                generatedPath = @"%appdata%\Info\Report.docx";
            }

            else if (report.ReportType == "XML")
            {
                // What if I want to add generation in XML???
                // ...
                generatedPath = @"%appdata%\Info\Report.mxl";
            }

            return generatedPath;
        }
    }
}
