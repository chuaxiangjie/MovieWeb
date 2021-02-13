using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MovieWeb.Services.Models.ApiResponse
{
    public class MovieResponse<T> where T : class
    {
        public string Message { get; set; } = "";

        public List<string> Errors { get; set; } = new List<string>();

        public T Data { get; set; } = default(T);

        public ResponseType Response { get; set; }
    }
}
