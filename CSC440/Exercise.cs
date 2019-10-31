using System;
using System.Collections.Generic;

namespace CSC440
{
    /* Module 4 Lesson 1 Creating Classes
     * Creating a class:
     * 1: Include the appropriate access modifier (private, public, internal etc)
     * 2: Include the class keyword
     * 3: Name the class (By convention in upper case)
     *
     * Defining Constructors:
     * 1: Access Modifier
     * 2: Same name as class
     * 3: Mandatory parameters
     * 4: Using "this" keyword for explicit assignment
     */
    public class Exercise
    {
        // Adding class members:
        // The following properties implement
        public string Name { get; private set; }

        // The private set indicates that the property
        // can only be set once through the constructor.
        public string MuscleGroup { get; private set; }
        public ICollection<Set> Sets { get; set; }


        // This is the class constructor. You use this method to identify
        // what parameteres are mandatory when creating an object.
        public Exercise(string name, string muscleGroup)
        {
            // The this keyword is not required in this example,
            // but companies may require it for other reasons.
            this.Name = name;
            this.MuscleGroup = muscleGroup;
        }
    }
}
