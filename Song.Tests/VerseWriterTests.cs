using System.Security.Cryptography;
using System;
using System.Text;

namespace Song.Tests
{
    public class VerseWriterTests
    {
        [Fact]
        public void WriteVerse_SingleAnimalVerse()
        {
            VerseWriter writer = new VerseWriter();
            
            string expected =
@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!";

            Stack<string> animals = new Stack<string>(["fly"]);

            string actual = writer.WriteVerse(animals, "");


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WriteVerse_TwoAnimalVerse()
        {
            VerseWriter writer = new VerseWriter();

            string expected =
@"There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!";

            Stack<string> animals = new Stack<string>(["fly", "spider"]);

            string actual = writer.WriteVerse(animals, "That wriggled and wiggled and tickled inside her.");

            Assert.Equal(expected, actual);
        }
    }
}