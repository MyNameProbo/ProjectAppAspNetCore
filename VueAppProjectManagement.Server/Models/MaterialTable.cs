using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Server.Models
{
    public class MaterialTable
    {   
      
        public string MaterialId { get; set; }

        [Required]
        public string Description { get; set; }        
        public string Spec { get; set; }
        public int  Quantity { get; set; }
        public string Unit { get; set; }

        public virtual ICollection<WorkingLine> WorkingLines { get; set; }
    }
}
