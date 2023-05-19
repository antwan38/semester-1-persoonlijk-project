
namespace slang
{
    partial class font
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(font));
            this.sHead = new System.Windows.Forms.RadioButton();
            this.enemy = new System.Windows.Forms.Button();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.rShotOrange = new System.Windows.Forms.RadioButton();
            this.lStart = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.lSurviveTime = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.seconden = new System.Windows.Forms.Timer(this.components);
            this.lSelect = new System.Windows.Forms.Label();
            this.lpijl = new System.Windows.Forms.Label();
            this.lAmmo = new System.Windows.Forms.Label();
            this.lAmmoCount = new System.Windows.Forms.Label();
            this.btOrange = new System.Windows.Forms.Button();
            this.btBlue = new System.Windows.Forms.Button();
            this.btGreen = new System.Windows.Forms.Button();
            this.rShotGreen = new System.Windows.Forms.RadioButton();
            this.rShotBlue = new System.Windows.Forms.RadioButton();
            this.lScore = new System.Windows.Forms.Label();
            this.lScoreStatus = new System.Windows.Forms.Label();
            this.lCredit = new System.Windows.Forms.Label();
            this.killerEnemy = new System.Windows.Forms.Button();
            this.btLeaderbord = new System.Windows.Forms.Button();
            this.lHighscoreState = new System.Windows.Forms.Label();
            this.lHighscore = new System.Windows.Forms.Label();
            this.lEnterusername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sHead
            // 
            this.sHead.AutoSize = true;
            this.sHead.BackColor = System.Drawing.Color.Transparent;
            this.sHead.Location = new System.Drawing.Point(52, 182);
            this.sHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sHead.Name = "sHead";
            this.sHead.Size = new System.Drawing.Size(17, 16);
            this.sHead.TabIndex = 0;
            this.sHead.UseVisualStyleBackColor = false;
            this.sHead.CheckedChanged += new System.EventHandler(this.sHead_CheckedChanged);
            this.sHead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sHead_KeyDown);
            this.sHead.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sHead_KeyUp);
            // 
            // enemy
            // 
            this.enemy.Image = ((System.Drawing.Image)(resources.GetObject("enemy.Image")));
            this.enemy.Location = new System.Drawing.Point(296, 206);
            this.enemy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(60, 54);
            this.enemy.TabIndex = 1;
            this.enemy.UseVisualStyleBackColor = true;
            this.enemy.Click += new System.EventHandler(this.enemy_Click);
            // 
            // gametime
            // 
            this.gametime.Tick += new System.EventHandler(this.gametime_Tick);
            // 
            // rShotOrange
            // 
            this.rShotOrange.AutoSize = true;
            this.rShotOrange.ForeColor = System.Drawing.Color.Coral;
            this.rShotOrange.Location = new System.Drawing.Point(820, 327);
            this.rShotOrange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rShotOrange.Name = "rShotOrange";
            this.rShotOrange.Size = new System.Drawing.Size(72, 21);
            this.rShotOrange.TabIndex = 2;
            this.rShotOrange.Text = "booom";
            this.rShotOrange.UseVisualStyleBackColor = true;
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.BackColor = System.Drawing.Color.Transparent;
            this.lStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lStart.Location = new System.Drawing.Point(443, 40);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(354, 39);
            this.lStart.TabIndex = 3;
            this.lStart.Text = "Press START to play";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(528, 206);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(183, 110);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lSurviveTime
            // 
            this.lSurviveTime.AutoSize = true;
            this.lSurviveTime.BackColor = System.Drawing.Color.Transparent;
            this.lSurviveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSurviveTime.Location = new System.Drawing.Point(11, 31);
            this.lSurviveTime.Name = "lSurviveTime";
            this.lSurviveTime.Size = new System.Drawing.Size(146, 25);
            this.lSurviveTime.TabIndex = 5;
            this.lSurviveTime.Text = "Survive Time:";
            this.lSurviveTime.Click += new System.EventHandler(this.lSurviveTime_Click);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.BackColor = System.Drawing.Color.Transparent;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(183, 31);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(24, 25);
            this.lTime.TabIndex = 6;
            this.lTime.Text = "0";
            this.lTime.Click += new System.EventHandler(this.lTime_Click);
            // 
            // seconden
            // 
            this.seconden.Interval = 1000;
            this.seconden.Tick += new System.EventHandler(this.seconden_Tick);
            // 
            // lSelect
            // 
            this.lSelect.AutoSize = true;
            this.lSelect.BackColor = System.Drawing.Color.Transparent;
            this.lSelect.Location = new System.Drawing.Point(12, 94);
            this.lSelect.Name = "lSelect";
            this.lSelect.Size = new System.Drawing.Size(137, 17);
            this.lSelect.TabIndex = 7;
            this.lSelect.Text = "Select player to Play";
            // 
            // lpijl
            // 
            this.lpijl.AutoSize = true;
            this.lpijl.BackColor = System.Drawing.Color.Transparent;
            this.lpijl.Location = new System.Drawing.Point(12, 122);
            this.lpijl.Name = "lpijl";
            this.lpijl.Size = new System.Drawing.Size(24, 17);
            this.lpijl.TabIndex = 8;
            this.lpijl.Text = ">>";
            // 
            // lAmmo
            // 
            this.lAmmo.AutoSize = true;
            this.lAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmmo.Location = new System.Drawing.Point(914, 31);
            this.lAmmo.Name = "lAmmo";
            this.lAmmo.Size = new System.Drawing.Size(80, 25);
            this.lAmmo.TabIndex = 9;
            this.lAmmo.Text = "Ammo:";
            // 
            // lAmmoCount
            // 
            this.lAmmoCount.AutoSize = true;
            this.lAmmoCount.BackColor = System.Drawing.Color.Transparent;
            this.lAmmoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmmoCount.Location = new System.Drawing.Point(1002, 31);
            this.lAmmoCount.Name = "lAmmoCount";
            this.lAmmoCount.Size = new System.Drawing.Size(93, 25);
            this.lAmmoCount.TabIndex = 10;
            this.lAmmoCount.Text = "X   X   X";
            // 
            // btOrange
            // 
            this.btOrange.BackColor = System.Drawing.Color.Coral;
            this.btOrange.Location = new System.Drawing.Point(763, 163);
            this.btOrange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOrange.Name = "btOrange";
            this.btOrange.Size = new System.Drawing.Size(60, 54);
            this.btOrange.TabIndex = 1;
            this.btOrange.UseVisualStyleBackColor = false;
            // 
            // btBlue
            // 
            this.btBlue.BackColor = System.Drawing.SystemColors.Highlight;
            this.btBlue.Location = new System.Drawing.Point(820, 372);
            this.btBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(60, 54);
            this.btBlue.TabIndex = 12;
            this.btBlue.UseVisualStyleBackColor = false;
            // 
            // btGreen
            // 
            this.btGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.btGreen.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btGreen.Location = new System.Drawing.Point(874, 122);
            this.btGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(60, 54);
            this.btGreen.TabIndex = 13;
            this.btGreen.UseVisualStyleBackColor = false;
            // 
            // rShotGreen
            // 
            this.rShotGreen.AutoSize = true;
            this.rShotGreen.ForeColor = System.Drawing.Color.YellowGreen;
            this.rShotGreen.Location = new System.Drawing.Point(778, 283);
            this.rShotGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rShotGreen.Name = "rShotGreen";
            this.rShotGreen.Size = new System.Drawing.Size(43, 21);
            this.rShotGreen.TabIndex = 14;
            this.rShotGreen.Text = "lol";
            this.rShotGreen.UseVisualStyleBackColor = true;
            // 
            // rShotBlue
            // 
            this.rShotBlue.AutoSize = true;
            this.rShotBlue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rShotBlue.Location = new System.Drawing.Point(742, 239);
            this.rShotBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rShotBlue.Name = "rShotBlue";
            this.rShotBlue.Size = new System.Drawing.Size(59, 21);
            this.rShotBlue.TabIndex = 15;
            this.rShotBlue.Text = "biem";
            this.rShotBlue.UseVisualStyleBackColor = true;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.BackColor = System.Drawing.Color.Transparent;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(11, 70);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(76, 25);
            this.lScore.TabIndex = 16;
            this.lScore.Text = "Score:";
            // 
            // lScoreStatus
            // 
            this.lScoreStatus.AutoSize = true;
            this.lScoreStatus.BackColor = System.Drawing.Color.Transparent;
            this.lScoreStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreStatus.Location = new System.Drawing.Point(103, 70);
            this.lScoreStatus.Name = "lScoreStatus";
            this.lScoreStatus.Size = new System.Drawing.Size(24, 25);
            this.lScoreStatus.TabIndex = 17;
            this.lScoreStatus.Text = "0";
            // 
            // lCredit
            // 
            this.lCredit.AutoSize = true;
            this.lCredit.Location = new System.Drawing.Point(882, 536);
            this.lCredit.Name = "lCredit";
            this.lCredit.Size = new System.Drawing.Size(213, 17);
            this.lCredit.TabIndex = 18;
            this.lCredit.Text = "Made by Antwan Lennart Bakker";
            // 
            // killerEnemy
            // 
            this.killerEnemy.BackColor = System.Drawing.Color.Red;
            this.killerEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("killerEnemy.BackgroundImage")));
            this.killerEnemy.Location = new System.Drawing.Point(296, 339);
            this.killerEnemy.Name = "killerEnemy";
            this.killerEnemy.Size = new System.Drawing.Size(130, 120);
            this.killerEnemy.TabIndex = 19;
            this.killerEnemy.UseVisualStyleBackColor = false;
            // 
            // btLeaderbord
            // 
            this.btLeaderbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeaderbord.Location = new System.Drawing.Point(528, 327);
            this.btLeaderbord.Name = "btLeaderbord";
            this.btLeaderbord.Size = new System.Drawing.Size(183, 55);
            this.btLeaderbord.TabIndex = 20;
            this.btLeaderbord.Text = "Leaderbord";
            this.btLeaderbord.UseVisualStyleBackColor = true;
            this.btLeaderbord.Click += new System.EventHandler(this.btLeaderbord_Click);
            // 
            // lHighscoreState
            // 
            this.lHighscoreState.AutoSize = true;
            this.lHighscoreState.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHighscoreState.Location = new System.Drawing.Point(54, 139);
            this.lHighscoreState.Name = "lHighscoreState";
            this.lHighscoreState.Size = new System.Drawing.Size(0, 46);
            this.lHighscoreState.TabIndex = 21;
            // 
            // lHighscore
            // 
            this.lHighscore.AutoSize = true;
            this.lHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHighscore.Location = new System.Drawing.Point(43, 46);
            this.lHighscore.Name = "lHighscore";
            this.lHighscore.Size = new System.Drawing.Size(264, 55);
            this.lHighscore.TabIndex = 22;
            this.lHighscore.Text = "Highscore:";
            // 
            // lEnterusername
            // 
            this.lEnterusername.AutoSize = true;
            this.lEnterusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnterusername.Location = new System.Drawing.Point(111, 122);
            this.lEnterusername.Name = "lEnterusername";
            this.lEnterusername.Size = new System.Drawing.Size(261, 25);
            this.lEnterusername.TabIndex = 23;
            this.lEnterusername.Text = "Enter here your username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(116, 163);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 24;
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(237, 163);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(106, 35);
            this.btEnter.TabIndex = 25;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // font
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 579);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lEnterusername);
            this.Controls.Add(this.lHighscore);
            this.Controls.Add(this.lHighscoreState);
            this.Controls.Add(this.btLeaderbord);
            this.Controls.Add(this.killerEnemy);
            this.Controls.Add(this.lCredit);
            this.Controls.Add(this.lScoreStatus);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.rShotBlue);
            this.Controls.Add(this.rShotGreen);
            this.Controls.Add(this.btGreen);
            this.Controls.Add(this.btBlue);
            this.Controls.Add(this.btOrange);
            this.Controls.Add(this.lAmmoCount);
            this.Controls.Add(this.lAmmo);
            this.Controls.Add(this.lpijl);
            this.Controls.Add(this.lSelect);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lSurviveTime);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lStart);
            this.Controls.Add(this.rShotOrange);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.sHead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "font";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sHead;
        private System.Windows.Forms.Button enemy;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.RadioButton rShotOrange;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lSurviveTime;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Timer seconden;
        private System.Windows.Forms.Label lSelect;
        private System.Windows.Forms.Label lpijl;
        private System.Windows.Forms.Label lAmmo;
        private System.Windows.Forms.Label lAmmoCount;
        private System.Windows.Forms.Button btOrange;
        private System.Windows.Forms.Button btBlue;
        private System.Windows.Forms.Button btGreen;
        private System.Windows.Forms.RadioButton rShotGreen;
        private System.Windows.Forms.RadioButton rShotBlue;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lScoreStatus;
        private System.Windows.Forms.Label lCredit;
        private System.Windows.Forms.Button killerEnemy;
        private System.Windows.Forms.Button btLeaderbord;
        private System.Windows.Forms.Label lHighscoreState;
        private System.Windows.Forms.Label lHighscore;
        private System.Windows.Forms.Label lEnterusername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btEnter;
    }
}

