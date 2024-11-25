using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string SourceAccNumber { get; set; }
        public string Operation { get; set; } // e.g., "transfer", "withdraw", "deposit"
        public decimal Amount { get; set; }

        // Navigation property
        public virtual BankAccount BankAccount { get; set; }
    }
}
