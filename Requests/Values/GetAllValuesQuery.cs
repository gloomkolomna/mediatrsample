using MediatR;
using MediatRSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSample.Requests.Values
{
    public class GetAllValuesQuery : IRequest<IEnumerable<string>>
    {
    }

    public class GetAllValuesQueryHandler : IRequestHandler<GetAllValuesQuery, IEnumerable<string>>
    {
        private readonly IValueService _valueService;

        public GetAllValuesQueryHandler(IValueService valueService)
        {
            _valueService = valueService;
        }

        public async Task<IEnumerable<string>> Handle(GetAllValuesQuery request, CancellationToken cancellationToken)
        {
            return await _valueService.GetAllValue();
        }
    }
}
