using MediaViewer.Common;
using MediaViewer.Service.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MediaViewer.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        IMediaProvider _provider;
        public MediaController(IMediaProvider provider)
        {
            _provider = provider;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Media> Get()
        {
            return _provider.GetMedia();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Media Get(int id)
        {
            return _provider.GetMedia().FirstOrDefault(p => p.Id == id);
        }
    }
}
