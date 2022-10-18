namespace Gerenciador_de_Despesas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_USUARIO = new System.Windows.Forms.TextBox();
            this.textBox_SENHA = new System.Windows.Forms.TextBox();
            this.button_LOGIN = new System.Windows.Forms.Button();
            this.button_NOVO_USUARIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(109, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERENCIADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(373, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESPESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(373, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "DE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(53, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "USUÁRIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(53, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "SENHA:";
            // 
            // textBox_USUARIO
            // 
            this.textBox_USUARIO.Location = new System.Drawing.Point(139, 327);
            this.textBox_USUARIO.Name = "textBox_USUARIO";
            this.textBox_USUARIO.Size = new System.Drawing.Size(340, 23);
            this.textBox_USUARIO.TabIndex = 5;
            // 
            // textBox_SENHA
            // 
            this.textBox_SENHA.Location = new System.Drawing.Point(139, 361);
            this.textBox_SENHA.Name = "textBox_SENHA";
            this.textBox_SENHA.Size = new System.Drawing.Size(340, 23);
            this.textBox_SENHA.TabIndex = 6;
            // 
            // button_LOGIN
            // 
            this.button_LOGIN.BackColor = System.Drawing.Color.IndianRed;
            this.button_LOGIN.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LOGIN.Location = new System.Drawing.Point(496, 327);
            this.button_LOGIN.Name = "button_LOGIN";
            this.button_LOGIN.Size = new System.Drawing.Size(96, 57);
            this.button_LOGIN.TabIndex = 7;
            this.button_LOGIN.Text = "LOGIN";
            this.button_LOGIN.UseVisualStyleBackColor = false;
            // 
            // button_NOVO_USUARIO
            // 
            this.button_NOVO_USUARIO.BackColor = System.Drawing.Color.IndianRed;
            this.button_NOVO_USUARIO.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_NOVO_USUARIO.Location = new System.Drawing.Point(598, 327);
            this.button_NOVO_USUARIO.Name = "button_NOVO_USUARIO";
            this.button_NOVO_USUARIO.Size = new System.Drawing.Size(117, 57);
            this.button_NOVO_USUARIO.TabIndex = 8;
            this.button_NOVO_USUARIO.Text = "NOVO USUÁRIO";
            this.button_NOVO_USUARIO.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_NOVO_USUARIO);
            this.Controls.Add(this.button_LOGIN);
            this.Controls.Add(this.textBox_SENHA);
            this.Controls.Add(this.textBox_USUARIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_USUARIO;
        private TextBox textBox_SENHA;
        private Button button_LOGIN;
        private Button button_NOVO_USUARIO;
    }
}