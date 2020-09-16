using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRSample.Services
{
    public class MockValueService : IValueService
    {
        private readonly List<string> _values;
        public MockValueService()
        {
            _values = new List<string>() { "a", "b", "c" };
        }

        public Task CreateValue(string value)
        {
            _values.Add(value);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<string>> GetAllValue()
        {
            return await Task.Run(() => _values);
        }
    }
}
