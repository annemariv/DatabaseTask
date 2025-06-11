using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class IntranetPermissions
    {
        [Key]
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string Comments { get; set; }
        public DateTime PermissionGrantedDate { get; set; }
        public DateTime PermissionEndDate { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
