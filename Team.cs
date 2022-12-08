using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace soccer_manager
{
    public class Team
    {
        //1 coach en 11 spelers
        //1 goalkeeper
        //max 5 defenders
        //max 5 midfielders
        //max 4 attackers


        public List<Player> players = new List<Player>();
        public string name { get; set; }

        public override string ToString()
        {
            Array array = players.ToArray();

            return name;
        }

        public bool canadd(Player selectedplayer)
        {
            bool possible = true;
            int coachamount = 0;
            int goalkeeperamount = 0;
            int defendersamount = 0;
            int midfieldersamount = 0;
            int attackersamount = 0;
            if (selectedplayer != null)
            {
                foreach (Player player in players)
                {
                    switch (player.position)
                    {
                        case Position.goaly:
                            ++goalkeeperamount;
                            break;
                        case Position.defender:
                            defendersamount++;
                            break;
                        case Position.attacker:
                            attackersamount++;
                            break;
                        case Position.mid:
                            midfieldersamount++;
                            break;
                    }
                }
            }
            else
            {
                goalkeeperamount = 2;
            }
            if (goalkeeperamount > 1 || defendersamount > 3 || attackersamount > 3 || midfieldersamount > 4)
            {
                MessageBox.Show("you can only have \n1 coach \n 1 goalkeeper\n5 defenders\n5 midfielders\n4 attackers");
                possible = false;
            }
            return possible;
        }
    }

}