using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Branches
    {
        [Key]
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
