using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
             try {
                 // buraya hataya neden olabilecek kodu yazıyoruz 

              Console.WriteLine("Bir sayı giriniz: ");
              int sayi = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("girmis oldugunuz sayı :"+sayi);
             }
             catch(Exception ex)
             {
                 // hataya neden olabilecek kodu burada yakala diyoruz ona da "ex" diyoruz  
                Console.WriteLine("Hata:"+ex.Message.ToString());

             }
            /* finally{
                 // bir kod blogu hata alsın veya almasın calışmasını ıstedıgımız kod blogunu burada gozuksun istıyorsak yazarız.
                Console.WriteLine("İslem tamamlandı:");
             }*/

             try
             {
                // int a = int.Parse(null);
                    int a = int.Parse("test");
                 
             }
             catch (ArgumentNullException ex)
             {
                 
                Console.WriteLine("Boş deger girdiniz");
                 Console.WriteLine(ex);

             }
             finally{
                 Console.WriteLine("islem başarılı");             }
            
        }
    }
}
