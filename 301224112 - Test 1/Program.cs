using System;

namespace comp100_test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 1:");
            Console.WriteLine("-----------");
            Exercise1();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("-----------");
            Exercise2();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 3:");
            Console.WriteLine("-----------");
            Exercise3();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 4:");
            Console.WriteLine("-----------");
            Exercise4();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 5:");
            Console.WriteLine("-----------");
            Exercise5();

            Console.WriteLine();
            Console.WriteLine("--- DONE!");
            Console.ReadKey();
        }

        static void Exercise1()
        {
            Console.WriteLine("Centennial College");
            Console.WriteLine("Address: 941 Progress Ave, Scarborough, ON M1G 3T8");
        }

        static void Exercise2()
        {
            //INPUT
            string name;
            double monthlybill;

            Console.Write("What is the name? ");
            name = Console.ReadLine();

            Console.Write("What is the monthly Visa Bill? ");
            monthlybill = Convert.ToDouble(Console.ReadLine());

            //PROCESSING
            Double AnnualBill;

            AnnualBill = monthlybill * 12;


            //OUTPUT
            Console.WriteLine("Name: {0}", name);

            Console.WriteLine($"Annual Visa Bill: {AnnualBill:C}");
        }

        static void Exercise3()
        {
            //INPUT
            char letter;

            Console.Write("Enter the letter: ");
            letter = Convert.ToChar(Console.ReadLine());
            int number = Convert.ToInt32(letter);

            //OUTPUT
            Console.WriteLine("Char: {0}", letter);
            Console.WriteLine("Number Equivalent: {0}", number);
        }

        static void Exercise4()
        {   
            Console.Write("Enter Home Planet: ");
            string planet = (Console.ReadLine());
            switch (planet.ToLower())

            {
                case "earth":
                    Console.WriteLine("earth. You are an Earthling and you have 10 toes");
                    break;

                case "venus":
                    Console.WriteLine("VENUS. You are a Venusian and you have 12 toes");
                    break;

                case "mercury":
                    Console.WriteLine("Mercury. You are a Mercurian and you have 8 toes");
                    break;

                default:
                    Console.WriteLine("I am sorry I don't know of that planet");
                    break;
            }
        }

        static void Exercise5()
        {
            Console.Write("Enter Home Planet: ");
            string planet = (Console.ReadLine());

            if (planet.ToLower() == "earth")
            {
            Console.WriteLine("earth. You are an Earthling and you have 10 toes");
            }
            else
            if (planet.ToLower() == "venus")
            {
            Console.WriteLine("VENUS. You are a Venusian and you have 12 toes");
            }
            else
            if (planet.ToLower() == "mercury")
            {
            Console.WriteLine("Mercury. You are a Mercurian and you have 8 toes");
            }
            else
            {
            Console.WriteLine("I am sorry I don't know of that planet");
            }
    

        }
    }
}