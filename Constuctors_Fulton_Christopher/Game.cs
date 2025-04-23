using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Fulton_Christopher
{
    class Game
    {

        // Public fields to store the title and genre of the game
        public string title, genre;

        // Constructors with optional parameters, providing default values if none are supplied
        public Game(string titleParam = "Unkown Title", string genreParam = "Casual")
        {
            // Assigns the provided parameters (or defaults) to the class fields
            title = titleParam;
            title = titleParam;
            genre = genreParam;
        }
    }
}