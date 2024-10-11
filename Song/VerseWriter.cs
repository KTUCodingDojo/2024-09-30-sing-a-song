using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class VerseWriter
    {
        private List<string> _lines;
        private string _lastAnimalName;
        public VerseWriter() 
        {
            _lines = new List<string>();
            _lastAnimalName = string.Empty;
        }
        public string WriteVerse(Animal animal)
        {
            if(_lines.Count == 0)
            {
                _lines.Add($"There was an old lady who swallowed a {animal.Name}.");
                _lines.Add($"I don't know why she swallowed a {animal.Name} - perhaps she'll die!");
                _lastAnimalName = animal.Name;
                return ParseVerse();
            }

            _lines[0] = $"There was an old lady who swallowed a {animal.Name};";

            if (_lines.Count == 2) 
            {
                _lines.Insert(1, animal.UniqueLine);
            }
            else
            {
                _lines[1] = animal.UniqueLine;
            }

            _lines.Insert(2, $"She swallowed the {animal.Name} to catch the {_lastAnimalName}");

            _lastAnimalName = animal.Name;
            return ParseVerse();
        }

        private string ParseVerse()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(_lines[0]);
            
            if(_lines.Count > 2)
            {
                sb.AppendLine(_lines[1]);

                for (int i = 2; i < _lines.Count - 2; i++)
                {
                    sb.AppendLine(_lines[i] + ",");
                }

                sb.AppendLine(_lines[_lines.Count - 2] + ";");
            }

            sb.Append(_lines[_lines.Count - 1]);

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
