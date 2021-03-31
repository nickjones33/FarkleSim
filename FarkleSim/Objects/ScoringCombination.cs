namespace FarkleSim.Objects
{
    public class ScoringCombination
    {
        public string Name { get; }
        public int Value { get; }
        public ScoringCombination(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
