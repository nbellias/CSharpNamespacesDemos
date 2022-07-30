using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.Models.Statements
{
    internal class Transaction
    {
        public string? SettlementDate { get; set; }
        public string? Description { get; set; }
        public float GrossAmount { get; set; }
        public float Commission { get; set; }
        public float NetAmount { get; set; }
    }
}
