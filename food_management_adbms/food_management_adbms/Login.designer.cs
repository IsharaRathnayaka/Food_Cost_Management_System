namespace ES_project2
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
            this.SlideA = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.box_log_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.box_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bt_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.line1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.SlideA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // SlideA
            // 
            this.SlideA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.SlideA.Controls.Add(this.bunifuCustomLabel4);
            this.SlideA.Controls.Add(this.chkbox);
            this.SlideA.Controls.Add(this.box_log_pass);
            this.SlideA.Controls.Add(this.bunifuCustomLabel2);
            this.SlideA.Controls.Add(this.box_id);
            this.SlideA.Controls.Add(this.bunifuCustomLabel1);
            this.SlideA.Controls.Add(this.bt_login);
            this.SlideA.Location = new System.Drawing.Point(40, 195);
            this.SlideA.Name = "SlideA";
            this.SlideA.Size = new System.Drawing.Size(629, 531);
            this.SlideA.TabIndex = 0;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 280);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(139, 24);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Show Password\r\n";
            // 
            // chkbox
            // 
            this.chkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkbox.Checked = false;
            this.chkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkbox.ForeColor = System.Drawing.Color.White;
            this.chkbox.Location = new System.Drawing.Point(4, 284);
            this.chkbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(20, 20);
            this.chkbox.TabIndex = 6;
            this.chkbox.OnChange += new System.EventHandler(this.chkbox_OnChange);
            // 
            // box_log_pass
            // 
            this.box_log_pass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.box_log_pass.BorderColorIdle = System.Drawing.Color.Silver;
            this.box_log_pass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(252)))), ((int)(((byte)(69)))));
            this.box_log_pass.BorderThickness = 3;
            this.box_log_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_log_pass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_log_pass.ForeColor = System.Drawing.Color.White;
            this.box_log_pass.isPassword = false;
            this.box_log_pass.Location = new System.Drawing.Point(4, 231);
            this.box_log_pass.Margin = new System.Windows.Forms.Padding(4);
            this.box_log_pass.Name = "box_log_pass";
            this.box_log_pass.Size = new System.Drawing.Size(618, 45);
            this.box_log_pass.TabIndex = 4;
            this.box_log_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(0, 203);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(99, 24);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Password :\r\n";
            // 
            // box_id
            // 
            this.box_id.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(33)))));
            this.box_id.BorderColorIdle = System.Drawing.Color.Silver;
            this.box_id.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(252)))), ((int)(((byte)(69)))));
            this.box_id.BorderThickness = 3;
            this.box_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_id.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_id.ForeColor = System.Drawing.Color.White;
            this.box_id.isPassword = false;
            this.box_id.Location = new System.Drawing.Point(4, 94);
            this.box_id.Margin = new System.Windows.Forms.Padding(4);
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(618, 45);
            this.box_id.TabIndex = 2;
            this.box_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.box_id.OnValueChanged += new System.EventHandler(this.box_id_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(140, 30);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "User Name :\r\n";
            // 
            // bt_login
            // 
            this.bt_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_login.BorderRadius = 0;
            this.bt_login.ButtonText = "LOGIN";
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.DisabledColor = System.Drawing.Color.Gray;
            this.bt_login.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_login.Iconimage = null;
            this.bt_login.Iconimage_right = null;
            this.bt_login.Iconimage_right_Selected = null;
            this.bt_login.Iconimage_Selected = null;
            this.bt_login.IconMarginLeft = 0;
            this.bt_login.IconMarginRight = 0;
            this.bt_login.IconRightVisible = true;
            this.bt_login.IconRightZoom = 0D;
            this.bt_login.IconVisible = true;
            this.bt_login.IconZoom = 90D;
            this.bt_login.IsTab = false;
            this.bt_login.Location = new System.Drawing.Point(164, 403);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_login.Name = "bt_login";
            this.bt_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bt_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bt_login.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_login.selected = false;
            this.bt_login.Size = new System.Drawing.Size(310, 61);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "LOGIN";
            this.bt_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_login.Textcolor = System.Drawing.Color.White;
            this.bt_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(105, 93);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(503, 78);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "FOOD COST MANAGEMENT \r\nLOGIN";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.line1.LineThickness = 6;
            this.line1.Location = new System.Drawing.Point(44, 175);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(625, 13);
            this.line1.TabIndex = 2;
            this.line1.Transparency = 255;
            this.line1.Vertical = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(661, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 38);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.InitialImage = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(11, 11);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(128, 80);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 60;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(720, 770);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.SlideA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SlideA.ResumeLayout(false);
            this.SlideA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SlideA;
        private Bunifu.Framework.UI.BunifuMetroTextbox box_id;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bt_login;
        private Bunifu.Framework.UI.BunifuMetroTextbox box_log_pass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuSeparator line1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCheckbox chkbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}

