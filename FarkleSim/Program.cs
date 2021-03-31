using System;

namespace FarkleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i ++)
            {
                var player = new Objects.Player();
                player.StartTurn();
                player.Dice.PrintContents();
                player.Dice.PrintPlays();
            }
        }
    }
}
