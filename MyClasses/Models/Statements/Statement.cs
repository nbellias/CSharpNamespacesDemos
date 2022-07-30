using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses.Models.Statements
{
    internal class Statement
    {
        public string? StatementID { get; set; }
        public string? StatementType { get; set; }
        public string? ReportDateFrom { get; set; }
        public string? ReportDateTo { get; set; }
        public string? IssueDate { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientName { get; set; }
        public string? ClientName2 { get; set; }
        public string? ClientCategory { get; set; }
        public string? ClientAddress1 { get; set; }
        public string? ClientPostal { get; set; }
        public string? ClientAddress2 { get; set; }
        public string? ClientVATNumber { get; set; }
        public string? ClientTaxOffice { get; set; }
        public string? StatementNumber { get; set; }
        public List<Transaction>? Transaction { get; set; }
        public float TotalGross { get; set; }
        public float TotalCommissions { get; set; }
        public float TotalNet { get; set; }
        public List<DetailedTransaction>? DetailedTransaction { get; set; }
    }
}
