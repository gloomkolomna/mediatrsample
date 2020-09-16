using MediatR;
using MediatRSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSample.Requests.Values
{
    public class CreateValueCommand : IRequest
    {
        [Required]
        public string Value { get; set; }
    }

    public class CreateValueCommandHandler : IRequestHandler<CreateValueCommand, Unit>
    {
        private readonly IValueService _valueService;

        public CreateValueCommandHandler(IValueService valueService)
        {
            _valueService = valueService;
        }

        public async Task<Unit> Handle(CreateValueCommand request, CancellationToken cancellationToken)
        {
            await _valueService.CreateValue(request.Value);
            return Unit.Value;
        }
    }
}
