using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.Context
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UN9RIPL\\SQLDERS; Database=Restaurant; Uid=sa; Pwd=1; TrustServerCertificate=true");
        }

       
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutCounter> AboutCounters { get; set; }
        public DbSet<MenuCategory> MenuCategorys { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Chefs> Chefs { get; set; }
        public DbSet<Contact> ContactMessages { get; set; }

        public DbSet<Slider> Sliders { get; set; }
    }

}
