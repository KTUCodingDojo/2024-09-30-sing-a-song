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
        private List<Animal> _animals;
        public SongWriter() 
        {
            _song = new StringBuilder();
            _verseWriter = new VerseWriter();
            _animals = new List<Animal>();
        }

        public string Sing(string animal, string uniqueLine)
        {
            _animals.Add(new Animal(animal, uniqueLine));

            if(_song.Length != 0)
            {
                _song.Append(Environment.NewLine + Environment.NewLine);
            }
           
            string verse = _verseWriter.WriteVerse(_animals);
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
