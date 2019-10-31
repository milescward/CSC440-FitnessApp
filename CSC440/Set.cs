namespace CSC440
{
    public class Set
    {
        public int Weight { get; private set; }
        public int Repetitions { get; private set; }
        public int SetNumber { get; private set; }

        public Set(int weight, int reps, int setNum)
        {
            this.Weight = weight;
            this.Repetitions = reps;
            this.SetNumber = setNum;
        }
    }
}