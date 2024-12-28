using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.BringToFront();
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coin(gamespeed);
            coinscollection();
            
        }

        int collectedcoins = 0;
        Random r = new Random();
        int x;

        //enemy
        void enemy(int speed)
        {

            if (enemy1.Top >= 500)
            {
                x = r.Next(25, 140);

                enemy1.Location = new Point(x, 0);

            }
            else { enemy1.Top += speed; }



            if (enemy2.Top >= 500)
            {
                x = r.Next(206, 295);

                enemy2.Location = new Point(x, 0);

            }
            else { enemy2.Top += speed; }



            if (enemy3.Top >= 500)
            {
                x = r.Next(206, 295);

                enemy3.Location = new Point(x, 0);

            }
            else { enemy3.Top += speed; }





        }

        //coins movment

        void coin(int speed)
        {

            if (coins1.Top >= 500)
            {
                x = r.Next(206, 295);

                coins1.Location = new Point(x, 0);

            }
            else { coins1.Top += speed; }


            if (coins2.Top >= 500)
            {
                x = r.Next(25, 140);

                coins2.Location = new Point(x, 0);

            }
            else { coins2.Top += speed; }



            if (coins3.Top >= 500)
            {
                x = r.Next(206, 295);

                coins3.Location = new Point(x, 0);

            }
            else { coins3.Top += speed; }



            if (coins4.Top >= 500)
            {
                x = r.Next(25, 140);

                coins4.Location = new Point(x, 0);

            }
            else { coins4.Top += speed; }

            if (redcoin.Top >= 500)
            {
                x = r.Next(25, 295); // Random horizontal position
                redcoin.Location = new Point(x, 0); // Random y between 0 and 200
            }
            else
            {
                redcoin.Top += speed; // Move the red coin down
            }

        }







        //game over 
        void gameover()
        {

            if (car.Bounds.IntersectsWith(enemy1.Bounds))

            {


                timer1.Enabled = false;
                over.Visible = true;
            }


            if (car.Bounds.IntersectsWith(enemy2.Bounds))

            {


                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))

            {


                timer1.Enabled = false;
                over.Visible = true;
            }

        }

        //street line movment
        void moveline(int speed) {

            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else { pictureBox1.Top += speed; }


            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else { pictureBox5.Top += speed; }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else { pictureBox6.Top += speed; }

            if (pictureBox7.Top >= 500)
            {
                pictureBox7.Top = 0;
            }
            else { pictureBox7.Top += speed; }



        }

        void coinscollection()
        {

            if (car.Bounds.IntersectsWith(coins1.Bounds))

            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                coins1.Location = new Point(x, 0);
            }


            if (car.Bounds.IntersectsWith(coins2.Bounds))

            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                coins2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coins3.Bounds))

            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                coins3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coins4.Bounds))

            {
                collectedcoins++;
                label1.Text = "Coins = " + collectedcoins.ToString();
                coins4.Location = new Point(x, 0);
            }


            if (car.Bounds.IntersectsWith(redcoin.Bounds))
            {
                collectedcoins += 10; // Add 10 points
                label1.Text = "Coins = " + collectedcoins.ToString();

                // Reset the red coin position
                redcoin.Location = new Point(r.Next(25, 295), r.Next(0, 200));
            }

        }

        void ResetGame()
        {
            // Reset game speed
            gamespeed = 0;

            // Reset collected coins
            collectedcoins = 0;
            label1.Text = "Coins = " + collectedcoins.ToString();

            // Reset car position
            car.Location = new Point(150, 400);

            // Reset enemy positions
            enemy1.Location = new Point(r.Next(25, 140), r.Next(0, 200));
            enemy2.Location = new Point(r.Next(206, 295), r.Next(0, 200));
            enemy3.Location = new Point(r.Next(206, 295), r.Next(0, 200));

            // Reset coin positions
            coins1.Location = new Point(r.Next(206, 295), r.Next(0, 200));
            coins2.Location = new Point(r.Next(25, 140), r.Next(0, 200));
            coins3.Location = new Point(r.Next(206, 295), r.Next(0, 200));
            coins4.Location = new Point(r.Next(25, 140), r.Next(0, 200));

            // Hide "Game Over" message
            over.Visible = false;

            // Re-enable the timer
            timer1.Enabled = true;
        }




        int gamespeed = 0;
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //car move to Left
            {


                if (car.Left > 25)
                    car.Left += -10;
            }



            if (e.KeyCode == Keys.Right)//car move to right
            {
                if (car.Left < 318)
                    car.Left += 10;
            }


            //car speed up
            if (e.KeyCode == Keys.Up) {
                if (gamespeed < 5)
                {



                    gamespeed++;


                }
            
            }


            //car speed down
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {

                    gamespeed--;



                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void over_MouseEnter(object sender, EventArgs e)
        {
            // Change the label's background color or font style on hover
            over.BackColor = Color.LightBlue; // Change background color
            over.ForeColor = Color.DarkBlue;  // Change text color
            over.Font = new Font(over.Font, FontStyle.Bold); // Make text bold
            over.Text = "New Game";
        }

        private void over_MouseLeave(object sender, EventArgs e)
        {
            // Revert the label's background color or font style when the mouse leaves
            over.BackColor = Color.Black; // Reset to original background
            over.ForeColor = Color.Red;       // Reset text color
            over.Font = new Font(over.Font, FontStyle.Bold); // Reset text style
            over.Text = "Game Over";
        }
    }
}
