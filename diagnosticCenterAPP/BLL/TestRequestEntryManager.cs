using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using diagnosticCenterAPP.DAL;

namespace diagnosticCenterAPP.BLL
{
    public class TestRequestEntryManager
    {
        TestRequestEntryGetWay aTestRequestEntryGetWay=new TestRequestEntryGetWay();
        public List<string> TestnameList()
        {
            return aTestRequestEntryGetWay.GetTestNameList();
        }

        public int UserSave(string name, string mobile, string dateofbirth, string address)
        {
            int x = aTestRequestEntryGetWay.SaveuserDB(name, mobile, dateofbirth, address);
            return x;
        }

        public int GetFee(string name)
        {
            TestRequestEntryGetWay aTestRequestEntryGetWay=new TestRequestEntryGetWay();

            return  aTestRequestEntryGetWay.GetFeeFromDB(name);

        }

        public int UserID(string name, string mobile)
        {

            return aTestRequestEntryGetWay.GetUserID(name, mobile);
        }

        public int SaveUserIDOthertable(int userId)
        {
            return aTestRequestEntryGetWay.SaveUserIDOthertableDB(userId);
        }

        public bool checkuser(string mobile)
        {
            return aTestRequestEntryGetWay.CheckUserDB(mobile);
        }

        public void SaveTotal(int id, int total)
        {
            aTestRequestEntryGetWay.SaveTotalDB(id, total);
        }
    }
}