using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        bool isWinner = false;
        bool turn = false;
        int turnCounter = 0;
        string winner;

        int PlayerXPoint;


        Button button = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this game is made by lado oqruashvili");
        }

        private void ButtonClickEvent(object sender, EventArgs e)
        {
            button = (Button)sender;

            if (turn)
            { 
                button.Text = "O";
            button.BackColor = Color.Blue;
            }
            else
            {
                button.Text = "X";
                button.BackColor = Color.Red;
            }

            turnCounter++;
            turn = !turn;
            button.Enabled = false;


            CheckWinner();
        }


        public void CheckWinner()
        {

            // ჰორიზონტალური შემოწმება

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                isWinner = true;

            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                isWinner = true;

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                isWinner = true;


            // ვერტიკალური შემოწმება

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                isWinner = true;
            
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                isWinner = true;
            
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                isWinner = true;


            // დიაგონალური შემოწმება

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                isWinner = true;
            
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                isWinner = true;


               

            if (isWinner)
            {
                

                if (turn)
                    winner = "X";
                else
                    winner = "O";


                MessageBox.Show($"თამაშის გამარჯვებულია {winner}");
                StopClickEventButton();

            }



            if (turnCounter == 9 && isWinner == false)
            {
                MessageBox.Show("თამაში ფრედ დასრულდა.");
            }



        }




        private void StopClickEventButton()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

