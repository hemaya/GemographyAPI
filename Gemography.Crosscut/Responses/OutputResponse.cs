using System.Collections.Generic;
using System.Net;

namespace Gemography.Crosscut.Responses
{
    public class OutputResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; }
        public object Message { get; set; }
        public int Count { get; set; }
        public T Model { get; set; }
        public List<ErrorModel> Errors { get; set; } = new();
    }
}
