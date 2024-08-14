using OCP.Open_Closed_Prinsiple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Open_Closed_Prinsiple.Good
{
    public class XmlReportGenerationHelper : IReportGenerator
    {
        public string GenerateReport(ReportInfo report)
        {
            string generatedPath = string.Empty;

            // Logic to generate XML file
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.xml";

            return generatedPath;
        }
    }
}
