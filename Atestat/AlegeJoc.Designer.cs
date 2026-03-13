namespace Atestat
{
    partial class AlegeJoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlegeJoc));
            this.snakeBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.flappyBirdBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snakeBtn
            // 
            this.snakeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeBtn.ForeColor = System.Drawing.Color.White;
            this.snakeBtn.Image = global::Atestat.Properties.Resources.backgroundPrim;
            this.snakeBtn.Location = new System.Drawing.Point(556, 204);
            this.snakeBtn.Name = "snakeBtn";
            this.snakeBtn.Size = new System.Drawing.Size(109, 61);
            this.snakeBtn.TabIndex = 7;
            this.snakeBtn.Text = "Snake";
            this.snakeBtn.UseVisualStyleBackColor = true;
            this.snakeBtn.Click += new System.EventHandler(this.snakeBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.welcomeLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.Aqua;
            this.welcomeLbl.Location = new System.Drawing.Point(12, 9);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(129, 21);
            this.welcomeLbl.TabIndex = 8;
            this.welcomeLbl.Text = "Bine ai venit!";
            // 
            // flappyBirdBtn
            // 
            this.flappyBirdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flappyBirdBtn.ForeColor = System.Drawing.Color.White;
            this.flappyBirdBtn.Image = global::Atestat.Properties.Resources.backgroundPrim;
            this.flappyBirdBtn.Location = new System.Drawing.Point(133, 204);
            this.flappyBirdBtn.Name = "flappyBirdBtn";
            this.flappyBirdBtn.Size = new System.Drawing.Size(109, 61);
            this.flappyBirdBtn.TabIndex = 9;
            this.flappyBirdBtn.Text = "FlappyBird";
            this.flappyBirdBtn.UseVisualStyleBackColor = true;
            this.flappyBirdBtn.Click += new System.EventHandler(this.flappyBirdBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackgroundImage = global::Atestat.Properties.Resources.backgroundPrim;
            this.disconnectBtn.ForeColor = System.Drawing.Color.White;
            this.disconnectBtn.Location = new System.Drawing.Point(689, 409);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(85, 30);
            this.disconnectBtn.TabIndex = 10;
            this.disconnectBtn.Text = "Deconectare";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // AlegeJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.backgroundPrim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 451);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.flappyBirdBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.snakeBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlegeJoc";
            this.Text = "Alege Joc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlegeJoc_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snakeBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button flappyBirdBtn;
        private System.Windows.Forms.Button disconnectBtn;
    }
}