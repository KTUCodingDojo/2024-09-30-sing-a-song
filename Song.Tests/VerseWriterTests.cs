using System.Security.Cryptography;
using System;
using System.Text;

namespace Song.Tests
{
    public class VerseWriterTests
    {
        [Fact]
        public void SingVerse_SingleAnimalVerse()
        {
            VerseWriter writer = new VerseWriter();
            string actual = writer.SingVerse("fly", "");

            Assert.Equal(
                $"There was an old lady who swallowed a fly.{Environment.NewLine}" +
                $"I don't know why she swallowed a fly - perhaps she'll die!",

                actual);
        }
    }
}