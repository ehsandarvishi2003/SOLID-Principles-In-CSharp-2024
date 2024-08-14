using OCP.Open_Closed_Prinsiple.CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Open_Closed_Prinsiple.CommonTypes
{
    public class ReportInfo
    {
        public ReportInfo(string reportType, string data)
        {
            ReportType = reportType;
            Data = data;
        }
        public string ReportType { get; set; }

        public string Data { get; set; }
    }
}
