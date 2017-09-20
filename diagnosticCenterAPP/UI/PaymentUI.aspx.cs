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
    public partial class PaymentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int BillNo = Convert.ToInt32(billNoTB.Text);
            ViewState["billNo"] = BillNo;

            PatiencTestManager aPatiencTestManager = new PatiencTestManager();
            List<IndividualTestList> aTestLists = aPatiencTestManager.ShowIndividualTestLists(BillNo);
            testListGridView.DataSource = aTestLists;
            testListGridView.DataBind();

            payment payList = aPatiencTestManager.PayDetail(BillNo);

            billDateTB.Text = payList.billDate;
            totalTB.Text = (payList.total).ToString();
            dueAmountTB.Text = (payList.total - payList.paid).ToString();
            paidAmountTB.Text = payList.paid.ToString();

        }

        protected void payBT_Click(object sender, EventArgs e)
        {
            int payment=Convert.ToInt32(paymentTB.Text);
            int BillNo = (int)ViewState["billNo"];
            PatiencTestManager aPatiencTestManager = new PatiencTestManager();

            int temp = Convert.ToInt32(paidAmountTB.Text) + payment;
            aPatiencTestManager.UpdateTotal(BillNo,temp);
           

            payment payList = aPatiencTestManager.PayDetail(BillNo);

            billDateTB.Text = payList.billDate;
            totalTB.Text = (payList.total).ToString();
            dueAmountTB.Text = (payList.total - payList.paid).ToString();
            paidAmountTB.Text = payList.paid.ToString();

        }
    }
}