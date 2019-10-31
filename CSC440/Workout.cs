using System;
using System.Collections.Generic;

namespace CSC440
{
    public class Workout
    {
        private TimeSpan duration;

        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration
        {
            get
            {
                return EndTime - StartTime;
            }
        }
        public ICollection<Exercise> Exercises { get; set; }


        public Workout()
        {
            this.StartTime = DateTime.Now;
            this.Name = DateTime.Today.ToString();
        }
    }
}
