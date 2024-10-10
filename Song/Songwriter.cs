using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class SongWriter
    {
        private string _song;
        private VerseWriter _verseWriter;
        private Stack<Animal> _animalStack;
        public SongWriter() 
        {
            _song = string.Empty;
            _verseWriter = new VerseWriter();
            _animalStack = new Stack<Animal>();
        }

        public string Sing(string animal, string uniqueLine)
        {
            _animalStack.Push(new Animal(animal, uniqueLine));

            return _verseWriter.WriteVerse(new Stack<Animal>(_animalStack.Reverse()));
        }
    }
}
