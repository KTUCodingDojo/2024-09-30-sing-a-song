using System.Text;

namespace Song.Tests
{
    public class SongWriterTests
    {
        [Fact]
        public void Sing_SingleAnimal()
        {
            SongWriter writer = new SongWriter();

            List<Animal> animals = new List<Animal>
            {
                new("fly", "")
            };

            string actual = writer.Sing(animals);

            Assert.Equal(
                $"There was an old lady who swallowed a fly.{Environment.NewLine}" +
                $"I don't know why she swallowed a fly - perhaps she'll die!",

                actual);
        }
    }
}