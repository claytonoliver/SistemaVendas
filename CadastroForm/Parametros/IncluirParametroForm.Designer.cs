namespace Sistema.Parametros
{
    partial class IncluirParametroForm
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
            label1 = new Label();
            label2 = new Label();
            txbChave = new TextBox();
            txbDescricao = new TextBox();
            btnSalvar = new Button();
            btnSair = new Button();
            txbValor = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 54);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Chave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 122);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // txbChave
            // 
            txbChave.Location = new Point(84, 50);
            txbChave.Name = "txbChave";
            txbChave.Size = new Size(204, 23);
            txbChave.TabIndex = 2;
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(84, 118);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(204, 23);
            txbDescricao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(20, 195);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(213, 195);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txbValor
            // 
            txbValor.Location = new Point(84, 84);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(204, 23);
            txbValor.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 88);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor";
            // 
            // IncluirParametroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 223);
            ControlBox = false;
            Controls.Add(txbValor);
            Controls.Add(label3);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(txbDescricao);
            Controls.Add(txbChave);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "IncluirParametroForm";
            ShowIcon = false;
            Text = "Incluir Parametro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbChave;
        private TextBox txbDescricao;
        private Button btnSalvar;
        private Button btnSair;
        private TextBox txbValor;
        private Label label3;
    }
}