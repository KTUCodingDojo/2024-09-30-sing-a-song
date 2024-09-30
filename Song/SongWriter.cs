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
        public string Sing(string animal, string animalLine)
        {
            VerseWriter verserWriter = new VerseWriter();
            return verserWriter.WriteVerse(animal, animalLine);
        }
    }
}
