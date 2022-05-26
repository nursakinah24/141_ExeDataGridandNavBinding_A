
namespace ExerciseDataGridandNavBinding
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.cbTnc = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.labelUname = new System.Windows.Forms.Label();
            this.lablTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(266, 365);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 32);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Location = new System.Drawing.Point(125, 365);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(118, 32);
            this.btnExitLogin.TabIndex = 24;
            this.btnExitLogin.Text = "Exit";
            this.btnExitLogin.UseVisualStyleBackColor = true;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // cbTnc
            // 
            this.cbTnc.AutoSize = true;
            this.cbTnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTnc.Location = new System.Drawing.Point(128, 313);
            this.cbTnc.Name = "cbTnc";
            this.cbTnc.Size = new System.Drawing.Size(160, 22);
            this.cbTnc.TabIndex = 23;
            this.cbTnc.Text = "Term and Condition";
            this.cbTnc.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(128, 269);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(256, 27);
            this.txtPass.TabIndex = 22;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(124, 246);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(83, 20);
            this.labelPass.TabIndex = 21;
            this.labelPass.Text = "Password";
            // 
            // txtUname
            // 
            this.txtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.Location = new System.Drawing.Point(128, 195);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(256, 27);
            this.txtUname.TabIndex = 20;
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(124, 172);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(86, 20);
            this.labelUname.TabIndex = 19;
            this.labelUname.Text = "Username";
            // 
            // lablTitle
            // 
            this.lablTitle.AutoSize = true;
            this.lablTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablTitle.Location = new System.Drawing.Point(120, 64);
            this.lablTitle.Name = "lablTitle";
            this.lablTitle.Size = new System.Drawing.Size(314, 46);
            this.lablTitle.TabIndex = 18;
            this.lablTitle.Text = "Data Mahasiswa";
            this.lablTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 461);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.cbTnc);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.labelUname);
            this.Controls.Add(this.lablTitle);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.CheckBox cbTnc;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.Label lablTitle;
    }
}

