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
        public string WriteVerse(List<string> animals, List<string> animalLines)
        {
            return $"There was an old lady who swallowed a {animals[0]}.{Environment.NewLine}" +
                 $"I don't know why she swallowed a {animals[0]} - perhaps she'll die!";
        }

    }
}
