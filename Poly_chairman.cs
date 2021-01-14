using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Poly_chairman
    {
        public void cricket(string a,string b)
        {
            Console.WriteLine("1. (Bat)Opener: " + a);
            Console.WriteLine("Left Hand Batsman");
            Console.WriteLine("                ");
            Console.WriteLine("2. (Bat)Opener: " + b);
            Console.WriteLine("Left Hand Batsman");
            Console.WriteLine("                ");
        }
        public void cricket(string a, string b, string c)
        {
            Console.WriteLine("3. (All/Sp)Top order: " + a);
            Console.WriteLine("Right Hand Batsman Right Arm Off Spiner");
            Console.WriteLine("                ");
            Console.WriteLine("4. (All/Sp)Top order: " + b);
            Console.WriteLine("Right Hand Batsman Right Arm Off Spiner");
            Console.WriteLine("                ");
            Console.WriteLine("6. (All/Sp)Middle order: " + c);
            Console.WriteLine("Left Hand Batsman Left Arm Orthodox");
            Console.WriteLine("                ");
        }
        public void cricket(string a)
        {
            Console.WriteLine("7. (Wk)Wicketkeeper " + a);
            Console.WriteLine("Wicketkeeper Right Hand Batsman");
            Console.WriteLine("                ");
        }
        public void cricket(string a, string b, string c, string d)
        {
            Console.WriteLine("8. (All/F)Lower order: " + a);
            Console.WriteLine("Left Hand Batsman Right Arm Fast Medium");
            Console.WriteLine("                ");
            Console.WriteLine("9. (Wk)Lower order: " + b);
            Console.WriteLine("Wicketkeeper Right Hand Batsman");
            Console.WriteLine("                ");
            Console.WriteLine("10. (Ball)Tailedner: " + c);
            Console.WriteLine("Right Hand Batsman Right Arm Fast Medium");
            Console.WriteLine("                ");
            Console.WriteLine("11. (Ball)Tailedner: " + d);
            Console.WriteLine("Right Hand Batsman Right Arm Fast Medium");
            Console.WriteLine("                ");
        }
        public void cricket(string a, int b)
        {
            Console.WriteLine("5. (All/Fa)Top order: " + a);
            Console.WriteLine("Jersey no: " + b);
            Console.WriteLine("Captain Left Hand Batsman Right Arm Fast");
        }
    }
}
