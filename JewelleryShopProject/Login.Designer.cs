namespace JewelleryShopProject
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
            this.chkshowpass = new System.Windows.Forms.CheckBox();
            this.buttoncross = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContinueAsSeller = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkshowpass
            // 
            this.chkshowpass.AutoSize = true;
            this.chkshowpass.Location = new System.Drawing.Point(799, 254);
            this.chkshowpass.Name = "chkshowpass";
            this.chkshowpass.Size = new System.Drawing.Size(129, 21);
            this.chkshowpass.TabIndex = 29;
            this.chkshowpass.Text = "Show Password";
            this.chkshowpass.UseVisualStyleBackColor = true;
            this.chkshowpass.CheckedChanged += new System.EventHandler(this.chkshowpass_CheckedChanged);
            // 
            // buttoncross
            // 
            this.buttoncross.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncross.Location = new System.Drawing.Point(1008, 42);
            this.buttoncross.Name = "buttoncross";
            this.buttoncross.Size = new System.Drawing.Size(91, 39);
            this.buttoncross.TabIndex = 28;
            this.buttoncross.Text = "X";
            this.buttoncross.UseVisualStyleBackColor = true;
            this.buttoncross.Click += new System.EventHandler(this.buttoncross_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(577, 447);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(176, 41);
            this.buttonReset.TabIndex = 27;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(577, 375);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(176, 40);
            this.buttonLogin.TabIndex = 26;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(620, 252);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(178, 22);
            this.txtpassword.TabIndex = 25;
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(620, 179);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(178, 22);
            this.txtuserName.TabIndex = 24;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Maroon;
            this.labelPassword.Location = new System.Drawing.Point(453, 242);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(123, 32);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Password:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Maroon;
            this.labelUserName.Location = new System.Drawing.Point(453, 170);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(135, 32);
            this.labelUserName.TabIndex = 22;
            this.labelUserName.Text = "UserName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(569, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "Jewellery Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblContinueAsSeller
            // 
            this.lblContinueAsSeller.AutoSize = true;
            this.lblContinueAsSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinueAsSeller.Location = new System.Drawing.Point(577, 511);
            this.lblContinueAsSeller.Name = "lblContinueAsSeller";
            this.lblContinueAsSeller.Size = new System.Drawing.Size(166, 20);
            this.lblContinueAsSeller.TabIndex = 30;
            this.lblContinueAsSeller.Text = "Continue As Seller";
            this.lblContinueAsSeller.Click += new System.EventHandler(this.lblContinueAsSeller_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 631);
            this.Controls.Add(this.lblContinueAsSeller);
            this.Controls.Add(this.chkshowpass);
            this.Controls.Add(this.buttoncross);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkshowpass;
        private System.Windows.Forms.Button buttoncross;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContinueAsSeller;
    }
}