using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRSample.Services
{
    public interface IValueService
    {
        Task<IEnumerable<string>> GetAllValue();
        Task CreateValue(string value);
    }
}
