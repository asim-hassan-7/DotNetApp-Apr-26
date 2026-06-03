using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetApp
{
    public static class StringExtensions
    {

        public static string ToPascalCase(this string strng)
        {

            var newStr = "";
            var wordArr = strng.Split(" ");


            foreach (var word in wordArr)
            {

                char fc = word[0];  //fc = l
                fc = char.ToUpper(fc); //fc = L

                var newWord = fc + word.Substring(1).ToLower(); // + ogic
                newStr += newWord; //Logic


            }
            return newStr;


        }



        public static string ToCamelCase(this string strng)
        {
            var newStr = "";
            var wordArr = strng.Split(" ");

            foreach (var word in wordArr)
            {
                if (word == wordArr[0])
                {

                    newStr += word.ToLower();
                }
                else
                {
                    char fc = word[0];
                    fc = char.ToUpper(fc);

                    var newWord = fc + word.Substring(1).ToLower();
                    newStr += newWord;
                }


            }
            return (newStr);

        }

    }

}
            

      

    
