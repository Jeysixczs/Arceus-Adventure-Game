namespace Arceus_Adventure_Game
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
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.AttackButton = new System.Windows.Forms.Button();
            this.CriticalButton = new System.Windows.Forms.Button();
            this.HealButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.PlayerHpProgressBar = new System.Windows.Forms.ProgressBar();
            this.EnemyHpProgressBar = new System.Windows.Forms.ProgressBar();
            this.PlayerManaProgressBar = new System.Windows.Forms.ProgressBar();
            this.EnemyManaProgressBar = new System.Windows.Forms.ProgressBar();
            this.PlayerHpLabel = new System.Windows.Forms.Label();
            this.PlayerManaLabel = new System.Windows.Forms.Label();
            this.EnemyHpLabel = new System.Windows.Forms.Label();
            this.EnemyManaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPictureBox.Image = global::Arceus_Adventure_Game.Properties.Resources.skelidle;
            this.PlayerPictureBox.Location = new System.Drawing.Point(52, 107);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(280, 240);
            this.PlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox.TabIndex = 0;
            this.PlayerPictureBox.TabStop = false;
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EnemyPictureBox.Image = global::Arceus_Adventure_Game.Properties.Resources.bat;
            this.EnemyPictureBox.Location = new System.Drawing.Point(454, 136);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(224, 211);
            this.EnemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyPictureBox.TabIndex = 1;
            this.EnemyPictureBox.TabStop = false;
            // 
            // AttackButton
            // 
            this.AttackButton.BackgroundImage = global::Arceus_Adventure_Game.Properties.Resources.attacks;
            this.AttackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AttackButton.Location = new System.Drawing.Point(176, 376);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(73, 65);
            this.AttackButton.TabIndex = 2;
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // CriticalButton
            // 
            this.CriticalButton.BackgroundImage = global::Arceus_Adventure_Game.Properties.Resources.attack;
            this.CriticalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CriticalButton.Location = new System.Drawing.Point(282, 376);
            this.CriticalButton.Name = "CriticalButton";
            this.CriticalButton.Size = new System.Drawing.Size(73, 65);
            this.CriticalButton.TabIndex = 3;
            this.CriticalButton.UseVisualStyleBackColor = true;
            this.CriticalButton.Click += new System.EventHandler(this.CriticalButton_Click);
            // 
            // HealButton
            // 
            this.HealButton.BackgroundImage = global::Arceus_Adventure_Game.Properties.Resources.heal;
            this.HealButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HealButton.Location = new System.Drawing.Point(385, 376);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(78, 65);
            this.HealButton.TabIndex = 4;
            this.HealButton.UseVisualStyleBackColor = true;
            this.HealButton.Click += new System.EventHandler(this.HealButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.BackgroundImage = global::Arceus_Adventure_Game.Properties.Resources.block;
            this.BlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BlockButton.Location = new System.Drawing.Point(493, 376);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(73, 65);
            this.BlockButton.TabIndex = 5;
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // PlayerHpProgressBar
            // 
            this.PlayerHpProgressBar.Location = new System.Drawing.Point(91, 78);
            this.PlayerHpProgressBar.Name = "PlayerHpProgressBar";
            this.PlayerHpProgressBar.Size = new System.Drawing.Size(175, 23);
            this.PlayerHpProgressBar.TabIndex = 6;
            // 
            // EnemyHpProgressBar
            // 
            this.EnemyHpProgressBar.Location = new System.Drawing.Point(470, 78);
            this.EnemyHpProgressBar.Name = "EnemyHpProgressBar";
            this.EnemyHpProgressBar.Size = new System.Drawing.Size(175, 23);
            this.EnemyHpProgressBar.TabIndex = 7;
            // 
            // PlayerManaProgressBar
            // 
            this.PlayerManaProgressBar.Location = new System.Drawing.Point(111, 108);
            this.PlayerManaProgressBar.Name = "PlayerManaProgressBar";
            this.PlayerManaProgressBar.Size = new System.Drawing.Size(138, 23);
            this.PlayerManaProgressBar.TabIndex = 8;
            // 
            // EnemyManaProgressBar
            // 
            this.EnemyManaProgressBar.Location = new System.Drawing.Point(485, 107);
            this.EnemyManaProgressBar.Name = "EnemyManaProgressBar";
            this.EnemyManaProgressBar.Size = new System.Drawing.Size(138, 23);
            this.EnemyManaProgressBar.TabIndex = 9;
            // 
            // PlayerHpLabel
            // 
            this.PlayerHpLabel.AutoSize = true;
            this.PlayerHpLabel.Location = new System.Drawing.Point(102, 56);
            this.PlayerHpLabel.Name = "PlayerHpLabel";
            this.PlayerHpLabel.Size = new System.Drawing.Size(44, 16);
            this.PlayerHpLabel.TabIndex = 10;
            this.PlayerHpLabel.Text = "label1";
            // 
            // PlayerManaLabel
            // 
            this.PlayerManaLabel.AutoSize = true;
            this.PlayerManaLabel.Location = new System.Drawing.Point(111, 136);
            this.PlayerManaLabel.Name = "PlayerManaLabel";
            this.PlayerManaLabel.Size = new System.Drawing.Size(44, 16);
            this.PlayerManaLabel.TabIndex = 11;
            this.PlayerManaLabel.Text = "label2";
            // 
            // EnemyHpLabel
            // 
            this.EnemyHpLabel.AutoSize = true;
            this.EnemyHpLabel.Location = new System.Drawing.Point(470, 56);
            this.EnemyHpLabel.Name = "EnemyHpLabel";
            this.EnemyHpLabel.Size = new System.Drawing.Size(44, 16);
            this.EnemyHpLabel.TabIndex = 12;
            this.EnemyHpLabel.Text = "label3";
            // 
            // EnemyManaLabel
            // 
            this.EnemyManaLabel.AutoSize = true;
            this.EnemyManaLabel.Location = new System.Drawing.Point(485, 137);
            this.EnemyManaLabel.Name = "EnemyManaLabel";
            this.EnemyManaLabel.Size = new System.Drawing.Size(44, 16);
            this.EnemyManaLabel.TabIndex = 13;
            this.EnemyManaLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arceus_Adventure_Game.Properties.Resources._10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 483);
            this.Controls.Add(this.EnemyManaLabel);
            this.Controls.Add(this.EnemyHpLabel);
            this.Controls.Add(this.PlayerManaLabel);
            this.Controls.Add(this.PlayerHpLabel);
            this.Controls.Add(this.EnemyManaProgressBar);
            this.Controls.Add(this.PlayerManaProgressBar);
            this.Controls.Add(this.EnemyHpProgressBar);
            this.Controls.Add(this.PlayerHpProgressBar);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.HealButton);
            this.Controls.Add(this.CriticalButton);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.PlayerPictureBox);
            this.Controls.Add(this.EnemyPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.PictureBox EnemyPictureBox;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button CriticalButton;
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.ProgressBar PlayerHpProgressBar;
        private System.Windows.Forms.ProgressBar EnemyHpProgressBar;
        private System.Windows.Forms.ProgressBar PlayerManaProgressBar;
        private System.Windows.Forms.ProgressBar EnemyManaProgressBar;
        private System.Windows.Forms.Label PlayerHpLabel;
        private System.Windows.Forms.Label PlayerManaLabel;
        private System.Windows.Forms.Label EnemyHpLabel;
        private System.Windows.Forms.Label EnemyManaLabel;
    }
}

