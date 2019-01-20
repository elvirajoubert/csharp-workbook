using System;
namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to PigLatin");
            Console.WriteLine("Please enter a word");
            string input = (Console.ReadLine().ToLower());
            string translateWord = TranslateWord(word);
            Console.WriteLine(translateWord);
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
        //declared variables:

        string addYay= "yay";
        string addAy = "ay";
        string vowel = "aeiouy";
        string firstChar = word[0].ToString();
        //check if your word starts with "y"


        if(firstChar == "y")
        {
            string y = word.Split(word[0])[1];
            string wordEnd = word.Split(word[0])[1];
            word =string.Concat(wordEnd, addYay);
            Console.WriteLine(word);
            return word;
        //check if vowel is first character

        } else if (vowel.Contains(firstChar))
            {
            word = string.Concat(word, addYay);
            return word;

            
        } else
        {
            {
                for (int i=0; i<word.Length; i++)
                {
                    if (vowel.Contains(word[i]))
                    {
                        string firstVowel = word[i].ToString();
                        string firstHalf = word.Split(word[i])[1];
                        string lastHalf = word.Split(word[i])[1];
                        word = string.Concat(firstVowel, lastHalf,firstHalf, addAy);
                        return word;
                        return word = string.Concat(word, addAy);
                    }
                    
    
        private static string TranslatePunctuation (string punctuation)
        {
            //int punctuationIndex = punctuation.IndexOfAny(new char[] { '.', ',', '!', '?' });
            string[] allPunctuation = punctuation.Split('.', ',', '!', '?');
            string[] translatedPunctuation = new string[allPunctuation.Length];

            for (int i= 0; i < allPunctuation.Length; i++)
            {
                translatedPunctuation[i] = TranslateWord(allPunctuation[i]);
            }
            return String.Join('.', ',', '!', '?', translatedPunctuation);

        }
    }
}

    