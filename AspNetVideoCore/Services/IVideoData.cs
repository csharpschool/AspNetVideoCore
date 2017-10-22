using AspNetVideoCore.Entities;
using System.Collections.Generic;

namespace AspNetVideoCore.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
        Video Get(int id);
        void Add(Video newVideo);
        int Commit();
    }
}
