namespace TesteCEP
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
            textBoxCEP = new TextBox();
            ButtonConsultar = new Button();
            txtLogradouro = new TextBox();
            txtBairro = new TextBox();
            txtLocalidade = new TextBox();
            txtUf = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(27, 47);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(125, 27);
            textBoxCEP.TabIndex = 0;
            textBoxCEP.TextChanged += textBoxCEP_TextChanged;
            // 
            // ButtonConsultar
            // 
            ButtonConsultar.FlatStyle = FlatStyle.Flat;
            ButtonConsultar.Location = new Point(158, 45);
            ButtonConsultar.Name = "ButtonConsultar";
            ButtonConsultar.Size = new Size(99, 31);
            ButtonConsultar.TabIndex = 1;
            ButtonConsultar.Text = "Pesquisar";
            ButtonConsultar.UseVisualStyleBackColor = true;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(27, 110);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(230, 27);
            txtLogradouro.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(273, 110);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(125, 27);
            txtBairro.TabIndex = 3;
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(414, 110);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(125, 27);
            txtLocalidade.TabIndex = 4;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(555, 110);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(63, 27);
            txtUf.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 7;
            label2.Text = "Rua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 87);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Bairro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 87);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 9;
            label4.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 87);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 10;
            label5.Text = "Estado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 159);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUf);
            Controls.Add(txtLocalidade);
            Controls.Add(txtBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(ButtonConsultar);
            Controls.Add(textBoxCEP);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCEP;
        private Button ButtonConsultar;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtLocalidade;
        private TextBox txtUf;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}