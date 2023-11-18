namespace Reservation_H
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_logo = new System.Windows.Forms.Panel();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_mdp = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_passe = new System.Windows.Forms.LinkLabel();
            this.btn_reduir = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reduir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(120)))));
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Controls.Add(this.panel1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(250, 330);
            this.panel_logo.TabIndex = 0;
            this.panel_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_logo_MouseDown);
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_user.Location = new System.Drawing.Point(310, 77);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_user.Size = new System.Drawing.Size(408, 25);
            this.textBox_user.TabIndex = 1;
            this.textBox_user.Text = "Nom D\'utilisateur";
            this.textBox_user.Enter += new System.EventHandler(this.textBox_user_Enter);
            this.textBox_user.Leave += new System.EventHandler(this.textBox_user_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 10);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(310, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(408, 10);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_mdp
            // 
            this.textBox_mdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox_mdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mdp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mdp.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_mdp.Location = new System.Drawing.Point(310, 142);
            this.textBox_mdp.Name = "textBox_mdp";
            this.textBox_mdp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_mdp.Size = new System.Drawing.Size(408, 25);
            this.textBox_mdp.TabIndex = 2;
            this.textBox_mdp.Text = "Mote De Passe";
            this.textBox_mdp.Enter += new System.EventHandler(this.textBox_mdp_Enter);
            this.textBox_mdp.Leave += new System.EventHandler(this.textBox_mdp_Leave);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.DimGray;
            this.label_login.Location = new System.Drawing.Point(409, 9);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(208, 40);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "S\'EDENTIFIER";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.LightGray;
            this.button_login.Location = new System.Drawing.Point(310, 238);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(408, 40);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "ACCEDER";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // linkLabel_passe
            // 
            this.linkLabel_passe.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel_passe.AutoSize = true;
            this.linkLabel_passe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_passe.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel_passe.Location = new System.Drawing.Point(438, 289);
            this.linkLabel_passe.Name = "linkLabel_passe";
            this.linkLabel_passe.Size = new System.Drawing.Size(173, 20);
            this.linkLabel_passe.TabIndex = 0;
            this.linkLabel_passe.TabStop = true;
            this.linkLabel_passe.Text = "Mode de passe oublié";
            // 
            // btn_reduir
            // 
            this.btn_reduir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reduir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reduir.Image = ((System.Drawing.Image)(resources.GetObject("btn_reduir.Image")));
            this.btn_reduir.Location = new System.Drawing.Point(738, 4);
            this.btn_reduir.Name = "btn_reduir";
            this.btn_reduir.Size = new System.Drawing.Size(16, 16);
            this.btn_reduir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_reduir.TabIndex = 10;
            this.btn_reduir.TabStop = false;
            this.btn_reduir.Click += new System.EventHandler(this.btn_reduir_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(760, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 9;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(33, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 180);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btn_reduir);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.linkLabel_passe);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_mdp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.panel_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reduir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_mdp;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_passe;
        private System.Windows.Forms.PictureBox btn_reduir;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Panel panel1;
    }
}