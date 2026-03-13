namespace Atestat
{
    partial class Logare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logare));
            this.emailLbl = new System.Windows.Forms.Label();
            this.parolaLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.parolaTxt = new System.Windows.Forms.TextBox();
            this.logareLbl = new System.Windows.Forms.Label();
            this.creeazaBtn = new System.Windows.Forms.Button();
            this.logareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Image = global::Atestat.Properties.Resources.backgroundPrim;
            this.emailLbl.Location = new System.Drawing.Point(161, 187);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email:";
            // 
            // parolaLbl
            // 
            this.parolaLbl.AutoSize = true;
            this.parolaLbl.ForeColor = System.Drawing.Color.White;
            this.parolaLbl.Image = global::Atestat.Properties.Resources.backgroundPrim;
            this.parolaLbl.Location = new System.Drawing.Point(161, 252);
            this.parolaLbl.Name = "parolaLbl";
            this.parolaLbl.Size = new System.Drawing.Size(40, 13);
            this.parolaLbl.TabIndex = 1;
            this.parolaLbl.Text = "Parola:";
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.emailTxt.Location = new System.Drawing.Point(241, 184);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(291, 20);
            this.emailTxt.TabIndex = 2;
            // 
            // parolaTxt
            // 
            this.parolaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.parolaTxt.Location = new System.Drawing.Point(241, 249);
            this.parolaTxt.Name = "parolaTxt";
            this.parolaTxt.PasswordChar = '*';
            this.parolaTxt.Size = new System.Drawing.Size(291, 20);
            this.parolaTxt.TabIndex = 3;
            // 
            // logareLbl
            // 
            this.logareLbl.AutoSize = true;
            this.logareLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logareLbl.ForeColor = System.Drawing.Color.White;
            this.logareLbl.Image = global::Atestat.Properties.Resources.asfgdghdgjfhfhj;
            this.logareLbl.Location = new System.Drawing.Point(314, 61);
            this.logareLbl.Name = "logareLbl";
            this.logareLbl.Size = new System.Drawing.Size(123, 37);
            this.logareLbl.TabIndex = 4;
            this.logareLbl.Text = "Logare";
            // 
            // creeazaBtn
            // 
            this.creeazaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creeazaBtn.ForeColor = System.Drawing.Color.White;
            this.creeazaBtn.Image = global::Atestat.Properties.Resources.backgroundPrim;
            this.creeazaBtn.Location = new System.Drawing.Point(423, 378);
            this.creeazaBtn.Name = "creeazaBtn";
            this.creeazaBtn.Size = new System.Drawing.Size(109, 61);
            this.creeazaBtn.TabIndex = 5;
            this.creeazaBtn.Text = "Creeaza Cont";
            this.creeazaBtn.UseVisualStyleBackColor = true;
            this.creeazaBtn.Click += new System.EventHandler(this.creeazaBtn_Click);
            // 
            // logareBtn
            // 
            this.logareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logareBtn.ForeColor = System.Drawing.Color.White;
            this.logareBtn.Image = global::Atestat.Properties.Resources.backgroundPrim;
            this.logareBtn.Location = new System.Drawing.Point(241, 346);
            this.logareBtn.Name = "logareBtn";
            this.logareBtn.Size = new System.Drawing.Size(156, 93);
            this.logareBtn.TabIndex = 6;
            this.logareBtn.Text = "Logare";
            this.logareBtn.UseVisualStyleBackColor = true;
            this.logareBtn.Click += new System.EventHandler(this.logareBtn_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.Properties.Resources.backgroundPrim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 507);
            this.Controls.Add(this.logareBtn);
            this.Controls.Add(this.creeazaBtn);
            this.Controls.Add(this.logareLbl);
            this.Controls.Add(this.parolaTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.parolaLbl);
            this.Controls.Add(this.emailLbl);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logare";
            this.Text = "Logare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logare_FormClosed);
            this.Load += new System.EventHandler(this.Logare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label parolaLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox parolaTxt;
        private System.Windows.Forms.Label logareLbl;
        private System.Windows.Forms.Button creeazaBtn;
        private System.Windows.Forms.Button logareBtn;
    }
}