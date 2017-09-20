using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using diagnosticCenterAPP.DAL;
using diagnosticCenterAPP.Models;

namespace diagnosticCenterAPP.BLL
{
    public class PatiencTestManager
    {

        public string PatiencTestSave(string name, int fee, int testUniqueID)
        {
            patiencTestGetway aPatiencTestGetway = new patiencTestGetway();

            int affected = aPatiencTestGetway.saveTestDetail(name, fee, testUniqueID);

            if (affected > 0)
            {
                return  "Added";
            }
            else
            {
                return "Problem Occured";
            }
        }

        public List<IndividualTestList> ShowIndividualTestLists(int billId)
        {
            patiencTestGetway aPatiencTestGetway=new patiencTestGetway();
            return aPatiencTestGetway.GetIndividualTestList(billId);
        }

        public payment PayDetail(int id)
        {
            patiencTestGetway aPatiencTestGetway=new patiencTestGetway();
            return aPatiencTestGetway.GetPayDetail(id);
        }

        public void UpdateTotal(int id, int pay)
        {
            patiencTestGetway aPatiencTestGetway = new patiencTestGetway();
            aPatiencTestGetway.UpdateTotalDB(id, pay);
        }
    }
}