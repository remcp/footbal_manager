using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soccer_manager
{
    internal class Teambuilder
    {
        public Team team = new Team();
        public Player defender1 = new Player();
        public Player defender2 = new Player();
        public Player defender3 = new Player();

        public Player mid1 = new Player();
        public Player mid2 = new Player();
        public Player mid3 = new Player();
        public Player mid4 = new Player();

        public Player attacker1 = new Player();
        public Player attacker2 = new Player();
        public Player attacker3 = new Player();

        public Player keeper = new Player();

        public override string ToString()
        {
            return team.ToString();
        }

        public void canadd(Player player)
        {
            Player playerback = new Player();
            if(player == defender1)
            {
                defender1 = new Player();
                
            }
            else if (player == defender2)
            {
                defender2 = new Player();
                
            }
            else if (player == defender3)
            {
                defender3 = new Player();
                
            }
            else if (player == mid1)
            {
                mid1 = new Player();
                
            }
            else if (player == mid2)
            {
                mid2 = new Player();
               
            }
            else if (player == mid3)
            {
                mid3 = new Player();
                
            }
            else if (player == mid4)
            {
                mid4 = new Player();
                
            }
            else if (player == attacker1)
            {
                attacker1 = new Player();
            }
            else if (player == attacker2)
            {
                attacker2 = new Player();
            }
            else if (player == attacker3)
            {
                attacker3 = new Player();
            }
            else if (player == keeper)
            {
                keeper = new Player();
            }
        }
    }
}