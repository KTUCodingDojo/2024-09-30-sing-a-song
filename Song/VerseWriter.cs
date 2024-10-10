using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class VerseWriter
    {
        public VerseWriter() { }
        public string WriteVerse(Stack<Animal> animals)
        {
            StringBuilder sb = new StringBuilder();

            Animal currentAnimal = animals.Pop();

            sb.Append($"There was an old lady who swallowed a {currentAnimal}");

            if(animals.Count == 0)
            {
                sb.AppendLine(".");
                sb.Append($"I don't know why she swallowed a {currentAnimal} - perhaps she'll die!");
                return sb.ToString();
            }
            
            sb.AppendLine(";");
            sb.AppendLine(currentAnimal.UniqueLine);

            while (animals.Count > 1) 
            {
                sb.AppendLine($"She swallowed the {currentAnimal} to catch the {currentAnimal = animals.Pop()},");
            }
            sb.AppendLine($"She swallowed the {currentAnimal} to catch the {currentAnimal = animals.Pop()};");

            sb.Append($"I don't know why she swallowed a {currentAnimal} - perhaps she'll die!");

            return sb.ToString();
        }

        public string FinalVerse(string animal)
        {
            return 
@$"There was an old lady who swallowed a {animal}...
...She's dead, of course!";
        }
    }
}
