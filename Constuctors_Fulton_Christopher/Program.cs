using System;

namespace Constructors_Fulton_Christopher
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // Creates a new instance of the Game class using the parameterized constructor
            Game myGame = new Game("CS:GO", "FPS");

            // Outputs the title and genre of the first game to the console
            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre} game!");

            // Creates a new instance of the Game class using the default constructor
            Game myOtherGame = new Game();

            // Outputs the title and genre of the second game to the console
            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is {myOtherGame.genre} game!");
        }
    }
}
