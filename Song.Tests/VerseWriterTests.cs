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

            string actual = writer.WriteVerse("fly", "");

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

            List<(string, string)> animals = new List<(string, string)>([
                ("fly", ""),
                ("spider", "That wriggled and wiggled and tickled inside her.")
                ]);

            string actual = "";
            foreach ((string, string) animal in animals)
            {
                actual = writer.WriteVerse(animal.Item1, animal.Item2);
            }

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(AnimalTestCases))]
        public void WriteVerse_MultipleAnimals(List<(string, string)> input, string expected)
        {
            VerseWriter writer = new VerseWriter();

            string actual = "";
            foreach ((string, string) animal in input)
            {
                actual = writer.WriteVerse(animal.Item1, animal.Item2);
            }

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> AnimalTestCases => new List<object[]>
        {
            new object[] 
            {
                new List<(string, string)>(
                [ 
                    ("fly", ""), 
                    ("spider", "That wriggled and wiggled and tickled inside her."),
                    ("bird", "How absurd to swallow a bird.")
                ]),

@"There was an old lady who swallowed a bird;
How absurd to swallow a bird.
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!"
            },

            new object[]
            {
                new List<(string, string)>(
                [
                    ("fly", ""),
                    ("bird", "How absurd to swallow a bird."),
                    ("spider", "That wriggled and wiggled and tickled inside her."),
                ]),

@"There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the bird,
She swallowed the bird to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!"
            }
        };

        [Fact]
        public void FinalVerse_WorksAsExpected()
        {
            string expected =
@"There was an old lady who swallowed a horse...
...She's dead, of course!";

            VerseWriter writer = new VerseWriter();

            string actual = writer.FinalVerse("horse");

            Assert.Equal(expected, actual);
        }
    }
}