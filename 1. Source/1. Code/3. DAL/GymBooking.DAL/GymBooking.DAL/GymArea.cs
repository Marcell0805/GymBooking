using System;
using System.Collections.Generic;
using System.Text;

namespace GymBooking.DAL
{
    public class GymArea
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public int AllowedSessions { get; set; }
    }
}
