using System;
using System.Collections.Generic;

namespace PigLatin
{
    class Program
    {
        //THIS DOES NOT SEEM NECESSARY - I would not use this.
        //public static global::System.Object String { get; private set; }

        public static void Main()
        {
            Console.WriteLine("Welcome to PigLatin");
            Console.WriteLine("Please enter a word");
            string word = (Console.ReadLine().ToLower());
            string translateWord = TranslateWord(word);
            Console.WriteLine(translateWord);
            Console.ReadLine();
        }

        public static string TranslateWord(string word)
        {
            //Declaring Variables
            string addYay = "yay";
            string addAy = "ay";
            string vowel = "aeiouy";
            string firstChar = word[0].ToString();
            //check for word begin with Y
            if (firstChar == "y")
            {
                string y = word.Split(word[0])[1];
                string wordEnd = word.Split(word[0])[1];
                word = string.Concat(wordEnd, addYay);
                Console.WriteLine(word + " Translated by first char = y");
                return word;
                //check for word with vowel first character
            }
            else if (vowel.Contains(firstChar))
            {
                Console.WriteLine(word+" Translated by first char = vowel");
                word = string.Concat(word, str1: addYay);
                return word;
                //check for vowel in word and rearrange word
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (vowel.Contains(word[i].ToString()))
                    {
                    string firstVowel = word[i].ToString();
                    string firstHalf = word.Split(word[i])[0];
                    string lastHalf = word.Split(word[i])[1];
                    word = string.Concat(firstVowel, lastHalf, firstHalf, addAy);
                    return word;
                    }
                    Console.WriteLine(word + " Translated by word contains vowel");
                }
                //other wise return a word that adds AY
                Console.WriteLine(word + " Translated by word has no vowels");
                return word = string.Concat(word, addAy);
            }
        }
    }
}


/*public static string TranslatePunctuation(string punctuation)
{
    //int punctuationIndex = punctuation.IndexOfAny(new char[] { '.', ',', '!', '?' });
    string[] allPunctuation = punctuation.Split('.', ',', '!', '?');
    string[] translatedPunctuation = new string[allPunctuation.Length];

    for (int i = 0; i < allPunctuation.Length; i++)
    {
        translatedPunctuation[i] = TranslateWord(allPunctuation[i]);
    }
    //for TESTING
    Console.WriteLine(translatedPunctuation);
    return String.Join(".", ",", "!", "?", translatedPunctuation);
}*/



