using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Project.Domain
{
    public class WorkingLine
    {
        [Required]
        public Guid LineId { get; set; }
        public string MaterialName { get; set; }
        public int Qty { get; set; }

        public virtual WorkingTable WorkingTable { get; set; }
        public Guid WorkingId { get; set; }
    }
}