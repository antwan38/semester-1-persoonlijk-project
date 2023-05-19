using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slang
{
    public partial class font : Form
    {
        Random rnd = new Random();
        int posx = 30;
        int posy = 100;
        string textFile = "C://Users//Antwa//OneDrive//Documenten//leaderbord.txt";
        string[] highscoreHolder = new string[5];
        string[] output = new string[5];
        int blockBluePosX = 0;
        int blockBluePosY = 0;
        int blockGreenPosX = 0;
        int blockGreenPosY = 0;
        int blockOrangePosX = 0;
        int blockOrangePosY = 0;
        int enemyBlockPosx = 60;
        int enemyBlockposy = 0;
        int enemyKillerBlockPosx = 2000;
        int enemyKillerBlockposy = 0;
        int killerEnemyLifes = 2;
        int minPosXBlue = 0;
        int maxPosXBlue = 0;
        int minPosYBlue = 0;
        int maxPosYBlue = 0;
        int minPosXOrange = 0;
        int maxPosXOrange = 0;
        int minPosYOrange = 0;
        int maxPosYOrange = 0;
        int minPosXGreen = 0;
        int maxPosXGreen = 0;
        int minPosYGreen = 0;
        int maxPosYGreen = 0;
        int enemyMinPosX = 0;
        int enemyMaxPosX = 0;
        int enemyMinPosY = 0;
        int enemyMaxPosY = 0;
        int blockspeed = 5;
        int schotspeed = 5;
        int speed = 0;
        int schotx = 0;
        int schotGreenx = 0;
        int schotBluex = 0;
        int gametimes = 0;
        int score = 0;
        bool nonkeypress = true;
        bool dead = false;
        bool btGreenHide = true;
        bool btBlueHide = true;
        bool btOrangeHide = true;
        int schot2PosY = 0;
        int schot3PosY = 0;
        int schot1PosY = 0;
        int secondsPast = 0;
        int colorPower = 0;
        int AmmoAmmount = 0;
        bool xmovement = false;
        bool ymovement = false;
        string[] Ammo = new string[4];
        int i = 0;
        public font()
        {
            InitializeComponent();
            enemy.Hide();
            killerEnemy.Hide();
            rShotOrange.Hide();
            sHead.Hide();
            lSurviveTime.Hide();
            lTime.Hide();
            lSelect.Hide();
            lpijl.Hide();
            lAmmo.Hide();
            lAmmoCount.Hide();
            btBlue.Hide();
            btGreen.Hide();
            btOrange.Hide();
            rShotBlue.Hide();
            rShotGreen.Hide();
            lScore.Hide();
            lScoreStatus.Hide();
            lHighscoreState.Hide();
            lEnterusername.Hide();
            tbUsername.Hide();
            btEnter.Hide();
            lHighscore.Hide();
            sHead.Location = new Point(posx, posy);
            killerEnemy.Location = new Point(enemyKillerBlockPosx, enemyKillerBlockposy);
        }





        private void sHead_CheckedChanged(object sender, EventArgs e)
        {
            if (sHead.Checked)
            {
                lSelect.Hide();
                lpijl.Hide();
            }
            if (sHead.Checked == false)
            {
                lSelect.Show();
                lpijl.Show();
            }
        }
       
        private void sHead_KeyDown(object sender, KeyEventArgs e)
        {
            nonkeypress = false;

            if (e.KeyCode == Keys.D)
            {
                if (e.KeyCode == Keys.ShiftKey)
                {
                    speed = 50;
                }
                speed = 10;
                xmovement = true;
                ymovement = false;


            }
            else
            if (e.KeyCode == Keys.A)
            {
                
                speed = -10;
                xmovement = true;
                ymovement = false;
               

            }
            else
            if (e.KeyCode == Keys.S)
            {
                
                speed = 10;
                ymovement = true;
                xmovement = false;
               

            }
            else
            if (e.KeyCode == Keys.W)
            {
                
                ymovement = true;
                xmovement = false;
                speed = -10;
               
            }
            else
            if (e.KeyCode == Keys.D && e.KeyCode == Keys.S)
            {
                
                speed = 10;
                ymovement = true;
                xmovement = true;
            }
            else
            if (e.KeyCode == Keys.A && e.KeyCode == Keys.S)
            {
                
                speed = 10;
                ymovement = true;
                xmovement = true;
            }
            
                if (e.KeyCode == Keys.Space)
                {
                if (i > 0)
                {
                    switch (Ammo[i])
                    {
                        case "Orange":

                            rShotOrange.Location = new Point(posx, posy);
                            schotx = posx;
                            rShotOrange.Show();
                            i--;
                            break;




                        case "Blue":

                            rShotBlue.Location = new Point(posx, posy);
                            schotBluex = posx;
                            rShotBlue.Show();
                            i--;
                            break;



                        case "Green":

                            rShotGreen.Location = new Point(posx, posy);
                            schotGreenx = posx;
                            rShotGreen.Show();
                            i--;
                            break;
                    }

                }


                }
                if(e.KeyCode == Keys.D && e.KeyCode == Keys.ShiftKey)
                {
                speed = 50;
                xmovement = true;
                ymovement = false;
                }
           
           

        }

        private void enemy_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gametime_Tick(object sender, EventArgs e)
        {
            block_obstakel();
            playerSpeed();
            crashen();
            schieten();
            oppakken();
            killen();
            
            
        }
        private void block_obstakel()
        {
            enemy.Location = new Point(enemyBlockPosx, enemyBlockposy += blockspeed);
            if (score >= 5 )
            {
                killerEnemy.Location = new Point(enemyKillerBlockPosx, enemyKillerBlockposy += blockspeed);
                killerEnemy.Show();

            }

            if (enemyBlockposy > 410)
            {

                enemyBlockposy = 0;
                enemyBlockPosx = rnd.Next(1, 820);
                enemy.Location = new Point(enemyBlockPosx, enemyBlockposy);
            }

            if (enemyKillerBlockposy > 370)
            {

                enemyKillerBlockposy = 0;
                enemyKillerBlockPosx = rnd.Next(1, 820);
                killerEnemy.Location = new Point(enemyKillerBlockPosx, enemyKillerBlockposy);
            }

        }


        public void crashen()
        {

            enemyMinPosX = enemy.Location.X - 13;
            enemyMaxPosX = enemy.Location.X + 45;
            enemyMaxPosY = enemy.Location.Y + 44;
            enemyMinPosY = enemy.Location.Y - 13;
           

            if (posx > enemyMinPosX && posx < enemyMaxPosX && posy < enemyMaxPosY && posy > enemyMinPosY && enemy.Visible)
            {
                dead = true;
            }

            if (sHead.Bounds.IntersectsWith(killerEnemy.Bounds) && killerEnemy.Visible)
            {
                dead = true;
            }

            if (dead == true)
            { 
                gametime.Stop();
                seconden.Stop();
                MessageBox.Show("Je bent gecrashed\nyour score = " + Convert.ToString(score) + "\nyour survivaltime = " + Convert.ToString(gametimes) + "\n\nHighscore holder:\n" + File.ReadAllLines(textFile)[0] + "\n" + File.ReadAllLines(textFile)[1] + " Score\n" + File.ReadAllLines(textFile)[2]+" Survivaltime", "Je bent gecrashed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(score >  Convert.ToInt32( File.ReadAllLines(textFile)[1])){
                    lEnterusername.Show();
                    tbUsername.Show();
                    btEnter.Show();
                     MessageBox.Show("YOU GOT A NEW HIGHSCORE!!!!!!!!!!!!!!!", "Lekker man", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                }
                else
                {
                    posx = 30;
                    posy = 100;
                    enemyKillerBlockPosx = 2000;
                    enemyKillerBlockposy = 0;
                    score = 0;
                    AmmoAmmount = 0;
                    gametime.Interval = 100;
                    i = 0;
                    lpijl.Hide();
                    lSelect.Hide();
                    gametimes = 0;
                    secondsPast = 0;
                    lTime.Text = "0";
                    lAmmoCount.Text = "X   X   X";
                    lScoreStatus.Text = "0";
                    killerEnemy.Location = new Point(enemyKillerBlockPosx, enemyBlockposy);
                    sHead.Location = new Point(posx, posy);
                    dead = false;
                    btBlue.Location = new Point(1000, 800);
                    btOrange.Location = new Point(1000, 800);
                    btGreen.Location = new Point(1000, 800);
                    btGreenHide = true;
                    btBlueHide = true;
                    btOrangeHide = true;
                    enemy.Hide();
                    rShotOrange.Hide();
                    sHead.Hide();
                    lSurviveTime.Hide();
                    lTime.Hide();
                    lSelect.Hide();
                    lpijl.Hide();
                    lAmmo.Hide();
                    lAmmoCount.Hide();
                    btBlue.Hide();
                    btGreen.Hide();
                    btOrange.Hide();
                    rShotBlue.Hide();
                    rShotGreen.Hide();
                    lScore.Hide();
                    lScoreStatus.Hide();
                    btStart.Show();
                    lStart.Show();
                    lCredit.Show();
                    btLeaderbord.Show();
                    sHead.Checked = false;
                }
                
               

            }
        }

        public void schieten()
        {


            rShotOrange.Location = new Point(schotx, rShotOrange.Location.Y - schotspeed);
            rShotGreen.Location = new Point(schotGreenx, rShotGreen.Location.Y - schotspeed);
            rShotBlue.Location = new Point(schotBluex, rShotBlue.Location.Y - schotspeed);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Hide();
            lStart.Hide();
            enemyBlockPosx = rnd.Next(60, 700);
            enemyBlockposy = 0;
            enemy.Location = new Point(enemyBlockPosx, enemyBlockposy);
            lCredit.Hide();
            gametime.Start();
            enemy.Show();
            sHead.Show();
            lSurviveTime.Show();
            lTime.Show();
            seconden.Start();
            lSelect.Show();
            lpijl.Show();
            lAmmo.Show();
            lAmmoCount.Show();
            lScoreStatus.Show();
            lScore.Show();
            btLeaderbord.Hide();
        }

        private void lTime_Click(object sender, EventArgs e)
        {

        }

        private void lSurviveTime_Click(object sender, EventArgs e)
        {

        }

        private void seconden_Tick(object sender, EventArgs e)
        {
            gametimes += 1;
            lTime.Text = Convert.ToString(gametimes);
            if (i + AmmoAmmount < 3)
            {
                if (gametimes - secondsPast >= 4)
                {
                    if (gametime.Interval > 3)
                    {
                        gametime.Interval -= 3;
                    }
                    secondsPast = gametimes;
                    colorPower = rnd.Next(4);
                    blockBluePosX = rnd.Next(10, 820);
                    blockBluePosY = rnd.Next(10, 400);
                    blockGreenPosX = rnd.Next(10, 820);
                    blockGreenPosY = rnd.Next(10, 400);
                    blockOrangePosX = rnd.Next(10, 820);
                    blockOrangePosY = rnd.Next(10, 400);

                    switch (colorPower)
                    {
                        case 0:
                            btGreen.Location = new Point(blockGreenPosX, blockGreenPosY);
                            if (btGreenHide == true)
                            {
                                btGreen.Show();
                                btGreenHide = false;
                                AmmoAmmount++;
                            }

                            break;
                        case 1:
                            btBlue.Location = new Point(blockBluePosX, blockBluePosY);
                            if (btBlueHide == true)
                            {
                                btBlue.Show();
                                btBlueHide = false;
                                AmmoAmmount++;
                            }
                            break;
                        case 2:
                            btOrange.Location = new Point(blockOrangePosX, blockOrangePosY);
                            if (btOrangeHide == true)
                            {
                                btOrange.Show();
                                btOrangeHide = false;
                                AmmoAmmount++;
                            }
                            break;

                    }
                }
            }
        }

        public void killen()
        {
            schot1PosY = rShotOrange.Location.Y;
            schot2PosY = rShotGreen.Location.Y;
            schot3PosY = rShotBlue.Location.Y;

            if (schotx > enemyMinPosX && schotx < enemyMaxPosX && schot1PosY < enemyMaxPosY && schot1PosY > enemyMinPosY && enemy.Visible && rShotOrange.Visible)
            {
                rShotOrange.Hide();
                enemyBlockposy = 0;
                enemyBlockPosx = rnd.Next(1, 820);
                enemy.Location = new Point(enemyBlockPosx, enemyBlockposy);
                score++;
                lScoreStatus.Text = Convert.ToString(score);
            }

            if (schotGreenx > enemyMinPosX && schotGreenx < enemyMaxPosX && schot2PosY < enemyMaxPosY && schot2PosY > enemyMinPosY && enemy.Visible && rShotGreen.Visible)
            {
                rShotGreen.Hide();
                enemyBlockposy = 0;
                enemyBlockPosx = rnd.Next(1, 820);
                enemy.Location = new Point(enemyBlockPosx, enemyBlockposy);
                score++;
                lScoreStatus.Text = Convert.ToString(score);
            }

            if (schotBluex > enemyMinPosX && schotBluex < enemyMaxPosX && schot3PosY < enemyMaxPosY && schot3PosY > enemyMinPosY && enemy.Visible && rShotBlue.Visible)
            {
                rShotBlue.Hide();
                enemyBlockposy = 0;
                enemyBlockPosx = rnd.Next(1, 820);
                enemy.Location = new Point(enemyBlockPosx, enemyBlockposy);
                score++;
                lScoreStatus.Text = Convert.ToString(score);
            }




            if (rShotOrange.Bounds.IntersectsWith(killerEnemy.Bounds)&& killerEnemy.Visible && rShotOrange.Visible)
            {
                rShotOrange.Hide();
                killerEnemyLifes--;
            }

            if (rShotGreen.Bounds.IntersectsWith(killerEnemy.Bounds) && killerEnemy.Visible && rShotGreen.Visible)
            {
                rShotGreen.Hide();
                killerEnemyLifes--;
            }

            if (rShotBlue.Bounds.IntersectsWith(killerEnemy.Bounds) && killerEnemy.Visible && rShotBlue.Visible)
            {
                rShotBlue.Hide();
                killerEnemyLifes--;
            }

            if (killerEnemyLifes == 0)
            {
                score += 3;
                killerEnemy.Hide();
                killerEnemyLifes = 2;
                lScoreStatus.Text = Convert.ToString(score);
                enemyKillerBlockposy = 0;
                enemyKillerBlockPosx = rnd.Next(1000, 2000);
                killerEnemy.Location = new Point(enemyKillerBlockPosx, enemyKillerBlockposy);
            }



        }
        public void oppakken()
        {
            minPosXBlue = btBlue.Location.X - 13;
            maxPosXBlue = btBlue.Location.X + 45;
            maxPosYBlue = btBlue.Location.Y + 44;
            minPosYBlue = btBlue.Location.Y - 13;
            minPosXOrange = btOrange.Location.X - 13;
            maxPosXOrange = btOrange.Location.X + 45;
            maxPosYOrange = btOrange.Location.Y + 44;
            minPosYOrange = btOrange.Location.Y - 13;
            minPosXGreen = btGreen.Location.X - 13;
            maxPosXGreen = btGreen.Location.X + 45;
            maxPosYGreen = btGreen.Location.Y + 44;
            minPosYGreen = btGreen.Location.Y - 13;

            if (posx > minPosXGreen && posx < maxPosXGreen && posy < maxPosYGreen && posy > minPosYGreen && btGreen.Visible)
            {
                btGreen.Hide();
                btGreenHide = true;
                AmmoAmmount--;
                i++;
                Ammo[i] = "Green";

            }

            if (posx > minPosXOrange && posx < maxPosXOrange && posy < maxPosYOrange && posy > minPosYOrange && btOrange.Visible)
            {
                btOrange.Hide();
                btOrangeHide = true;
                AmmoAmmount--;
                i++;
                Ammo[i] = "Orange";


            }

            if (posx > minPosXBlue && posx < maxPosXBlue && posy < maxPosYBlue && posy > minPosYBlue && btBlue.Visible)
            {
                btBlue.Hide();
                btBlueHide = true;
                AmmoAmmount--;
                i++;
                Ammo[i] = "Blue";

            }
            switch (i)
            {
                case 0:
                    lAmmoCount.Text = "0/3";

                    break;
                case 1:
                    lAmmoCount.Text = "1/3";

                    break;
                case 2:
                    lAmmoCount.Text = "2/3";

                    break;
                case 3:
                    lAmmoCount.Text = "3/3";

                    break;
            }

        }

        public void playerSpeed()
        {
            
            if (speed > 0 && nonkeypress == true)
            {
                speed--;
            }

            if (speed < 0 && nonkeypress == true)
            {
                speed++;
            }
            if (xmovement == true)
            {
                sHead.Location = new Point(posx += speed, posy);
            }

            if (ymovement == true)
            {
                sHead.Location = new Point(posx, posy += speed);
            }

            if (posy > 430)
            {
                posy = 10;
            }
            if (posy < 10)
            {
                posy = 430;
            }
            if (posx > 820)
            {
                posx = 10;
            }
            if (posx < 10)
            {
                posx = 820;
            }

        }

        private void sHead_KeyUp(object sender, KeyEventArgs e)
        {
            nonkeypress = true;
        }

        private void btLeaderbord_Click(object sender, EventArgs e)
        {
            if (lHighscore.Visible)
            {
                lHighscore.Hide();
                lHighscoreState.Hide();
                lHighscoreState.Text = "";
                btStart.Show();
                lStart.Show();
            }
            else
            {   
                lHighscoreState.Show();
                lHighscore.Show();
                lHighscoreState.Text = "";
                btStart.Hide();
                lStart.Hide();
            }
            for (int i = 0; i < File.ReadAllLines(textFile).Length; i++)
            {
                highscoreHolder[i] = File.ReadAllLines(textFile)[i];
                if (i == 0)
                {
                    lHighscoreState.Text = highscoreHolder[i] + " \n"; 
                }
                else if (i == 1)
                {
                    lHighscoreState.Text += highscoreHolder[i] + " Score \n";
                }
                else if (i == 2)
                {
                    lHighscoreState.Text += highscoreHolder[i] + " Survivaltime \n";
                }

                

            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            lEnterusername.Hide();
            tbUsername.Hide();
            btEnter.Hide();
            output[0] = tbUsername.Text;
            output[1] = Convert.ToString(score);
            output[2] = Convert.ToString(gametimes);
            File.WriteAllLines(textFile, output);

            posx = 30;
            posy = 100;
            enemyKillerBlockPosx = 2000;
            enemyKillerBlockposy = 0;
            score = 0;
            AmmoAmmount = 0;
            gametime.Interval = 100;
            i = 0;
            lpijl.Hide();
            lSelect.Hide();
            gametimes = 0;
            secondsPast = 0;
            lTime.Text = "0";
            lAmmoCount.Text = "X   X   X";
            lScoreStatus.Text = "0";
            killerEnemy.Location = new Point(enemyKillerBlockPosx, enemyBlockposy);
            sHead.Location = new Point(posx, posy);
            dead = false;
            btBlue.Location = new Point(1000, 800);
            btOrange.Location = new Point(1000, 800);
            btGreen.Location = new Point(1000, 800);
            btGreenHide = true;
            btBlueHide = true;
            btOrangeHide = true;
            enemy.Hide();
            rShotOrange.Hide();
            sHead.Hide();
            lSurviveTime.Hide();
            lTime.Hide();
            lSelect.Hide();
            lpijl.Hide();
            lAmmo.Hide();
            lAmmoCount.Hide();
            btBlue.Hide();
            btGreen.Hide();
            btOrange.Hide();
            rShotBlue.Hide();
            rShotGreen.Hide();
            lScore.Hide();
            lScoreStatus.Hide();
            btStart.Show();
            lStart.Show();
            lCredit.Show();
            btLeaderbord.Show();
            sHead.Checked = false;
           
        }

       
    }
}
