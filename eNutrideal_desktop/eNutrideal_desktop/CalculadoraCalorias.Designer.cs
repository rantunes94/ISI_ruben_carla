namespace eNutrideal_desktop
{
    partial class CalculadoraCalorias
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
            this.textBox_idade = new System.Windows.Forms.TextBox();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.comboBox_atividadeFisica = new System.Windows.Forms.ComboBox();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nível de actividade física";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género";
            // 
            // textBox_idade
            // 
            this.textBox_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idade.Location = new System.Drawing.Point(277, 86);
            this.textBox_idade.Name = "textBox_idade";
            this.textBox_idade.Size = new System.Drawing.Size(100, 26);
            this.textBox_idade.TabIndex = 7;
            // 
            // textBox_altura
            // 
            this.textBox_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_altura.Location = new System.Drawing.Point(277, 156);
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(100, 26);
            this.textBox_altura.TabIndex = 8;
            // 
            // textBox_peso
            // 
            this.textBox_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_peso.Location = new System.Drawing.Point(277, 191);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(100, 26);
            this.textBox_peso.TabIndex = 9;
            // 
            // comboBox_atividadeFisica
            // 
            this.comboBox_atividadeFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_atividadeFisica.FormattingEnabled = true;
            this.comboBox_atividadeFisica.Location = new System.Drawing.Point(277, 224);
            this.comboBox_atividadeFisica.Name = "comboBox_atividadeFisica";
            this.comboBox_atividadeFisica.Size = new System.Drawing.Size(223, 28);
            this.comboBox_atividadeFisica.TabIndex = 10;
            this.comboBox_atividadeFisica.SelectedIndexChanged += new System.EventHandler(this.comboBox_atividadeFisica_SelectedIndexChanged);
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Location = new System.Drawing.Point(277, 122);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(121, 28);
            this.comboBox_genero.TabIndex = 11;
            this.comboBox_genero.SelectedIndexChanged += new System.EventHandler(this.comboBox_genero_SelectedIndexChanged);
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(95, 263);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(84, 27);
            this.button_calcular.TabIndex = 12;
            this.button_calcular.Text = "Calcular!";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Voltar atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Calculadora de Calorias";
            // 
            // CalculadoraCalorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.comboBox_genero);
            this.Controls.Add(this.comboBox_atividadeFisica);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.textBox_idade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculadoraCalorias";
            this.Text = "eNutrideal";
            this.Load += new System.EventHandler(this.CalculadoraCalorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_idade;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.ComboBox comboBox_atividadeFisica;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}