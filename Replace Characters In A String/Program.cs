using System;

namespace Replace_Characters_In_A_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello im string replacer !");
            Console.WriteLine("Enter The Sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter the chracter you want to replace");
            string replace = Console.ReadLine();
            Console.WriteLine("to which chracter you want to replace");
            string toreplace = Console.ReadLine();
            
            Console.WriteLine(sentence.Replace(replace, toreplace));
        
        }
    }
}
