using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace soccer_manager
{
    public class Player
    {
        public int lengte { get; set; }
        public int backnumber { get; set; }
        public string name { get; set; }
        public int defense { get; set; }
        public int attack { get; set; }
        public Team team { get; set; }

        public Position position { get; set; }

        public override string ToString()
        {
            return team + ": name = " + name + ": backnumber = " + backnumber  + ", attack = " + attack + ", defense = " + defense;

        }

        public Player(int backnumber, string name, int attack, int defense, Position position)
        {
            this.backnumber = backnumber;
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.position = position;
        }
        public Player()
        {

        }
    }
}