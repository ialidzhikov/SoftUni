using System;

namespace Animals.Animal
{
    public class Kitten : Animal, ISoundProducible
    {
        #region Constructors

        public Kitten(string name, int age) : base(name, age, "Male")
        {
            
        }

        #endregion

        #region Methods

        public void ProduceSound()
        {
            Console.WriteLine("Myauuu myauuu myauuuuuu!");
        }

        #endregion
    }
}
