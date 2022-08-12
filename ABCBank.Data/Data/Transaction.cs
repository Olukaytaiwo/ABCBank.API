using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class Transaction : AuditBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string SourceAccount { get; set; }
        public string DestinationAccount { get; set; }
        public double Amount { get; set; }
        public string Narration { get; set; }
        public string RefrenceId { get; set; }

    }
}
