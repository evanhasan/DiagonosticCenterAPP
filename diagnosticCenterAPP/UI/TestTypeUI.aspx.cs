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
    public partial class TestTypeUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestManager aManager = new TestManager();
            List<testType> aList = aManager.ShowList();
            ShoeAllGridView.DataSource = aList;
            ShoeAllGridView.DataBind();
        }

        protected void SaveTestTypeBT_Click(object sender, EventArgs e)
        {
            testType aTestType = new testType();
            aTestType.tesType = testTypeNameTB.Text;
            TestManager aTestManager = new TestManager();

            if (aTestType.tesType != "")
            {
                bool test = aTestManager.isTestExist(aTestType.tesType);
                if (test == false)
                {
                    int x = aTestManager.save(aTestType.tesType);
                    showMessageLB.Text = x + " Row Affected";

                    TestManager aManager = new TestManager();
                    List<testType> aList = aManager.ShowList();
                    ShoeAllGridView.DataSource = aList;
                    ShoeAllGridView.DataBind();


                }
                else
                {
                    showMessageLB.Text = "Data Exists";
                }
            }
            else
            {
                showMessageLB.Text = "It's Blank";
            }

        }
    }
}