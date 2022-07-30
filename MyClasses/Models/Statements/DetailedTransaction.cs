using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.Models.Statements
{
    internal class DetailedTransaction
    {
        public string? Paymentdate { get; set; }
        public float TotalAmount { get; set; }
        public float TotalCommission { get; set; }
        public List<TransactionDetail>? TransactionDetails { get; set; }

    }
}
