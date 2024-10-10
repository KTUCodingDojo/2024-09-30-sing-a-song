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
        public string WriteVerse(List<Animal> animals)
        {
            if(animals.Count == 0) { throw new InvalidOperationException("List must contain atleast one Animal."); }

            StringBuilder sb = new StringBuilder();

            sb.Append($"There was an old lady who swallowed a {animals[animals.Count - 1].Name}");

            if(animals.Count >= 2)
            {
                sb.AppendLine(";");

                sb.AppendLine(animals[animals.Count - 1].UniqueLine);

                for (int i = animals.Count - 1; i > 1; i--)
                {
                    sb.AppendLine($"She swallowed the {animals[i]} to catch the {animals[i - 1]},");
                }
                sb.AppendLine($"She swallowed the {animals[1]} to catch the {animals[0]};");

            }
            else
            {
                sb.AppendLine(".");
            }

            sb.Append($"I don't know why she swallowed a {animals[0]} - perhaps she'll die!");


            return sb.ToString();

            //Animal currentAnimal = animals.Pop();

            //sb.Append($"There was an old lady who swallowed a {currentAnimal}");

            //if(animals.Count == 0)
            //{
            //    sb.AppendLine(".");
            //    sb.Append($"I don't know why she swallowed a {currentAnimal} - perhaps she'll die!");
            //    return sb.ToString();
            //}

            //sb.AppendLine(";");
            //sb.AppendLine(currentAnimal.UniqueLine);

            //while (animals.Count > 1) 
            //{
            //    sb.AppendLine($"She swallowed the {currentAnimal} to catch the {currentAnimal = animals.Pop()},");
            //}
            //sb.AppendLine($"She swallowed the {currentAnimal} to catch the {currentAnimal = animals.Pop()};");

            //sb.Append($"I don't know why she swallowed a {currentAnimal} - perhaps she'll die!");

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
