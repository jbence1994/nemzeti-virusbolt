using System.Net.Http;
using System.Net.Http.Headers;

namespace NemzetiVirusbolt.Desktop.Services.Helpers
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        public const string MediaType = "application/json";

        static ApiHelper()
        {
            ApiClient = new HttpClient();

            ApiClient.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue(MediaType));
        }
    }
}
