using FarkleSim.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarkleSim.Objects
{
    public class Dice
    {
        public Dice()
        {
            DieArray = new List<Die>();
        }
        public void RollSix()
        {
            DieArray.Clear();
            for (int i = 0; i < 6; i++)
            {
                DieArray.Add(new Die());
            }
        }
        public void LockDie(int i)
        {
            DieArray[i].LockDie();
        }
        public string PrintPlays()
        {
            StringBuilder rtn = new();
            rtn.Append("Plays: ");

            Scorer scorer = new Scorer(DieArray);
            var plays = scorer.GetPlays();
            foreach (var play in plays)
            {
                rtn.Append($"({play.Name}: {play.Value}), ");
            }
            return rtn.ToString();
        }
        public string PrintContents()
        {
            StringBuilder rtn = new();
            rtn.Append("Player's Dice Info ");
            if (LockedDice.Any())
            {
                rtn.Append("Locked: [");
                foreach (var die in LockedDice)
                {
                    rtn.Append($"{die.Value},");
                }
                rtn.Remove(rtn.Length - 1, 1);
                rtn.Append("]; ");
            }
            if (UnlockedDice.Any())
            {
                rtn.Append("Unlocked: [");
                foreach (var die in UnlockedDice)
                {
                    rtn.Append($"{die.Value},");
                }
                rtn.Remove(rtn.Length - 1, 1);
                rtn.Append("]; ");
            }
            return rtn.ToString();
        }
        private List<Die> DieArray { get; set; }
        public List<Die> LockedDice => DieArray.Where(d => d.Locked).ToList();
        public List<Die> UnlockedDice => DieArray.Where(d => !d.Locked).ToList();
    }
}
