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

        [Fact]
        public void Sing_TwoAnimalsAndFinish()
        {
            string expected =
@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";

            SongWriter writer = new SongWriter();

            writer.Sing("fly", "");
            writer.Sing("spider", "That wriggled and wiggled and tickled inside her.");
            string actual = writer.FinishSong("horse");

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(SongTestCases))]
        public void Sing_FullSong(List<(string, string)> input, string expected)
        {
            SongWriter writer = new SongWriter();

            for (int i = 0; i < input.Count - 1; i++) 
            {
                writer.Sing(input[i].Item1, input[i].Item2);
            }
            string actual = writer.FinishSong(input[input.Count - 1].Item1);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> SongTestCases => new List<object[]>
        {
            new object[]
            {
                new List<(string, string)>
                {
                    ("fly", ""),
                    ("spider", "That wriggled and wiggled and tickled inside her."),
                    ("horse", "")
                },

@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!"
            },

            new object[]
            {
                new List<(string, string)>
                {
                    ("fly", ""),
                    ("spider", "That wriggled and wiggled and tickled inside her."),
                    ("bird", "How absurd to swallow a bird."),
                    ("horse", "")
                },

@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a bird;
How absurd to swallow a bird.
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!"
            },
        };
    }
}