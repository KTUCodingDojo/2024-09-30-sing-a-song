using System.Text;

namespace Song.Tests
{
    public class SongWriterTests
    {
        [Fact]
        public void Sing_SingleAnimal()
        {
            SongWriter writer = new SongWriter();

            string actual = writer.Sing("fly", "");

            Assert.Equal(
                $"There was an old lady who swallowed a fly.{Environment.NewLine}" +
                $"I don't know why she swallowed a fly - perhaps she'll die!",

                actual);
        }
    }
}