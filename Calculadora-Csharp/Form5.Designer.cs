namespace Calculadora_Csharp
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1Usertype = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.comboBox1Usertype);
            this.panel2.Controls.Add(this.textBoxSenha);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buttonSair);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.textBoxNome);
            this.panel2.Controls.Add(this.textCPF);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 271);
            this.panel2.TabIndex = 2;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 3;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(197, 219);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(81, 39);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatAppearance.BorderSize = 3;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.buttonSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(111, 219);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(81, 39);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(85, 84);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(149, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(54, 50);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(149, 20);
            this.textCPF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar User";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(66, 148);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(149, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo User";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(103, 184);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(149, 20);
            this.textBoxSenha.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Senha";
            // 
            // comboBox1Usertype
            // 
            this.comboBox1Usertype.FormattingEnabled = true;
            this.comboBox1Usertype.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox1Usertype.Location = new System.Drawing.Point(127, 116);
            this.comboBox1Usertype.Name = "comboBox1Usertype";
            this.comboBox1Usertype.Size = new System.Drawing.Size(149, 21);
            this.comboBox1Usertype.TabIndex = 15;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 270);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar User";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1Usertype;
    }
}