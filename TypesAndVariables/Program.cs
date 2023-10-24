namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("Hello World!");
            byte number4 = 255;
            short number3 = -32768;

            int number1 = 2147483647; // int veri tipi, number1 değişken, int tam sayı değişkenlerine ait veri tipidir.
            long number2 = 9223372036854775807; 
            Console.WriteLine("Number1 is {0}",number1); // {0} indeks. virgülden sonraki ilk sıradaki değeri baz alır.
            Console.WriteLine("Number1 is {0}", number2);
            Console.WriteLine("Number1 is {0}", number3);
            Console.WriteLine("Number1 is {0}", number4);

            // int -2147483648 ile 2147483647 arasında değer alır. 32bit yer kaplar.
            // long, 9223372036854775807. 64bit yer kaplar.
            // short, 16bit yer kaplar. 
            // byte 0 ile 255 arasında değer alır. 

            // int, long, short ve byte tam sayı değerlerini tutan veri tipleridir.

            bool condition = false;

            // bool veri tipi, genelde if bloklarında kullanılır. true ya da false değerini alır. 

            char character = 'A';
            Console.WriteLine("Character is : {0}", character);

            // char veri tipi, tek karakterli değerleri tutar. 

            double number5 = 10.4;

            // double veri tipi, küsüratlı sayıları tutmak için kullanılır. 

            decimal number6 = 10.4m;

            // decimal veri tipi, double'dan daha büyük sayıları tutmaya yarar. Sonunda 'm' ile kullanılır.

            var number7 = 10;

            // var değişken tutmak için kullanılır. 
            // var ile tanımlanan değişkenin aldığı değerin tipi ne ise (int, char, string vb.) o veri tipi haline gelir. 

        }

        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
            // enum bize string ifadeleri tekrar tekrar yazmaktan kurtarır. 
            // Bir enum, belirli bir öğenin yalnızca belirli bir dizi değer alabileceği bir veri tipi oluşturmanıza olanak tanır. Genellikle sabit değerlerin temsil edilmesi için kullanılır ve kodun daha okunaklı ve anlaşılır olmasını sağlar. Enum'lar, genellikle bir öğenin kabul edilebileceği belirli değerlerin sınırlı bir listesi olduğu durumlarda kullanılır.
            // bu örnekte monday 0, tuesday 1, ... şeklinde temsil edilir. 
            // Enum'lar, kodun daha anlaşılır olmasına ve hata yapma olasılığını azaltmaya yardımcı olur. Özellikle belirli seçeneklerin veya durumların sınırlı bir kümesini temsil etmek için kullanışlıdır. Enum'lar, sıklıkla kullanılan sabit değerlerin merkezi bir yerde tanımlandığı ve kullanıldığı birçok C# uygulamasında bulunur.
        }
    }
}