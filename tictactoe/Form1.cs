using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int count = 0;
        public static int countX = 0;
        public static int countY = 0;

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TicTacToe_Click(object sender, EventArgs e)
        {
            count++;
            Button clicked = sender as Button;
            if(clicked.Text=="X" || clicked.Text=="O")
            {
             clicked.Enabled = false;
            
            }
            else 
            { if (count % 2 != 0)
            {
                clicked.Text = "X";
                countX++;

            }
            else
            {
                clicked.Text = "O";
                countY++;
            }
              
            }
            
           
            label1.Text = countX.ToString();
            label2.Text = countY.ToString();

            if(button1.Text==button2.Text && button1.Text == button3.Text && (button1.Text == "X" || button1.Text == "O"))
            {
                button1.BackColor = Color.Lime;
                button2.BackColor = Color.Lime;
                button3.BackColor = Color.Lime;
                string win = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else  if ((button4.Text == button5.Text && button4.Text == button6.Text) && (button4.Text=="X" || button4.Text=="O"))
            {
                button4.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button6.BackColor = Color.Lime;
                string win1 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win1);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if ((button7.Text == button8.Text && button7.Text == button9.Text) && (button7.Text == "X" || button7.Text == "O"))
            {
                button7.BackColor = Color.Lime;
                button8.BackColor = Color.Lime;
                button9.BackColor = Color.Lime;
                string win2 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win2);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if ((button1.Text == button4.Text && button1.Text == button7.Text) && (button1.Text == "X" || button1.Text == "O"))
            {
                button7.BackColor = Color.Lime;
                button1.BackColor = Color.Lime;
                button4.BackColor = Color.Lime;
                string win3 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win3);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if ((button2.Text == button5.Text && button2.Text == button8.Text) && (button2.Text == "X" || button2.Text == "O"))
            {
                button2.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button8.BackColor = Color.Lime;
                string win4 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win4);
                button10.Visible = true;
            }
            else if ((button3.Text == button6.Text && button3.Text == button9.Text) && (button3.Text == "X" || button3.Text == "O"))
            {
                button3.BackColor = Color.Lime;
                button6.BackColor = Color.Lime;
                button9.BackColor = Color.Lime;
                string win5 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win5);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if ((button1.Text == button5.Text && button1.Text == button9.Text) && (button1.Text == "X" || button1.Text == "O"))
            {
                button5.BackColor = Color.Lime;
                button1.BackColor = Color.Lime;
                button9.BackColor = Color.Lime;
                string win6 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win6);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if ((button3.Text == button5.Text && button3.Text == button7.Text) && (button3.Text == "X" || button3.Text == "O"))
            {
                button3.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button7.BackColor = Color.Lime;
                string win7 = clicked.Text.ToString();
                MessageBox.Show("Winner is " + win7);
                button10.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            count = 0;
            countX = 0;
            countY = 0;
            label1.Text = " ";
            label2.Text = " ";
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;
            button7.BackColor = Color.Yellow;
            button8.BackColor = Color.Yellow;
            button9.BackColor = Color.Yellow;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            count = 0;
            countX = 0;
            countY = 0;
            label1.Text = " ";
            label2.Text = " ";
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;
            button7.BackColor = Color.Yellow;
            button8.BackColor = Color.Yellow;
            button9.BackColor = Color.Yellow;
        }
    }
}
