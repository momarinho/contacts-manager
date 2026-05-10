using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactsManager.Models
{
    public class Contact
    {
    public Guid ContactId { get; set; }
    
    [Required(ErrorMessage = "Name is Required")]
   [StringLength(100)]
    public string? Name { get; set; }
    
    [Required(ErrorMessage =  "Email is Required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }
    
    [Phone(ErrorMessage = "Phone Number is Required")]
    public string? Phone { get; set; }
    
    [StringLength(200)]
    public string? Address { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    [Required]
    public string? Gender { get; set; }
    }
}