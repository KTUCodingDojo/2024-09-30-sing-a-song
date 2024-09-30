using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song.Tests
{
    public class SongWriterTests
    {
        [Fact]
        public void EmptySongWriterAddSingleAnimal()
        {
            SongWriter writer = new SongWriter();
            List<string> animals = [ "fly" ];
            List<string> animalLines = [ "" ];

            string actual = writer.Sing(animals, animalLines);

            Assert.Equal(@"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!", actual);
        }

        [Fact]
        public void EmptySongWriterAddDifferentSingleAnimal()
        {
            SongWriter writer = new SongWriter();
            List<string> animals = ["tiger"];
            List<string> animalLines = [""];

            string actual = writer.Sing(animals, animalLines);

            Assert.Equal(@"There was an old lady who swallowed a tiger.
I don't know why she swallowed a tiger - perhaps she'll die!", actual);
        }
    }
}

