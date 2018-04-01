using System;
using System.Linq;

namespace HomeTask3
{
    class WorkWithStrings
    {
        string text;
        int longestSentence;

        public void LongestSentence()
        {
            Console.WriteLine("\n***Fun with sentences***\n");

            //text = "Here comes a traveller.Let us see who can strip him of his cloak?Said the Sun.";
            Console.WriteLine("Write the text\n");
            text = Console.ReadLine();

            //split text to sentences
            string[] sentences = text.Split(new char[] { '.', '!', '?' });

            //array number of sentences
            int[] intArray = new int[sentences.Length];

            //count number of words in each sentence
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Trim().Split(new string[] { " ","  ","   ","    ","     " }, StringSplitOptions.RemoveEmptyEntries);
                intArray[i] = words.Length;
            }

            //sort elements and get first - largest!
            longestSentence = intArray.OrderByDescending(x => x).First();
            Console.WriteLine($"The longest sentence in the text has {longestSentence} words\a");
        }
    }
}
