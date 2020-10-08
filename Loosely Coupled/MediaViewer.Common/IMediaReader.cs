using System.Collections.Generic;

namespace MediaViewer.Common
{
    public interface IMediaReader
    {
        IEnumerable<Media> GetMedia();
        Media GetMedia(int id);
    }
}
