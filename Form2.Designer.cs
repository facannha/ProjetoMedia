namespace ProjetoMédia {
    partial class Form2 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lLogo = new System.Windows.Forms.Label();
            this.lApresent = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.lSenha = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-57, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 57);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lLogo
            // 
            this.lLogo.AutoSize = true;
            this.lLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lLogo.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lLogo.Location = new System.Drawing.Point(12, 9);
            this.lLogo.Name = "lLogo";
            this.lLogo.Size = new System.Drawing.Size(212, 35);
            this.lLogo.TabIndex = 0;
            this.lLogo.Text = "LOGIN ESCOLA";
            this.lLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lApresent
            // 
            this.lApresent.AutoSize = true;
            this.lApresent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lApresent.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lApresent.Location = new System.Drawing.Point(12, 78);
            this.lApresent.Name = "lApresent";
            this.lApresent.Size = new System.Drawing.Size(376, 25);
            this.lApresent.TabIndex = 4;
            this.lApresent.Text = "Digite seus dados para entrar no sistema";
            this.lApresent.Click += new System.EventHandler(this.lApresent_Click);
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lUser.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUser.Location = new System.Drawing.Point(12, 174);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(87, 21);
            this.lUser.TabIndex = 12;
            this.lUser.Text = "USUÁRIO:";
            // 
            // lSenha
            // 
            this.lSenha.AutoSize = true;
            this.lSenha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lSenha.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSenha.Location = new System.Drawing.Point(12, 246);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(69, 21);
            this.lSenha.TabIndex = 13;
            this.lSenha.Text = "SENHA:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(485, 344);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.Location = new System.Drawing.Point(12, 344);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(104, 26);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(120, 172);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(300, 23);
            this.textUser.TabIndex = 16;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(120, 244);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(300, 23);
            this.textSenha.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 379);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lSenha);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.lApresent);
            this.Controls.Add(this.lLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Escola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lLogo;
        private Label lApresent;
        private Label lUser;
        private Label lSenha;
        private Button btnSair;
        private Button btnEntrar;
        private TextBox textUser;
        private TextBox textSenha;
    }
}