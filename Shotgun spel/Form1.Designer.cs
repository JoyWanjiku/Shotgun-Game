namespace WindowsFormsApplication2
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
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.lblPlayerAction = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerAmmunitionCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxComputer = new System.Windows.Forms.GroupBox();
            this.lblComputerAction = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblComputerAmmunitionCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPlayer.SuspendLayout();
            this.groupBoxComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(16, 15);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(4);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(100, 28);
            this.btnShoot.TabIndex = 0;
            this.btnShoot.Text = "Skjuta";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.BtnShoot_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(124, 15);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(100, 28);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Blocka";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(232, 15);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Ladda";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.lblPlayerAction);
            this.groupBoxPlayer.Controls.Add(this.label5);
            this.groupBoxPlayer.Controls.Add(this.lblPlayerAmmunitionCount);
            this.groupBoxPlayer.Controls.Add(this.label1);
            this.groupBoxPlayer.Location = new System.Drawing.Point(16, 50);
            this.groupBoxPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPlayer.Size = new System.Drawing.Size(267, 112);
            this.groupBoxPlayer.TabIndex = 3;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Spelare";
            // 
            // lblPlayerAction
            // 
            this.lblPlayerAction.AutoSize = true;
            this.lblPlayerAction.Location = new System.Drawing.Point(104, 69);
            this.lblPlayerAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerAction.Name = "lblPlayerAction";
            this.lblPlayerAction.Size = new System.Drawing.Size(13, 17);
            this.lblPlayerAction.TabIndex = 3;
            this.lblPlayerAction.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Händelse:";
            // 
            // lblPlayerAmmunitionCount
            // 
            this.lblPlayerAmmunitionCount.AutoSize = true;
            this.lblPlayerAmmunitionCount.Location = new System.Drawing.Point(104, 31);
            this.lblPlayerAmmunitionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerAmmunitionCount.Name = "lblPlayerAmmunitionCount";
            this.lblPlayerAmmunitionCount.Size = new System.Drawing.Size(13, 17);
            this.lblPlayerAmmunitionCount.TabIndex = 1;
            this.lblPlayerAmmunitionCount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ammunition:";
            // 
            // groupBoxComputer
            // 
            this.groupBoxComputer.Controls.Add(this.lblComputerAction);
            this.groupBoxComputer.Controls.Add(this.label7);
            this.groupBoxComputer.Controls.Add(this.lblComputerAmmunitionCount);
            this.groupBoxComputer.Controls.Add(this.label3);
            this.groupBoxComputer.Location = new System.Drawing.Point(311, 50);
            this.groupBoxComputer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxComputer.Name = "groupBoxComputer";
            this.groupBoxComputer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxComputer.Size = new System.Drawing.Size(267, 112);
            this.groupBoxComputer.TabIndex = 5;
            this.groupBoxComputer.TabStop = false;
            this.groupBoxComputer.Text = "Dator";
            // 
            // lblComputerAction
            // 
            this.lblComputerAction.AutoSize = true;
            this.lblComputerAction.Location = new System.Drawing.Point(105, 69);
            this.lblComputerAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerAction.Name = "lblComputerAction";
            this.lblComputerAction.Size = new System.Drawing.Size(13, 17);
            this.lblComputerAction.TabIndex = 7;
            this.lblComputerAction.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Händelse:";
            // 
            // lblComputerAmmunitionCount
            // 
            this.lblComputerAmmunitionCount.AutoSize = true;
            this.lblComputerAmmunitionCount.Location = new System.Drawing.Point(105, 31);
            this.lblComputerAmmunitionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerAmmunitionCount.Name = "lblComputerAmmunitionCount";
            this.lblComputerAmmunitionCount.Size = new System.Drawing.Size(13, 17);
            this.lblComputerAmmunitionCount.TabIndex = 5;
            this.lblComputerAmmunitionCount.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ammunition:";
            // 
            // btnShotgun
            // 
            this.btnShotgun.Enabled = false;
            this.btnShotgun.Location = new System.Drawing.Point(340, 15);
            this.btnShotgun.Margin = new System.Windows.Forms.Padding(4);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(100, 28);
            this.btnShotgun.TabIndex = 6;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.BtnShotgun_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(439, 238);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(127, 28);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Starta om spelet";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(184, 181);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 17);
            this.lblWinner.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(33, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "- May the best cowboy win!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.groupBoxComputer);
            this.Controls.Add(this.groupBoxPlayer);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnShoot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Shotgun game";
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.groupBoxComputer.ResumeLayout(false);
            this.groupBoxComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.Label lblPlayerAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerAmmunitionCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxComputer;
        private System.Windows.Forms.Label lblComputerAction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblComputerAmmunitionCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

