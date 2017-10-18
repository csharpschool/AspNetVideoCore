using AspNetVideoCore.Models;
using System.Collections.Generic;

namespace AspNetVideoCore.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
    }
}
