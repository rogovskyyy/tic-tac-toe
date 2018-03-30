using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Moves = 0;
        int PlayedGames = 0;
        string WindowTitle = "Kółko i Krzyżyk";
        int[,] tablica = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public void CountMoves()
        {
            if (Moves >= 8)
            {
                tablica = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                Moves = -1;
                MessageBox.Show("Nikt nie wygrał", WindowTitle, MessageBoxButtons.OK);
                this.button1.Text = "";
                this.button2.Text = "";
                this.button3.Text = "";
                this.button4.Text = "";
                this.button5.Text = "";
                this.button6.Text = "";
                this.button7.Text = "";
                this.button8.Text = "";
                this.button9.Text = "";
                PlayedGames += 1;
                this.button11.Text = PlayedGames.ToString();
            }
        }
        public void CountMovesValidate()
            {
                tablica = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                Moves = -1;
                PlayedGames += 1;
                this.button11.Text = PlayedGames.ToString();
        }
        public new void Validate()
        {
            if ((tablica[0, 0] == 1 && tablica[0, 1] == 1 && tablica[0, 2] == 1) || 
                (tablica[0, 0] == 2 && tablica[0, 1] == 2 && tablica[0, 2] == 2) ||

                (tablica[1, 0] == 1 && tablica[1, 1] == 1 && tablica[1, 2] == 1) ||
                (tablica[1, 0] == 2 && tablica[1, 1] == 2 && tablica[1, 2] == 2) ||

                (tablica[2, 0] == 1 && tablica[2, 1] == 1 && tablica[2, 2] == 1) ||
                (tablica[2, 0] == 2 && tablica[2, 1] == 2 && tablica[2, 2] == 2) ||

                (tablica[0, 0] == 1 && tablica[1, 0] == 1 && tablica[2, 0] == 1) ||
                (tablica[0, 0] == 2 && tablica[1, 1] == 2 && tablica[2, 0] == 2) ||

                (tablica[0, 1] == 1 && tablica[1, 1] == 1 && tablica[2, 1] == 1) ||
                (tablica[0, 1] == 2 && tablica[1, 1] == 2 && tablica[2, 1] == 2) ||

                (tablica[0, 2] == 1 && tablica[1, 2] == 1 && tablica[2, 2] == 1) ||
                (tablica[0, 2] == 2 && tablica[1, 2] == 2 && tablica[2, 2] == 2) ||

                (tablica[0, 0] == 1 && tablica[1, 1] == 1 && tablica[2, 2] == 1) ||
                (tablica[0, 0] == 2 && tablica[1, 1] == 2 && tablica[2, 2] == 2) ||

                (tablica[2, 0] == 1 && tablica[1, 1] == 1 && tablica[0, 2] == 1) ||
                (tablica[2, 0] == 2 && tablica[1, 1] == 2 && tablica[0, 2] == 2))
            {
                if (Moves % 2 == 0)
                {
                    MessageBox.Show("Wygrał X", WindowTitle, MessageBoxButtons.OK);
                    CountMovesValidate();
                    this.button1.Text = "";
                    this.button2.Text = "";
                    this.button3.Text = "";
                    this.button4.Text = "";
                    this.button5.Text = "";
                    this.button6.Text = "";
                    this.button7.Text = "";
                    this.button8.Text = "";
                    this.button9.Text = "";

                } else {
                    MessageBox.Show("Wygrał O", WindowTitle, MessageBoxButtons.OK);
                    CountMovesValidate();
                    this.button1.Text = "";
                    this.button2.Text = "";
                    this.button3.Text = "";
                    this.button4.Text = "";
                    this.button5.Text = "";
                    this.button6.Text = "";
                    this.button7.Text = "";
                    this.button8.Text = "";
                    this.button9.Text = "";
                }
            }  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tablica[0, 0] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button1.Text = "X";
                    tablica[0, 0] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button1.Text = "O";
                    tablica[0, 0] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            } else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tablica[0, 1] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button2.Text = "X";
                    tablica[0, 1] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button2.Text = "O";
                    tablica[0, 1] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (tablica[0, 2] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button3.Text = "X";
                    tablica[0, 2] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button3.Text = "O";
                    tablica[0, 2] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (tablica[1, 0] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button4.Text = "X";
                    tablica[1, 0] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button4.Text = "O";
                    tablica[1, 0] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (tablica[1, 1] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button5.Text = "X";
                    tablica[1, 1] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button5.Text = "O";
                    tablica[1, 1] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (tablica[1, 2] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button6.Text = "X";
                    tablica[1, 2] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button6.Text = "O";
                    tablica[1, 2] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (tablica[2, 0] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button7.Text = "X";
                    tablica[2, 0] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button7.Text = "O";
                    tablica[2, 0] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (tablica[2, 1] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button8.Text = "X";
                    tablica[2, 1] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button8.Text = "O";
                    tablica[2, 1] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (tablica[2, 2] == 0)
            {
                if (Moves % 2 == 0)
                {
                    button9.Text = "X";
                    tablica[2, 2] = 1;
                    Validate();
                    CountMoves();
                }
                else
                {
                    button9.Text = "O";
                    tablica[2, 2] = 2;
                    Validate();
                    CountMoves();
                }
                Moves += 1;
            }
            else
            {
                MessageBox.Show("Nie możesz wprowadzać zajętych już pól", WindowTitle, MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zresetować?", WindowTitle, MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                tablica = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                Moves = 0;
                this.button1.Text = "";
                this.button2.Text = "";
                this.button3.Text = "";
                this.button4.Text = "";
                this.button5.Text = "";
                this.button6.Text = "";
                this.button7.Text = "";
                this.button8.Text = "";
                this.button9.Text = "";
            }          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }
    }
}