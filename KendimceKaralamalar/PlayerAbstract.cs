using System;
using System.Collections.Generic;
using System.Text;

namespace KendimceKaralamalar
{
    abstract class PlayerAbstract
    {
      
        public abstract void PermissionToPlay();

        public void PricePerMatch()
        {
            Console.WriteLine(" Bu maçta oynadığı için 100 birim para kazandı ");
        }

        public void PricePerGoal()
        {
            Console.WriteLine(" Gol attığı için 150 birim para kazandı");
        }
        public void Writing()
        {
            FootballPlayer footballPlayer = new FootballPlayer();
            Console.WriteLine("Lütfen Futbolcu Id'sini giriniz Id = 1 -----> Yerli , Id=2 ------> Yabancı ifade etmektedir");
            footballPlayer.Id = Convert.ToInt32(Console.ReadLine());
            if (footballPlayer.Id == 1)
            {
                WritingNativeFootballPlayer writingNativeFootballPlayer = new WritingNativeFootballPlayer();
                writingNativeFootballPlayer.NativeInformation();
            }
            else if (footballPlayer.Id ==2)
            {
                
                WritingForeignFootballPlayer writingForeignFootballPlayer = new WritingForeignFootballPlayer();
                writingForeignFootballPlayer.ForeignInformation();
            }
        }




    }
}
