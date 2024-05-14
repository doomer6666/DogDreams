namespace DogDreams
{
    partial class Level3
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.info = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.missionPassed = new System.Windows.Forms.PictureBox();
            this.rocket3 = new System.Windows.Forms.PictureBox();
            this.rocket1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rocket2 = new System.Windows.Forms.PictureBox();
            this.usa = new System.Windows.Forms.PictureBox();
            this.lifes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.missionPassed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usa)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.SkyBlue;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info.Location = new System.Drawing.Point(-6, 40);
            this.info.MaximumSize = new System.Drawing.Size(200, 700);
            this.info.Name = "info";
            this.info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.info.Size = new System.Drawing.Size(200, 250);
            this.info.TabIndex = 17;
            this.info.Text = "Выйдя из церкви ты обнаружил что на нее готовится нападение прямо сейчас! Собрери" +
    "сь с силами и отрази атаку безбожников за отведенное время. Пора уже очнуться от" +
    "о сна!\r\n";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(24, 499);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(146, 37);
            this.button.TabIndex = 18;
            this.button.Text = "Старт";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // tm
            // 
            this.tm.Interval = 1000;
            this.tm.Tick += new System.EventHandler(this.Tm_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "00:01:00";
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.Location = new System.Drawing.Point(24, 565);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(146, 96);
            this.restart.TabIndex = 20;
            this.restart.Text = "Начать заново";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // missionPassed
            // 
            this.missionPassed.Image = global::DogDreams.Properties.Resources.Mission_passed;
            this.missionPassed.Location = new System.Drawing.Point(721, 1930);
            this.missionPassed.Name = "missionPassed";
            this.missionPassed.Size = new System.Drawing.Size(637, 263);
            this.missionPassed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.missionPassed.TabIndex = 21;
            this.missionPassed.TabStop = false;
            this.missionPassed.Click += new System.EventHandler(this.MissionPassed_Click);
            // 
            // rocket3
            // 
            this.rocket3.BackColor = System.Drawing.Color.Transparent;
            this.rocket3.Image = global::DogDreams.Properties.Resources.bomb;
            this.rocket3.Location = new System.Drawing.Point(1550, 556);
            this.rocket3.Name = "rocket3";
            this.rocket3.Size = new System.Drawing.Size(203, 88);
            this.rocket3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket3.TabIndex = 16;
            this.rocket3.TabStop = false;
            this.rocket3.Click += new System.EventHandler(this.Rocket3_Click);
            // 
            // rocket1
            // 
            this.rocket1.BackColor = System.Drawing.Color.Transparent;
            this.rocket1.Image = global::DogDreams.Properties.Resources.bomb;
            this.rocket1.Location = new System.Drawing.Point(1550, 12);
            this.rocket1.Name = "rocket1";
            this.rocket1.Size = new System.Drawing.Size(203, 88);
            this.rocket1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket1.TabIndex = 15;
            this.rocket1.TabStop = false;
            this.rocket1.Click += new System.EventHandler(this.Rocket1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 720);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // rocket2
            // 
            this.rocket2.BackColor = System.Drawing.Color.Transparent;
            this.rocket2.Image = global::DogDreams.Properties.Resources.bomb;
            this.rocket2.Location = new System.Drawing.Point(1550, 324);
            this.rocket2.Name = "rocket2";
            this.rocket2.Size = new System.Drawing.Size(203, 88);
            this.rocket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket2.TabIndex = 12;
            this.rocket2.TabStop = false;
            this.rocket2.Click += new System.EventHandler(this.Rocket2_Click);
            // 
            // usa
            // 
            this.usa.BackColor = System.Drawing.Color.Transparent;
            this.usa.Image = global::DogDreams.Properties.Resources.church;
            this.usa.Location = new System.Drawing.Point(176, -2);
            this.usa.Name = "usa";
            this.usa.Size = new System.Drawing.Size(340, 704);
            this.usa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usa.TabIndex = 13;
            this.usa.TabStop = false;
            // 
            // lifes
            // 
            this.lifes.AutoSize = true;
            this.lifes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lifes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lifes.Location = new System.Drawing.Point(52, 374);
            this.lifes.Name = "lifes";
            this.lifes.Size = new System.Drawing.Size(92, 25);
            this.lifes.TabIndex = 22;
            this.lifes.Text = "Жизни:3";
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1554, 673);
            this.Controls.Add(this.lifes);
            this.Controls.Add(this.missionPassed);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.info);
            this.Controls.Add(this.rocket3);
            this.Controls.Add(this.rocket1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rocket2);
            this.Controls.Add(this.usa);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level3";
            ((System.ComponentModel.ISupportInitialize)(this.missionPassed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox rocket2;
        private System.Windows.Forms.PictureBox usa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox rocket1;
        private System.Windows.Forms.PictureBox rocket3;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.PictureBox missionPassed;
        private System.Windows.Forms.Label lifes;
    }
}