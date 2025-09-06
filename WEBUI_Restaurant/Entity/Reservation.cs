using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime ReservationDateTime { get; set; } 
        public string? SpecialRequest { get; set; }       
                 
    }
}
