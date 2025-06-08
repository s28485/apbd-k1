using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_1.Models;

[Table("Customer")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    
    [MaxLength(50)]
    public String FirstName { get; set; }
    
    [MaxLength(100)]
    public String LastName { get; set; }
    
    [MaxLength(100)]
    public String? PhoneNumber { get; set; }
    
    public ICollection<PurchasedTicket> PurchasedTickets { get; set; }
}