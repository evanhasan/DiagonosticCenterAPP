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
    public partial class TestNameSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                testTypeDropDownList.Items.Clear();
                TestManager aManager = new TestManager();
                List<testType> aList = aManager.ShowList();
                foreach (var testType in aList)
                {
                    testTypeDropDownList.Items.Add(testType.tesType.ToString());
                }  
            }
            

            testTypeNameManager aTestTypeNameManager = new testTypeNameManager();
            List<TestName> NameaList = aTestTypeNameManager.showDetailTestName();
            testNameGridView.DataSource = NameaList;
            testNameGridView.DataBind();

        }

        protected void testNameSaveBT_Click(object sender, EventArgs e)
        {
            TestName aTestName = new TestName();
            testTypeNameManager aTestTypeNameManager = new testTypeNameManager();

          

            if (testNameTB.Text != "" && Convert.ToInt32(feeTestTB.Text) > 0)
            {
                aTestName.testName = testNameTB.Text;
                aTestName.fee = Convert.ToInt32(feeTestTB.Text);
                aTestName.testType = testTypeDropDownList.Text;

                bool x = aTestTypeNameManager.chectExistTestname(aTestName.testName);

                if (x != true)
                {
                    int rowAffected = aTestTypeNameManager.SaveTestName(aTestName.testName, aTestName.fee, aTestName.testType);
                    if (rowAffected > 0)
                    {
                        showMessageLB.Text = rowAffected + " is Affected";
                        Response.Redirect("TestNameSetup.aspx");
                    }
                }
                else
                {
                    showMessageLB.Text = "exist";
                }

            }
            else
            {
                showMessageLB.Text = "Some Field Empty";
            }

        }


    }
}