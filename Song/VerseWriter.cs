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
            bool multipleAnimals = animals.Count > 1 ? true : false;
            Animal currentAnimal = animals.Pop();

            if(!multipleAnimals)
            {
                sb.AppendLine($"There was an old lady who swallowed a {currentAnimal}.");
            }
            else
            {
                sb.AppendLine($"There was an old lady who swallowed a {currentAnimal};");
                sb.AppendLine(currentAnimal.UniqueLine);
            }

            while (animals.Count > 1)
            {
                sb.AppendLine($"She swallowed the {currentAnimal} to catch the {currentAnimal = animals.Pop()},");
            }

            Animal lastAnimal;
            if (multipleAnimals)
            {
                lastAnimal = animals.Pop();
                sb.AppendLine($"She swallowed the {currentAnimal} to catch the {lastAnimal};");
            }
            else
            {
                lastAnimal = currentAnimal;
            }

            sb.Append($"I don't know why she swallowed a {lastAnimal} - perhaps she'll die!");

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
