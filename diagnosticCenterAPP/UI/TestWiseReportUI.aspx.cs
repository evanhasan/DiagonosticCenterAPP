using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using diagnosticCenterAPP.BLL;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.UI
{
    public partial class TestWiseReportUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            string FromDate = fromDateTB.Text;
            string ToDate = toDateTB.Text;
            DateTime oDate = DateTime.Parse(FromDate);
            DateTime oDate2 = DateTime.Parse(ToDate);
            int Fday = oDate.Day;
            int Fmonth = oDate.Month;
            int Fyear = oDate.Year;
            int Tday = oDate2.Day;
            int Tmonth = oDate2.Month;
            int Tyear = oDate2.Year;

            string Fdate = Fyear + "-" + Fmonth + "-" + Fday;
            string Tdate = Tyear + "-" + Tmonth + "-" + Tday;

            ReportManager aManagera=new ReportManager();
            List<testWReport> alist=aManagera.TestWiseResult(Fdate,Tdate);

            ResultGridView.DataSource = alist;
            ResultGridView.DataBind();


        }
    }
}