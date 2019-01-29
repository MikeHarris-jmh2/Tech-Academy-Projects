﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceAgency.Models
{
    public class InsuranceInformation
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateofBirth { get; set; }

        public int CarYear { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public int hasDUI { get; set; }

        public int SpeedingTickets { get; set; }

        public int FullCoverageLiaility { get; set; }

        public int InsuranceTotal { get; set; }
    }
}