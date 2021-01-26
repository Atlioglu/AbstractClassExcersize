using System;
using System.Collections.Generic;
using System.Text;

namespace KendimceKaralamalar
{
    class NativeFootballPlayerManager : PlayerAbstract
    {
        public override void PermissionToPlay()
        {
            FootballPlayer footballPlayer = new NativeFootballPlayer();
            footballPlayer.Permission = "Herhangi bir koşul yoktur, her türlü koşulda oynayabilir.";
        }
    }
}
