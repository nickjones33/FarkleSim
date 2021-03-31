using System;

namespace FarkleSim.Objects
{
    public class Die
    {
        private readonly Random rng;
        public Die()
        {
            rng = new Random();
            decimal rnd = rng.Next(6);
            var floor = Math.Floor(rnd);
            Value = (int)floor+1;
        }
        public int Value { get; }
        public bool Locked => _locked;
        private bool _locked { get; set; } = false;
        public void LockDie()
        {
            _locked = true;
        }

    }
}
