using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Project.Domain
{
    public class WorkerTable
    { 
        public Guid WorkerId { get; set; }
        [Required]
        public string Name { get; set; }        
        public string Job { get; set; }
    }
}
