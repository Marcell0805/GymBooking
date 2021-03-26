using System;
using System.Collections.Generic;
using System.Text;

namespace GymBooking.DAL
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public double Duration { get; set; }
        public GymArea AreaId { get; set; }
    }
}
