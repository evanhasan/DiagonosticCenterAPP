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
    public partial class TestRequestEntryUI : System.Web.UI.Page
    {
       
      
       public int testUniqueID = 0;
         
      protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TestRequestEntryManager aTestRequestEntryManager = new TestRequestEntryManager();
                List<string> NameaList = aTestRequestEntryManager.TestnameList();
                foreach (string test in NameaList)
                {
                    testNameDropDownList.Items.Add(test.ToString());
                }

                addBT.Enabled = false;
                SaveBT.Enabled = false;
                ViewState["sn"] = 0;
               
            }

            
          
        }

        protected void addBT_Click(object sender, EventArgs e)
        {
            //get fee
            string value = testNameDropDownList.Text;
            TestRequestEntryManager aTestRequestEntryManager = new TestRequestEntryManager();

            int fee = aTestRequestEntryManager.GetFee(value);
            feeTB.Text = fee.ToString();
            int i = (int)ViewState["sn"];
            ViewState["sn"] =i+1;
            test_list aTestList = new test_list();
           
            aTestList.id = (int) ViewState["sn"];
            aTestList.testName = testNameDropDownList.Text;
           aTestList.testFee = fee;

          
            
            if (ViewState["testList"] == null)
            {
                List<test_list> atesList = new List<test_list>();
                atesList.Add(aTestList);
                ViewState["testList"] = atesList;
                
                atesList = (List<test_list>)ViewState["testList"];
                ShowGridView.DataSource = atesList;
                ShowGridView.DataBind();              
            }
            else
            {
                List<test_list> atesList = (List<test_list>)ViewState["testList"];
                atesList.Add(aTestList);
                ViewState["testList"] = atesList;
                
                ShowGridView.DataSource = atesList;
                ShowGridView.DataBind();               
            }

            int total = Convert.ToInt32(totalTB.Text);
            int x = total + Convert.ToInt32(feeTB.Text);
            totalTB.Text = x.ToString();
          
        }

        protected void addUserBT_Click(object sender, EventArgs e)
        {
            TestRequestEntryManager aTestRequestEntryManager = new TestRequestEntryManager();
            UserClass aUserClass = new UserClass();
            aUserClass.userName = userNameTB.Text;
            aUserClass.mobileNumber = mobilTB.Text;
            aUserClass.dateOfBirth = dateOfBirthTB.Text;
            aUserClass.address = addressTB.Text;
            bool x = aTestRequestEntryManager.checkuser(aUserClass.mobileNumber);

            if (x == false)
            {
                int affectedRow = aTestRequestEntryManager.UserSave(aUserClass.userName, aUserClass.mobileNumber, aUserClass.dateOfBirth, aUserClass.address);
                if (affectedRow > 0)
                resultLB.Text = affectedRow + "User Added";
                userNameTB.Text = aUserClass.userName;
                userNameTB.Enabled = false;
                mobilTB.Text = aUserClass.mobileNumber;
                mobilTB.Enabled = false;
                dateOfBirthTB.Text = aUserClass.dateOfBirth;
                dateOfBirthTB.Enabled = false;
                addressTB.Text = aUserClass.address;
                addressTB.Enabled = false;
                addUserBT.Enabled = false;
                int userId = aTestRequestEntryManager.UserID(aUserClass.userName, aUserClass.mobileNumber);
                ViewState["userID"] = userId;
                testUniqueID = aTestRequestEntryManager.SaveUserIDOthertable(userId);
                ViewState["testUniqueID"] = testUniqueID;

                addBT.Enabled = true;
                SaveBT.Enabled = true;
            }
            else
            {
                resultLB.Text = "Exist";
            }
           
        }


        protected void SaveBT_Click(object sender, EventArgs e)
        {
           
            //make list
            List<test_list> atesList = (List<test_list>)ViewState["testList"];
            PatiencTestManager aPatiencTestManager=new PatiencTestManager();
            testUniqueID =(int)ViewState["testUniqueID"];

            foreach (var test in atesList)
            {
                string result = aPatiencTestManager.PatiencTestSave(test.testName, test.testFee, testUniqueID);
                
            }
            //save total amount
            TestRequestEntryManager aTestRequestEntryManager = new TestRequestEntryManager();
            aTestRequestEntryManager.SaveTotal(testUniqueID, Convert.ToInt32(totalTB.Text));

            ShowGridView.DataSource = "";
            ShowGridView.DataBind();
            TestIdLB.Text = "Your Bill ID is : "+testUniqueID.ToString()+"<br/> And User ID is: "+ (int)ViewState["userID"];
            addBT.Enabled = false;
            SaveBT.Enabled = false;

        }

      
    }
}