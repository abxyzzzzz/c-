using System;

namespace nw
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
            Console.Clear();

           Console.WriteLine("please enter your respected name:");
           string name=Console.ReadLine();
           
           Console.WriteLine($"thats great {name} please tell me in what collage your studying:");
           string col=Console.ReadLine();

           Console.WriteLine("in which event you want to participate?:");
           Console.WriteLine("in which event");
           string ev=Console.ReadLine();

           Console.Write($"how much exprience do you have .of {ev} ?:");
           string ex=Console.ReadLine();
           int exprience=Convert.ToInt32(ex);
           
           if(exprience<2){
            Console.WriteLine($"thanks for your {ex} years of exprirence but sorry your not allowed");
            continue ;
           }
           else{
            Console.WriteLine("congralutons you can precsed further ");
            Console.WriteLine($"thanks for providing your information, your {col} is registred for {ev} event");
           }
           Console.WriteLine($"So {name} do you want to enable your whatsapp notifiation?");
          string whatsapp=Console.ReadLine();
          string wp=Convert.ToString(whatsapp);
           if(wp=="yes"){
            Console.WriteLine("your Whtasapp notification is suscesfully enabled");
           }
           else if(wp=="no"){
            Console.WriteLine("your Whtasapp notification is suscesfull disabled");
           }
           else{
            Console.WriteLine("please try agaian");
            continue ;
           }

            Console.WriteLine($"So {name} do you want to enable your facebook notifiation?");
            string facebook=Console.ReadLine();
            string fb=Convert.ToString(facebook);
            if(fb=="yes"){
                Console.WriteLine("your facebook notification is suscesfully enabled");
            }
           else if(fb=="no"){
            Console.WriteLine("your facebook notification dissabled");
           }
           else{
            Console.WriteLine("sorry please try again");
            continue ;
            }
            break ;
            }
        }
    }
}