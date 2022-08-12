using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class Account : ApplicationUser
    {
        public long Id { get; set; }
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
    }
}
