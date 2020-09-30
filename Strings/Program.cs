using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string story = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'".ToLower();
            Console.WriteLine("What word would you like to search in this story?");
            string word = Console.ReadLine().ToLower();
            
            if (story.Contains(word) == true)
            {
                Console.WriteLine("Your word was found.");
                Console.WriteLine("The index of your word is " + story.IndexOf(word));
                Console.WriteLine("The length of your word is " + word.Length + " characters.");
                string newStory = story.Replace(word, "");
                Console.WriteLine(newStory);
            }
            else
            {
                Console.WriteLine("Your word was not found.");
            }
        }
    }
}
