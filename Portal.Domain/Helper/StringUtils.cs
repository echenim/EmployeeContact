using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Domain.Helper
{
    public static class StringUtils
    {

        public static string FirstLetter(string word)
            => !string.IsNullOrEmpty(word) ? 
            word.Split(' ').Select(s => s[0]).FirstOrDefault().ToString()
            :string.Empty;

        /// <summary>
        /// methodd to get first character in a word or sentence
        /// </summary>
        /// <param name="word">parameter will be either a word or a sentence</param>
        /// <returns>char</returns>
        public static string OptimizedFirstLetter(string word) 
            =>!string.IsNullOrEmpty(word) ? word.Trim().Where((ch, index) 
                => ch != ' ' &&  (index == 0 || word[index - 1] == ' '))
            .FirstOrDefault().ToString().ToUpper() : string.Empty;




    }
}
