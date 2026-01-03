using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad zorunlu")]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email zorunlu")]
        [EmailAddress(ErrorMessage = "Geçerli bir email girin")]
        public string Email { get; set; }

        [MaxLength(30, ErrorMessage = "En fazla 30 karakter")]
        public string? Phone { get; set; }

        [Range(1, 10, ErrorMessage = "Kişi sayısı 1 - 10 arası olmalı")]
        public int NumberOfPeople { get; set; }

        [Required(ErrorMessage = "Tarih & Saat zorunlu")]
        public DateTime ReservationDateTime { get; set; }

        [MaxLength(500, ErrorMessage = "En fazla 500 karakter")]
        public string? SpecialRequest { get; set; }       
                 
    }
}
