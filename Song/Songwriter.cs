using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class SongWriter
    {
        private StringBuilder _song;
        private VerseWriter _verseWriter;
        private Stack<Animal> _animalStack;
        public SongWriter() 
        {
            _song = new StringBuilder();
            _verseWriter = new VerseWriter();
            _animalStack = new Stack<Animal>();
        }

        public string Sing(string animal, string uniqueLine)
        {
            _animalStack.Push(new Animal(animal, uniqueLine));

            if(_song.Length != 0)
            {
                _song.Append(Environment.NewLine + Environment.NewLine);
            }
           
            string verse = _verseWriter.WriteVerse(new Stack<Animal>(_animalStack.Reverse()));
            _song.Append(verse);

            return _song.ToString();
        }

        public string FinishSong(string animal)
        {
            _song.Append(Environment.NewLine + Environment.NewLine);

            _song.Append(_verseWriter.FinalVerse(animal));

            return _song.ToString();
        }
    }
}
