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
                vælg = Menu("\nIndtastete Tal: ");

                switch (vælg)
                {
                    case 1:
                        do
                        {
                            int førsteTal = FørsteTal("");
                            int andenTal = AndetTal("");

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
                               

                        } while (true);
                        break;

                    case 2:
                        do
                        {
                            int førsteTal = FørsteTal("");
                            int andenTal = AndetTal("");

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
                            int førsteTal = FørsteTal("");
                            int andenTal = AndetTal("");

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
                            int førsteTal = FørsteTal("");
                            int andenTal = AndetTal("");

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
            Console.Write(promt);
            string input = Console.ReadLine();
            double value = Convert.ToDouble(input);
            return value;
        }
        static double Menu(string promt)
        {
            Console.WriteLine("Tryk 1 - Plus");
            Console.WriteLine("Tryk 2 - Minus");
            Console.WriteLine("Tryk 3 - Dividere");
            Console.WriteLine("Tryk 4 - Gange");
            Console.WriteLine("Try 5 - EXIT");


            double choice = ReadInput(promt);
            return choice;
        }
        static int FørsteTal(string promt)
        {
            Console.Clear();
            Console.WriteLine("\nIndtastete Første Tal: ");
            int Tal1 = ReadInput(promt);
            return Tal1;
        }
        static int AndetTal(string promt)
        {
            Console.WriteLine("\nIndtastete Andet Tal: ");
            int Tal2 = ReadInput(promt);
            return Tal2;
        }
    }
}