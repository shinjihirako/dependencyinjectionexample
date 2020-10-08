using MediaViewer.Common;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace MediaViewer.Service
{
    public class ServiceReader
    {
        WebClient client = new WebClient();
        string baseUri = "https://localhost:44375/api/media";

        public IEnumerable<Media> GetMedia()
        {
            string result = client.DownloadString(baseUri);
            var media = JsonConvert.DeserializeObject<IEnumerable<Media>>(result);
            return media;
        }

        public Media GetMedia(int id)
        {
            string result = client.DownloadString($"{baseUri}/{id}");
            var media = JsonConvert.DeserializeObject<Media>(result);
            return media;
        }
    }
}
