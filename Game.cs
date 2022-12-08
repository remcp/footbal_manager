using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace soccer_manager
{
    internal class Game
    {
        List<Player> team1 = new List<Player> { };
        int attackattack1 = 0;
        int midattack1 = 0;
        int defenseattack1 = 0;
        int goalkeeperattack1 = 0;

        int attackdefense1 = 0;
        int middefense1 = 0;
        int defensedefense1 = 0;
        int goalkeeperdefense1 = 0;
        List<Player> team2 = new List<Player> { };
        int attackattack2 = 0;
        int midattack2 = 0;
        int defenseattack2 = 0;
        int goalkeeperattack2 = 0;

        int attackdefense2 = 0;
        int middefense2 = 0;
        int defensedefense2 = 0;
        int goalkeeperdefense2 = 0;

        int ballcontrol = 0;

        public Game(List<Player> team1, List<Player> team2)
        {
            this.team1 = team1;
            foreach(Player player in team1)
            {
                switch (player.position)
                {
                    case Position.attacker:
                        attackattack1 = attackattack1 + player.attack;
                        attackdefense1 = attackdefense1 + player.defense;
                        break;
                    case Position.mid:
                        midattack1 = midattack1 + player.attack;
                        middefense1 = middefense1 + player.defense;
                        break;
                    case Position.defender:
                        defenseattack1 = defenseattack1 + player.attack;
                        defensedefense1 = defensedefense1 + player.defense;
                        break;
                    case Position.goaly:
                        goalkeeperdefense1 = goalkeeperdefense1 + player.defense;
                        goalkeeperattack1 = goalkeeperattack1 + player.attack;
                        break;
                }
            }
            this.team2 = team2;
            foreach (Player player in team2)
            {
                switch (player.position)
                { 
                    case Position.attacker:
                    attackattack2 = attackattack2 + player.attack;
                    attackdefense2 = attackdefense2 + player.defense;
                    break;
                case Position.mid:
                    midattack2 = midattack2 + player.attack;
                    middefense2 = middefense2 + player.defense;
                    break;
                case Position.defender:
                    defenseattack2 = defenseattack2 + player.attack;
                    defensedefense2 = defensedefense2 + player.defense;
                    break;
                case Position.goaly:
                    goalkeeperdefense2 = goalkeeperdefense2 + player.defense;
                    goalkeeperattack2 = goalkeeperattack2 + player.attack;
                    break;
                }
            }
        }
        public void play()
        {
            MessageBox.Show("game begins. team1 has the ball");
            ballcontrol = 1;
            int gamestage = 0;
            int time = 0;
            int scoreteam1 = 0;
            int scoreteam2 = 0;

            while (time < 90)
            {

                switch (gamestage)
                {
                    case 0:
                        time = time + 5;
                        MessageBox.Show(time + ": " + scoreteam1 +";" + scoreteam2 + "\nteam" + ballcontrol + " is at the middle of the field trying to make a play");
                        if (ballcontrol == 1)
                        {
                            gamestage = actionmid(attackattack1, middefense2);
                        }
                        else
                        {
                            gamestage = actionmid(attackattack2, middefense1);
                        }
                        break;
                    case 1:
                        MessageBox.Show(time + ": " + scoreteam1 + ";" + scoreteam2 + "\nteam" + ballcontrol + " is running towards the goal.\n can the defenders stop them?");
                        if (ballcontrol == 1)
                        {
                            gamestage = actionattack(attackattack1, defensedefense2);
                        }
                        else
                        {
                            gamestage = actionattack(attackattack2, defensedefense1);
                        }
                        break;
                    case 2:
                        gamestage = 0;
                        if (ballcontrol == 1)
                        {
                            scoreteam1 = goal(attackattack1, goalkeeperdefense2, scoreteam1);
                            ballcontrol = 2;
                        }
                        else
                        {
                            scoreteam2 =  goal(attackattack2, goalkeeperdefense1, scoreteam2);
                            ballcontrol = 1;
                        }
                        break;
                }
                if (time == 45)
                {
                    MessageBox.Show("the first half is over");
                }
            }
        }

        public int actionmid(int attackers, int defenders)
        {
            int gamestage = 0;
            int attack = randomgenerator(attackers);
            int defense = randomgenerator(defenders);
            if (attack < defense)
            {
                MessageBox.Show("team" + ballcontrol + " loses the ball");
                if(ballcontrol == 1)
                {
                    ballcontrol = 2;
                }
                else
                {
                    ballcontrol = 1;
                }
                gamestage = 0;
            }
            else
            {
                MessageBox.Show("team" + ballcontrol + " rushes forward");
                gamestage++;
            }
            return gamestage;
        }

        public int actionattack(int attackers, int defenders)
        {
            int gamestage = 1;
            int attack = randomgenerator(attackers);
            int defense = randomgenerator(defenders);
            if (attack < defense)
            {
                MessageBox.Show("team" + ballcontrol + " gets stopped and no longer has control over the bal");
                if (ballcontrol == 1)
                {
                    ballcontrol = 2;
                }
                else
                {
                    ballcontrol = 1;
                }
                gamestage = 0;
            }
            else
            {
                MessageBox.Show("team" + ballcontrol + " breaks trough the defense and gets a chance to score");
                gamestage++;
            }
            return gamestage;
        }

        public int goal(int attackers, int goalkeeper,int score)
        {
            int shot = randomgenerator(attackers / 3);
            int keeper = randomgenerator(goalkeeper);
            if (keeper < shot)
            {
                MessageBox.Show("GOAL!!");
                score++;
            }
            else
            {
                MessageBox.Show("WHAT A SAVE");
            }
            return score;
        }

        public int randomgenerator(int skill)
        {
            Random random = new Random();
            int rnd = random.Next(0, skill +1);
            return rnd;
        }
    }
}