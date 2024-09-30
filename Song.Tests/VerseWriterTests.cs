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
        public void WriteSecondVerse()
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


    }
}
