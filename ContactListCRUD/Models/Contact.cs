namespace ContactListCRUD.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

[PrimaryKey("Id")]  
    public class Contact
    {
        public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
    [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }


    [Required(ErrorMessage = "Phone number is required")]
    [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be exactly 10 digits")]
    [RegularExpression(@"^\d+$", ErrorMessage = "Phone number must contain only digits")]

    public string Phone { get; set; }
    }
