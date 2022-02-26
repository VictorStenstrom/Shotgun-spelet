using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2
{
    public partial class Form1 : Form
    {
        bool gameOver = false;
        string enemyChoice;
        
        int randomNumber = 0;
        int playerBullets = 0;
        int enemyBullets = 0;
        int playerScore = 0;
        int enemyScore = 0;

        string[] enemyChoiceList = { "shoot", "reload", "block", "reload", "block", "shoot" };
        Random EnemyRandom = new Random();
       
        public Form1()
        {
            InitializeComponent();
            ShowAmmunition();
            ShowScore();
        }
        private void cmdShoot_Click(object sender, EventArgs e)
        {
            EnemyTurn();

            if (playerBullets < 1 && gameOver == false)
            {
                MessageBox.Show("Du har inga skott, ladda först");
            }
            else if (gameOver == true)
            {
                MessageBox.Show("Spelet är slut, tryck på 'spela igen' för att fortsätta");
            }            
            else if (playerBullets > 0 && gameOver == false)
            {
                switch (enemyChoice)
                {
                    case "shoot":
                        if (enemyBullets > 0)
                        {
                            playerBullets--;
                            enemyBullets--;
                            MessageBox.Show("Du och din motståndare sköt mot varrandra, ni har förlorat ett skott var");
                            break;
                        }
                        else
                            MessageBox.Show("Motståndaren försökte skjuta men hade slut på skott, du har vunnit!");
                            gameOver = true;
                            playerScore++;
                        break;
                    
                    case "reload":
                        MessageBox.Show("du sköt när motståndaren laddade, du har vunnit!");
                        gameOver = true;
                        playerScore++;
                        break;

                    case "block":
                        playerBullets--;
                        MessageBox.Show("Du sköt mot block, du har förlorar ett skott");
                        break;
                }   
            ShowAmmunition();
            ShowScore();
            }
        }
        private void cmdReload_Click(object sender, EventArgs e)
        {
            if (gameOver == true)
            {
                MessageBox.Show("Spelet är slut, tryck på 'spela igen' för att fortsätta");
            }
            else
            {
                playerBullets++;
                EnemyTurn();
      
                switch (enemyChoice)
                {
                    case "shoot":
                        if (enemyBullets > 0)
                        {
                            MessageBox.Show("Motstånadren sköt när du laddade, du har förlorat");
                            gameOver = true;
                            enemyScore++;
                        }
                        else
                            MessageBox.Show("Motståndaren försökte skjuta men hade slut på skott");
                        break;

                    case "reload":
                            playerBullets++;
                            enemyBullets = enemyBullets + 2;
                            //enemyBullets++;
                            MessageBox.Show("Du laddade samtidigt som motståndaren, ni får ett skott vardera");
                            if (enemyBullets >= 3)
                            {
                                MessageBox.Show("Motståndaren besegrade dig med shotgun, du har förlorat");
                                gameOver = true;
                                enemyScore++;
                                break;
                            }
                        break;
                        
                    case "block":
                        playerBullets++;
                        MessageBox.Show("Du laddade när motstånadren blockade, du får ett skott");
                        break;
                }
            }
            ShowAmmunition();
            ShowScore();
        }
        private void cmdBlock_Click(object sender, EventArgs e)
        {
            if (gameOver == true)
            {
                MessageBox.Show("Spelet är slut, tryck på 'spela igen' för att fortsätta");
            }

            else
            {
                EnemyTurn();

                switch (enemyChoice)
                {
                    case "shoot":
                        MessageBox.Show("Motstånadren sköt när du blockade, den förlorar ett skott");
                        enemyBullets--;
                        break;

                    case "reload":
                        enemyBullets++;
                        MessageBox.Show("Du blockade när motståndaren laddade, den får ett skott");
                            if (enemyBullets >= 3)
                            {
                                MessageBox.Show("Motståndaren besegrade dig med shotgun, du har förlorat");
                                gameOver = true;
                                enemyScore++;
                                break;
                            }
                        break;

                    case "block":
                        MessageBox.Show("Du blockade samtidigt som motståndaren, ingenting händer");
                        break;
                }
            ShowAmmunition();
            ShowScore();
            }
        }
        private void cmdShotgun_Click(object sender, EventArgs e)
        {
            if (playerBullets >= 3 && gameOver == false)
            {
                gameOver = true;
                playerScore++;
                ShowScore();
                MessageBox.Show("Du besegrade motståndaren med shotgun!");
            }
            else if (playerBullets < 3 && gameOver == false)
            {
                MessageBox.Show("Du behöver minst 3 skott för att använda shotgun");
            }
            else
                MessageBox.Show("Spelet är slut, tryck på 'spela igen' för att fortsätta");
        }
        private void cmdRestart_Click(object sender, EventArgs e)
        {
            gameOver = false;
            playerBullets = 0;
            enemyBullets = 0;
            ShowAmmunition();
            MessageBox.Show("Ny runda startad");       
        }
        private void ShowAmmunition()
        {
            txtPlayerBullets.Text = playerBullets.ToString();
            txtEnemyBullets.Text = enemyBullets.ToString();
        }
        private void ShowScore()
        {
            txtScoreEnemy.Text = enemyScore.ToString();
            txtScorePlayer.Text = playerScore.ToString();
        }
        private void EnemyTurn()
        {
            randomNumber = EnemyRandom.Next(0, enemyChoiceList.Length);
            enemyChoice = enemyChoiceList[randomNumber];
        }
    }
}
