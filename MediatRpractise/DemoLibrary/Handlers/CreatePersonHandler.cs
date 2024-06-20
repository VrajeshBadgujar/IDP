using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, PersonModel>
    {
        private IDataAccess _data;

        public CreatePersonHandler(IDataAccess data)
        {
            _data = data;
        }
        public async Task<PersonModel> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
