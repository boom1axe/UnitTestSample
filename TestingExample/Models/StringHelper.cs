using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingExample.Models
{
    public class StringHelper
    {
        /// <summary>
        /// Ensures <paramref name="fileName"/> ends with .txt
        /// (not case sensitive)
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsTextFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return false;
            }

            fileName = fileName.Trim().ToLower();

            if(!fileName.EndsWith(".txt"))
            {
                return false;
            }

            if (fileName)
            {

            }

            return true;
        }

        private static bool DoesContainSpecialCharacters(string name)
        {
            // < > $ % ^ &
            if (name.Contains("<") || name.Contains(">") || name.Contains("$"))
            {
                return true;
            }
            return false;
        }
    }
}
