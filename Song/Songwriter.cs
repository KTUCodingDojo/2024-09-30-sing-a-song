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

        public string Sing(string animal, string uniqueLine)
        {
            return _verseWriter.SingVerse(animal, uniqueLine);
        }
    }
}
