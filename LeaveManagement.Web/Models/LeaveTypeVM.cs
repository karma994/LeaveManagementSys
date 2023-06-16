using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1,25, ErrorMessage = "Enter a valid Number")]
        public int DefaultDays { get; set; }

    }
}
