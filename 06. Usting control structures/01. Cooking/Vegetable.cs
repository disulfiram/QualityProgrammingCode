namespace Cooking
{
    using System;

    /// <summary>
    /// Vegetable class.
    /// </summary>
    public class Vegetable
    {
        private bool isPeeled = false;
        private bool isCut = false;
        private bool isFresh = true;
        
        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }
            set
            {
                if (value == false)
                {
                    throw new InvalidOperationException("Cannot unpeel food.");
                }
                this.isPeeled = value;
            }
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }
            set
            {
                if (value == false)
                {
                    throw new InvalidOperationException("Cannot uncut food.");
                }
                this.isCut = value;
            }
        }

        public bool IsFresh
        {
            get
            {
                return this.isFresh;
            }
            set
            {
                this.isFresh = value;
            }
        }
    }
}