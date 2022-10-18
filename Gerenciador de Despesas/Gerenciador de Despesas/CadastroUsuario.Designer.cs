namespace Gerenciador_de_Despesas
{
    partial class CadastroUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cadastroUsuario = new System.Windows.Forms.TextBox();
            this.textBox_cadastroSenha = new System.Windows.Forms.TextBox();
            this.button_cadastroUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(195, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(195, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "DESPESA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "GERENCIADOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(28, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "SENHA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(28, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "USUÁRIO:";
            // 
            // textBox_cadastroUsuario
            // 
            this.textBox_cadastroUsuario.Location = new System.Drawing.Point(114, 187);
            this.textBox_cadastroUsuario.Name = "textBox_cadastroUsuario";
            this.textBox_cadastroUsuario.Size = new System.Drawing.Size(281, 23);
            this.textBox_cadastroUsuario.TabIndex = 8;
            // 
            // textBox_cadastroSenha
            // 
            this.textBox_cadastroSenha.Location = new System.Drawing.Point(114, 218);
            this.textBox_cadastroSenha.Name = "textBox_cadastroSenha";
            this.textBox_cadastroSenha.Size = new System.Drawing.Size(281, 23);
            this.textBox_cadastroSenha.TabIndex = 9;
            // 
            // button_cadastroUsuario
            // 
            this.button_cadastroUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.button_cadastroUsuario.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cadastroUsuario.Location = new System.Drawing.Point(114, 247);
            this.button_cadastroUsuario.Name = "button_cadastroUsuario";
            this.button_cadastroUsuario.Size = new System.Drawing.Size(281, 37);
            this.button_cadastroUsuario.TabIndex = 10;
            this.button_cadastroUsuario.Text = "CRIAR USUÁRIO";
            this.button_cadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(421, 300);
            this.Controls.Add(this.button_cadastroUsuario);
            this.Controls.Add(this.textBox_cadastroSenha);
            this.Controls.Add(this.textBox_cadastroUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroUsuario";
            this.Text = "Cadastro de Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseCadastroUsuario);
            this.Load += new System.EventHandler(this.LoadCadastroUsuario);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox textBox_cadastroUsuario;
        private TextBox textBox_cadastroSenha;
        private Button button_cadastroUsuario;
    }
}