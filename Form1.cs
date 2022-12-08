using System.Numerics;

namespace soccer_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int property = -1;
        Player player2 = new Player(1, "name", 10, 10, Position.mid);
        Player playerback = new Player();
        Team team = new Team();
        Team team1 = new Team();
        Team team2 = new Team();
        Teambuilder teambuilder = new Teambuilder();
        List<Player> playerList = new List<Player>();
        private void Form1_Load(object sender, EventArgs e)
        {
            empty.Text = "";
            Player player = new Player();
            player.name = "mark";
            player.position = Position.attacker;
            player.backnumber = 1;
            player.attack = 60;

            listBox1.Items.Add("name = " + player.name);
            listBox1.Items.Add("position = " + player.position);
            listBox1.Items.Add("backnumber = " + player.backnumber);
            listBox1.Items.Add("skill level = " + player.attack);
            listBox3.Sorted = true;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (property)
                {
                    case -1:

                        player2 = new Player();
                        label1.Text = "name";
                        property++;
                        textBox1.Text = "player";
                        break;
                    case 0:
                        label1.Text = "position";
                        player2.name = textBox1.Text;
                        property++;
                        textBox1.Text = "defender";
                        break;
                    case 1:
                        label1.Text = "backnumber";
                        Position position = (Position)Enum.Parse(typeof(Position), textBox1.Text);
                        player2.position = position;
                        property++;
                        textBox1.Text = "15";
                        break;
                    case 2:
                        label1.Text = "skill";
                        player2.backnumber = Convert.ToInt32(textBox1.Text);
                        property++;
                        textBox1.Text = "80";
                        break;
                    case 3:
                        label1.Text = "box in";
                        player2.attack = Convert.ToInt32(textBox1.Text);
                        property++;
                        textBox1.Text = "";
                        break;
                    case 4:
                        listBox2.Items.Add(player2);
                        property = -1;
                        textBox1.Text = "";
                        break;
                }
            }
            catch { MessageBox.Show("voeg waarde toe"); }

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            bool canadd = true;
            object selectedplayer = listBox2.SelectedItem;
            Player player = (Player)selectedplayer;
            team.players.Add(player);
            canadd = team.canadd(player);
            if (canadd == true)
            {
                player.team = team;
                listBox2.Items.Remove(selectedplayer);
                listBox3.Items.Add(player);
            }
            else
            {
                team.players.Remove(player);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            team = new Team();
            playerList = new List<Player>();
            string teamname = textBox2.Text;
            team.name = teamname;
            listBox3.Items.Add(team);
            teambuilder = new Teambuilder();
            teambuilder.team = team;
            comboBox1.Items.Add(teambuilder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedteam = listBox3.SelectedItem;
                team = (Team)selectedteam;
                teambuilder.team = team;
            }
            catch { MessageBox.Show("select a team not a player"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int defense = 0;
            int attack = 0;
            for (int i = 0; i < 11; i++)
            {
                int s = randomgenerator(100);
                string name = namegenerator();
                switch (i)
                {
                    case 0:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(11, name, attack, defense, Position.goaly);
                        listBox2.Items.Add(player2);
                        break;
                    case 1:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(15, name, attack, defense, Position.defender);
                        listBox2.Items.Add(player2);
                        break;
                    case 2:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(12, name, attack, defense, Position.defender);
                        listBox2.Items.Add(player2);
                        break;
                    case 3:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(17, name, attack, defense, Position.defender);
                        listBox2.Items.Add(player2);
                        break;
                    case 4:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(16, name, attack, defense, Position.mid);
                        listBox2.Items.Add(player2);
                        break;
                    case 5:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(7, name, attack, defense, Position.mid);
                        listBox2.Items.Add(player2);
                        break;
                    case 6:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(2, name, attack, defense, Position.mid);
                        listBox2.Items.Add(player2);
                        break;
                    case 7:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(21, name, attack, defense, Position.mid);
                        listBox2.Items.Add(player2);
                        break;
                    case 8:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(19, name, attack, defense, Position.attacker);
                        listBox2.Items.Add(player2);
                        break;
                    case 9:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(3, name, attack, defense, Position.attacker);
                        listBox2.Items.Add(player2);
                        break;
                    case 10:
                        attack = randomgenerator(100);
                        defense = randomgenerator(100);
                        player2 = new Player(9, name, attack, defense, Position.attacker);
                        listBox2.Items.Add(player2);
                        break;
                }
            }
        }

        public int randomgenerator(int max)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, max + 1);
            return random;
        }
        public string namegenerator()
        {
            string name = " ";
            int random = randomgenerator(30);
            switch (random)
            {
                case 0:
                    name = "HTTP 418";
                    break;
                case 1:
                    name = "bart";
                    break;
                case 2:
                    name = "mark";
                    break;
                case 3:
                    name = "gerda";
                    break;
                case 4:
                    name = "steven";
                    break;
                case 5:
                    name = "pearl";
                    break;
                case 6:
                    name = "karel";
                    break;
                case 7:
                    name = "dolfje";
                    break;
                case 8:
                    name = "roos";
                    break;
                case 9:
                    name = "destroyer69";
                    break;
                case 10:
                    name = "starplayer";
                    break;
                case 11:
                    name = "ronaldo";
                    break;
                case 12:
                    name = "messi";
                    break;
                case 13:
                    name = "messy";
                    break;
                case 14:
                    name = "robben";
                    break;
                case 15:
                    name = "alberta";
                    break;
                case 16:
                    name = "india";
                    break;
                case 17:
                    name = "doornroosje";
                    break;
                case 18:
                    name = "7 dwergen";
                    break;
                case 19:
                    name = "name";
                    break;
                case 20:
                    name = "elon";
                    break;
                case 21:
                    name = "xct-018";
                    break;
                case 22:
                    name = "rex";
                    break;
                case 23:
                    name = "ashoka";
                    break;
                case 24:
                    name = "peter parker";
                    break;
                case 25:
                    name = "khalifa";
                    break;
                case 26:
                    name = "tom";
                    break;
                case 27:
                    name = "jerry";
                    break;
                case 28:
                    name = "natasha";
                    break;
                case 29:
                    name = "roodkapje";
                    break;
                case 30:
                    name = "grote boze wolf";
                    break;
            }
            return name;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = team.ToString();
            team1 = team;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = team.ToString();
            team2 = team;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Game game = new Game(team1.players, team2.players);
            game.play();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void keeper_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.keeper;
            listBox3.Items.Remove(player2);
            player2.position = Position.goaly;
            keeper.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.keeper = player2;
            buildteamtree();
        }

        private void defense1_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.defender1;
            listBox3.Items.Remove(player2);
            player2.position = Position.defender;
            defense1.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.defender1 = player2;
            buildteamtree();
        }

        private void defense2_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.defender2;
            listBox3.Items.Remove(player2);
            player2.position = Position.defender;
            defense2.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.defender2 = player2;
            buildteamtree();
        }

        private void defense3_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.defender3;
            listBox3.Items.Remove(player2);
            player2.position = Position.defender;
            defense3.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.defender3 = player2;
            buildteamtree();
        }

        private void mid1_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.mid1;
            listBox3.Items.Remove(player2);
            player2.position = Position.mid;
            mid1.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.mid1 = player2;
            buildteamtree();
        }
        private void mid2_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.mid2;
            listBox3.Items.Remove(player2);
            player2.position = Position.mid;
            mid2.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.mid2 = player2;
            buildteamtree();
        }

        private void mid3_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.mid3;
            listBox3.Items.Remove(player2);
            player2.position = Position.mid;
            mid3.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.mid3 = player2;
            buildteamtree();
        }

        private void mid4_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.mid4;
            listBox3.Items.Remove(player2);
            player2.position = Position.mid;
            mid4.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.mid4 = player2;
            buildteamtree();
        }

        private void attack1_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.attacker1;
            listBox3.Items.Remove(player2);
            player2.position = Position.attacker;
            attack1.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.attacker1 = player2;
            buildteamtree();
        }

        private void attack2_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.attacker2;
            listBox3.Items.Remove(player2);
            player2.position = Position.attacker;
            attack2.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.attacker2 = player2;
            buildteamtree();
        }

        private void attack3_Click(object sender, EventArgs e)
        {
            playerback = teambuilder.attacker3;
            listBox3.Items.Remove(player2);
            player2.position = Position.attacker;
            attack3.Text = player2.name;
            teambuilder.canadd(player2);
            if (playerback.backnumber != 0)
            {
                listBox3.Items.Add(playerback);
            }
            teambuilder.attacker3 = player2;
            buildteamtree();
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            try
            {
                object playerchoice = listBox3.SelectedItem;
                player2 = (Player)playerchoice;
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                object playerchoice = listBox3.SelectedItem;
                player2 = (Player)playerchoice;
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object playerchoice = comboBox1.SelectedItem;
            teambuilder = (Teambuilder)playerchoice;

            buildteamtree();
        }
        private void buildteamtree()
        {
            keeper.Text = teambuilder.keeper.name;
            defense1.Text = teambuilder.defender1.name;
            defense2.Text = teambuilder.defender2.name;
            defense3.Text = teambuilder.defender3.name;
            mid1.Text = teambuilder.mid1.name;
            mid2.Text = teambuilder.mid2.name;
            mid3.Text = teambuilder.mid3.name;
            mid4.Text = teambuilder.mid4.name;
            attack1.Text = teambuilder.attacker1.name;
            attack2.Text = teambuilder.attacker2.name;
            attack3.Text = teambuilder.attacker3.name;

            if (keeper.Text == "")
            {
                keeper.Text = "keeper";
            }
            if (defense1.Text == "")
            {
                defense1.Text = "defense1";
            }
            if (defense2.Text == "")
            {
                defense2.Text = "defense2";
            }
            if (defense3.Text == "")
            {
                defense3.Text = "defense3";
            }
            if (mid1.Text == "")
            {
                mid1.Text = "mid1";
            }
            if (mid2.Text == "")
            {
                mid2.Text = "mid2";
            }
            if (mid3.Text == "")
            {
                mid3.Text = "mid3";
            }
            if (mid4.Text == "")
            {
                mid4.Text = "mid4";
            }
            if (attack1.Text == "")
            {
                attack1.Text = "attack1";
            }
            if (attack2.Text == "")
            {
                attack2.Text = "attack2";
            }
            if (attack3.Text == "")
            {
                attack3.Text = "attack3";
            }

        }
    }
}