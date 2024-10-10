using System.Text;

namespace Song.Tests
{
    public class SongWriterTests
    {
        [Fact]
        public void Sing_SingleAnimal()
        {
            string expected =
@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!";

            SongWriter writer = new SongWriter();

            string actual = writer.Sing("fly", "");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sing_TwoAnimals()
        {
            string expected =
@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!";

            SongWriter writer = new SongWriter();

            writer.Sing("fly", "");
            string actual = writer.Sing("spider", "That wriggled and wiggled and tickled inside her.");

            Assert.Equal(expected, actual);
        }
    }
}