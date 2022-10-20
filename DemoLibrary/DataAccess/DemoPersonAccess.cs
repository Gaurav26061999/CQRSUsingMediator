using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoPersonAccess : IDemoPersonAccess
    {
        private List<PersonModel> people = new();

        public DemoPersonAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Gaurav", LastName = "Singh" });
            people.Add(new PersonModel { Id = 2, FirstName = "Harshit", LastName = "Varshney" });
            people.Add(new PersonModel { Id = 3, FirstName = "Harsh", LastName = "Gupta" });

        }


        public List<PersonModel> GetPeople()
        {
            return people;
        }
        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new()
            {
                FirstName = firstName,
                LastName = lastName
            };
            p.Id = people.Max(x => x.Id) + 1;
            return p;

        }

    }
}
