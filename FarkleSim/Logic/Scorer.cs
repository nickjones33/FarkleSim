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
            if (Combinations.ThreeOfAKind.Ace(_dice)) rtn.Add(new ScoringCombination("Three Aces", 300));
            if (Combinations.ThreeOfAKind.Two(_dice)) rtn.Add(new ScoringCombination("Three Twos", 200));
            if (Combinations.ThreeOfAKind.Three(_dice)) rtn.Add(new ScoringCombination("Three Threes", 300));
            if (Combinations.ThreeOfAKind.Four(_dice)) rtn.Add(new ScoringCombination("Three Fours", 400));
            if (Combinations.ThreeOfAKind.Five(_dice)) rtn.Add(new ScoringCombination("Three Fives", 500));
            if (Combinations.ThreeOfAKind.Six(_dice)) rtn.Add(new ScoringCombination("Three Sixes", 600));
            if (Combinations.FourOfAKind(_dice)) rtn.Add(new ScoringCombination("Four of a kind", 1000));
            if (Combinations.FiveOfAKind(_dice)) rtn.Add(new ScoringCombination("Five of a kind", 2000));
            if (Combinations.SixOfAKind(_dice)) rtn.Add(new ScoringCombination("Six of a kind", 3000));
            if (Combinations.Straight(_dice)) rtn.Add(new ScoringCombination("Straight 1-6", 1500));
            if (Combinations.ThreePairs(_dice)) rtn.Add(new ScoringCombination("Three Pairs", 1500));
            if (Combinations.TwoTriplets(_dice)) rtn.Add(new ScoringCombination("Two Triplets", 2500));
            if (Combinations.FourWithPair(_dice)) rtn.Add(new ScoringCombination("Four of a kind and a Pair", 1500));
            return rtn;
        }
    }    
}
