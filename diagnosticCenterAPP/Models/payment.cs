using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace diagnosticCenterAPP.Models
{
    public class payment
    {
       public int total { get; set; }
       public int paid { get; set; }
       public int due { get; set; }
       public string billDate { get; set; }
    }
}