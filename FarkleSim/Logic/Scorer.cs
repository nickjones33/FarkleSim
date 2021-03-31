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
            if (Combinations.ThreeOfAKind_Ace(_dice)) rtn.Add(new ScoringCombination(nameof(Combinations.ThreeOfAKind_Ace), 300));
            if (Combinations.ThreeOfAKind_Two(_dice)) rtn.Add(new ScoringCombination(nameof(Combinations.ThreeOfAKind_Two), 200));
            if (Combinations.ThreeOfAKind_Three(_dice)) rtn.Add(new ScoringCombination(nameof(Combinations.ThreeOfAKind_Three), 300));
            if (Combinations.ThreeOfAKind_Four(_dice)) rtn.Add(new ScoringCombination(nameof(Combinations.ThreeOfAKind_Four), 400));
            if (Combinations.ThreeOfAKind_Five(_dice)) rtn.Add(new ScoringCombination(nameof(Combinations.ThreeOfAKind_Five), 500));
            if (Combinations.ThreeOfAKind_Six(_dice)) rtn.Add(new ScoringCombination(nameof(Combinations.ThreeOfAKind_Six), 600));
            return rtn;
        }
    }    
}
