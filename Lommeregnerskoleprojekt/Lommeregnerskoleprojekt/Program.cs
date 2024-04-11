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

                switch (vælg)
                {
                    case 1:
                        do
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

                            if (Plus == 2)
                                break;

                        } while (true);
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                            int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                            Console.Clear();
                            resultat = førsteTal - andenTal;

                            Console.WriteLine("Resulatet er:" + resultat);

                            Console.WriteLine("\nTry 1 Hvis Du vil minus igen");
                            Console.Write("\nTry 2 for at se Menu");
                            Plus = ReadInput(": ");

                            if (Plus == 2)
                                break;

                        } while (true);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                            int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                            Console.Clear();
                            resultat = førsteTal / andenTal;

                            Console.WriteLine("Resulatet er:" + resultat);

                            Console.WriteLine("\nTryk 1 Hvis Du vil / igen");
                            Console.Write("\nTryk 2 for at se Menu");
                            Plus = ReadInput(": ");

                            if (Plus == 2)
                                break;

                        } while (true);
                        break;
                    case 4:
                        do
                        {
                            Console.Clear();
                            int førsteTal = ReadInput("\nIndtastete Første Tal: ");
                            int andenTal = ReadInput("\nIndtastete Andet Tal: ");

                            Console.Clear();
                            resultat = førsteTal - andenTal;

                            Console.WriteLine("Resulatet er:" + resultat);

                            Console.WriteLine("\nTry 1 Hvis Du vil minus igen");
                            Console.Write("\nTry 2 for at se Menu");
                            Plus = ReadInput(": ");

                            if (Plus == 2)
                                break;

                        } while (true);
                        break;
                    case 5:
                        Start = false;
                        break;
                }
                if (vælg != 5)
                    Console.Clear();
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