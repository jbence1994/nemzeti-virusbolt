using System.Net.Http;

namespace NemzetiVirusbolt.Desktop.Services.Helpers
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();
    }
}
