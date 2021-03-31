using FarkleSim.Objects;
using System.Collections.Generic;

namespace FarkleSim.Logic
{
    public class Scorer
    {
        private readonly List<Die> _dice;
        public Scorer(List<Die> dice)
        {
            _dice = dice;
        }
        public List<ScoringCombination> GetPlays()
        {
            var rtn = new List<ScoringCombination>();
            if (Combinations.ThreeOfAKind.Ace(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreeOfAKind_Aces));
            if (Combinations.ThreeOfAKind.Two(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreeOfAKind_Twos));
            if (Combinations.ThreeOfAKind.Three(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreeOfAKind_Threes));
            if (Combinations.ThreeOfAKind.Four(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreeOfAKind_Fours));
            if (Combinations.ThreeOfAKind.Five(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreeOfAKind_Fives));
            if (Combinations.ThreeOfAKind.Six(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreeOfAKind_Sixes));
            if (Combinations.FourOfAKind(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.FourOfAKind));
            if (Combinations.FiveOfAKind(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.FiveOfAKind));
            if (Combinations.SixOfAKind(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.SixOfAKind));
            if (Combinations.Straight(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.Straight));
            if (Combinations.ThreePairs(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.ThreePairs));
            if (Combinations.TwoTriplets(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.TwoTriplets));
            if (Combinations.FourWithPair(_dice)) rtn.Add(new ScoringCombination(ScoringCombinations.FourAndPair));
            return rtn;
        }
    }    
}
