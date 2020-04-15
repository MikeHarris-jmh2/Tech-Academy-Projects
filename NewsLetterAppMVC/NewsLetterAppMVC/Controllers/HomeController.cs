﻿using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsLetterEntities db = new NewsLetterEntities())
                {
                    var signup = new SignUpss();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUpsses.Add(signup);
                    db.SaveChanges();  
                }

                //string queryString = @"INSERT INTO SignUpss (FirstName, LastName, EmailAddress) VALUES
                //                        (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close(); 

                //}
                    return View("Success");

            }
        }
        
        
    }
}





//string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from Signupss";
//List<NewsletterSignup> signups = new List<NewsletterSignup>();

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);

//    connection.Open();

//    SqlDataReader reader = command.ExecuteReader();

//    while(reader.Read()){
//        var signup = new NewsletterSignup();
//        signup.Id = Convert.ToInt32(reader["Id"]);
//        signup.FirstName = reader["FirstName"].ToString();
//        signup.LastName = reader["LastName"].ToString();
//        signup.EmailAddress = reader["EmailAddress"].ToString();
//        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
//        signups.Add(signup);

//    }
//}