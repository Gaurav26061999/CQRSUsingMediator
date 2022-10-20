
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{

   public record AddPersonCommand(string FirstName, string LastName): IRequest<PersonModel>;

   // Or use the code below
   //public  class AddPersonCommand: IRequest<PersonModel>
   // {
   //     public string FirstName { get; set; }
   //     public string LastName { get; set; }

   //     public AddPersonCommand(string fisrtName, string lastName)
   //     {
   //         FirstName = FirstName;
   //         LastName = lastName;
   //     }
    }
}
