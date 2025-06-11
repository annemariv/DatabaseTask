using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class LoanableItems
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime LoanStartingDate { get; set; }
        public DateTime LoanEndingDate { get; set; }
        public bool IsReturned { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
