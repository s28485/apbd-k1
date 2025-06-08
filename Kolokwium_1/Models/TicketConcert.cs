using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Kolokwium_1.Models;

[Table("Ticket_Concert")]

public class TicketConcert
{
    [Key]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(Ticket))]
    public int TicketId { get; set; }
    
    [ForeignKey(nameof(Concert))]
    public int ConcertId { get; set; }
    
    // dodac decimal(10,2)
    public float Price { get; set; }
    
    public Concert Concert { get; set; }
    public Ticket Ticket { get; set; }
    
    public ICollection<PurchasedTicket> PurchasedTickets { get; set; }
        
}