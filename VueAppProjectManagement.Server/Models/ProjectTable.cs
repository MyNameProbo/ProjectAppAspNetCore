using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Server.Models
{
    public class ProjectTable
    {
        public Guid ProjectId { get; set; }
        [Required]
        public string Name { get; set; }        
        public string Customer { get; set; }
        public int  Stage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        
        public virtual WorkerTable WorkerTable { get; set; }
        public string ProjectManager {  get; set; }
    }
}
