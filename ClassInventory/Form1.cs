using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List <Players> players = new List <Players> (); 

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen
            int age = Convert.ToInt32(ageInput.Text);
            string playerName = nameInput.Text;
            string team = teamInput.Text;
            string position = positionInput.Text;   

            // TODO - create object with gathered information
            Players p = new Players(age, playerName, team, position); 

            // TODO - add object to global list
            players.Add(p);

            // TODO - display message to indicate addition made
            outputLabel.Text = "Player added";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            string playerName = removeInput.Text;
            Players player = players.Find(x => x.playerName == removeInput.Text);

            // TODO - if object is in list remove it
            if (players.Contains(player))
            {
                players.Remove(player);
            }

            // TODO - display message to indicate deletion made
            outputLabel.Text = "Player removed";

            //foreach (Players player in players)
            //{
            //    if (playerName == player.playerName)
            //    {
            //        players.Remove(player);
            //        outputLabel.Text = "Player removed";
            //        break;
            //    }
            //}
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            string playerName = nameSearchInput.Text;
            Players player = players.Find(x => x.playerName == nameSearchInput.Text);

            // TODO - if object entered exists in list show it
            if (players.Contains(player))
            {
                outputLabel.Text = $"{playerName}"; 
            }
            // TODO - else show not found message
            else
            {
                outputLabel.Text = "Player not found";
            }    
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list. Use a foreach loop.
            outputLabel.Text = "";

            foreach (Players player in players)
            {
                outputLabel.Text += $"{player.playerName} {player.age} {player.team} {player.position}\n";
            }
        }
    }
}
