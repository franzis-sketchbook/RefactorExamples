using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorExamples
{
    public class MysteriousName
    {
        public class Cust
        {
            public Cust(List<License> licenses)
            {
                Lic = licenses;
            }

            public List<License> Lic { get; set; }
        }
    }
}
