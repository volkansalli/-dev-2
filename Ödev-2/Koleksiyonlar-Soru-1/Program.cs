/*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)



Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
using System;
using System.Collections;


namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList sayilar=new ArrayList();
            ArrayList asal=new ArrayList();
            ArrayList noasal=new ArrayList();
            int gecici, s=7;
            for (int i = 0; i < 20; i++)
            {
            volki:
            try{
            Console.WriteLine("bir tam sayi giriniz");
            gecici=(Convert.ToInt32(Console.ReadLine()));
            }
            catch(Exception ex){
                Console.WriteLine("hatali giris sayi pozitif tam sayı olmalı"+ ex.Message.ToString());
              goto volki;
            }
            if(gecici < 0)
            {
                Console.WriteLine("hatali giris sayi pozitif tam sayı olmalı");
                goto volki;
            }

            if(gecici==1 || gecici==0)
            noasal.Add(gecici);
            if(gecici==2)
            asal.Add(gecici);
            if(gecici>2)
                    {
                        for (int z = 2; z < gecici; z++)
                        {
                  
                            if((gecici%z) == 0)
                            {
                            noasal.Add(gecici);
                            s=1;
                            break;
                            
                            }
                        }

                        if(s!=1)
                        {
                        asal.Add(gecici);
                        }
                        s=7;
                        
                        
                    }
            }
            
            
            
            Console.WriteLine("girilen sayilardan asal olanlar");
            foreach (var item in asal)
            {
            Console.WriteLine(item);
                
            }
            Console.WriteLine("girilen sayilardan asal OLMAYANLAR");
            foreach (var item in noasal)
            {
            Console.WriteLine(item);
                
            }
            Console.WriteLine("Sıralanmış Asallar");
            asal.Sort();
            asal.Reverse();
            foreach (var item in asal)
            {
            Console.WriteLine(item);
                
            }
            Console.WriteLine("Sıralanmış Asal_OLMAYANLAR");
            noasal.Sort();
            noasal.Reverse();
            foreach (var item in noasal)
            {
            Console.WriteLine(item);
                
            }
            s=0;
            Console.WriteLine("Asal Olanların adedi"+asal.Count);
            Console.WriteLine("Asal Olanların Ortalaması");
            foreach (int item in asal)
            {
                s+=item;
            }
            Console.WriteLine(((float)s)/asal.Count);
            
            
            Console.WriteLine("AsalOLMAYANLARIN adedi"+noasal.Count);
            Console.WriteLine("Asal Olmayanların Ortalaması");
            s=0;
            foreach (int item in noasal)
            {
                s+=item;
            }
            Console.WriteLine(((float)s)/noasal.Count);
            

        }
    }
}
