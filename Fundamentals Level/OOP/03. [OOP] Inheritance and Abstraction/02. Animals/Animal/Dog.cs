using System;

namespace Animals.Animal
{
    public class Dog : Animal, ISoundProducible
    {
        #region Constructors

        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
            

        }

        #endregion

        #region Methods

        public void ProduceSound()
        {
            Console.WriteLine("Bau bau bau!");
        }

        #endregion
    }
}
