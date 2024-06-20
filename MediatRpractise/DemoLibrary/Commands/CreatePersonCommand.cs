using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DemoLibrary.Commands
{
    public record CreatePersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;

    /*   public class CreatePersonCommand : IRequest<PersonModel>
      {       
          public string  FirstName { get; set; }
          public string LastName { get; set; }

          public CreatePersonCommand(string firstName, string lastName)
          {
              FirstName = firstName;

              LastName = lastName;
          }
       
}   */
}
