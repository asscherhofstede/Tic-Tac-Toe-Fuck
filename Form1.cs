using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        bool turn = true;//true =x turn; false = o turn;
        double turn_count=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jo Kevin bro dit werkt nu gewoon hoe goed suck my dick not for real tho. Ik hoop dat je mooie tijd hebt!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "x";
            }
            else
            {
                b.Text = "o";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForWinner();
        }
        
        private void CheckForWinner()
        {
           bool There_Is_A_Winner = false;
        //horizontaal 
           
           if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A3.Text == A4.Text) && (!A1.Enabled))
           {
                There_Is_A_Winner = true;
           }
            
           if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B3.Text == B4.Text) && (!B1.Enabled))
           {
               There_Is_A_Winner = true;
           }
           
           if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C3.Text == C4.Text) && (!C1.Enabled))
           {
               There_Is_A_Winner = true;
           }          
          
           if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (D3.Text == D4.Text) && (!D1.Enabled))
           {
               There_Is_A_Winner = true;
           }
            //verticaal
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (C1.Text == D1.Text)&&(!A1.Enabled))
            {
                There_Is_A_Winner = true;
            }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (C2.Text == D2.Text)&&(!A2.Enabled))
            {
                There_Is_A_Winner = true;
            }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (C3.Text == D3.Text)&&(!A3.Enabled))
            {
                There_Is_A_Winner = true;
            }
            if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (C4.Text == D4.Text)&&(!A4.Enabled))
            {
                There_Is_A_Winner = true;
            }
            //Schuin
            if ((A1.Text == B2.Text)&&(B2.Text==C3.Text)&&(C3.Text==D4.Text)&&(!A1.Enabled))
            {
                There_Is_A_Winner = true;
            }
            if ((A4.Text == B3.Text) && (B3.Text == C2.Text) && (C2.Text == D1.Text)&&(!A4.Enabled))
            {
                There_Is_A_Winner = true;
            }


            if (There_Is_A_Winner)
            {
                DisableButton();
                string winner = "";
                if(turn)
                {
                    winner = "o";
                }
                else
                {
                    winner = "x";
                }
               MessageBox.Show("jo wow goed van je man koop een sticker!");
            }
            else
            {
                if( turn_count == 16)
                {
                    MessageBox.Show("1 Van jullie is een DICK!");
                }
            }
           
           
        }
        private void DisableButton()
        {

            try
            {


                foreach (Control C in Controls)
                {
                    Button b = (Button)C;
                    b.Enabled = false;
                }
            }
            catch { }


        }
    }
}
