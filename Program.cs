using System;

namespace BlokTryCatch
{
    class Program
    {

        class PodstZero : Exception 
        {
        };

        class Hzero : Exception
        {
        };

        static void Main(string[] args)
        {
            double a, h;
            string text;
            do
            {
                Console.Write("Prosze podac podstawe: ");
                text = Console.ReadLine();
                double.TryParse(text, out a);
                Console.Write("Prosze podac wysokosc: ");
                text = Console.ReadLine();
                double.TryParse(text, out h);

                try
                {

                    if (a <= 0)
                    {
                        throw new PodstZero();
                    }
                    else if (h <= 0)
                    {
                        throw new Hzero();
                    }
                    Console.WriteLine("Pole trojkata wynosi: {0}", a * h / 2);

                }
                catch (PodstZero e) 
                {
                    Console.WriteLine("Podstawa ma wartosc 0 lub mniejsza albo podana wartosc nie jest liczba!");
                }
                catch (Hzero e) 
                {
                    Console.WriteLine("Wysokosc ma wartosc 0 lub mniejsza albo podana wartosc nie jest liczba!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} wyjatek", e);
                }
                finally
                {
                    Console.WriteLine("Zapraszam ponownie!");
                    Console.ReadKey();
                }

            } while (a <= 0 || h <= 0);

            Console.ReadLine();
        }

    }
}
