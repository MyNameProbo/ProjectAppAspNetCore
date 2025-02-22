using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Server.Models
{
    public class WorkerTable
    { 
        public string WorkerId { get; set; }
        [Required]
        public string Name { get; set; }        
        public string Job { get; set; }   
        
        public virtual ICollection<ProjectTable> ProjectTables { get; set; }
        public virtual ICollection<WorkingTable> WorkingTables { get; set; }
    }
}
