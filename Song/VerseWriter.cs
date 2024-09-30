using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class VerseWriter
    {
        public string WriteVerse(string animal, string animalLine)
        {
            return $"There was an old lady who swallowed a {animal}.{Environment.NewLine}" +
                 $"I don't know why she swallowed a {animal} - perhaps she'll die!";
        }
    }
}
