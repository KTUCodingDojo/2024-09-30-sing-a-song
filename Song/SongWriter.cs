using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class SongWriter
    {
        public string Sing(List<string> animals, List<string> animalLines)
        {
            VerseWriter verserWriter = new VerseWriter();
            return verserWriter.WriteVerse(animals, animalLines);
        }
    }
}
