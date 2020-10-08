using System;

namespace MediaViewer.Common
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MediaUrl { get; set; }
        public string MediaType { get; set; }
        public DateTime PublishDate { get; set; }
        public double Rating { get; set; }
        public string FormatString { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FormatString))
                FormatString = "{0} {1}";
            return string.Format(FormatString, MediaUrl, MediaType);
        }
    }
}
