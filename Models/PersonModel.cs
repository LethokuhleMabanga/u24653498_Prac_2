﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u24653498_Prac_2.Models
{
	public class PersonModel
	{
        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; } = 0;

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }
    }
}