namespace School_Management_System
{
    partial class SignIn
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
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BorderRadius = 18;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(684, 328);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(135, 37);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Submit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ready to Sign in";
            // 
            // IDTxt
            // 
            this.IDTxt.BorderRadius = 20;
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.DefaultText = "";
            this.IDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Location = new System.Drawing.Point(648, 171);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PasswordChar = '\0';
            this.IDTxt.PlaceholderText = "";
            this.IDTxt.SelectedText = "";
            this.IDTxt.Size = new System.Drawing.Size(209, 39);
            this.IDTxt.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderRadius = 20;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Location = new System.Drawing.Point(648, 241);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '●';
            this.PasswordTxt.PlaceholderText = "";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.Size = new System.Drawing.Size(209, 39);
            this.PasswordTxt.TabIndex = 3;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forget Password?";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 477);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox IDTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;

        #endregion

        //private BunifuButton bunifuButton1;
    }
}

