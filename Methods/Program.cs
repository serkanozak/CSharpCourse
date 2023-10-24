namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Console.ReadLine();

            //int result = Add2(20,30);
            //Console.WriteLine(result);

            //int number1 = 20;
            //int number1;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //var result2 = Add3(out number1, number2);


            //Console.WriteLine(result2);
            //Console.WriteLine(number1); 

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //static void Add2(int number1, int number2)
        // C#'da "void," bir metodun geriye bir değer döndürmediğini veya bir işlemi tamamladığını belirten bir anahtar kelimedir. "void" dönüş türü, bir C# metodu tanımlanırken kullanılır ve metodun bir değer döndürmediğini belirtir. Yani, metodun işlemi tamamlaması veya başka bir işlemi tetiklemesi amaçlanır, ancak bir değer üretilip döndürülmez.
        // "void" dönüş türü, genellikle belirli bir sonuç beklenmediğinde veya yalnızca bir işlem gerçekleştiren metotlarda kullanılır. Eğer bir metodun bir değer döndürmesi isteniyorsa, o zaman başka bir dönüş türü kullanılır, örneğin "int," "string," "bool," vb.

        static int Add2(int number1, int number2=70)
        {
            return number1 + number2;
        }

        // number1 ve number2 yi topla ve "return" geri döndür. 
        // var result = number1 + number2;
        // return result; şeklinde de yazılabilir.

        // default parametreli metotlarda, örnekte olduğu gibi int number2=70 ile number2'ye herhangi bir değer ataması yapılmazsa, default olarak 70'i kabul edecektir. 
        // default değerler parametrenin en sonunda olması gerekir. 
        // bu nedenle Add2(int number1=70, int number2) şeklinde bir default tanımlama yapılamaz. 
        // ancak Add2(int number1=10, int number2=70) şeklinde her iki değişkene de default değer ataması yapılabilir. 

        //static int Add3(ref int number1, int number2)
        //{
        //    number1 = 30;
        //    return number1 + number2;
        //}

        // C#'da "ref" anahtar kelimesi, bir metodun argümanlarını "referans" olarak geçmek için kullanılır. Bu, argümanın orijinal değerini değiştirme yeteneği sağlar. 

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // out ile ref aynı amaca hizmet eder. ancak;
        // ref de, yukarıdaki örnekte number1'e mutlaka bir değer ataması yapılması gerekir. 
        // out da, number1'e bir değer ataması yapılması gerekmez. tanımlanması yeterlidir. 
        // ancak kullanılacak metodun içerisinde bir kere set edilmesi gerekir. 

        static int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return (number1 * number2 * number3);
        }

        // aynı metodun içerisine farklı bir değişken tanımlayarak kullanabiliriz.
        // buna metodların method overloading denir.

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

        // params keyword ile yukarıdaki fonksiyonda istediğimiz sayıda değişken gönderebiliriz. 
        // Sum --> toplama yapar. numbers dizisi içerisindeki değerleri topla. 
        // params ile metodumuza aynı tipte istediğimiz kadar parametre gönderebiliriz.
    }
}

// metodlar, tekrar eden kodları tekrar etmemek için kullanılır. 
// metodlar tekrar eden aynı işlemlerde kullanılır. Don't repeat yourself!
