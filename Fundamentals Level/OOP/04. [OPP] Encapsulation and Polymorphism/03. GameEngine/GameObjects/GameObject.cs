using System;

namespace TheSlum.GameObjects
{
    public abstract class GameObject
    {
        private string id;

        protected GameObject(string id)
        {
            this.ID = id;
        }

        public string ID
        {
            get { return this.id; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The id of a game object cannot be null, empty or whitespace.");
                }
                this.id = value;
            }
        }
    }
}
