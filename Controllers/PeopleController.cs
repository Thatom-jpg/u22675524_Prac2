using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u22675524_Prac2.Models;

namespace u22675524_Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<Persons> people = new List<Persons>
            {
                new Persons()
                {
                    StudentNumber = "u22675524",
                    Name = "Thato",
                    Surname = "Modise",
                    Email = "u22675524@tuks.co.za",
                    myLink = "~/HTML/Person1.html"

                },

                new Persons()
                {
                    StudentNumber = "u24687945",
                    Name = "Naledi",
                    Surname = "Nkwana",
                    Email = "u24687945@tuks.co.za",
                    myLink = "~/HTML/Person2.html",
                   

                },

                new Persons()
                {
                    StudentNumber = "u24573877",
                    Name = "Nabeeha",
                    Surname = "Mohamed",
                    Email = "u24573877@tuks.co.za",
                    myLink = "~/HTML/Person3.html"

                },

                new Persons()
                {
                    StudentNumber = "u22607235",
                    Name = "Kamogelo",
                    Surname = "Morare",
                    Email = "u22607235@tuks.co.za",
                    myLink = "~/HTML/Person4.html"

                },

                new Persons()
                {
                    StudentNumber = "u24722490",
                    Name = "Nyiko",
                    Surname = "Mbalati",
                    Email = "u24722490@tuks.co.za",
                    myLink = "~/HTML/Person5.html"

                },






            };
            return View(people);
               
              
        }

    }
}