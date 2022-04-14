namespace ProjetoMédia {
    partial class Form1 {
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
            this.lMedia = new System.Windows.Forms.Label();
            this.lApresent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lNota1 = new System.Windows.Forms.Label();
            this.lNota2 = new System.Windows.Forms.Label();
            this.lNota3 = new System.Windows.Forms.Label();
            this.textN1 = new System.Windows.Forms.TextBox();
            this.textN2 = new System.Windows.Forms.TextBox();
            this.textN3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lMedia
            // 
            this.lMedia.AutoSize = true;
            this.lMedia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lMedia.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lMedia.Location = new System.Drawing.Point(42, 14);
            this.lMedia.Name = "lMedia";
            this.lMedia.Size = new System.Drawing.Size(235, 35);
            this.lMedia.TabIndex = 0;
            this.lMedia.Text = "MÉDIA ESCOLAR";
            this.lMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lMedia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lApresent
            // 
            this.lApresent.AutoSize = true;
            this.lApresent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lApresent.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lApresent.Location = new System.Drawing.Point(41, 90);
            this.lApresent.Name = "lApresent";
            this.lApresent.Size = new System.Drawing.Size(584, 25);
            this.lApresent.TabIndex = 1;
            this.lApresent.Text = "Digite as notas dos três trimestres do aluno e calcule sua média:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lMedia);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 64);
            this.panel1.TabIndex = 2;
            // 
            // lNota1
            // 
            this.lNota1.AutoSize = true;
            this.lNota1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lNota1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNota1.Location = new System.Drawing.Point(66, 206);
            this.lNota1.Name = "lNota1";
            this.lNota1.Size = new System.Drawing.Size(185, 21);
            this.lNota1.TabIndex = 3;
            this.lNota1.Text = "NOTAS 1º TRIMESTRE:";
            // 
            // lNota2
            // 
            this.lNota2.AutoSize = true;
            this.lNota2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lNota2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNota2.Location = new System.Drawing.Point(66, 258);
            this.lNota2.Name = "lNota2";
            this.lNota2.Size = new System.Drawing.Size(185, 21);
            this.lNota2.TabIndex = 4;
            this.lNota2.Text = "NOTAS 2º TRIMESTRE:";
            // 
            // lNota3
            // 
            this.lNota3.AutoSize = true;
            this.lNota3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lNota3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNota3.Location = new System.Drawing.Point(66, 316);
            this.lNota3.Name = "lNota3";
            this.lNota3.Size = new System.Drawing.Size(185, 21);
            this.lNota3.TabIndex = 5;
            this.lNota3.Text = "NOTAS 3º TRIMESTRE:";
            // 
            // textN1
            // 
            this.textN1.Location = new System.Drawing.Point(286, 204);
            this.textN1.Name = "textN1";
            this.textN1.Size = new System.Drawing.Size(100, 23);
            this.textN1.TabIndex = 6;
            // 
            // textN2
            // 
            this.textN2.Location = new System.Drawing.Point(286, 258);
            this.textN2.Name = "textN2";
            this.textN2.Size = new System.Drawing.Size(100, 23);
            this.textN2.TabIndex = 7;
            // 
            // textN3
            // 
            this.textN3.Location = new System.Drawing.Point(286, 314);
            this.textN3.Name = "textN3";
            this.textN3.Size = new System.Drawing.Size(100, 23);
            this.textN3.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(66, 375);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(128, 31);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "CALCULAR MÉDIA";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(617, 383);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lNome.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNome.Location = new System.Drawing.Point(66, 159);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(154, 21);
            this.lNome.TabIndex = 11;
            this.lNome.Text = "NOME DO ALUNO:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(286, 157);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(233, 23);
            this.textNome.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(219, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "LIMPAR CAMPOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResult
            // 
            this.textResult.Enabled = false;
            this.textResult.Location = new System.Drawing.Point(516, 314);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(167, 23);
            this.textResult.TabIndex = 14;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lResult.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lResult.Location = new System.Drawing.Point(400, 316);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(110, 21);
            this.lResult.TabIndex = 15;
            this.lResult.Text = "RESULTADO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 418);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textN3);
            this.Controls.Add(this.textN2);
            this.Controls.Add(this.textN1);
            this.Controls.Add(this.lNota3);
            this.Controls.Add(this.lNota2);
            this.Controls.Add(this.lNota1);
            this.Controls.Add(this.lApresent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média escolar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lMedia;
        private Label lApresent;
        private Panel panel1;
        private Label lNota1;
        private Label lNota2;
        private Label lNota3;
        private TextBox textN1;
        private TextBox textN2;
        private TextBox textN3;
        private Button btnCalc;
        private Button btnSair;
        private Label lNome;
        private TextBox textNome;
        private Button button1;
        private TextBox textResult;
        private Label lResult;
    }
}