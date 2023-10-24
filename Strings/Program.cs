using System.Reflection.Metadata.Ecma335;

namespace Strings
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Intro();

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length; // kaç harf olduğunu sayar. 
            var result2 = sentence.Clone(); // ilgili değerin referansını oluşturur. 
            sentence = "My name is Derin Demiroğ"; // konsola yazdırdığımızda yine engin demiroğ yazar.

            bool result3 = sentence.EndsWith("ğ"); // cümlenin sonu ğ ile bitip bitmediğine bakılır.
            bool result4 = sentence.StartsWith("My name"); // cümle My name ile başlıyor mu 

            var result5 = sentence.IndexOf("name"); // name kelimesinin hangi indeks numarasından başladığına bakılır. bulamazsa -1 döndürür.
            var result6 = sentence.IndexOf(" "); // ilk boşluğun hangi indeks numarasından başladığına bakar. 

            var result7 = sentence.LastIndexOf(" "); // cümleye sondan başlayacak ve ilk gelen boşluğun indeks numarasının döndürecek.
            var result8 = sentence.Insert(0, "Hello, "); // cümlenin 0 indeksli yerine verdiğimiz değeri yazdırır. 

            var result9 = sentence.Substring(3); // 3. indeksten itibaren al.
            var result10 = sentence.Substring(3,4); // 3. karakterden itibaren 4 tane al. name yazacak.

            var result11 = sentence.ToLower(); // tüm karakterleri küçük yapar.
            var result12 = sentence.ToUpper(); // tüm karakterleri büyük yapar.

            var result13 = sentence.Replace(" ", "-"); // cümle içinde boşluk yerine - koyar.
            var result14 = sentence.Remove(2); // 2 den itibaren kes. 



            Console.WriteLine(result); // 24 döndürür.
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item); // Ankara kelimesinin harflerini alt alta yazar.
            }

            string city2 = "İstanbul";

            //string result = city + city2;
            /*Console.WriteLine(result);*/ // string ifadenin toplanması, yan yana yazılmasını sağlar.

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
