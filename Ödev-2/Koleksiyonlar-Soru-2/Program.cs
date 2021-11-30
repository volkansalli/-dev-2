//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
//her iki grubun kendi içerisinde ortalamalarını alan 
//ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar=new int[20];
            int[] tempo=new int[3];
            int gecici;
            for (int i = 0; i < 20; i++)
            {
            volki:
            try
            {
                gecici=Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("hatali giris tekrar deneyin sayi bir tam sayi olmali");
                goto volki;
            }
            sayilar[i]=gecici;
            }
            Console.WriteLine("girilen dizi şu şekilde ");
            foreach (int item in sayilar)
            {
                Console.Write(" "+item);
            }
            Array.Sort(sayilar);
            Console.WriteLine("\ngirilen dizinin siralanmis hali");
            foreach(int item in sayilar)
            {
                Console.WriteLine(item);
            }
            tempo=sayilar;
            Array.Resize(ref tempo,3);
            Console.WriteLine("en küçük 3 girdi");
            foreach(int item in tempo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("kücüklerin ortalamasi "+((float)(tempo[0]+tempo[1]+tempo[2]))/3);
            tempo=sayilar;
            Array.Reverse(tempo);
            Array.Resize(ref tempo,3);
            Console.WriteLine("en büyük 3 girdi");
            foreach(int item in tempo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("büyüklerin ortalamasi "+((float)(tempo[0]+tempo[1]+tempo[2]))/3);

        }
    }
}
