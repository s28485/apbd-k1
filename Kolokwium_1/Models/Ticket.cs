using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kolokwium_1.Models;


[Table("Ticket")]
public class Ticket
{
    [Key]
    public int TicketId { get; set; }
    
    [MaxLength(50)]
    public String SerialNumber { get; set; }
    
    public int SeatNumber { get; set; }
    
    public ICollection<TicketConcert> TicketConcerts { get; set; }
}