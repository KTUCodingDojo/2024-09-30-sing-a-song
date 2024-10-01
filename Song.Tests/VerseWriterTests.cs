using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song.Tests
{
    public class VerseWriterTests
    {
        [Fact]
        public void WriteFirstVerse()
        {
            string expected = @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!";
            VerseWriter writer = new VerseWriter();

            List<string> animals = ["fly"];
            List<string> animalLines = [""];


            string actual = writer.WriteVerse(animals, animalLines);
            
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void WriteSecondVerse() // needs more code, prob
        {
            string expected = @"There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!";

            VerseWriter writer = new VerseWriter();

            List<string> animals = ["fly", "spider"];
            List<string> animalLines = ["", "That wriggled and wiggled and tickled inside her."];


            string actual = writer.WriteVerse(animals, animalLines);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void WriteThirdVerse() // needs more code, prob
        {
            string expected = @"There was an old lady who swallowed a bird;
How absurd to swallow a bird.
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!";

            VerseWriter writer = new VerseWriter();

            List<string> animals = ["fly", "spider", "bird"];
            List<string> animalLines = ["", "That wriggled and wiggled and tickled inside her.", "How absurd to swallow a bird."];


            string actual = writer.WriteVerse(animals, animalLines);

            Assert.Equal(expected, actual);

        }

    }
}
