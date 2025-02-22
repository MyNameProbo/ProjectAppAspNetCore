using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Server.Models
{
    public class WorkingTable
    {   
        [Required]
        public string WorkingId { get; set; }
        public string Description { get; set; }        
        public DateTime WorkingDate { get; set; }
        public string ProjectId { get; set; }
        public string WorkerId { get; set; }

        public virtual ProjectTable ProjectTable { get; set; }
        public virtual WorkerTable WorkerTable { get; set; }
        public virtual ICollection<WorkingLine> WorkingLines { get; set; }
    }
}
