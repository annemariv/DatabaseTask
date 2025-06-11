using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Replacement { get; set; }
    }
}
