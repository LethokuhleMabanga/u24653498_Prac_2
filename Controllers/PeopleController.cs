using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24653498_Prac_2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PeopleList()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { StudentNumber = 24653498, Name = "Lethokuhle", Surname = "Mabanga", EmailAddress = "u24653498@tuks.co.za", myLink="~/HTML/Person01.html" });
            people.Add(new Models.PersonModel { StudentNumber = 24355897, Name = "Alwande", Surname = "Nyembe", EmailAddress = "letho.@icloud.com", myLink = "~/HTML/Person02.html" });
            people.Add(new Models.PersonModel { StudentNumber = 24137890, Name = "Thando", Surname = "Buthelezi", EmailAddress = "thando@gmail.com", myLink = "~/HTML/Person03.html" });
            people.Add(new Models.PersonModel { StudentNumber = 24398213, Name = "Amanda", Surname = "Nhlengethwa", EmailAddress = "amanda@gmail.com", myLink = "~/HTML/Person04.html" });
            people.Add(new Models.PersonModel { StudentNumber = 24721342, Name = "Lethinhlanhla", Surname = "Mncwango", EmailAddress = "u24721342@tuks.co.za", myLink = "~/HTML/Person05.html" });

            return View(people);
        }
    }
}