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
    }
}