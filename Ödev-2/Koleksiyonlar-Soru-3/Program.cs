//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri
//bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle girin");
            string cumle=Console.ReadLine();
            string sesliler="aeıioöuüAEIİOÖUÜ";
            string y="";
            
            int i;

            for(i=0;i<sesliler.Length;i++)
            {
            if(cumle.Contains(sesliler[i]))
            y=String.Concat(y,sesliler[i]);
            }
            Console.WriteLine("girilen cumlenin icerdigi sesli harfler");
            Console.WriteLine(y);
            //aşağı taraf aslında gereksiz çünkü kontrol sıralamayıda sağlıyor, ama aşağısı güzel bir hızlı sıralama örneği
            string[] harfler=y.Split("");
            Console.WriteLine("Sesli harflerin sirali hali");
            foreach (var item in harfler)
            {
                Console.WriteLine(item);
            }

            

            
            
        }
    }
}
