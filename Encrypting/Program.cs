using System;

namespace Encrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence; char letter;
            Console.Write("Can you enter the sentence: ");
            sentence = Console.ReadLine();
            Console.WriteLine("Enterend sentence : {0}", sentence);
            Console.Write("Encrypted version : ");
            int encrypted = 0;
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                letter = sentence[i];
                if (letter == 'a') { letter = '?'; encrypted++; }
                if (letter == 'e') { letter = '*'; encrypted++; }
                if (letter == 'ı' || letter == 'i') { letter = '='; encrypted++; }
                if (letter == 'ö' || letter == 'o') { letter = '&'; encrypted++; }
                if (letter == 'u' || letter == 'ü') { letter = '+'; encrypted++; }
                if (i == 0) Console.WriteLine("{0}", letter);
                else Console.Write("{0}", letter);
            }
            Console.WriteLine("Total { 0} letters were encrypted { 1}were not encrypted", encrypted, sentence.Length - encrypted);
            Console.ReadKey();
        }
    }
}
