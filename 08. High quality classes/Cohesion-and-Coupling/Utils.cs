namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Utilities class for working with files.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Gets file extension as string.
        /// </summary>
        /// <param name="fileName">File path as string.</param>
        /// <returns>File extension as string.</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new FormatException("Argument has no extension.");
            }
            
            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Gets file name as string.
        /// </summary>
        /// <param name="fileName">File path.</param>
        /// <returns>File name as string.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}