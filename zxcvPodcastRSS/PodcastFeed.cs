using zxcvPodcastRSS.Models;

namespace zxcvPodcastRSS
{
    /// <summary>
    /// The Podcast application
    /// </summary>
    public class PodcastFeed
    {
        /// <summary>
        /// Current library version
        /// </summary>
        private string _Version = "1.0";

        /// <summary>
        /// Podcast Feed
        /// </summary>
        public FeedModel Feed;

        /// <summary>
        /// Collection of Podcast Episodes
        /// </summary>
        public List<PodcastModel> Podcasts;

        /// <summary>
        /// Initalize the Podcast Feed
        /// </summary>
        public PodcastFeed()
        {
            Feed = new FeedModel();
            Podcasts = new List<PodcastModel>();
        }

        /// <summary>
        /// Initalize the Podcast Feed
        /// </summary>
        /// <param name="_Feed">Feed to use</param>
        public PodcastFeed(FeedModel _Feed)
        {
            if (_Feed != null)
            {
                Feed = _Feed;
            }
            else
            {
                Feed = new FeedModel();
            }
            Podcasts = new List<PodcastModel>();
        }

        /// <summary>
        /// Initalize the Podcast Feed
        /// </summary>
        /// <param name="_Podcasts">Podcasts to add</param>
        public PodcastFeed(List<PodcastModel> _Podcasts)
        {
            if (_Podcasts != null && _Podcasts.Count > 0)
            {
                Podcasts = _Podcasts;
            }
            else
            {
                Podcasts = new List<PodcastModel>();
            }

            Feed = new FeedModel();
        }

        /// <summary>
        /// Initalize the Podcast Feed
        /// </summary>
        /// <param name="_Feed">Feed to use</param>
        /// <param name="_Podcasts">Podcast to add</param>
        public PodcastFeed(FeedModel? _Feed, PodcastModel _Podcast)
        {
            if (_Feed != null)
            {
                Feed = _Feed;
            }
            else
            {
                Feed = new FeedModel();
            }
            if (_Podcast != null)
            {
                List<PodcastModel>? _Podcasts = new List<PodcastModel>();
                _Podcasts.Add(_Podcast);
                Podcasts = _Podcasts;
            }
            else
            {
                Podcasts = new List<PodcastModel>();
            }
        }

        /// <summary>
        /// Initalize the Podcast Feed
        /// </summary>
        /// <param name="_Feed">Feed to use</param>
        /// <param name="_Podcasts">Podcast(s) to add</param>
        public PodcastFeed(FeedModel? _Feed, List<PodcastModel>? _Podcasts)
        {
            if (_Feed != null)
            {
                Feed = _Feed;
            }
            else
            {
                Feed = new FeedModel();
            }
            if (_Podcasts != null && _Podcasts.Count > 0)
            {
                Podcasts = _Podcasts;
            }
            else
            {
                Podcasts = new List<PodcastModel>();
            }
        }

        /// <summary>
        /// Get the library version number
        /// </summary>
        public string Version
        {
            get { return _Version; }
        }

        /// <summary>
        /// Set basic PodCast Feed attributes
        /// </summary>
        /// <param name="Title">Podcast Title</param>
        /// <param name="Link">Podcast Website Link</param>
        /// <param name="Summary">Podcast Summary</param>
        /// <param name="Description">Podcast Description</param>
        public void SetFeedDetails(string Title, string Link, string Summary, string Description)
        {
            Feed.Title = Title;
            Feed.Link = Link;
            Feed.Summary = Summary;
            Feed.Description = Description;
        }

        /// <summary>
        /// Set the Podcast Feed Owner attributes
        /// </summary>
        /// <param name="OwnerName">Owner's Full Name</param>
        /// <param name="OwnerEmail">Owener's Email</param>
        public void SetFeedOwner(string OwnerName, string OwnerEmail)
        {
            Feed.OwnerName = OwnerName;
            Feed.OwnerEmail = OwnerEmail;
        }

        /// <summary>
        /// Add Podcast to Podcast Feed
        /// </summary>
        /// <param name="Podcast">Podcast model to add</param>
        public void AddPodcast(PodcastModel Podcast)
        {
            Podcasts.Add(Podcast);
        }

        /// <summary>
        /// Add a Podcast to the Podcast Feed
        /// </summary>
        /// <param name="Title">Episode Title</param>
        /// <param name="PodcastURL">Episode Specific MP3 URL</param>
        /// <param name="ImageURL">Episode Image to display</param>
        public void AddPodcast(string Title, string PodcastURL, string ImageURL)
        {
            AddPodcast(Title, "", PodcastURL, ImageURL, "");
        }

        /// <summary>
        /// Add a Podcast to the Podcast Feed
        /// </summary>
        /// <param name="Title">Episode Title</param>
        /// <param name="Summary">Episode Summary</param>
        /// <param name="PodcastURL">Episode Specific MP3 URL</param>
        /// <param name="ImageURL">Episode Image to display</param>
        public void AddPodcast(string Title, string Summary, string PodcastURL, string ImageURL)
        {
            AddPodcast(Title, Summary, PodcastURL, ImageURL, Summary);
        }

