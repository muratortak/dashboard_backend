
using System.Collections.Generic;
using System.Linq;

namespace Advantage.API
{
    public class PaginateResponse<T>
    {
        public PaginateResponse(IEnumerable<T> data, int i, int len)
        {
            // [1] page, 10 results
            // Skip the len of the first 10 (or whatever the length is) and get the next 10 (whatever the length is)
            Data = data.Skip((i - 1) * len).Take(len).ToList();
            Total = data.Count();
        }

        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}