using OCP.Open_Closed_Prinsiple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Open_Closed_Prinsiple.Good
{
    public interface IReportGenerator
    {
        string GenerateReport(ReportInfo report);
    }
}
