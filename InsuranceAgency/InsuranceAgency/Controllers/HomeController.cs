using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InsuranceAgency;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public ActionResult InsuranceInfo(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool hasDUI, int speedingTickets, bool fullCoverage)
        {
             if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string queryString = @"INSERT INTO InsuranceAgency (FirstName, LastName, EmailAddress, DateofBirth) VALUES (@FirstName, @LastName, @EmailAddress, #DateofBirth)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateofBirth", SqlDbType.Date);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@hasDUI?", SqlDbType.Bit);
                    command.Parameters.Add("@SpeedingTickets", SqlDbType.Int);
                    command.Parameters.Add("@FullCoverageLiability", SqlDbType.Bit); 

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateofBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@hasDUI?"].Value = hasDUI;
                    command.Parameters["@SpeedingTickets"].Value = speedingTickets;
                    command.Parameters["@FullCoverageLiability"].Value = fullCoverage;


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return View();
            }
        }
    }
} 