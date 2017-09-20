using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace diagnosticCenterAPP.Models
{
[Serializable]
    public class test_list
    {
        public int id { get; set; }
        public string testName { get; set; }
        public int testFee { get; set; }
    }
}