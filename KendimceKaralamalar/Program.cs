using System;

namespace KendimceKaralamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForeignFootballPlayer foreignFootballPlayer = new ForeignFootballPlayer();
            //foreignFootballPlayer.Nationality = "Nigeria";
            //foreignFootballPlayer.FirstName = "Hanry";
            //foreignFootballPlayer.Age = 23;
            //foreignFootballPlayer.Position = "Left Back";
            //foreignFootballPlayer.Team = "Galatasaray";


            ForeignFootballPlayerManager foreignFootballPlayerManager = new ForeignFootballPlayerManager();
            NativeFootballPlayerManager nativeFootballPlayerManager = new NativeFootballPlayerManager();

            foreignFootballPlayerManager.Writing();
            foreignFootballPlayerManager.PermissionToPlay();
            foreignFootballPlayerManager.PricePerGoal();
            foreignFootballPlayerManager.PricePerMatch();



            nativeFootballPlayerManager.Writing();
            nativeFootballPlayerManager.PermissionToPlay();
            nativeFootballPlayerManager.PricePerGoal();
            nativeFootballPlayerManager.PricePerMatch();



            Console.Read();




               
        }
    }
}
