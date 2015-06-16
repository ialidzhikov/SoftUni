using System;

namespace Animals.Animal
{
    public class Cat : Animal, ISoundProducible
    {
        #region Constructors

        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
            
        }

        #endregion

        #region Methods

        public void ProduceSound()
        {
            Console.WriteLine("Myau myau myau!");
        }

        #endregion
    }
}
