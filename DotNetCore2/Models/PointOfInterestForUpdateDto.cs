using System.ComponentModel.DataAnnotations;

namespace DotNetCore2.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
