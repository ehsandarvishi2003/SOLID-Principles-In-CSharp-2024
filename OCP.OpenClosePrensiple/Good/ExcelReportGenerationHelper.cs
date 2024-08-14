using OCP.Open_Closed_Prinsiple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Open_Closed_Prinsiple.Good
{
    public class ExcelReportGenerationHelper:IReportGenerator
    {
        public string GenerateReport(ReportInfo report)
        {
            string generatedPath = string.Empty;

            // Logic to generate Excel file
            // ....
            // ....
            generatedPath = @"%appdata%\Info\Report.xlsx";
            return generatedPath;
        }
    }
}
