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

            if (animals.Count == 1) 
            {
                return verserWriter.WriteVerse(animals, animalLines);
            }
            
            else
            {
                List<string> newAnimals = new List<string>();
                List<string> newAnimalsLines = new List<string>();
                newAnimals.Add(animals[0]);
                newAnimalsLines.Add(animalLines[0]);

                string firstVerse = verserWriter.WriteVerse(newAnimals, newAnimalsLines) + Environment.NewLine+Environment.NewLine;
                string otherVerses = "";
                for (int i = 1; i < animals.Count; i++)
                {
                    newAnimals.Add(animals[i]);
                    newAnimalsLines.Add(animalLines[i]);
                    if (i < animals.Count - 1)
                    {
                        otherVerses += verserWriter.WriteVerse(newAnimals, newAnimalsLines) + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        otherVerses += verserWriter.WriteVerse(newAnimals, newAnimalsLines);
                    }
                    
                }
                
                return firstVerse + otherVerses;
            }
            


            
        }
    }
}
