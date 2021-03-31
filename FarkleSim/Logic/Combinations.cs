using FarkleSim.Objects;
using System.Collections.Generic;
using System.Linq;

namespace FarkleSim.Logic
{
    public static class Combinations
    {
        public static bool ThreeOfAKind_Ace(List<Die> dice)
        {
            return dice.Where(d => d.Value == 1).Count() >= 3;            
        }
        public static bool ThreeOfAKind_Two(List<Die> dice)
        {
            return dice.Where(d => d.Value == 2).Count() >= 3;
        }
        public static bool ThreeOfAKind_Three(List<Die> dice)
        {
            return dice.Where(d => d.Value == 3).Count() >= 3;
        }
        public static bool ThreeOfAKind_Four(List<Die> dice)
        {
            return dice.Where(d => d.Value == 4).Count() >= 3;
        }
        public static bool ThreeOfAKind_Five(List<Die> dice)
        {
            return dice.Where(d => d.Value == 5).Count() >= 3;
        }
        public static bool ThreeOfAKind_Six(List<Die> dice)
        {
            return dice.Where(d => d.Value == 6).Count() >= 3;
        }
    }
}
