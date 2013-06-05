namespace Cooking
{
    using System;

    /// <summary>
    /// Chef class.
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Gets new bowl object.
        /// </summary>
        /// <returns>Bowl object.</returns>
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        /// <summary>
        /// Gets new carrot objcet.
        /// </summary>
        /// <returns>Carrot objcet.</returns>
        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        /// <summary>
        /// Gets new potato objcet.
        /// </summary>
        /// <returns>Potato objcet.</returns>
        private Potato GetPotato()
        {
            return new Potato();
        }

        /// <summary>
        /// Cuts vegetable.
        /// </summary>
        /// <param name="vegatebleToCut">Vegetable to cut.</param>
        private void Cut(Vegetable vegatebleToCut)
        {
            vegatebleToCut.IsCut = true;
        }

        /// <summary>
        /// Peels vegetable.
        /// </summary>
        /// <param name="vegetableToPeal">Vegetable to peel.</param>
        private void Peel(Vegetable vegetableToPeal)
        {
            vegetableToPeal.IsPeeled = true;
        }

        /// <summary>
        /// Cooks smething with potato and a carrot.
        /// </summary>
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}