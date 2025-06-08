﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_1.Models;

[Table("Concert")]
public class Concert
{
    [Key]
    public int ConcertId { get; set; }
    
    [MaxLength(100)]
    public String Name { get; set; }
    
    public DateTime Date { get; set; }
    public int AvailableTickets { get; set; }
    
    public ICollection<TicketConcert> TicketConcerts { get; set; }
}