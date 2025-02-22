using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Project.Domain
{
    public class WorkingTable
    {   
        [Required]
        public Guid WorkingId { get; set; }
        public string Description { get; set; }        
        public DateTime WorkingDate { get; set; }
        public Guid ProjectId { get; set; }
        public Guid WorkerId { get; set; }
        public virtual ICollection<WorkingLine> WorkingLines { get; set; }
    }
}
