using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleBookBook
{
    internal class LedgerEntry
    {
        public DateTime TranDate { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public decimal CarryForwardBalance { get; set; }

        public bool IsValid()
        {
            bool isValid = true;

            // System will not accpet future date entry
            if (this.TranDate.Date > DateTime.Now.Date)
                isValid = false;

            // Amount should be in positive 
            if (Amount < 0)
                isValid = false;

            return isValid;
        }

    }
}
