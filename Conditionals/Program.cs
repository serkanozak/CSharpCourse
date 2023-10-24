namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;

            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20) 
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}


            // Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            // Bu ifade if else'in single line halidir. ilk ifade koşul, doğru ise ? den sonraki ifadeyi çalıştır. değilse : den sonraki ifadeyi çalıştır. 


            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is not 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is not 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}


            // switch case yapısında, switch içerisindeki değeri sağlayan case değeri içerisindeki kod çalışacak. 
            // ancak hiçbir case durumu gerçekleşmezse, default kısmı devreye girecek. else gibi. 


            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200) 
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}


            // && işareti koşulun her iki tarafını da kontrol eder. koşulun her iki tarafının da doğru olması gerekir. 
            // kısa devre görevi görür. eğer ilk koşul yanlışsa diğer koşul incelenmeden bloktan çıkılır. 
            // || veya anlamına gelir. şartlardan herhangi birinin sağlanması yeterlidir. her iki taraf da kontrol edilir. 


            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
                else
                {

                }
            }


            Console.ReadLine();
        }
    }
}
