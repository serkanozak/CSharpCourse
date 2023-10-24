namespace Loops
{
    class Program
    {
        static void Main(string[] args) 
        {

            // FOR DÖNGÜSÜ 

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");


            // Tek sayıları yazdırmak istersek;

            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            // Çift sayıları yazdırmak istersek;

            for (int i = 2; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            // WHİLE DÖNGÜSÜ 

            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--; // her turda sayıyı bir azaltır. 
            }
            Console.WriteLine("Now number is {0}",number);

            // while döngüsünde koşul sağlandığı sürece döngü devam eder.

            // DO-WWILE DÖNGÜSÜ 

            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;
            } while (number>=0);

            // do-while döngüsünde şart sağlanmasa bile döngü bir kere çalışacaktır. 

            // FOREACH DÖNGÜSÜ

            // foreach döngüsü dizi temelli dataların dolaşılması için kullanılır.

            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // ASAL SAYI ÖRNEĞİ

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            private static bool IsPrimeNumber(int number)
            {
                bool result = true;

                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number - 1;
                    }
                }
                return result;
            }
        }
    }
}
