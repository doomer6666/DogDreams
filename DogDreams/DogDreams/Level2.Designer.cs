namespace DogDreams
{
    partial class Level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.devil = new System.Windows.Forms.PictureBox();
            this.papa = new System.Windows.Forms.PictureBox();
            this.maxwell = new System.Windows.Forms.PictureBox();
            this.taro = new System.Windows.Forms.PictureBox();
            this.harvi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.strPapa = new System.Windows.Forms.Label();
            this.strDevil = new System.Windows.Forms.Label();
            this.strTaro = new System.Windows.Forms.Label();
            this.strMaxwell = new System.Windows.Forms.Label();
            this.strHarvi = new System.Windows.Forms.Label();
            this.missionPassed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxwell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionPassed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 720);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // devil
            // 
            this.devil.BackColor = System.Drawing.Color.Transparent;
            this.devil.Image = global::DogDreams.Properties.Resources.invisDevil;
            this.devil.Location = new System.Drawing.Point(760, 102);
            this.devil.Name = "devil";
            this.devil.Size = new System.Drawing.Size(163, 121);
            this.devil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.devil.TabIndex = 9;
            this.devil.TabStop = false;
            this.devil.Click += new System.EventHandler(this.Devil_Click);
            // 
            // papa
            // 
            this.papa.BackColor = System.Drawing.Color.Transparent;
            this.papa.Image = global::DogDreams.Properties.Resources.invisPapa;
            this.papa.Location = new System.Drawing.Point(706, 539);
            this.papa.Name = "papa";
            this.papa.Size = new System.Drawing.Size(119, 141);
            this.papa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.papa.TabIndex = 10;
            this.papa.TabStop = false;
            this.papa.Click += new System.EventHandler(this.Papa_Click);
            // 
            // maxwell
            // 
            this.maxwell.BackColor = System.Drawing.Color.Transparent;
            this.maxwell.Image = global::DogDreams.Properties.Resources.invismaxvell;
            this.maxwell.Location = new System.Drawing.Point(1146, 255);
            this.maxwell.Name = "maxwell";
            this.maxwell.Size = new System.Drawing.Size(88, 91);
            this.maxwell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxwell.TabIndex = 11;
            this.maxwell.TabStop = false;
            this.maxwell.Click += new System.EventHandler(this.Maxwell_Click);
            // 
            // taro
            // 
            this.taro.BackColor = System.Drawing.Color.Transparent;
            this.taro.Image = global::DogDreams.Properties.Resources.invisTaro;
            this.taro.Location = new System.Drawing.Point(492, 359);
            this.taro.Name = "taro";
            this.taro.Size = new System.Drawing.Size(24, 41);
            this.taro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.taro.TabIndex = 12;
            this.taro.TabStop = false;
            this.taro.Click += new System.EventHandler(this.Taro_Click);
            // 
            // harvi
            // 
            this.harvi.BackColor = System.Drawing.Color.Transparent;
            this.harvi.Image = global::DogDreams.Properties.Resources.invisHarvi;
            this.harvi.Location = new System.Drawing.Point(250, 567);
            this.harvi.Name = "harvi";
            this.harvi.Size = new System.Drawing.Size(176, 113);
            this.harvi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.harvi.TabIndex = 13;
            this.harvi.TabStop = false;
            this.harvi.Click += new System.EventHandler(this.Harvi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Найдите:";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Goldenrod;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info.Location = new System.Drawing.Point(-6, 0);
            this.info.MaximumSize = new System.Drawing.Size(200, 700);
            this.info.Name = "info";
            this.info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.info.Size = new System.Drawing.Size(199, 400);
            this.info.TabIndex = 15;
            this.info.Text = resources.GetString("info.Text");
            // 
            // strPapa
            // 
            this.strPapa.AutoSize = true;
            this.strPapa.BackColor = System.Drawing.Color.Goldenrod;
            this.strPapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strPapa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strPapa.Location = new System.Drawing.Point(-6, 539);
            this.strPapa.Name = "strPapa";
            this.strPapa.Size = new System.Drawing.Size(144, 25);
            this.strPapa.TabIndex = 16;
            this.strPapa.Text = "Папа Римский";
            // 
            // strDevil
            // 
            this.strDevil.AutoSize = true;
            this.strDevil.BackColor = System.Drawing.Color.Goldenrod;
            this.strDevil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strDevil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strDevil.Location = new System.Drawing.Point(-6, 564);
            this.strDevil.Name = "strDevil";
            this.strDevil.Size = new System.Drawing.Size(159, 25);
            this.strDevil.TabIndex = 17;
            this.strDevil.Text = "Круг Бафомета";
            // 
            // strTaro
            // 
            this.strTaro.AutoSize = true;
            this.strTaro.BackColor = System.Drawing.Color.Goldenrod;
            this.strTaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strTaro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strTaro.Location = new System.Drawing.Point(-6, 614);
            this.strTaro.Name = "strTaro";
            this.strTaro.Size = new System.Drawing.Size(132, 25);
            this.strTaro.TabIndex = 18;
            this.strTaro.Text = "Повешенный";
            // 
            // strMaxwell
            // 
            this.strMaxwell.AutoSize = true;
            this.strMaxwell.BackColor = System.Drawing.Color.Goldenrod;
            this.strMaxwell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strMaxwell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strMaxwell.Location = new System.Drawing.Point(-6, 589);
            this.strMaxwell.Name = "strMaxwell";
            this.strMaxwell.Size = new System.Drawing.Size(143, 25);
            this.strMaxwell.TabIndex = 19;
            this.strMaxwell.Text = "Кот Максвелл";
            // 
            // strHarvi
            // 
            this.strHarvi.AutoSize = true;
            this.strHarvi.BackColor = System.Drawing.Color.Goldenrod;
            this.strHarvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strHarvi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strHarvi.Location = new System.Drawing.Point(-6, 639);
            this.strHarvi.Name = "strHarvi";
            this.strHarvi.Size = new System.Drawing.Size(124, 25);
            this.strHarvi.TabIndex = 20;
            this.strHarvi.Text = "Дядя Харви";
            // 
            // missionPassed
            // 
            this.missionPassed.BackColor = System.Drawing.Color.Goldenrod;
            this.missionPassed.Image = global::DogDreams.Properties.Resources.Mission_passed;
            this.missionPassed.Location = new System.Drawing.Point(3084, 181);
            this.missionPassed.Name = "missionPassed";
            this.missionPassed.Size = new System.Drawing.Size(494, 311);
            this.missionPassed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.missionPassed.TabIndex = 21;
            this.missionPassed.TabStop = false;
            this.missionPassed.Click += new System.EventHandler(this.MissionPassed_Click);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogDreams.Properties.Resources.hram;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.missionPassed);
            this.Controls.Add(this.strHarvi);
            this.Controls.Add(this.strMaxwell);
            this.Controls.Add(this.strTaro);
            this.Controls.Add(this.strDevil);
            this.Controls.Add(this.strPapa);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.harvi);
            this.Controls.Add(this.taro);
            this.Controls.Add(this.maxwell);
            this.Controls.Add(this.papa);
            this.Controls.Add(this.devil);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxwell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionPassed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox devil;
        private System.Windows.Forms.PictureBox papa;
        private System.Windows.Forms.PictureBox maxwell;
        private System.Windows.Forms.PictureBox taro;
        private System.Windows.Forms.PictureBox harvi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label strPapa;
        private System.Windows.Forms.Label strDevil;
        private System.Windows.Forms.Label strTaro;
        private System.Windows.Forms.Label strMaxwell;
        private System.Windows.Forms.Label strHarvi;
        private System.Windows.Forms.PictureBox missionPassed;
    }
}