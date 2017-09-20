using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using diagnosticCenterAPP.DAL;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.BLL
{
    public class ReportManager
    {
        public List<testWReport> TestWiseResult(string F, string T)
        {
            ReportGetWay aReportGetWay=new ReportGetWay();

            return aReportGetWay.TestWiseResultDB(F, T);

        } 

    }
}