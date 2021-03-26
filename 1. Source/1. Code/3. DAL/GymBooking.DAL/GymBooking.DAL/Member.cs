using System;
using System.Collections.Generic;
using System.Text;

namespace GymBooking.DAL
{
    public class Member
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public Booking BookingId { get; set; }
    }
}
