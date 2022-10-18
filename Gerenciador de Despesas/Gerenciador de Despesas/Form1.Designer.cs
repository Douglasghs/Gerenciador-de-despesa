namespace Gerenciador_de_Despesas
{
    partial class Form1
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
            this.LB_CARTAO = new System.Windows.Forms.Label();
            this.LB_QUANT_VEZES = new System.Windows.Forms.Label();
            this.LB_PROP_CARTAO = new System.Windows.Forms.Label();
            this.textBox_cartao = new System.Windows.Forms.TextBox();
            this.textBox_QuantidadeVezes = new System.Windows.Forms.TextBox();
            this.textBox_proprtiarioCartao = new System.Windows.Forms.TextBox();
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.LB_VALOR_PRODUTO = new System.Windows.Forms.Label();
            this.button_SALVAR = new System.Windows.Forms.Button();
            this.textBox_NOME_PRODUTO = new System.Windows.Forms.TextBox();
            this.LB_NOME_PRODUTO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_CARTAO
            // 
            this.LB_CARTAO.AutoSize = true;
            this.LB_CARTAO.Location = new System.Drawing.Point(274, 22);
            this.LB_CARTAO.Name = "LB_CARTAO";
            this.LB_CARTAO.Size = new System.Drawing.Size(51, 15);
            this.LB_CARTAO.TabIndex = 1;
            this.LB_CARTAO.Text = "CARTÃO";
            // 
            // LB_QUANT_VEZES
            // 
            this.LB_QUANT_VEZES.AutoSize = true;
            this.LB_QUANT_VEZES.Location = new System.Drawing.Point(391, 22);
            this.LB_QUANT_VEZES.Name = "LB_QUANT_VEZES";
            this.LB_QUANT_VEZES.Size = new System.Drawing.Size(117, 15);
            this.LB_QUANT_VEZES.TabIndex = 2;
            this.LB_QUANT_VEZES.Text = "QUANTIDADE_VEZES";
            // 
            // LB_PROP_CARTAO
            // 
            this.LB_PROP_CARTAO.AutoSize = true;
            this.LB_PROP_CARTAO.Location = new System.Drawing.Point(567, 22);
            this.LB_PROP_CARTAO.Name = "LB_PROP_CARTAO";
            this.LB_PROP_CARTAO.Size = new System.Drawing.Size(134, 15);
            this.LB_PROP_CARTAO.TabIndex = 3;
            this.LB_PROP_CARTAO.Text = "PROPRIETÁRIO_CARTÃO";
            // 
            // textBox_cartao
            // 
            this.textBox_cartao.Location = new System.Drawing.Point(247, 40);
            this.textBox_cartao.Name = "textBox_cartao";
            this.textBox_cartao.Size = new System.Drawing.Size(100, 23);
            this.textBox_cartao.TabIndex = 5;
            // 
            // textBox_QuantidadeVezes
            // 
            this.textBox_QuantidadeVezes.Location = new System.Drawing.Point(369, 40);
            this.textBox_QuantidadeVezes.Name = "textBox_QuantidadeVezes";
            this.textBox_QuantidadeVezes.Size = new System.Drawing.Size(165, 23);
            this.textBox_QuantidadeVezes.TabIndex = 6;
            // 
            // textBox_proprtiarioCartao
            // 
            this.textBox_proprtiarioCartao.Location = new System.Drawing.Point(557, 40);
            this.textBox_proprtiarioCartao.Name = "textBox_proprtiarioCartao";
            this.textBox_proprtiarioCartao.Size = new System.Drawing.Size(153, 23);
            this.textBox_proprtiarioCartao.TabIndex = 7;
            // 
            // textBox_valor
            // 
            this.textBox_valor.Location = new System.Drawing.Point(129, 40);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(100, 23);
            this.textBox_valor.TabIndex = 8;
            // 
            // LB_VALOR_PRODUTO
            // 
            this.LB_VALOR_PRODUTO.AutoSize = true;
            this.LB_VALOR_PRODUTO.Location = new System.Drawing.Point(129, 22);
            this.LB_VALOR_PRODUTO.Name = "LB_VALOR_PRODUTO";
            this.LB_VALOR_PRODUTO.Size = new System.Drawing.Size(101, 15);
            this.LB_VALOR_PRODUTO.TabIndex = 9;
            this.LB_VALOR_PRODUTO.Text = "VALOR_PRODUTO";
            // 
            // button_SALVAR
            // 
            this.button_SALVAR.Location = new System.Drawing.Point(726, 23);
            this.button_SALVAR.Name = "button_SALVAR";
            this.button_SALVAR.Size = new System.Drawing.Size(75, 40);
            this.button_SALVAR.TabIndex = 10;
            this.button_SALVAR.Text = "SALVAR";
            this.button_SALVAR.UseVisualStyleBackColor = true;
            // 
            // textBox_NOME_PRODUTO
            // 
            this.textBox_NOME_PRODUTO.Location = new System.Drawing.Point(12, 40);
            this.textBox_NOME_PRODUTO.Name = "textBox_NOME_PRODUTO";
            this.textBox_NOME_PRODUTO.Size = new System.Drawing.Size(100, 23);
            this.textBox_NOME_PRODUTO.TabIndex = 11;
            // 
            // LB_NOME_PRODUTO
            // 
            this.LB_NOME_PRODUTO.AutoSize = true;
            this.LB_NOME_PRODUTO.Location = new System.Drawing.Point(12, 22);
            this.LB_NOME_PRODUTO.Name = "LB_NOME_PRODUTO";
            this.LB_NOME_PRODUTO.Size = new System.Drawing.Size(100, 15);
            this.LB_NOME_PRODUTO.TabIndex = 12;
            this.LB_NOME_PRODUTO.Text = "NOME_PRODUTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 530);
            this.Controls.Add(this.LB_NOME_PRODUTO);
            this.Controls.Add(this.textBox_NOME_PRODUTO);
            this.Controls.Add(this.button_SALVAR);
            this.Controls.Add(this.LB_VALOR_PRODUTO);
            this.Controls.Add(this.textBox_valor);
            this.Controls.Add(this.textBox_proprtiarioCartao);
            this.Controls.Add(this.textBox_QuantidadeVezes);
            this.Controls.Add(this.textBox_cartao);
            this.Controls.Add(this.LB_PROP_CARTAO);
            this.Controls.Add(this.LB_QUANT_VEZES);
            this.Controls.Add(this.LB_CARTAO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LB_CARTAO;
        private Label LB_QUANT_VEZES;
        private Label LB_PROP_CARTAO;
        private TextBox textBox_cartao;
        private TextBox textBox_QuantidadeVezes;
        private TextBox textBox_proprtiarioCartao;
        private TextBox textBox_valor;
        private Label LB_VALOR_PRODUTO;
        private Button button_SALVAR;
        private TextBox textBox_NOME_PRODUTO;
        private Label LB_NOME_PRODUTO;
    }
}