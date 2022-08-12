using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class Cards : AuditBase
    {
        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string CardPan { get; set; }
        public string PIN { get; set; }        
    }
}
