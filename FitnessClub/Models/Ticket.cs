﻿using System.ComponentModel.DataAnnotations;

namespace FitnessClub.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Type { get; set; }
        public string Period { get; set; }
        public int Price { get; set; }
        // Зв'язок багато до багатьох
        public ICollection<UserTicket>? UserTickets { get; set; }
    }
}
