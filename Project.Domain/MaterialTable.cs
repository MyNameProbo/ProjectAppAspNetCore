using System.ComponentModel.DataAnnotations;

namespace VueAppProjectManagement.Project.Domain
{
    public class MaterialTable
    {   
      
        public Guid MaterialId { get; set; }

        [Required]
        public string Description { get; set; }        
        public string Spec { get; set; }
        public int  Quantity { get; set; }
        public string Unit { get; set; }
    }
}
