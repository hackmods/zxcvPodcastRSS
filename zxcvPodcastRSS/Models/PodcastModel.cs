namespace zxcvPodcastRSS.Models
{
    /// <summary>
    /// The Podcast model for individual episode entries
    /// </summary>
    public class PodcastModel
    {
        public string? Title { get; set; }

        public string? Link { get; set; }

        public string? Description { get; set; }

        public string? Summary { get; set; }

        public string? Author { get; set; }

        public string? AtomLink { get; set; }

        public string? Docs { get; set; }

        public string? Generator { get; set; }

        public string? PublishDate { get; set; }

        public string? Duration { get; set; }


        public string? Guid { get; set; }

        public PodcastImage? Image { get; set; }

        public string? Language { get; set; }

        public string? LastBuildDate { get; set; }

    }

    /// <summary>
    /// The Podcast Image used for Episode artwork
    /// </summary>
    public class PodcastImage
    {
        /// <summary>
        /// Initalize the default PodcastImage
        /// </summary>
        public PodcastImage()
        {
            url = "";
            title = "";
            link = "";
        }

        /// <summary>
        /// Image source URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Image alt text / Title
        /// </summary>
        public string title { get; set; }

        //Image Link
        public string link { get; set; }
    }
}
