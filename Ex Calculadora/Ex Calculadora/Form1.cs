namespace Ex_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidacaoSomenteNumero(valor1.Text, valor2.Text) == true)
            {
                if(valor1.Text.Contains(".") || valor2.Text.Contains("."))
                {
                    valor1.Text = valor1.Text.Replace(".", ",");
                    valor2.Text = valor1.Text.Replace(".", ",");

                }
                double n1 = double.Parse(valor1.Text);
                double n2 = double.Parse(valor2.Text);
                double resultado = 0;
               
                resultado = n1 + n2;
                MessageBox.Show(resultado.ToString(), "Resultado:");
            }         

        }

        private bool ValidacaoSomenteNumero(string v1, string v2)
        {
            try
            {
                double.Parse(v1);
                double.Parse(v2);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digite apenas números");
                return false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidacaoSomenteNumero(valor1.Text, valor2.Text) == true)
            {

            


                double n1 = double.Parse(valor1.Text);
                double n2 = double.Parse(valor2.Text);
                double resultado;

            resultado = n1 - n2;
            MessageBox.Show(resultado.ToString(), "Resultado:");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ValidacaoSomenteNumero(valor1.Text, valor2.Text) == true)
            { 

                double n1 = double.Parse(valor1.Text);
                double n2 = double.Parse(valor2.Text);
                double resultado;

            resultado = n1 * n2;
            MessageBox.Show(resultado.ToString(), "Resultado:");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0; //declarado 0
            double resultado;

            if (ValidacaoSomenteNumero(valor1.Text, valor2.Text) == true)
            {
                n1 = double.Parse(valor1.Text);
                n2 = double.Parse(valor2.Text);

                if (n2 > 0) //maior q zero
                {

                    resultado = n1 / n2;
                    MessageBox.Show(resultado.ToString(), "Resultado:");
                }
                else
                {
                    string erro = "Escolha um dividendo maior que zero";

                    labelresultado.Text = erro.ToString();
                }

            }
        }

        


        #region Windows Form Designer generated code
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


        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.labelresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Somar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Subtrair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Multiplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(487, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dividir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira o primeiro número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o segundo número:";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(408, 64);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(150, 31);
            this.valor1.TabIndex = 6;
            this.valor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(408, 111);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(150, 31);
            this.valor2.TabIndex = 7;
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelresultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelresultado.Location = new System.Drawing.Point(72, 303);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelresultado.Size = new System.Drawing.Size(25, 41);
            this.labelresultado.TabIndex = 9;
            this.labelresultado.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(758, 382);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private TextBox valor1;
        private TextBox valor2;
        private Label labelresultado;


    }
}