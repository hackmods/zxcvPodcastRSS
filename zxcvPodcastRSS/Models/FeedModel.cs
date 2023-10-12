namespace zxcvPodcastRSS.Models
{
    /// <summary>
    /// The Feed containing Podcast information
    /// </summary>
    public class FeedModel
    {
            private string _languague = "en-us";

            private string _explicit = "no";

            private string _imageURL = "http://www.Behind7Proxies.com/podcast-icon.jpg";

            public string? Title { get; set; }

            public string? Link { get; set; }

            public string? Subtitle { get; set; }

            public string? Author { get; set; }

            public string? Summary { get; set; }

            public string? Description { get; set; }

            public string? OwnerName { get; set; }

            public string? OwnerEmail { get; set; }

            public string? Category { get; set; }

            public string Explicit
            {
                get
                {
                    return _explicit;
                }
                set
                {
                    _explicit = value;
                }
            }

            public string ImageURL
            {
                get
                {
                    return _imageURL;
                }
                set
                {
                    _imageURL = value;
                }
            }

            public string Languague
            {
                get
                {
                    return _languague;
                }
                set
                {
                    _languague = value;
                }
            }
        }
    }