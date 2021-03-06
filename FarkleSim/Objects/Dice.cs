using FarkleSim.Logic;
using System;
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
        public void PrintPlays()
        {
            StringBuilder rtn = new();
            rtn.Append("Plays: ");

            Scorer scorer = new Scorer(DieArray);
            var plays = scorer.GetPlays().OrderByDescending(p => p.Value);
            if (plays.Any()) {

                foreach (var scoreCombination in plays)
                {
                    rtn.Append($"({scoreCombination.Label}: {scoreCombination.Value}), ");
                }
                Console.WriteLine(rtn.ToString());
            }
        }
        public void PrintContents()
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
            if (LockedDice.Any() || UnlockedDice.Any())
            {
                Console.WriteLine(rtn.ToString());
            }
        }
        private List<Die> DieArray { get; set; }
        public List<Die> LockedDice => DieArray.Where(d => d.Locked).ToList();
        public List<Die> UnlockedDice => DieArray.Where(d => !d.Locked).ToList();
    }
}
