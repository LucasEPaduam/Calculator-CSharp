namespace Calculadora_Csharp
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.buttonSair);
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.textBoxNewPass);
            this.panel2.Controls.Add(this.textBoxOld);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 232);
            this.panel2.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.BorderSize = 3;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(111, 169);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 39);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(142, 128);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(159, 20);
            this.textBoxNewPass.TabIndex = 5;
            // 
            // textBoxOld
            // 
            this.textBoxOld.Location = new System.Drawing.Point(115, 77);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(149, 20);
            this.textBoxOld.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Password";
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
            this.buttonSair.Location = new System.Drawing.Point(206, 169);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(81, 39);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 231);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Pass";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSair;
    }
}