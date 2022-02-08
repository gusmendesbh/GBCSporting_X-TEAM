using System.ComponentModel.DataAnnotations;

namespace GBCSporting_X_TEAM.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