        /// <summary>
        /// Add a Podcast to the Podcast Feed
        /// </summary>
        /// <param name="Title">Episode Title</param>
        /// <param name="Summary">Episode Summary</param>
        /// <param name="PodcastURL">Episode Specific MP3 URL</param>
        /// <param name="ImageURL">Episode Image to display</param>
        /// <param name="Description">Episode Description</param>
        public void AddPodcast(string Title, string Summary, string PodcastURL, string ImageURL, string? Description)
        {
            PodcastModel Podcast = new PodcastModel()
            {
                Title = Title,
                Summary = Summary,
                Link = PodcastURL,
                Image = new PodcastImage()
                {
                    url = ImageURL,
                    link = ImageURL,
                    title = Title
                },                
                Description = Description ?? string.Empty
            };

            Podcasts.Add(Podcast);
        }

        /// <summary>
        /// Replace Podcasts in the feed with a given podcast list
        /// </summary>
        /// <param name="_Podcasts">List of podcasts to populate the feed with</param>
        public void UpdatePodcasts(List<PodcastModel>? _Podcasts)
        {
            if(_Podcasts != null && _Podcasts.Count > 0)
            {
                Podcasts = _Podcasts;
            }
        }

        /// <summary>
        /// Remove a Podcast from the podcast feed.
        /// </summary>
        /// <param name="i">Podcast entry index to remove.</param>
        public void RemovePodcast(int i)
        {
            if (i < Podcasts.Count - 1)
            {
                Podcasts.RemoveAt(i);
            }
        }

        /// <summary>
        /// Remove a Podcast from the podcast feed
        /// </summary>
        /// <param name="podcast">The matching model to remove</param>
        public void RemovePodcast(PodcastModel podcast)
        {
            PodcastModel? foundPodcast = null;

            foundPodcast = Podcasts.Where(x => x == podcast).FirstOrDefault();

            if (foundPodcast != null)
            {
                Podcasts.Remove(foundPodcast);
            }
        }

        /// <summary>
        /// Remove a Podcast from the podcast feed
        /// </summary>
        /// <param name="PodcastTitle"></param>
        public void RemovePodcast(string PodcastTitle)
        {
            PodcastModel? foundPodcast = null;

            foundPodcast = Podcasts.Where(x => x.Title == PodcastTitle).FirstOrDefault();

            if (foundPodcast != null)
            {
                Podcasts.Remove(foundPodcast);
            }
        }

        /// <summary>
        /// Generate a RSS Feed containing all podcast entries.
        /// </summary>
        /// <returns>A raw RSS Podcast feed.</returns>
        public string GenerateFeed()
        {
            return GenerateFeed(int.MaxValue);
        }

        /// <summary>
        /// Generate a RSS Feed containing a subset of podcast entries
        /// </summary>
        /// <param name="ResultCount">Podcast entries to generate</param>
        /// <returns>A raw RSS Podcast feed.</returns>
        public string GenerateFeed(int ResultCount)
        {
            string rssFeedHeader = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
           "<rss xmlns:itunes=\"http://www.itunes.com/dtds/podcast-1.0.dtd\" version=\"2.0\">";

            string rssFeed =
           "<channel>" +
           $"<title>{Feed.Title}</title>" +
           $"<link>{Feed.Link}</link>" +
           $"<language>{Feed.Languague}</language>" +
           $"<itunes:subtitle>{Feed.Subtitle}</itunes:subtitle>" +
           $"<itunes:author>{Feed.Author}</itunes:author>" +
           $"<itunes:summary>{Feed.Summary}</itunes:summary>" +
           $"<description>{Feed.Description}</description>" +
           "<itunes:owner>" +
           $"    <itunes:name>{Feed.OwnerName}</itunes:name>" +
           $"    <itunes:email>{Feed.OwnerEmail}</itunes:email>" +
           "</itunes:owner>" +
           $"<itunes:explicit>{Feed.Explicit}</itunes:explicit>" +
           $"<itunes:image href=\"{Feed.ImageURL}\" />" +
           $"<itunes:category text=\"Category Name\"/>{Feed.Category}</itunes:category>";

            foreach (PodcastModel i in Podcasts)
            {
                rssFeed += "<item>" +
                "<title>" + i.Title + "</title>" +
                $"<itunes:summary>{ i.Summary}</itunes:summary>" +
                 $"<description>{i.Description}</description>" +
                $"<link>{ i.Link}</link>" +
                $"<enclosure url=\"{i.Link}\" type=\"audio/mpeg\" length=\"1024\"></enclosure>";

                if (!String.IsNullOrWhiteSpace(i.PublishDate))
                {
                    rssFeed += $"<pubDate>{i.PublishDate}</pubDate>";
                }
                else
                {
                    rssFeed += $"<pubDate>{System.DateTime.Now}</pubDate>";
                }

                rssFeed += $"<itunes:author>{i.Author}</itunes:author>";

                if (!String.IsNullOrWhiteSpace(i.Duration))
                {
                    rssFeed += $"<itunes:duration>{i.Duration}</itunes:duration>";
                }
                else
                {
                    rssFeed += $"<itunes:duration>00:10:00</itunes:duration>";
                }

                rssFeed += $"<itunes:explicit>{i.Author}</itunes:explicit>";


                if (!String.IsNullOrWhiteSpace(i.Guid))
                {
                    rssFeed += $"<guid>hhttp://www.Behind7Proxies.com/2</guid>";
                }
                else
                {
                    rssFeed += $"<guid>{new Guid()}</guid>";
                }

                rssFeed += "</item> ";
            }

            rssFeed += "</channel>";

            string rssFeedFooter = "</rss>";

            return rssFeedHeader + rssFeed + rssFeedFooter;
        }
    }
}

