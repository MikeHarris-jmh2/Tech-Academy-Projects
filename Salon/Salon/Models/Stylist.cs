using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salon.Models
{
    public class Stylist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StylistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}