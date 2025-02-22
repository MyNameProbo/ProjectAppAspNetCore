using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Server.Models
{
    public class WorkingLine
    {
        [Required]
        public string LineId { get; set; }
        public string MaterialId { get; set; }
        public int Qty { get; set; }

        public virtual WorkingTable WorkingTable { get; set; }
        public string WorkingId { get; set; }

        public virtual MaterialTable MaterialTable { get; set; }
    }
}