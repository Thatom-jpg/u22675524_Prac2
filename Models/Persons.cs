using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u22675524_Prac2.Models
{
	public class Persons
	{

        [Display(Name = "StudentNumber")]
        public string StudentNumber { get; set; }

        [Display(Name = " Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name= "Email")]
        public string Email { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }

       
    }
}