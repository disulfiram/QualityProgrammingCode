using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// Sample singleton object.
    /// </summary>
    public sealed class SiteStructure
    {
        /// <summary>
        /// This is an expensive resource.
        /// We need to only store it in one place.
        /// </summary>
        List <object> data = new List<object>(10);

        /// <summary>
        /// Allocate ourselves.
        /// We have a private constructor, so no one else can.
        /// </summary>
        static readonly SiteStructure _instance = new SiteStructure();

        /// <summary>
        /// Access SiteStructure.Instance to get the singleton object.
        /// Then call methods on that instance.
        /// </summary>
        public static SiteStructure Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Adds an object for the tests.
        /// </summary>
        /// <param name="objectToBeAdded">Object to be added.</param>
        public void AddObject(object objectToBeAdded)
        {
            this.data.Add(objectToBeAdded);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int siteObject = 0; siteObject < data.Count; siteObject++)
            {
                result.AppendLine(data[siteObject].ToString());
            }
            return result.ToString();
        }

        /// <summary>
        /// This is a private constructor, meaning no outsiders have access.
        /// </summary>
        private SiteStructure()
        {
            // Initialize members here.
        }
    }
}