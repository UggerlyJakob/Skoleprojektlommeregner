using System.Xml.Serialization;

namespace Lommeregner
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            bool Start = true;
            int resultat;
            int vælg;
            int Plus = 0;
            int Minus = 0;
            int Divider = 0;
            int Gange = 0;
            #endregion

            do
            {
                vælg = Menu("\nIndtastete Tal: ");

                do
                {
                    if (vælg == 1 || Plus == 1)
                    {
                        Console.Clear();
                        int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                        int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                        Console.Clear();
                        resultat = førsteTal + andenTal;

                        Console.WriteLine("Resulatet er:" + resultat);

                        Console.WriteLine("\nTry 1 Hvis Du vil plusse igen");
                        Console.Write("\nTry 2 for at se Menu");
                        Plus = ReadInput(": ");
                    }
                } while (Plus != 2);

                do
                {
                    if (vælg == 2 || Minus == 1)
                    {
                        Console.Clear();
                        int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                        int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                        Console.Clear();
                        resultat = førsteTal - andenTal;

                        Console.WriteLine("Resulatet er:" + resultat);

                        Console.WriteLine("\nTry 1 Hvis Du vil plusse igen");
                        Console.Write("\nTry 2 for at se Menu");
                        Minus = ReadInput(": ");
                    }
                } while (Minus != 2);

                do
                {
                    if (vælg == 3 || Divider == 1)
                    {
                        Console.Clear();
                        int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                        int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                        Console.Clear();
                        resultat = førsteTal / andenTal;

                        Console.WriteLine("Resulatet er:" + resultat);

                        Console.WriteLine("\nTry 1 Hvis Du vil plusse igen");
                        Console.Write("\nTry 2 for at se Menu");
                        Divider = ReadInput(": ");
                    }
                } while (Divider != 2);

                do
                {
                    if (vælg == 4 || Gange == 1)
                    {
                        Console.Clear();
                        int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                        int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                        Console.Clear();
                        resultat = førsteTal * andenTal;

                        Console.WriteLine("Resulatet er:" + resultat);

                        Console.WriteLine("\nTry 1 Hvis Du vil plusse igen");
                        Console.Write("\nTry 2 for at se Menu");
                        Gange = ReadInput(": ");
                    }
                } while (Gange != 2);

                if (vælg == 5)
                {
                    Start = false;
                }
                if (Plus == 2)
                {
                    Console.Clear();
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


            int choice = ReadInput(promt);
            return choice;

        }
    }
}