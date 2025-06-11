using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Kids
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
