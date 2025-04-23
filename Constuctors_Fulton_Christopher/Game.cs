using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Fulton_Christopher
{
    class Game
    {

        public string title, genre;

        public Game(string titleParam = "Unkown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}