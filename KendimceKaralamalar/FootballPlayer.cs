using System;
using System.Collections.Generic;
using System.Text;

namespace KendimceKaralamalar
{
    class FootballPlayer
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public int Id { get; set; }
        public string Permission { get; set; }



    }


    class ForeignFootballPlayer: FootballPlayer
    {
        public string Nationality { get; set; }

    }

    class NativeFootballPlayer : FootballPlayer
    {
        public string PlayForTurkey { get; set; }
    }
}
