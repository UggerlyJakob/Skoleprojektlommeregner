using System.Xml.Serialization;

namespace Lommeregner
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Start = true;
            int resultat = 0;
            var choice2 = 0;
            var choice = 0;
            do
            {
                choice = Menu("\nIndtastete Tal: ");

                do
                {
                    if (choice == 1 || choice2 == 1)
                    {
                        Console.Clear();
                        var førsteTal = ReadInput("\nIndtastete Tal: ");

                        Console.WriteLine("Indtast anden tal");
                        var andenTal = ReadInput("\nIndtastete Tal: ");

                        Console.Clear();
                        resultat = førsteTal + andenTal;


                        Console.WriteLine("Resulatet er:" + resultat);

                        Console.WriteLine("\n Try 1 Hvis Du vil plusse igen");
                        Console.Write("Eller Trry 2 for at se Menu");
                        choice2 = ReadInput(": ");
                    }
                    else if (choice2 == 2)
                    {
                        break;
                    }


                } while (choice2 != 2);


                if (choice == 2)
                {
                    Console.Clear();
                    var førsteTal = ReadInput("\nIndtastete Tal: ");

                    Console.WriteLine("Indtast anden tal");
                    var andenTal = ReadInput("\nIndtastete Tal: ");


                    Console.Clear();
                    resultat = førsteTal + andenTal;

                    Console.WriteLine(resultat);
                }
                if (choice == 3)
                {
                    Console.Clear();

                    var førsteTal = ReadInput("\nIndtastete Tal: ");

                    Console.WriteLine("Indtast anden tal");
                    var andenTal = ReadInput("\nIndtastete Tal: ");


                    Console.Clear();
                    resultat = førsteTal / andenTal;

                    Console.WriteLine(resultat);

                }
                if (choice == 4)
                {
                    Console.Clear();
                    var førsteTal = ReadInput("\nIndtastete Tal: ");


                    Console.WriteLine("Indtast andet tal");
                    var andenTal = ReadInput("\nIndtastete Tal: ");


                    Console.Clear();
                    resultat = førsteTal * andenTal;

                    Console.WriteLine(resultat);
                }
                if (choice2 == 2)
                {
                    Console.Clear();
                }
                if (choice == 5)
                {
                    Start = false;
                }
            } while (Start);
        }
        static int ReadInput(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            return value;
        }
        static int Menu(string promt)
        {
            Console.WriteLine("Tryk 1 - Plus");
            Console.WriteLine("Tryk 2 - Minus");
            Console.WriteLine("Tryk 3 - Dividere");
            Console.WriteLine("Tryk 4 - Gange");
            Console.WriteLine("Try 5 - EXIT");


            var choice = ReadInput(promt);
            return choice;

        }
    }
}