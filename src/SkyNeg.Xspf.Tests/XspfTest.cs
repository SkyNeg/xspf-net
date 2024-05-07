namespace SkyNeg.Xspf.Tests
{
    public class XspfTest
    {
        [Theory]
        [InlineData("Data/TestPlaylist.xspf", 3)]
        public void Read(string path, int tracks)
        {
            Playlist? playlist = null;
            using (var stream = File.OpenRead(path))
            {
                playlist = Xspf.Read(stream);
            }

            Assert.NotNull(playlist);
            Assert.NotEmpty(playlist.License);
            Assert.NotEmpty(playlist.Creator);
            Assert.NotEqual(DateTime.MinValue, playlist.Date);
            Assert.NotNull(playlist.Info);
            Assert.Equal(tracks, playlist.Tracks.Count);
        }

        [Fact]
        public void Write()
        {
            Playlist playlist = new Playlist();
            playlist.Info = "info";
            playlist.Title = "title";
            playlist.Creator = "creator";

            playlist.Tracks =
            [
                new Track() { Location = "file://audio.mp3" },
                new Track() { Location = "file://videl.mkv" },
            ];

            Playlist? assertPlaylist = null;
            using (var ms = new MemoryStream())
            {
                Xspf.Save(ms, playlist);
                ms.Position = 0;
                assertPlaylist = Xspf.Read(ms);
            }

            Assert.NotNull(assertPlaylist);
            Assert.Equal(playlist.Title, assertPlaylist.Title);
            Assert.Equal(playlist.Tracks.Count, assertPlaylist.Tracks.Count);
        }
    }
}