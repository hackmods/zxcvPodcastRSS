using Microsoft.VisualStudio.TestTools.UnitTesting;
using zxcvPodcastRSS;

namespace zxcvPodcastRSSTest
{
    [TestClass]
    public class PodcastFeedTest
    {
        // https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio?pivots=dotnet-7-0

        /// <summary>
        /// Confirm the test matches the current Libray Version
        /// </summary>
        [TestMethod]
        public void ValidateLibraryVersion1()
        {
            PodcastFeed podcastFeed = new PodcastFeed();
            
            string version = podcastFeed.Version;
            string expectedVersion = "1.0";

            bool result = version == expectedVersion;

            Assert.IsTrue(result,
                      string.Format("Expected for '{0}': true; Actual: {1}",
                                    version, result));
        }


        /// <summary>
        /// Confirm the test case does not match the current Libray Version
        /// </summary>
        [TestMethod]
        public void ValidateLibraryVersion2()
        {
            PodcastFeed podcastFeed = new PodcastFeed();

            string version = podcastFeed.Version;
            string expectedVersion = "0.6";

            bool result = version == expectedVersion;

            Assert.IsFalse(result,
                      string.Format("Expected for '{0}': false; Actual: {1}",
                                    version, result));
        }

        /// <summary>
        /// Confirm Feed ds updates as intended after SetFeedDetails is called
        /// </summary>
        [TestMethod]
        public void ValidateFeedGeneration1()
        {
            PodcastFeed podcastFeed = new PodcastFeed();

            podcastFeed.SetFeedDetails("Title", "Link", "Summary", "Description");

            string actual = podcastFeed.Feed.Title ?? "";
            string expected = "Title";

            bool result = actual == expected;

            Assert.IsTrue(result,
                      string.Format("Expected for '{0}': true; Actual: {1}",
                                    actual, expected));
        }
    }
}