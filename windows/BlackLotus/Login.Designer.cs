
namespace BlackLotus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frogotpassword = new System.Windows.Forms.Label();
            this.Signin = new XanderUI.XUISuperButton();
            this.label3 = new System.Windows.Forms.Label();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.loginemil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 356);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.frogotpassword);
            this.panel2.Controls.Add(this.Signin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.loginpassword);
            this.panel2.Controls.Add(this.loginemil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(312, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 366);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // frogotpassword
            // 
            this.frogotpassword.AutoSize = true;
            this.frogotpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frogotpassword.ForeColor = System.Drawing.Color.Red;
            this.frogotpassword.Location = new System.Drawing.Point(155, 265);
            this.frogotpassword.Name = "frogotpassword";
            this.frogotpassword.Size = new System.Drawing.Size(91, 13);
            this.frogotpassword.TabIndex = 5;
            this.frogotpassword.Text = "frogot password ?";
            this.frogotpassword.Click += new System.EventHandler(this.frogotpassword_Click);
            // 
            // Signin
            // 
            this.Signin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Signin.ButtonImage = null;
            this.Signin.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.Signin.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.Signin.ButtonText = "Sign-in";
            this.Signin.CornerRadius = 30;
            this.Signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Signin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.Signin.HoverTextColor = System.Drawing.Color.White;
            this.Signin.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.Signin.Location = new System.Drawing.Point(100, 302);
            this.Signin.Name = "Signin";
            this.Signin.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.Signin.SelectedTextColor = System.Drawing.Color.White;
            this.Signin.Size = new System.Drawing.Size(122, 39);
            this.Signin.SuperSelected = false;
            this.Signin.TabIndex = 1;
            this.Signin.TextColor = System.Drawing.Color.White;
            this.Signin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to \" Black Lotus \"..";
            // 
            // loginpassword
            // 
            this.loginpassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpassword.Location = new System.Drawing.Point(62, 225);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(187, 28);
            this.loginpassword.TabIndex = 3;
            this.loginpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginemil
            // 
            this.loginemil.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginemil.Location = new System.Drawing.Point(62, 156);
            this.loginemil.Name = "loginemil";
            this.loginemil.Size = new System.Drawing.Size(187, 28);
            this.loginemil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name Or Email";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(99, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 125);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuiGradientPanel1.Controls.Add(this.xuiButton1);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Controls.Add(this.pictureBox2);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-7, -1);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(325, 369);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 1;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 25;
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(19, 13);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(54, 50);
            this.xuiButton1.TabIndex = 8;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.XuiButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(104, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sign-in";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(697, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(713, 402);
            this.MinimumSize = new System.Drawing.Size(713, 402);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginemil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginpassword;
        private System.Windows.Forms.Label frogotpassword;
        private XanderUI.XUISuperButton Signin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton xuiButton1;
    }
}