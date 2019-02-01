using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Salon.Models;

namespace Salon.DAL
{
    public class SalonInitializer : DropCreateDatabaseIfModelChanges<SalonContext> 
    {
        protected override void Seed(SalonContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{FirstName = "James", LastName="Michael", Phonenumber="(714)-331-9811"},
                new Customer{FirstName = "Tim", LastName="Arnold", Phonenumber="(704)-241-1121"},
                new Customer{FirstName = "Adam", LastName="Samuel", Phonenumber="(414)-198-7851"}
            };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var appointments = new List<Appointment>
            {
                new Appointment{AppointmentID = 1, CustomerID= 1, StylistID= 1, appointmentTime=DateTime.Now},
                new Appointment{AppointmentID = 1, CustomerID= 2, StylistID= 2, appointmentTime=DateTime.Now},
                new Appointment{AppointmentID = 1, CustomerID= 3, StylistID= 3, appointmentTime=DateTime.Now}
            };

            appointments.ForEach(c => context.Appointments.Add(c);
            context.SaveChanges();

            var stylists = new List<Stylist>
            {
                new Stylist{StylistId = 1, FirstName="John", LastName="Doe"},
                new Stylist{StylistId = 2, FirstName="Samantha", LastName="Parry"},
                new Stylist{StylistId = 3, FirstName="Georgia", LastName="Smith"}
            };

            stylists.ForEach(c => context.Stylists.Add(c));
            context.SaveChanges();
        }
    }
}