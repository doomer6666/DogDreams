namespace DogDreams
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.monkey = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.strMonkey = new System.Windows.Forms.Label();
            this.strCola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola)).BeginInit();
            this.SuspendLayout();
            // 
            // monkey
            // 
            this.monkey.BackColor = System.Drawing.Color.Transparent;
            this.monkey.Image = ((System.Drawing.Image)(resources.GetObject("monkey.Image")));
            this.monkey.Location = new System.Drawing.Point(1115, 459);
            this.monkey.Name = "monkey";
            this.monkey.Size = new System.Drawing.Size(66, 129);
            this.monkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.monkey.TabIndex = 0;
            this.monkey.TabStop = false;
            this.monkey.Click += new System.EventHandler(this.monkey_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.ForestGreen;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info.Location = new System.Drawing.Point(0, -2);
            this.info.MaximumSize = new System.Drawing.Size(200, 700);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(200, 420);
            this.info.TabIndex = 1;
            this.info.Text = resources.GetString("info.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 720);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(33, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Найдите:";
            // 
            // strMonkey
            // 
            this.strMonkey.AutoSize = true;
            this.strMonkey.BackColor = System.Drawing.Color.ForestGreen;
            this.strMonkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strMonkey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strMonkey.Location = new System.Drawing.Point(-1, 579);
            this.strMonkey.Name = "strMonkey";
            this.strMonkey.Size = new System.Drawing.Size(110, 25);
            this.strMonkey.TabIndex = 4;
            this.strMonkey.Text = "Шимпанзе";
            // 
            // strCola
            // 
            this.strCola.AutoSize = true;
            this.strCola.BackColor = System.Drawing.Color.ForestGreen;
            this.strCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strCola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strCola.Location = new System.Drawing.Point(-1, 604);
            this.strCola.Name = "strCola";
            this.strCola.Size = new System.Drawing.Size(137, 25);
            this.strCola.TabIndex = 5;
            this.strCola.Text = "Добрый Кола";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-11, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // cola
            // 
            this.cola.BackColor = System.Drawing.Color.Transparent;
            this.cola.Image = ((System.Drawing.Image)(resources.GetObject("cola.Image")));
            this.cola.Location = new System.Drawing.Point(256, 508);
            this.cola.Name = "cola";
            this.cola.Size = new System.Drawing.Size(91, 121);
            this.cola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cola.TabIndex = 7;
            this.cola.TabStop = false;
            this.cola.Click += new System.EventHandler(this.cola_Click);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cola);
            this.Controls.Add(this.strCola);
            this.Controls.Add(this.strMonkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monkey);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Level1";
            this.Text = "Level1";
            ((System.ComponentModel.ISupportInitialize)(this.monkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox monkey;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label strMonkey;
        private System.Windows.Forms.Label strCola;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox cola;
    }
}