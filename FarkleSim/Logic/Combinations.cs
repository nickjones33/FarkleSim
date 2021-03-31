using FarkleSim.Objects;
using System.Collections.Generic;
using System.Linq;

namespace FarkleSim.Logic
{
    public static class Combinations
    {
        public static class ThreeOfAKind
        {
            public static bool Ace(List<Die> dice)
            {
                return dice.Where(d => d.Value == 1).Count() >= 3;
            }
            public static bool Two(List<Die> dice)
            {
                return dice.Where(d => d.Value == 2).Count() >= 3;
            }
            public static bool Three(List<Die> dice)
            {
                return dice.Where(d => d.Value == 3).Count() >= 3;
            }
            public static bool Four(List<Die> dice)
            {
                return dice.Where(d => d.Value == 4).Count() >= 3;
            }
            public static bool Five(List<Die> dice)
            {
                return dice.Where(d => d.Value == 5).Count() >= 3;
            }
            public static bool Six(List<Die> dice)
            {
                return dice.Where(d => d.Value == 6).Count() >= 3;
            }
        }
        public static bool FourOfAKind(List<Die> dice)
        {
            return dice.GroupBy(d => d.Value).OrderByDescending(g => g.Key).First().Count() == 4;
        }
        public static bool FiveOfAKind(List<Die> dice)
        {
            return dice.GroupBy(d => d.Value).OrderByDescending(g => g.Key).First().Count() == 5;
        }
        public static bool SixOfAKind(List<Die> dice)
        {
            return dice.GroupBy(d => d.Value).OrderByDescending(g => g.Key).First().Count() == 6;
        }
        public static bool Straight(List<Die> dice)
        {
            return dice.GroupBy(d => d.Value).Count() == 6;
        }
        public static bool ThreePairs(List<Die> dice)
        {
            var groupedDice = dice.GroupBy(d => d.Value);
            return groupedDice.Count() == 3 && groupedDice.All(g => g.Count() == 2);
        }
        public static bool TwoTriplets(List<Die> dice)
        {
            var groupedDice = dice.GroupBy(d => d.Value);
            return groupedDice.Count() == 2 && groupedDice.All(g => g.Count() == 3);
        }
        public static bool FourWithPair(List<Die> dice)
        {
            var groupedDice = dice.GroupBy(d => d.Value);
            return groupedDice.Count() == 2 && groupedDice.Any(g => g.Count() == 4);
        }
    }
}
