using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using diagnosticCenterAPP.DAL;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.BLL
{
    public class TestManager
    {
        testGetWay aTestGetWay=new testGetWay();

        public bool isTestExist(string testType)
        {
           
           bool test = aTestGetWay.existCheck(testType);

            return test;
        }

        public int save(string test)
        {
          int x=  aTestGetWay.saveData(test);
            return x;

        }

        public List<testType> ShowList()
        {
           return  aTestGetWay.GetAllList();

        }

       
    }
}