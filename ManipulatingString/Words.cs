using System;

namespace StringManipulation
{
    class Words
    {
        
        public string text = "Just some words that can demonstrate certain ways to manipulate a string variable";

        public string textTwo= "Just some words that can demonstrate certain ways to manipulate a string variable";

        public string textThree = "This is another set of words to demonstrate string manipulation using methods";

        public string textFour = "kayak";
             
        public string evenOdd()
        {
            string text = this.text;
            if (text.Length % 2 == 0)
                return "Even";
            else
            {
                return "Odd";
            }
        }        
        public string primeNum()
        {
            string text = this.text;
            int n = text.Length, a = 0;

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    a++;                   
                }
            }
            if (a == 2)
            {
                return "Prime Number";
            }
            else
            {
                return "Not a Prime Number";
            }
        }

        public string palindrome()
        {
            string text = this.textFour;
            string rev;
            char[] ch = text.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = text.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                return "String 4 is a Palindrome";
            }
            else
            {
                return "String 4 is not a Palindrome";
            }
        }
            
    }   

}