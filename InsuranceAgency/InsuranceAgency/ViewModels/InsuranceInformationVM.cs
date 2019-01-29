using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceAgency.ViewModels
{
    public class InsuranceInformationVM
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public int InsuranceTotal { get; set; }
    }
}