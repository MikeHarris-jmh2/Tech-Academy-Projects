using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salon.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int StylistID { get; set; }
        public int CustomerID { get; set; }
        public DateTime appointmentTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}