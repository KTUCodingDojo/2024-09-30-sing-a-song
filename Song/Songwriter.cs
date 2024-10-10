using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class SongWriter
    {
        private string _song;
        private VerseWriter _verseWriter;
        public SongWriter() 
        {
            _song = string.Empty;
            _verseWriter = new VerseWriter();
        }

        public string Sing(List<Animal> animals)
        {
            if(animals.Count == 0) { return null; }

            Stack<string> stack = new Stack<string>();

            foreach (var animal in animals)
            {
                stack.Push(animal.Name);
            }

            return _verseWriter.WriteVerse(stack, animals[animals.Count - 1].UniqueLine);
        }
    }
}
