
namespace Inlämningsuppgift2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdShoot = new System.Windows.Forms.Button();
            this.cmdReload = new System.Windows.Forms.Button();
            this.cmdBlock = new System.Windows.Forms.Button();
            this.cmdRestart = new System.Windows.Forms.Button();
            this.Points1 = new System.Windows.Forms.Label();
            this.Bullets1 = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.Bullets2 = new System.Windows.Forms.Label();
            this.cmdShotgun = new System.Windows.Forms.Button();
            this.Points2 = new System.Windows.Forms.Label();
            this.txtScorePlayer = new System.Windows.Forms.Label();
            this.txtScoreEnemy = new System.Windows.Forms.Label();
            this.txtPlayerBullets = new System.Windows.Forms.Label();
            this.txtEnemyBullets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdShoot
            // 
            this.cmdShoot.Location = new System.Drawing.Point(67, 364);
            this.cmdShoot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdShoot.Name = "cmdShoot";
            this.cmdShoot.Size = new System.Drawing.Size(146, 40);
            this.cmdShoot.TabIndex = 0;
            this.cmdShoot.Text = "Skjut";
            this.cmdShoot.UseVisualStyleBackColor = true;
            this.cmdShoot.Click += new System.EventHandler(this.cmdShoot_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Location = new System.Drawing.Point(274, 364);
            this.cmdReload.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(146, 40);
            this.cmdReload.TabIndex = 0;
            this.cmdReload.Text = "Ladda";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // cmdBlock
            // 
            this.cmdBlock.Location = new System.Drawing.Point(480, 364);
            this.cmdBlock.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdBlock.Name = "cmdBlock";
            this.cmdBlock.Size = new System.Drawing.Size(146, 40);
            this.cmdBlock.TabIndex = 0;
            this.cmdBlock.Text = "Blocka";
            this.cmdBlock.UseVisualStyleBackColor = true;
            this.cmdBlock.Click += new System.EventHandler(this.cmdBlock_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.Location = new System.Drawing.Point(680, 364);
            this.cmdRestart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(146, 40);
            this.cmdRestart.TabIndex = 0;
            this.cmdRestart.Text = "Spela igen";
            this.cmdRestart.UseVisualStyleBackColor = true;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // Points1
            // 
            this.Points1.AutoSize = true;
            this.Points1.Location = new System.Drawing.Point(270, 100);
            this.Points1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Points1.Name = "Points1";
            this.Points1.Size = new System.Drawing.Size(95, 20);
            this.Points1.TabIndex = 1;
            this.Points1.Text = "Dina poäng:";
            // 
            // Bullets1
            // 
            this.Bullets1.AutoSize = true;
            this.Bullets1.Location = new System.Drawing.Point(270, 186);
            this.Bullets1.Name = "Bullets1";
            this.Bullets1.Size = new System.Drawing.Size(85, 20);
            this.Bullets1.TabIndex = 2;
            this.Bullets1.Text = "Dina skott:";
            // 
            // Bullets2
            // 
            this.Bullets2.AutoSize = true;
            this.Bullets2.Location = new System.Drawing.Point(476, 186);
            this.Bullets2.Name = "Bullets2";
            this.Bullets2.Size = new System.Drawing.Size(145, 20);
            this.Bullets2.TabIndex = 3;
            this.Bullets2.Text = "Skott motståndare:";
            // 
            // cmdShotgun
            // 
            this.cmdShotgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShotgun.Location = new System.Drawing.Point(354, 264);
            this.cmdShotgun.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmdShotgun.Name = "cmdShotgun";
            this.cmdShotgun.Size = new System.Drawing.Size(194, 71);
            this.cmdShotgun.TabIndex = 4;
            this.cmdShotgun.Text = "Shotgun";
            this.cmdShotgun.UseVisualStyleBackColor = true;
            this.cmdShotgun.Click += new System.EventHandler(this.cmdShotgun_Click);
            // 
            // Points2
            // 
            this.Points2.AutoSize = true;
            this.Points2.Location = new System.Drawing.Point(476, 100);
            this.Points2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Points2.Name = "Points2";
            this.Points2.Size = new System.Drawing.Size(111, 20);
            this.Points2.TabIndex = 1;
            this.Points2.Text = " Poäng fiende:";
            // 
            // txtScorePlayer
            // 
            this.txtScorePlayer.AutoSize = true;
            this.txtScorePlayer.Location = new System.Drawing.Point(373, 100);
            this.txtScorePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScorePlayer.Name = "txtScorePlayer";
            this.txtScorePlayer.Size = new System.Drawing.Size(0, 20);
            this.txtScorePlayer.TabIndex = 5;
            // 
            // txtScoreEnemy
            // 
            this.txtScoreEnemy.AutoSize = true;
            this.txtScoreEnemy.Location = new System.Drawing.Point(595, 100);
            this.txtScoreEnemy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScoreEnemy.Name = "txtScoreEnemy";
            this.txtScoreEnemy.Size = new System.Drawing.Size(0, 20);
            this.txtScoreEnemy.TabIndex = 5;
            // 
            // txtPlayerBullets
            // 
            this.txtPlayerBullets.AutoSize = true;
            this.txtPlayerBullets.Location = new System.Drawing.Point(361, 186);
            this.txtPlayerBullets.Name = "txtPlayerBullets";
            this.txtPlayerBullets.Size = new System.Drawing.Size(0, 20);
            this.txtPlayerBullets.TabIndex = 6;
            // 
            // txtEnemyBullets
            // 
            this.txtEnemyBullets.AutoSize = true;
            this.txtEnemyBullets.Location = new System.Drawing.Point(627, 186);
            this.txtEnemyBullets.Name = "txtEnemyBullets";
            this.txtEnemyBullets.Size = new System.Drawing.Size(0, 20);
            this.txtEnemyBullets.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 482);
            this.Controls.Add(this.txtEnemyBullets);
            this.Controls.Add(this.txtPlayerBullets);
            this.Controls.Add(this.txtScoreEnemy);
            this.Controls.Add(this.txtScorePlayer);
            this.Controls.Add(this.cmdShotgun);
            this.Controls.Add(this.Bullets2);
            this.Controls.Add(this.Bullets1);
            this.Controls.Add(this.Points2);
            this.Controls.Add(this.Points1);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.cmdBlock);
            this.Controls.Add(this.cmdReload);
            this.Controls.Add(this.cmdShoot);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdShoot;
        private System.Windows.Forms.Button cmdReload;
        private System.Windows.Forms.Button cmdBlock;
        private System.Windows.Forms.Button cmdRestart;
        private System.Windows.Forms.Label Points1;
        private System.Windows.Forms.Label Bullets1;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label Bullets2;
        private System.Windows.Forms.Button cmdShotgun;
        private System.Windows.Forms.Label Points2;
        private System.Windows.Forms.Label txtScorePlayer;
        private System.Windows.Forms.Label txtScoreEnemy;
        private System.Windows.Forms.Label txtPlayerBullets;
        private System.Windows.Forms.Label txtEnemyBullets;
    }
}

