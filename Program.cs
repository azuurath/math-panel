using System;

namespace h_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "menu";
            Console.ForegroundColor = ConsoleColor.Cyan;
            string ascii = @"
███╗░░░███╗░█████╗░████████╗██╗░░██╗
████╗░████║██╔══██╗╚══██╔══╝██║░░██║
██╔████╔██║███████║░░░██║░░░███████║
██║╚██╔╝██║██╔══██║░░░██║░░░██╔══██║
██║░╚═╝░██║██║░░██║░░░██║░░░██║░░██║
╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝";

            Console.WriteLine(ascii);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[1] addition\n[2] subtraction\n[3] multiplcation\n[4] divison");
            
            int subsection = Convert.ToInt32(Console.ReadLine());

            if (subsection == 1)
            {   
                Console.Clear();
                    Console.Title = "addition";

                double add1;
                double add2;

                Console.WriteLine("enter first digit: ");
                add1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please enter second digit: ");
                add2 = Convert.ToDouble(Console.ReadLine());

                double result1 = add1 + add2;

                Console.Clear();

                Console.WriteLine("your result is " + result1);
                Console.ReadKey();



            }
            else if (subsection == 2)
            {
  Console.Title = "subtraction";
                Console.Clear();
            
                double sub1;
                double sub2;

                Console.WriteLine("enter first digit: ");
                sub1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please enter second digit: ");
                sub2 = Convert.ToDouble(Console.ReadLine());

                double result2 = sub1 - sub2;

                Console.Clear();

                Console.WriteLine("your result is " + result2);
                Console.ReadKey();
            }
            else if (subsection == 3)
            {
  Console.Title = "multiplcation";
                Console.Clear();
            
                double mul1;
                double mul2;

                Console.WriteLine("enter first digit: ");
                mul1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please enter second digit: ");
                mul2 = Convert.ToDouble(Console.ReadLine());

                double result1 = mul1 * mul2;

                Console.Clear();

                Console.WriteLine("your result is " + result1);
                Console.ReadKey();
            }
            else if (subsection == 4)
            {
                                    Console.Clear();
                                    Console.Title = "division";
            
                double div1;
                double div2;

                Console.WriteLine("enter first digit: ");
                div1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("please enter second digit: ");
                div2 = Convert.ToDouble(Console.ReadLine());

                double result1 = div1 / div2;

                Console.Clear();

                Console.WriteLine("your result is " + result1);
                Console.ReadKey();
            }



        }
    }
}