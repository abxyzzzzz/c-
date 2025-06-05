using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace File_Handleing
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello im File handeling mangement system ");
            Console.WriteLine("Press 1 for Content store");
            Console.WriteLine("Press 2 for current directory");
            Console.WriteLine("Press 3 for creation of a Folder and a File");
            Console.WriteLine("Press 4 for File Information");
            string choice = Console.ReadLine();
            int choi = Convert.ToInt32(choice);
            string filepath ="";


            if (choi == 1)
            {
                Console.WriteLine("Hello im  file Content storer . YOU can save what ever contnt you want to save : ");
                Console.WriteLine("what name you like to keep the file?(without .txt): ");
                string re = Console.ReadLine();
                Console.WriteLine("what content/text you like to store?");
                string re2 = Console.ReadLine();

                string filename = re + ".txt";
                string content = re2;
                File.WriteAllText(filename, content);
                string readcontent = File.ReadAllText(filename);
                Console.WriteLine("file sucessfully saved");
            }
            else if (choi == 2)
            {
                string currdirect = Directory.GetCurrentDirectory();
                Console.WriteLine($"the current directory is : {currdirect}");
            }
            else if (choi == 3)
            {
                Console.WriteLine("Enter your folder name");
                string fol = Console.ReadLine();
                Console.WriteLine("Enter your file name (with extention)");
                string fil = Console.ReadLine();
                if (!Directory.Exists(fol))
                {
                    Directory.CreateDirectory(fol);
                    Console.WriteLine("Folder created sucesssfully", fol);
                }
                filepath = Path.Combine(fol, fil);
                Console.WriteLine(filepath);
                Console.WriteLine("Enter your content :");
                string content = Console.ReadLine();
                File.WriteAllText(filepath, content);
            }
            else if (choi == 4)
            {
                Console.WriteLine("Enter your FileName or Path")
                string helo=Console.ReadLine();
                FileInfo filei = new FileInfo(helo);
                Console.WriteLine(filei.Name);
                Console.WriteLine(filei.Length);
                Console.WriteLine(filei.Directory.FullName);


            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
