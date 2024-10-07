using System.Text;

namespace Song.Tests
{
    public class AprovalTest
    {
        [Fact]
        public Task Test()
        {
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            
            Song.Program.Main(new string[] { });
            var output = fakeOutput.ToString();

            return Verifier.Verify(output);
        }

        [Fact]
        public Task FinalTest()
        {
            SongWriter writer = new SongWriter();
            List<string> animals = ["fly", "spider", "bird", "cat", "dog", "cow"];
            List<string> animalLines = ["", "That wriggled and wiggled and tickled inside her.", "How absurd to swallow a bird.", "Fancy that to swallow a cat!", "What a hog, to swallow a dog!", "I don't know how she swallowed a cow!"];
            var generatedSong = new StringReader(writer.Sing(animals, animalLines));


           // var fakeOutput = new StringBuilder();
           // Console.SetOut(new StringWriter(fakeOutput));

            Song.Program.Main(new string[] { });
            var output = generatedSong.ToString();

            return Verifier.Verify(output);

        }

    }
}