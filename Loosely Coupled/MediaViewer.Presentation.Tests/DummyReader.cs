using MediaViewer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaViewer.Presentation.Tests
{
    public class DummyReader : IMediaReader
    {
        List<Media> testData = new List<Media>()
        {
            new Media() { Id = 1,
            Title = "Cool Movie", MediaType = "image",
            Rating = 7, PublishDate = new DateTime(2001, 10, 10),
            MediaUrl = "http://www.containsimageof.nl/somemovie"},
            new Media() { Id = 2,
            Title = "Another Cool Movie", MediaType = "image",
            Rating = 7, PublishDate = new DateTime(2001, 11, 10),
            MediaUrl = "http://www.containsimageof.nl/somemovie2"}
        };

        public IEnumerable<Media> GetMedia()
        {
            return testData;
        }

        public Media GetMedia(int id)
        {
            return testData.FirstOrDefault(p => p.Id == id);
        }
    }
}
