using AspNetVideoCore.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AspNetVideoCore.Services
{
    public class MockVideoData : IVideoData
    {
        private IEnumerable<Video> _videos;
        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, GenreId = 1, Title = "Shreck" },
                new Video { Id = 2, GenreId = 1, Title = "Despicable Me" },
                new Video { Id = 3, GenreId = 1, Title = "Megamind" }
            };
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(v => v.Id.Equals(id));
        }

    }
}
