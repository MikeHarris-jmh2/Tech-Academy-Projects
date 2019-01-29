using InsuranceAgency.Models;
using InsuranceAgency.ViewModels;
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

        public int insuranceTotal = 50;
        public string clientInfo = "";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsuranceInfo(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, int hasDUI, int speedingTickets, int fullCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                int calculate = Calculation( dateOfBirth,  carYear,  carMake, carModel, hasDUI, speedingTickets,fullCoverage, insuranceTotal);

                insuranceTotal = calculate;

                string queryString = @"INSERT INTO InsuranceInformation (FirstName, LastName, EmailAddress, DateofBirth, CarYear, CarMake, CarModel, hasDUI, SpeedingTickets, FullCoverageorLiability, InsuranceTotal) VALUES (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @hasDUI, @SpeedingTickets, @FullCoverageorLiability, @insuranceTotal)";

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
                    command.Parameters.Add("@hasDUI", SqlDbType.Bit);
                    command.Parameters.Add("@SpeedingTickets", SqlDbType.Int);
                    command.Parameters.Add("@FullCoverageorLiability", SqlDbType.Bit);
                    command.Parameters.Add("@InsuranceTotal", SqlDbType.Int);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateofBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@hasDUI"].Value = hasDUI;
                    command.Parameters["@SpeedingTickets"].Value = speedingTickets;
                    command.Parameters["@FullCoverageorLiability"].Value = fullCoverage;
                    command.Parameters["@InsuranceTotal"].Value = insuranceTotal;


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                ViewBag.InsuranceTotal = calculate;
                return View("Calculation");
            }

        }


        public  int Calculation(DateTime dateOfBirth, int carYear, string carMake, string carModel, int hasDUI, int speedingTickets, int fullCoverage, int insuranceTotal)
        {
            DateTime date = new DateTime(2001, 1, 1);

            DateTime date_two = new DateTime(1994, 1, 1);

            DateTime date_three = new DateTime(1919, 1, 1);

            


            if (dateOfBirth > date)
            {
                insuranceTotal += 100;
            }else if (dateOfBirth >= date_two)
            {
                insuranceTotal += 25;
            } else if (dateOfBirth > date_three)
            {
                insuranceTotal += 25;
            } else
            {
                insuranceTotal += 0;
            }

            

            if (carYear < 2000)
            {
                insuranceTotal += 25;
            } else if(carYear > 2015)
            {
                insuranceTotal += 25;
            }
            else
            {
                insuranceTotal += 0;
            }

           
            if(carMake.ToLower() == "porsche")
            {
                insuranceTotal += 25;
            } else if(carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera")
            {
                insuranceTotal += 50;
            }

            do
            {
                insuranceTotal += 10;
                speedingTickets--;
            } while (speedingTickets >= 1);
            
            if(hasDUI == 1)
            {
                double confirmed = insuranceTotal * .25;
                insuranceTotal = insuranceTotal + Convert.ToInt32(confirmed);
            }

            if(fullCoverage == 1)
            {
                double confirmedCoverage = insuranceTotal * .50;
                insuranceTotal = insuranceTotal + Convert.ToInt32(confirmedCoverage);
            }

            return insuranceTotal;

            
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, InsuranceTotal from InsuranceInformation";
            List<InsuranceInformation> quoteinformation = new List<InsuranceInformation>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var insuranceinfo = new InsuranceInformation();
                    insuranceinfo.Id = Convert.ToInt32(reader["Id"]);
                    insuranceinfo.FirstName = reader["FirstName"].ToString();
                    insuranceinfo.LastName = reader["LastName"].ToString();
                    insuranceinfo.EmailAddress = reader["EmailAddress"].ToString();
                    insuranceinfo.InsuranceTotal = Convert.ToInt32(reader["InsuranceTotal"]);
                    quoteinformation.Add(insuranceinfo);

                }
            }
            return View(quoteinformation);
        }
    }
}




