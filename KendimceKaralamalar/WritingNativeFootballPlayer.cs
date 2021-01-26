using System;
using System.Collections.Generic;
using System.Text;

namespace KendimceKaralamalar
{
    class WritingNativeFootballPlayer 
    {

      
        public void NativeInformation()
        {
            NativeFootballPlayer nativeFootballPlayer = new NativeFootballPlayer();
            Console.Write("Lütfen oyuncu ismini giriniz : ");
            nativeFootballPlayer.FirstName = Console.ReadLine();
            Console.Write("Lütfen Oyuncu Yaşını Giriniz : ");
            nativeFootballPlayer.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Oyuncu Takımını giriniz : ");
            nativeFootballPlayer.Team = Console.ReadLine();
            Console.Write("Lütfen oyuncunun milli takımımız için oynayıp oynamadığını giriniz : ");
            nativeFootballPlayer.PlayForTurkey = Console.ReadLine();



            Console.WriteLine("***Oyuncu Bilgileri***");
            Console.WriteLine("Oynayabilme Durumu       : " + nativeFootballPlayer.Permission);
            Console.WriteLine("Adı                      : " + nativeFootballPlayer.FirstName);
            Console.WriteLine("Yaş                      : " + nativeFootballPlayer.Age);
            Console.WriteLine("Takımı                   : " + nativeFootballPlayer.Team);
            Console.WriteLine("Ülkemiz için oynadı mı?  : " + nativeFootballPlayer.PlayForTurkey);
        }

    
    }
}
