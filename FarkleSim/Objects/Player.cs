using System.Linq;
using System.Text;

namespace FarkleSim.Objects
{
    public class Player
    {
        public Dice Dice { get; }
        public Player()
        {
            Dice = new Dice();
        }
        public void StartTurn()
        {
            Dice.RollSix();
        }        
    }
}
