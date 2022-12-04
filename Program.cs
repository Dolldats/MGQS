using System;
namespace startApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to be Encoded : ");
            string text = Console.ReadLine();
            char[] cha = text.ToCharArray();

            for (int i = 0; i <= text.Length; i++)
            {
                if (text.Length <= 10)
                {
                    Console.WriteLine("You are require to enter more than 10 character!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                }

            }

            string a = text.Substring(0, text.Length / 2);
            Console.WriteLine("The first substring is: " + a);
            string b = text.Substring(text.Length / 2);
            Console.WriteLine("The second substring is: " + b);

            string vara = "";
            string varb = "";

            for (int i = 0; i < a.Length; i++)
            {
                var even = i % 2 == 0;
                if (even)
                {
                    vara += a[i] + "" + b[i];
                }
                else
                {
                    varb += a[i] + "" + b[i];
                }

            }

            Console.WriteLine("The first encoding part is: " + vara);
            Console.WriteLine("The second encoding part is: " + varb);
            string combine = varb + vara;
            Console.WriteLine("The Concatenation part is: " + combine);

            string reversedA = String.Join(a, "", b);
            Console.WriteLine(reversedA);
        }

    }
}


