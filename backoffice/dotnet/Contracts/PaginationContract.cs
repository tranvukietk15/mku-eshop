using System.Collections.Generic;

namespace dotnet.Contracts
{
    public class PaginationContract<T> : PagingModel
    {
        public IEnumerable<T> Items { get; set; }
        public int Total { get; set; }
    }
}