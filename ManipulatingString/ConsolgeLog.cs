using System;
using StringManipulation;

namespace ManipulatingString
{
    class ConsoleLog : Words
    {
        public void stringStuff()
        {
            Words myWords = new Words();

            //Regular text
            Console.WriteLine("String 1: "+myWords.text);
            Console.WriteLine("String 2: " + myWords.textTwo);
            Console.WriteLine("String 3: " + myWords.textThree);
            Console.WriteLine("String 4: " + myWords.textFour);

            Console.WriteLine("\nThis is a Clone of string 3: " + '"' + myWords.textThree.Clone()+'"');

            Console.WriteLine("\nThe length of String 1 is: " + myWords.text.Length);

            Console.WriteLine("\nThis compares String 1, 2, and returns 0 for true and 1 for false: " + myWords.text.CompareTo(textTwo));

            Console.WriteLine("\nThis compares String 1, 3, and returns 0 for true and 1 for false: " + myWords.text.CompareTo(textThree));

            Console.WriteLine("\nThis demostrates if the character \"some\" is in String 1 and returns a boolean: " + myWords.text.Contains("some"));

            Console.WriteLine("\nALL CAPS: " + myWords.text.ToUpper());

            Console.WriteLine("\nall lowercase: " + myWords.text.ToLower());

            Console.WriteLine("\nType of string: " + myWords.text.GetType());

            Console.WriteLine("\nHashcode: " + myWords.text.GetHashCode());

            Console.WriteLine("\nChar array: " + myWords.text.ToCharArray());

            Console.WriteLine("\nShows if String 1 is even or Odd: " + evenOdd());

            Console.WriteLine("\nShows if the length of String 1 is a Prime Number: " + primeNum());

            Console.WriteLine("\nShows if String 4 is a Palindrome: " + palindrome());
        }

    }
}