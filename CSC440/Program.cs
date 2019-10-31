using System;


namespace CSC440
{
    class Program
    {
        static void Main(string[] args)
        {
            Workout wk = new Workout();
            Exercise benchPress = new Exercise("Bench Press", "Chest");
            Exercise chestPress = new Exercise("Chest Press", "Chest");
            Exercise lateralRaise = new Exercise("Lateral Raise", "Shoulder");
            wk.Exercises.Add(benchPress);
            wk.Exercises.Add(chestPress);
            wk.Exercises.Add(lateralRaise);
        }
    }
}
