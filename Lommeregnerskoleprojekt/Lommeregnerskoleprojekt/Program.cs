using System.ComponentModel;
using System.Xml.Serialization;

namespace Lommeregner
{
    //TO DO LIST!!!!!
    //make so we can calculate more then 2 numbers.
    //give more options like sqaure etc.
    //times with 0.5 or silliar logic if we have more then 2 numbers


    public class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            bool Start = true;
            double resultat;
            double vælg;
            double Plus;
            double Minus;
            double Divider;
            double Gange;
            #endregion

            do
            {
                vælg = Menu();

                switch (vælg)
                {
                    case 1:
                        do
                        {
                            #region PLUS
                            double førsteTal = FørsteTal("");
                            double andenTal = AndetTal("");

                            Console.Clear();
                            resultat = førsteTal + andenTal;

                            Console.WriteLine($"{førsteTal} + {andenTal} = {resultat}");
                            Console.WriteLine("------------------------------------");

                            Console.WriteLine("\nTry 1 Hvis Du vil plusse igen");
                            Console.Write("\nTry 2 for at se Menu");
                            Plus = ReadInput(": ");

                            if (Plus == 2)
                            {   
                                Console.Clear();
                                break;
                            }

                            #endregion

                        } while (true);
                        break;

                    case 2:
                        do
                        {
                            double førsteTal = FørsteTal("");
                            double andenTal = AndetTal("");

                            Console.Clear();
                            resultat = førsteTal - andenTal;

                            Console.WriteLine($"{førsteTal} - {andenTal} = {resultat}");
                            Console.WriteLine("------------------------------------");

                            Console.WriteLine("\nTry 1 Hvis Du vil - igen");
                            Console.Write("\nTry 2 for at se Menu");
                            Minus = ReadInput(": ");

                            if (Minus == 2)
                            {
                                Console.Clear();
                                break;
                            }
                        } while (true);
                        break;
                    case 3:
                        do
                        {
                            double førsteTal = FørsteTal("");
                            double andenTal = AndetTal("");

                            Console.Clear();
                            resultat = førsteTal / andenTal;

                            Console.WriteLine($"{førsteTal} / {andenTal} = {resultat}");
                            Console.WriteLine("------------------------------------");

                            Console.WriteLine("\nTryk 1 Hvis Du vil / igen");
                            Console.Write("\nTryk 2 for at se Menu");
                            Divider = ReadInput(": ");

                            if (Divider == 2)
                            {
                                Console.Clear();
                                break;
                            }

                        } while (true);
                        break;
                    case 4:
                        do
                        {
                            double førsteTal = FørsteTal("");
                            double andenTal = AndetTal("");

                            Console.Clear();
                            resultat = førsteTal * andenTal;

                            Console.WriteLine($"{førsteTal} * {andenTal} = {resultat}");
                            Console.WriteLine("------------------------------------");

                            Console.WriteLine("\nTry 1 Hvis Du vil * igen");
                            Console.Write("\nTry 2 for at se Menu");
                            Gange = ReadInput(": ");

                            if (Gange == 2)
                            {
                                Console.Clear();
                                break;
                            }

                        } while (true);
                        break;
                    case 5:

                        Start = false;
                        break;
                }
            } while (Start);
        }
        static double ReadInput(string promt)
        {
                bool loop = true;
                double value;
            do
            {
                Console.WriteLine(promt);
                string input = Console.ReadLine();


                if (!double.TryParse(input, out value))
                {
                    Console.Clear();
                    Console.WriteLine($"{input} er ikke et tal \n Indast et nyt tal: ");
                }
                else
                {
                    value = Convert.ToDouble(input);
                    loop = false;
                }
            } while (loop == true);

            return value;
        }
        static double Menu()
        {
            double choice;
            choice = ReadInput("Tryk 1 - Plus \nTryk 2 - Minus \nTryk 3 - Dividere \nTryk 4 - Gang \nTryk 5 - EXIT \n Indtast Tal: ");

            if (choice > 5) // Exception //hvis man vælger for højt tal i Menu.
            {
                Console.Clear();
                Console.WriteLine("Prøv igen");
            }

            return choice;
        }
        static double FørsteTal(string promt)
        {
            Console.Clear();
            Console.WriteLine("\nIndtastete Første Tal: ");
            double Tal1 = ReadInput(promt);
            return Tal1;
        }
        static double AndetTal(string promt)
        {
            Console.WriteLine("\nIndtastete Andet Tal: ");
            double Tal2 = ReadInput(promt);
            return Tal2;
        }
    }
}