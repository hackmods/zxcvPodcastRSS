using zxcvPodcastRSS;

// Initialize the PodCast Feed
PodcastFeed podcastFeed = new PodcastFeed();

// Set Podcast Feed information for the feed owner
podcastFeed.SetFeedOwner("Owner Name", "email@ryanmorris,ca");

// Set Podcast Feed information containing general Podcast information
podcastFeed.SetFeedDetails("Podcast Title","http://ryanmorris.ca","My awesome podcast summary.","A detail description of what our Podcast covers.");

// Add a Podcast episode
podcastFeed.AddPodcast("Podcast Title", "Podcast Summary", "PodcastURL", "ImageURL");

// Add a Podcast episode with more detail
podcastFeed.AddPodcast("Podcast Title", "Podcast Summary", "PodcastURL","ImageURL","Podcast Description");

// Generate the itunes supported Podcast feed
string generatedRSS = podcastFeed.GenerateFeed();

//Output the generated feed. For future purposes you can write the generated RSS content directly to file
Console.WriteLine("Generated feed:");
Console.WriteLine($"{generatedRSS}");


