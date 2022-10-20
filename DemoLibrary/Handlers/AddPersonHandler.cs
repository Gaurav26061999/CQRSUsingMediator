using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, PersonModel>
    {
        private readonly IDemoPersonAccess _data;

        public AddPersonHandler(IDemoPersonAccess data)
        {
            _data = data;
        }
        public Task<PersonModel> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
