using Microsoft.OpenApi.Models;

namespace DivisibleBy11
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public Contact Contact { get; set; }
    }
}