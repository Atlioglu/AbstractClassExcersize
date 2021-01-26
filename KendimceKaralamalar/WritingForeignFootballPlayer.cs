using System;
using System.Collections.Generic;
using System.Text;

namespace KendimceKaralamalar
{
    class WritingForeignFootballPlayer
    {
        public void ForeignInformation()
        {
            ForeignFootballPlayer foreignFootballPlayer = new ForeignFootballPlayer();
            Console.Write("Lütfen oyuncu ismini giriniz : ");
            foreignFootballPlayer.FirstName = Console.ReadLine();
            Console.Write("Lütfen Oyuncu Yaşını Giriniz : ");
            foreignFootballPlayer.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Oyuncu Takımını giriniz : ");
            foreignFootballPlayer.Team = Console.ReadLine();
            Console.Write("Lütfen oyuncunun ırkını giriniz : ");
            foreignFootballPlayer.Nationality = Console.ReadLine();


            Console.WriteLine("***Oyuncu Bilgileri***");
            Console.WriteLine("Oynayabilme Durumu : " + foreignFootballPlayer.Permission);
            Console.WriteLine("Adı                : " + foreignFootballPlayer.FirstName);
            Console.WriteLine("Yaş                : " + foreignFootballPlayer.Age);
            Console.WriteLine("Takımı             : " + foreignFootballPlayer.Team);
            Console.WriteLine("Irkı               : " + foreignFootballPlayer.Nationality);
        }
    }
}
