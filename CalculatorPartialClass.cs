using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GUI_final_practice
{
    internal class CalculatorPartialClass
    {
        public string Operation { get; set; }
        public double FirstNumber { get; set; }
        
        public CalculatorPartialClass(string firstnumber, double operation)
        {
            this.FirstNumber = 0;
            this.Operation = string.Empty;
        }
    }
}
