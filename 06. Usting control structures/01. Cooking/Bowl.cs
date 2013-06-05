namespace Cooking
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        /// <summary>
        /// Contents of bowl.
        /// </summary>
        private List<Vegetable> contents;

        /// <summary>
        /// Initializes a new instance of the Bowl class.
        /// </summary>
        public Bowl()
        {
        }

        /// <summary>
        /// Gets or sets contents of bowl.
        /// </summary>
        public List<Vegetable> Contetnts
        {
            get
            {
                return this.contents;
            }
            set
            {
                this.contents = value;
            }
        }

        /// <summary>
        /// Adds a vegetable into the bowl.
        /// </summary>
        /// <param name="vegetableToAdd">Vegetable.</param>
        public void Add(Vegetable vegetableToAdd)
        {
            this.contents.Add(vegetableToAdd);
        }
    }
}