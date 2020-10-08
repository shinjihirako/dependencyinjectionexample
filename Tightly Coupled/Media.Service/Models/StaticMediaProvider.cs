using MediaViewer.Common;
using System;
using System.Collections.Generic;

namespace MediaViewer.Service.Models
{
    public class StaticMediaProvider : IMediaProvider
    {
        public List<Media> GetMedia()
        {
            var m = new List<Media>()
            {
                new Media() { Id=1, Title="Akira",MediaUrl="https://m.media-amazon.com/images/M/MV5BM2ZiZTk1ODgtMTZkNS00NTYxLWIxZTUtNWExZGYwZTRjODViXkEyXkFqcGdeQXVyMTE2MzA3MDM@._V1_UX182_CR0,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(1988, 05, 15), Rating=8 },
                new Media() { Id=2, Title="Ghost in the Shell",MediaUrl="https://m.media-amazon.com/images/M/MV5BYWRiYjQyOGItNzQ1Mi00MGI1LWE3NjItNTg1ZDQwNjUwNDM2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(1996, 05, 15), Rating=8 },
                new Media() { Id=3, Title="Cowboy Bebop",MediaUrl="https://m.media-amazon.com/images/M/MV5BNGNlNjBkODEtZThlOC00YzUxLWI0MjMtMjk3YzJmMDFlNWZlXkEyXkFqcGdeQXVyNjI0MDg2NzE@._V1_UX182_CR0,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(1998, 05, 15), Rating=8.9 },
                new Media() { Id=4, Title="Samurai Champloo",MediaUrl="https://m.media-amazon.com/images/M/MV5BOWNhMDMyMDYtNzJlOS00YzhhLWFiMjktYWY1MzMzZGZhOGRjXkEyXkFqcGdeQXVyNDYzNTI2ODc@._V1_UX182_CR0,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(2005, 05, 15), Rating=8.5 },
                new Media() { Id=5, Title="Berserk",MediaUrl="https://m.media-amazon.com/images/M/MV5BYWE1YTU4NmYtMTY2Ni00NDIxLTgwMzYtNWJjYWE4MDE5OTE1XkEyXkFqcGdeQXVyNjc2NjA5MTU@._V1_UY268_CR6,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(1998, 05, 15), Rating=8.6 },
                new Media() { Id=6, Title="One Punch Man",MediaUrl="https://m.media-amazon.com/images/M/MV5BMTNmZDE2NDEtNTg3MS00OTE1LThlZGUtOGZkZTg0NTUyNGVmXkEyXkFqcGdeQXVyNTgyNTA4MjM@._V1_UX182_CR0,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(2015, 05, 15), Rating=8.8 },
                new Media() { Id=7, Title="Basilisk: The Kouga Ninja Scrolls",MediaUrl="https://m.media-amazon.com/images/M/MV5BOGVjYjkzMWMtOGRiZi00MjYxLTliYmMtZWMxZWI2MWY3ODNiXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY268_CR0,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(2005, 05, 15), Rating=7.9 },
                new Media() { Id=8, Title="Afro Samurai",MediaUrl="https://m.media-amazon.com/images/M/MV5BY2I2MzU0ZmUtNWE5Mi00OWM3LWIyZDEtZTg0Y2U2N2FlZDUyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_UY268_CR3,0,182,268_AL_.jpg", MediaType="image", PublishDate = new DateTime(2007, 05, 15), Rating=7.7 }
            };
            return m;
        }

    }
}
