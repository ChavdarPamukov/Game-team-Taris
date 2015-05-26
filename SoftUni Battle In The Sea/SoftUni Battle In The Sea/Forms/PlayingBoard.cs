using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftUni_Battle_In_The_Sea.Interfaces;
using SoftUni_Battle_In_The_Sea.Forms;
using SoftUni_Battle_In_The_Sea.Factories;
using System.IO;

namespace SoftUni_Battle_In_The_Sea
{
    public partial class PlayingBoard : Form
    {
        private Player[] _players;
        private int _numberOfPlayers;
        private String _shipImagepath = Directory.GetCurrentDirectory() + "../../../Resources/Historic-Ship.ico";
        //private String _hitImagePath;
        //private String _missedHitImagePath;

        public PlayingBoard()
        {
            InitializeComponent();
            reinitialyzeBoard();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by a team \"Taris\"", "SoftUni Battle In The Sea About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reinitialyzeBoard()
        {
            for (int i = 1; i <= 50; i++)
            {
                Button button = GetButtonFor(i);
                button.Image = System.Drawing.Image.FromFile(this._shipImagepath);
                button.TextImageRelation = TextImageRelation.TextAboveImage;
                button.BackColor = Color.Teal;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reinitialyzeBoard();

            this._numberOfPlayers = 2;
            this._players = new Player[this._numberOfPlayers];

            BeginStageOne();
        }

        private void BeginStageOne()
        {
            ShowInstructions();
            CreatePlayers();
            SetShipsOnTheBoard();

            BeginStageTwo();
        }

        private void BeginStageTwo()
        {
            bool winCondition = false;
            int flag = 0;
            while (!winCondition)
            {
                Player guessingPlayer;
                Player checkingPlayer;
                if (flag == 0)
                {
                    guessingPlayer = this._players[0];
                    checkingPlayer = this._players[1];
                    flag = 1;
                }
                else
                {
                    guessingPlayer = this._players[1];
                    checkingPlayer = this._players[0];
                    flag = 0;
                }

                int hitLocation = -1;
                while (!HitLocationIsNotMarked(hitLocation))
                {
                    hitLocation = guessingPlayer.ChooseHitLocation();
                    if (hitLocation == -2)
                    {
                        this.Close();
                    }
                }

                if (IsAHit(hitLocation, checkingPlayer)) 
                {
                    PlayerHasWon(guessingPlayer);
                    winCondition = true;
                }
                else
                {
                    SetHitLocationOnBoard(hitLocation);
                }
            }
        }

        private void PlayerHasWon(Player player)
        {
            PopupNotificationForm popup = new PopupNotificationForm();
            String playerName;
            if (player.IsHuman()) 
            {
                playerName = this.label1.Text; 
            } else 
            {
                playerName = this.label2.Text;
            }
            popup.SetText(playerName + " has won!");
            popup.ShowDialog();
        }

        private void SetHitLocationOnBoard(int hitLocation)
        {
            Button button = GetButtonFor(hitLocation);
            button.BackColor = Color.Yellow;
        }

        private bool IsAHit(int hitLocation, Player player)
        {
            Battleship[] battleships = player.GetBattleships();
            for (int i = 0; i < battleships.Length; i++)
            {
                if (battleships[i].IsHit(hitLocation))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HitLocationIsNotMarked(int hitLocation)
        {
            if (hitLocation == -1)
            {
                return false;
            }

            Button button = GetButtonFor(hitLocation);
            return button.BackColor != Color.Yellow;
        }

        private void CreatePlayers()
        {
            int playerTypeFlag = 0;
            for (int i = 0; i < this._players.Length; i++)
            {
                if (playerTypeFlag == 0)
                {
                    this._players[i] = PlayerFactory.PLAYER_FACTORY.BuildPlayer("human");
                    playerTypeFlag = 1;
                }
                else
                {
                    this._players[i] = PlayerFactory.PLAYER_FACTORY.BuildPlayer("computer");
                    playerTypeFlag = 0;
                }

                this._players[i].CreateBattleships();
            }
        }

        private void SetShipsOnTheBoard()
        {
            for (int i = 0; i < this._players.Length; i++)
            {
                Player player = this._players[i];
                for (int j = 0; j < player.GetShipCount(); j++)
                {
                    Battleship ship = player.GetBattleships()[j];
                    int location = -1;
                    while (!LocationIsNotSet(location))
                    {
                        location = player.GetLocationForShip();
                        if (location == -2)
                        {
                            this.Close();
                        }
                    }

                    SetShip(location, ship, player);
                }
            }
        }

        private bool LocationIsNotSet(int location)
        {
            if (location == -1)
            {
                return false;
            }
            Button button = GetButtonFor(location);
            return button.BackColor != Color.Red;
            //return button.Image 
        }

        private void SetShip(int location, Battleship ship, Player player)
        {
            if (player.IsHuman())
            {
                Button button = GetButtonFor(location);
                button.BackColor = Color.Red;
            }

            ship.SetLocation(location);
        }

        private Button GetButtonFor(int location)
        {
            switch (location)
            {
                case 1:
                    return button1;
                case 2:
                    return button2;
                case 3:
                    return button3;
                case 4:
                    return button4;
                case 5:
                    return button5;
                case 6:
                    return button6;
                case 7:
                    return button7;
                case 8:
                    return button8;
                case 9:
                    return button9;
                case 10:
                    return button10;
                case 11:
                    return button11;
                case 12:
                    return button12;
                case 13:
                    return button13;
                case 14:
                    return button14;
                case 15:
                    return button15;
                case 16:
                    return button16;
                case 17:
                    return button17;
                case 18:
                    return button18;
                case 19:
                    return button19;
                case 20:
                    return button20;
                case 21:
                    return button21;
                case 22:
                    return button22;
                case 23:
                    return button23;
                case 24:
                    return button24;
                case 25:
                    return button25;
                case 26:
                    return button26;
                case 27:
                    return button27;
                case 28:
                    return button28;
                case 29:
                    return button29;
                case 30:
                    return button30;
                case 31:
                    return button31;
                case 32:
                    return button32;
                case 33:
                    return button33;
                case 34:
                    return button34;
                case 35:
                    return button35;
                case 36:
                    return button36;
                case 37:
                    return button37;
                case 38:
                    return button38;
                case 39:
                    return button39;
                case 40:
                    return button40;
                case 41:
                    return button41;
                case 42:
                    return button42;
                case 43:
                    return button43;
                case 44:
                    return button44;
                case 45:
                    return button45;
                case 46:
                    return button46;
                case 47:
                    return button47;
                case 48:
                    return button48;
                case 49:
                    return button49;
                case 50:
                    return button50;
                default:
                    throw new Exception("Invalid location returned from player");
            }
        }

        private void ShowInstructions()
        {
            PopupNotificationForm popup = new PopupNotificationForm();
            popup.ShowDialog();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInstructions();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void startButoon_Click(object sender, EventArgs e)
        {
             for (int i = 1; i <= 50; i++)
            {
                Button button = GetButtonFor(i);
                button.BackColor = Color.White;
            }

            this._numberOfPlayers = 2;
            this._players = new Player[this._numberOfPlayers];

            BeginStageOne();
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }
        }
    }

