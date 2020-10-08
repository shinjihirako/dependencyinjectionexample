using MediaViewer.Common;
using System.Collections.Generic;

namespace MediaViewer.Service.Models
{
    public interface IMediaProvider
    {
        List<Media> GetMedia();
    }
}
