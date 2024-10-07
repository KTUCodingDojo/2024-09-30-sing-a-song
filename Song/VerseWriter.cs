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
            string separator = animals.Count == 1 ? "." : ";";
            string secondSeparator;
            string firstLine = $"There was an old lady who swallowed a {animals[animals.Count - 1]}{separator}{Environment.NewLine}";
            string secondLine = "";
            if(animals.Count > 1)
            {
                secondLine = $"{animalLines[animalLines.Count - 1]}{Environment.NewLine}";
            }
            string rhymeLines = "";
            for (int i = animalLines.Count - 1; i > 0; i--)
            {
                secondSeparator = i == 1 ? ";" : ",";
                rhymeLines += $"She swallowed the {animals[i]} to catch the {animals[i - 1]}{secondSeparator}{Environment.NewLine}";
            }
            string lastLine = $"I don't know why she swallowed a {animals[0]} - perhaps she'll die!";

            return firstLine + secondLine + rhymeLines + lastLine;
        }

    }
}
