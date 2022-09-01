using System.Net;

namespace Infrastructure.Network
{
    public class WebClientWrapper : IWebClientWrapper
    {
        public void Post(string address, string json)
        {
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
            }
        }
    }
}
