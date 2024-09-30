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
        public string Sing(string animal, string animalLine)
        {
            return "There was an old lady who swallowed a " + animal + ".\r\n" +
                 "I don't know why she swallowed a fly - perhaps she'll die!";
        }
    }
}
