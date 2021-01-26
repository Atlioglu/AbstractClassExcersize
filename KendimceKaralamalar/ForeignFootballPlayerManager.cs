using System;
using System.Collections.Generic;
using System.Text;

namespace KendimceKaralamalar
{
    class ForeignFootballPlayerManager : PlayerAbstract
    {
        public override void PermissionToPlay()
        {
            FootballPlayer footballPlayer = new NativeFootballPlayer();
            footballPlayer.Permission = "Sahada kendisi dışındaki yabancı Futbolcu sayısı 5 ten fazla ise oynayabilir";
        }

    }
}
