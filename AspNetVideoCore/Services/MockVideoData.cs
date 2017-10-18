using AspNetVideoCore.Models;
using System;
using System.Collections.Generic;

namespace AspNetVideoCore.Services
{
    public class MockVideoData : IVideoData
    {
        private IEnumerable<Video> _videos;
        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "Shreck" },
                new Video { Id = 2, Title = "Despicable Me" },
                new Video { Id = 3, Title = "Megamind" }
            };
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}
