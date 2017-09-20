using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using diagnosticCenterAPP.DAL;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.BLL
{
    public class testTypeNameManager
    {
        testNameGetway aTestNameGetway=new testNameGetway();

        public bool chectExistTestname(string testname)
        {
           return aTestNameGetway.checkTestnameDB(testname);
        }

       
        public int SaveTestName(string testname, int fee, string testType)
        {
           return  aTestNameGetway.saveTestNameDB(testname, fee, testType);
        }

        public List<TestName> showDetailTestName()
        {
            return aTestNameGetway.GetTestNames();
        }

    }
}