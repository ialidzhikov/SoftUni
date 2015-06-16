using System;

namespace Animals.Animal
{
    public class Tomcat : Animal, ISoundProducible
    {
        #region Constructors

        public Tomcat(string name, int age) : base(name, age, "Female")
        {
            
        }

        #endregion

        #region Methods

        public void ProduceSound()
        {
            Console.WriteLine("Mmmmmmmmyau!!");
        }

        #endregion
    }
}
