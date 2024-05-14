namespace DogDreams
{
    partial class End
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
            this.winText = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.around = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winText
            // 
            this.winText.AutoSize = true;
            this.winText.BackColor = System.Drawing.Color.Wheat;
            this.winText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winText.Location = new System.Drawing.Point(226, 401);
            this.winText.MaximumSize = new System.Drawing.Size(1000, 1100);
            this.winText.Name = "winText";
            this.winText.Size = new System.Drawing.Size(988, 87);
            this.winText.TabIndex = 0;
            this.winText.Text = "Вы наконец проснулись, хотя... вы проспали всего 5 минут. Полные разочарования вы" +
    " решаете продолжить спать, но помогать со сном  нашему герою или нет еще раз, ре" +
    "шать уже вам...\r\n";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.Wheat;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.win.Location = new System.Drawing.Point(488, 224);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(453, 69);
            this.win.TabIndex = 1;
            this.win.Text = "Поздравление!";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Wheat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(344, 543);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(134, 123);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // around
            // 
            this.around.BackColor = System.Drawing.Color.Wheat;
            this.around.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.around.Location = new System.Drawing.Point(957, 543);
            this.around.Name = "around";
            this.around.Size = new System.Drawing.Size(134, 123);
            this.around.TabIndex = 3;
            this.around.Text = "Начать сначала";
            this.around.UseVisualStyleBackColor = false;
            this.around.Click += new System.EventHandler(this.Around_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogDreams.Properties.Resources.childrenHouse;
            this.ClientSize = new System.Drawing.Size(1420, 799);
            this.Controls.Add(this.around);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.win);
            this.Controls.Add(this.winText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            this.Load += new System.EventHandler(this.End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winText;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button around;
    }
}