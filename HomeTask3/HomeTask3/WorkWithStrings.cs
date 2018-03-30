using System;
using System.Linq;

namespace HomeTask3
{
    class WorkWithStrings
    {
        string text;
        int longestSentence;

        public WorkWithStrings()
        {
            text = "Here comes a traveller.Let us see who can strip him of his cloak?Said the Sun.";
        }

        public void LongestSentence()
        {
            Console.WriteLine("***Fun with sentences***\n");

            //split text to sentences
            string[] sentences = text.Split(new char[] { '.', '!', '?' });

            //array number of sentences
            int[] intArray = new int[sentences.Length];

            //count number of words in each sentence
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(new char[] { ' ' });

                intArray[i] = words.Length;
            }

            //The largest element of the counting array of words
            longestSentence = intArray.OrderByDescending(x => x).First();
            Console.WriteLine("The longest sentence in the text has {0} words",longestSentence);
        }

        //demo version of string
        public override string ToString()
        {
            return longestSentence.ToString();
        }
    }

}
