using MediaViewer.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaViewer.CSV
{
    public class CSVReader : IMediaReader
    {
        public ICSVFileLoader FileLoader { get; set; }

        public CSVReader()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Media.txt";
            FileLoader = new CSVFileLoader(filePath);
        }

        public IEnumerable<Media> GetMedia()
        {
            var fileData = FileLoader.LoadFile();
            var media = ParseDataString(fileData);
            return media;
        }

        public Media GetMedia(int id)
        {
            var media = GetMedia();
            return media?.FirstOrDefault(p => p.Id == id);
        }

        private IEnumerable<Media> ParseDataString(string csvData)
        {
            var media = new List<Media>();
            var lines = csvData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                try
                {
                    media.Add(ParsemediaString(line));
                }
                catch (Exception ex)
                {
                    // Skip the bad record, log it, and move to the next record
                    // log.Write($"Unable to parse record: {line}")
                }
            }
            return media;
        }

        private Media ParsemediaString(string mediaData)
        {
            var elements = mediaData.Split(',');
            var media = new Media()
            {
                Id = int.Parse(elements[0]),
                Title = elements[1],
                MediaUrl = elements[2],
                MediaType = elements[3],
                PublishDate = DateTime.Parse(elements[4]),
                Rating = int.Parse(elements[5]),
            };
            return media;
        }
    }
}
