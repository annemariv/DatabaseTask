using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class AnonymousHint
    {
        [Key]
        public int Id { get; set; }
        public string HintType { get; set; }
        public DateTime HintDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
