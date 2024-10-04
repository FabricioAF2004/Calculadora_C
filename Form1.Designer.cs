namespace Calculadora
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
            PrimerioValor = new Label();
            Valor1 = new TextBox();
            Valor2 = new TextBox();
            SegundoValor = new Label();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // PrimerioValor
            // 
            PrimerioValor.AutoSize = true;
            PrimerioValor.Location = new Point(320, 9);
            PrimerioValor.Name = "PrimerioValor";
            PrimerioValor.Size = new Size(143, 25);
            PrimerioValor.TabIndex = 0;
            PrimerioValor.Text = "PrimerioNumero";
            // 
            // Valor1
            // 
            Valor1.Location = new Point(313, 37);
            Valor1.Name = "Valor1";
            Valor1.Size = new Size(150, 31);
            Valor1.TabIndex = 1;
            Valor1.TextChanged += Valor1_TextChanged;
            // 
            // Valor2
            // 
            Valor2.Location = new Point(313, 109);
            Valor2.Name = "Valor2";
            Valor2.Size = new Size(150, 31);
            Valor2.TabIndex = 3;
            Valor2.TextChanged += Valor2_TextChanged;
            // 
            // SegundoValor
            // 
            SegundoValor.AutoSize = true;
            SegundoValor.Location = new Point(332, 81);
            SegundoValor.Name = "SegundoValor";
            SegundoValor.Size = new Size(124, 25);
            SegundoValor.TabIndex = 2;
            SegundoValor.Text = "SegundoValor";
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(123, 175);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(112, 34);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(270, 175);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(112, 34);
            btnSubtrair.TabIndex = 5;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(423, 175);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(112, 34);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(568, 175);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(112, 34);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 246);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(Valor2);
            Controls.Add(SegundoValor);
            Controls.Add(Valor1);
            Controls.Add(PrimerioValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PrimerioValor;
        private TextBox Valor1;
        private TextBox Valor2;
        private Label SegundoValor;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
