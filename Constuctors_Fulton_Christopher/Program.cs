using System;

namespace Constructors_Fulton_Christopher
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre} game!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is {myOtherGame.genre} game!");
        }
    }
}