using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello.I will count 4 different expressions, and you need to write 2 numbers.The first one is for 3 expressions, and the second one is for the last one. So the first one ? ");
            float one = float.Parse(Console.ReadLine());
            Console.Write("Second? And don't forget to press Enter after each expression! ");
            float two = float.Parse(Console.ReadLine());

            Console.Write(-6 * one / 3 + 5 * one / 2 - 10 * one + 15);
            Console.ReadLine();
            Console.Write(Math.Abs(one) * Math.Sin(one));
            Console.ReadLine();
            Console.Write(2 * Math.PI * one);
            Console.ReadLine();
            Console.Write(Math.Max(one, two));
        }

        void firsttaskfromhomework()
        {
            Console.Write("Type first number: ");
            float one = float.Parse(Console.ReadLine());
            Console.Write("Type second number: ");
            float second = float.Parse(Console.ReadLine());
            Console.Write("Choose operation (+, -, *, /): ");
            string third = Console.ReadLine();

            switch (third)
            {
                case "+":
                    Console.Write(one + second);
                    break;
                case "-":
                    Console.Write(one - second);
                    break;
                case "*":
                    Console.Write(one * second);
                    break;
                case "/":
                    Console.Write(one / second);
                    break;
                default:
                    Console.Write("No no no, i don`t know this operation. Yet.");
                    break;
            }
        }
    }
}
