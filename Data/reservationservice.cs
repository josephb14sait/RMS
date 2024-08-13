using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    public class ReservationService
    {
        //read only list
        private readonly List<Reservation> _reservations = new List<Reservation>();

        //returns reservation list
        public IEnumerable<Reservation> GetReservations()
        {
            return _reservations;
        }

        //adds reservation to list
        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }
    }


}
