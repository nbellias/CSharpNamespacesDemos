using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.Models.Statements
{
    internal class TransactionDetail
    {
        public string? ProductCode { get; set; }
        public string? ProductDescription { get; set; }
        public float Amount { get; set; }
        public float CommissionPercentage { get; set; }
        public float CommissionAmount { get; set; }

    }
}
