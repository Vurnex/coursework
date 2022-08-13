/* 

	Laquon Hamilton
	ITS-245
	10/25/20
    Lab 7
	Problem 3

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_3
{
    public partial class LetsMakeADeal : Form
    {
        private string[] newPrizes = { "Haunted House Tickets", "Candy Basket", "Carrots" };
        
        //private int random;

        private bool selected = false;

        private int[] doorPrize;


        Random randomGen = new Random();

        public LetsMakeADeal()
        {
            InitializeComponent();
        }

        private void LetsMakeADeal_Load(object sender, EventArgs e)
        {

            doorPrize = new int[3];
            doorPrize[0] = 0;
            doorPrize[1] = randomGen.Next(1, 3);

            if (doorPrize[1] == 1)
            {
                doorPrize[2] = 2;
            }
            else if (doorPrize[1] == 2)
            {
                doorPrize[2] = 1;
            }
        }

        private void doorOne_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                doorOneLabel.Text = newPrizes[doorPrize[0]];
                doorTwoLabel.Text = newPrizes[doorPrize[1]];
                doorThreeLabel.Text = newPrizes[doorPrize[2]];
                nextChoiceLabel1.Text = "You selected the " + newPrizes[doorPrize[0]] + " prize!";

                nextChoiceLabel1.Visible = true;
                nextChoiceLabel2.Visible = false;
                nextChoiceLabel3.Visible = false;
                doorOneLabel.Visible = true;
                doorTwoLabel.Visible = true;
                doorThreeLabel.Visible = true;
            }
            else
            {
                doorTwoLabel.Text = "";
                doorThreeLabel.Text = "";
                nextChoiceLabel1.Text = "";

                int randomDoor = randomGen.Next(1, 3);

                if (randomDoor == 1)
                {
                    doorTwoLabel.Text = newPrizes[doorPrize[randomDoor]];
                    doorTwoLabel.Visible = true;
                }
                else if (randomDoor == 2)
                {
                    doorThreeLabel.Text = newPrizes[doorPrize[randomDoor]];
                    doorThreeLabel.Visible = true;
                }

                nextChoiceLabel1.Text = "Click on another door if you want to change your selection.";
                nextChoiceLabel1.Visible = true;
                nextChoiceLabel2.Visible = false;
                nextChoiceLabel3.Visible = false;

                selected = true;
            }
        }

        private void doorTwo_Click(object sender, EventArgs e)
        {

            if (selected)
            {
                doorOneLabel.Text = newPrizes[doorPrize[0]];
                doorTwoLabel.Text = newPrizes[doorPrize[1]];
                doorThreeLabel.Text = newPrizes[doorPrize[2]];
                nextChoiceLabel2.Text = "You selected the " + newPrizes[doorPrize[1]] + " prize!";

                nextChoiceLabel1.Visible = false;
                nextChoiceLabel2.Visible = true;
                nextChoiceLabel3.Visible = false;
                doorOneLabel.Visible = true;
                doorTwoLabel.Visible = true;
                doorThreeLabel.Visible = true;

            }
            else
            {
                doorThreeLabel.Text = newPrizes[doorPrize[2]];
                doorThreeLabel.Visible = true;
                nextChoiceLabel2.Text = "Click on another door if you want to change your selection.";
                nextChoiceLabel1.Visible = false;
                nextChoiceLabel2.Visible = true;
                nextChoiceLabel3.Visible = false;

                selected = true;
            }

        }

        private void doorThree_Click(object sender, EventArgs e)
        {

            if (selected)
            {
                doorOneLabel.Text = newPrizes[doorPrize[0]];
                doorTwoLabel.Text = newPrizes[doorPrize[1]];
                doorThreeLabel.Text = newPrizes[doorPrize[2]];
                nextChoiceLabel3.Text = "You selected the " + newPrizes[doorPrize[2]] + " prize!";

                nextChoiceLabel1.Visible = false;
                nextChoiceLabel2.Visible = false;
                nextChoiceLabel3.Visible = true;
                doorOneLabel.Visible = true;
                doorTwoLabel.Visible = true;
                doorThreeLabel.Visible = true;

            }
            else
            {
                doorThreeLabel.Text = newPrizes[doorPrize[2]];
                doorThreeLabel.Visible = true;
                nextChoiceLabel3.Text = "Click on another door if you want to change your selection.";
                nextChoiceLabel3.Visible = true;
                nextChoiceLabel2.Visible = false;

                selected = true;
            }

        }
    }
}
