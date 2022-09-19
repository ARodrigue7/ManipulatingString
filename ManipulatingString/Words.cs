using System;

namespace StringManipulation
{
    class Words
    {
        
        public string text = "Just some words that can demonstrate certain ways to manipulate a string variable";

        public string textTwo= "Just some words that can demonstrate certain ways to manipulate a string variable";

        public string textThree = "This is another set of words to demonstrate string manipulation using methods";
             
        public string evenOdd(string text)
        {
            if (text.Length % 2 == 0)
                return "Even";
            else
            {
                return "Odd";
            }
        }        
        public string primeNum(string text)
        {
            int i = 0;

            for (i = 2; i <= (text.Length / 2); i++)
            {
                if(text.Length % i == 0)
                {
                    return "Number is not Prime";                   
                }
                else
                {
                    return "Number is Prime";
                }
            }
        }
            
    }   

}