using System;

namespace Animals.Animal
{
    public class Frog : Animal, ISoundProducible
    {
        #region Constructors

        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
            
        }

        #endregion

        #region Methods

        public void ProduceSound()
        {
            Console.WriteLine("Kwark kwark!");
        }

        #endregion
    }
}
