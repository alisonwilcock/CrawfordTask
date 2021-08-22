
namespace CrawfordTask
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toppanel = new System.Windows.Forms.Panel();
            this.logoutlbl = new System.Windows.Forms.Label();
            this.closelbl = new System.Windows.Forms.Label();
            this.middlepnl = new System.Windows.Forms.Panel();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.textlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unlbl = new System.Windows.Forms.Label();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.usdtxt = new System.Windows.Forms.TextBox();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.losslbl = new System.Windows.Forms.Label();
            this.lossgridview = new System.Windows.Forms.DataGridView();
            this.toppanel.SuspendLayout();
            this.middlepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lossgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(68)))), ((int)(((byte)(134)))));
            this.toppanel.Controls.Add(this.logoutlbl);
            this.toppanel.Controls.Add(this.closelbl);
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(504, 40);
            this.toppanel.TabIndex = 1;
            // 
            // logoutlbl
            // 
            this.logoutlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutlbl.AutoSize = true;
            this.logoutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.logoutlbl.Location = new System.Drawing.Point(374, 9);
            this.logoutlbl.Name = "logoutlbl";
            this.logoutlbl.Size = new System.Drawing.Size(60, 20);
            this.logoutlbl.TabIndex = 2;
            this.logoutlbl.Text = "Logout";
            this.logoutlbl.Click += new System.EventHandler(this.logoutlbl_Click);
            // 
            // closelbl
            // 
            this.closelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closelbl.AutoSize = true;
            this.closelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.closelbl.Location = new System.Drawing.Point(440, 9);
            this.closelbl.Name = "closelbl";
            this.closelbl.Size = new System.Drawing.Size(52, 20);
            this.closelbl.TabIndex = 1;
            this.closelbl.Text = "Close";
            this.closelbl.Click += new System.EventHandler(this.closelbl_Click);
            // 
            // middlepnl
            // 
            this.middlepnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlepnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(105)))), ((int)(((byte)(158)))));
            this.middlepnl.Controls.Add(this.welcomelbl);
            this.middlepnl.Location = new System.Drawing.Point(0, 40);
            this.middlepnl.Name = "middlepnl";
            this.middlepnl.Size = new System.Drawing.Size(504, 50);
            this.middlepnl.TabIndex = 2;
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.welcomelbl.Location = new System.Drawing.Point(7, 10);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(113, 32);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Welcome";
            // 
            // textlbl
            // 
            this.textlbl.AutoSize = true;
            this.textlbl.Location = new System.Drawing.Point(12, 113);
            this.textlbl.Name = "textlbl";
            this.textlbl.Size = new System.Drawing.Size(235, 20);
            this.textlbl.TabIndex = 3;
            this.textlbl.Text = "Login to view your Loss Type data.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(182)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 10);
            this.panel1.TabIndex = 4;
            // 
            // unlbl
            // 
            this.unlbl.AutoSize = true;
            this.unlbl.Location = new System.Drawing.Point(31, 144);
            this.unlbl.Name = "unlbl";
            this.unlbl.Size = new System.Drawing.Size(78, 20);
            this.unlbl.TabIndex = 5;
            this.unlbl.Text = "Username:";
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.Location = new System.Drawing.Point(31, 177);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(73, 20);
            this.pwdlbl.TabIndex = 6;
            this.pwdlbl.Text = "Password:";
            // 
            // usdtxt
            // 
            this.usdtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usdtxt.Location = new System.Drawing.Point(115, 141);
            this.usdtxt.Name = "usdtxt";
            this.usdtxt.Size = new System.Drawing.Size(373, 27);
            this.usdtxt.TabIndex = 7;
            // 
            // pwdtxt
            // 
            this.pwdtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdtxt.Location = new System.Drawing.Point(115, 177);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(373, 27);
            this.pwdtxt.TabIndex = 8;
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbtn.Location = new System.Drawing.Point(116, 216);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(372, 29);
            this.loginbtn.TabIndex = 9;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // losslbl
            // 
            this.losslbl.AutoSize = true;
            this.losslbl.Location = new System.Drawing.Point(12, 265);
            this.losslbl.Name = "losslbl";
            this.losslbl.Size = new System.Drawing.Size(109, 20);
            this.losslbl.TabIndex = 10;
            this.losslbl.Text = "Loss Type data:";
            this.losslbl.Visible = false;
            // 
            // lossgridview
            // 
            this.lossgridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lossgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lossgridview.Location = new System.Drawing.Point(12, 298);
            this.lossgridview.Name = "lossgridview";
            this.lossgridview.ReadOnly = true;
            this.lossgridview.RowHeadersWidth = 51;
            this.lossgridview.RowTemplate.Height = 29;
            this.lossgridview.Size = new System.Drawing.Size(476, 281);
            this.lossgridview.TabIndex = 11;
            this.lossgridview.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 591);
            this.Controls.Add(this.lossgridview);
            this.Controls.Add(this.losslbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.usdtxt);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.unlbl);
            this.Controls.Add(this.textlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.middlepnl);
            this.Controls.Add(this.toppanel);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.middlepnl.ResumeLayout(false);
            this.middlepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lossgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel middlepnl;
        private System.Windows.Forms.Label closelbl;
        private System.Windows.Forms.Label textlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label unlbl;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.TextBox usdtxt;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label losslbl;
        private System.Windows.Forms.DataGridView lossgridview;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label logoutlbl;
    }
}

