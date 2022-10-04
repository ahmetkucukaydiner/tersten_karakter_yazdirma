using System;
using System.Linq;

namespace tersten_karakter_yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir değer giriniz: ");
            string sentence = Console.ReadLine();
            CharReverse(sentence);
        }

        static void CharReverse(string sentence)
        {
            string newSentence = "";  
            string letter = "";

            for (int i = 0; i <= sentence.Length; i++)
            {
                if (i == 0)
                {
                    letter += sentence[i].ToString(); 
                }
                else if (i == sentence.Length)
                {
                    newSentence += letter; 
                }
                else if (sentence[i - 1].ToString() == " ")
                    continue;
                else if (sentence[i].ToString() == " ")
                {
                    newSentence += letter + " ";  
                    letter = sentence[i + 1].ToString();
                }
                else
                    newSentence += sentence[i].ToString();
            }
            Console.WriteLine(newSentence);
        }
    }
}
