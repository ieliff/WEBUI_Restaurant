using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ReservationService
    {
        private readonly ReservationDal reservationDal;
        public ReservationService()
        {
            reservationDal = new ReservationDal();
        }
        
         public Reservation GetAllReservations()
         {
            return reservationDal.GetAll().FirstOrDefault();
        }

        public void AddReservation(Reservation reservation)
        {
            reservationDal.Add(reservation);
        }
    }
}
