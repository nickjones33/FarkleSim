namespace FarkleSim.Objects
{
    public class ScoringCombination
    {
        public ScoringCombinations Combo { get; set; }
        public string Label
        {
            get
            {
                return Combo switch
                {
                    ScoringCombinations.ThreeOfAKind_Aces => "Three of a kind - Aces",
                    ScoringCombinations.ThreeOfAKind_Twos => "Three of a kind - Twos",
                    ScoringCombinations.ThreeOfAKind_Threes => "Three of a kind - Threes",
                    ScoringCombinations.ThreeOfAKind_Fours => "Three of a kind - Fours",
                    ScoringCombinations.ThreeOfAKind_Fives => "Three of a kind - Fives",
                    ScoringCombinations.ThreeOfAKind_Sixes => "Three of a kind - Sixes",
                    ScoringCombinations.FourOfAKind => "Four of a kind",
                    ScoringCombinations.FiveOfAKind => "Five of a kind",
                    ScoringCombinations.SixOfAKind => "Six of a kind",
                    ScoringCombinations.Straight => "Straight 1-6",
                    ScoringCombinations.ThreePairs => "Three Pairs",
                    ScoringCombinations.TwoTriplets => "Two Triplets",
                    ScoringCombinations.FourAndPair => "Four of a kind and a Pair",
                    _ => "Unhandled Scoring Combination Label",
                };
            }
        }
        public int Value
        {
            get
            {
                return Combo switch
                {
                    ScoringCombinations.ThreeOfAKind_Aces => 300,
                    ScoringCombinations.ThreeOfAKind_Twos => 200,
                    ScoringCombinations.ThreeOfAKind_Threes => 300,
                    ScoringCombinations.ThreeOfAKind_Fours => 400,
                    ScoringCombinations.ThreeOfAKind_Fives => 500,
                    ScoringCombinations.ThreeOfAKind_Sixes => 600,
                    ScoringCombinations.FourOfAKind => 1000,
                    ScoringCombinations.FiveOfAKind => 2000,
                    ScoringCombinations.SixOfAKind => 3000,
                    ScoringCombinations.Straight => 1500,
                    ScoringCombinations.ThreePairs => 1500,
                    ScoringCombinations.TwoTriplets => 2500,
                    ScoringCombinations.FourAndPair => 1500,
                    _ => 0,
                };
            }
        }
        public ScoringCombination(ScoringCombinations combo)
        {
            Combo = combo;
        }
    }
    public enum ScoringCombinations
    {
        ThreeOfAKind_Aces,
        ThreeOfAKind_Twos,
        ThreeOfAKind_Threes,
        ThreeOfAKind_Fours,
        ThreeOfAKind_Fives,
        ThreeOfAKind_Sixes,
        FourOfAKind,
        FiveOfAKind,
        SixOfAKind,
        Straight,
        ThreePairs,
        TwoTriplets,
        FourAndPair
    }
}
