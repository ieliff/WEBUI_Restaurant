using DAL.Context;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ReservationDal
    {
        private readonly DataContext context;

        public ReservationDal()
        {
            context = new DataContext();
        }

        public List<Reservation> GetAll()
        {
            return context.Reservations.ToList();
        }

        public void Add(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
        }

        public void Update(Reservation reservation)
        {
            context.Reservations.Update(reservation);
            context.SaveChanges();
        }

        public void Delete(Reservation reservation)
        {
            context.Reservations.Remove(reservation);
            context.SaveChanges();
        }
    }
}
