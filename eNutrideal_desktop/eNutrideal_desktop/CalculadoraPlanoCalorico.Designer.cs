namespace eNutrideal_desktop
{
    partial class CalculadoraPlanoCalorico
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_peso = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_altura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_idade = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button_calcular = new System.Windows.Forms.Button();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.comboBox_atividadeFisica = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_pesoIdeal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_calorias = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idade)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(71, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Calculadora de Plano Calórico";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Altura(cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Peso(kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nível de actividade física";
            // 
            // numericUpDown_peso
            // 
            this.numericUpDown_peso.DecimalPlaces = 1;
            this.numericUpDown_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown_peso.Increment = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            this.numericUpDown_peso.Location = new System.Drawing.Point(258, 204);
            this.numericUpDown_peso.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_peso.Name = "numericUpDown_peso";
            this.numericUpDown_peso.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_peso.TabIndex = 29;
            // 
            // numericUpDown_altura
            // 
            this.numericUpDown_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown_altura.Location = new System.Drawing.Point(258, 164);
            this.numericUpDown_altura.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown_altura.Name = "numericUpDown_altura";
            this.numericUpDown_altura.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_altura.TabIndex = 28;
            // 
            // numericUpDown_idade
            // 
            this.numericUpDown_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_idade.Location = new System.Drawing.Point(258, 93);
            this.numericUpDown_idade.Maximum = new decimal(new int[] {
            78,
            0,
            0,
            0});
            this.numericUpDown_idade.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDown_idade.Name = "numericUpDown_idade";
            this.numericUpDown_idade.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_idade.TabIndex = 27;
            this.numericUpDown_idade.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDown_idade.ValueChanged += new System.EventHandler(this.numericUpDown_idade_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(969, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Voltar atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(77, 289);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(84, 27);
            this.button_calcular.TabIndex = 25;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Location = new System.Drawing.Point(258, 126);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(121, 28);
            this.comboBox_genero.TabIndex = 24;
            this.comboBox_genero.SelectedIndexChanged += new System.EventHandler(this.comboBox_genero_SelectedIndexChanged);
            // 
            // comboBox_atividadeFisica
            // 
            this.comboBox_atividadeFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_atividadeFisica.FormattingEnabled = true;
            this.comboBox_atividadeFisica.Location = new System.Drawing.Point(258, 241);
            this.comboBox_atividadeFisica.Name = "comboBox_atividadeFisica";
            this.comboBox_atividadeFisica.Size = new System.Drawing.Size(223, 28);
            this.comboBox_atividadeFisica.TabIndex = 23;
            this.comboBox_atividadeFisica.SelectedIndexChanged += new System.EventHandler(this.comboBox_atividadeFisica_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "*baseado na fórmula de Robinson (1983)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "O seu peso ideal em kg é:";
            // 
            // textBox_pesoIdeal
            // 
            this.textBox_pesoIdeal.Location = new System.Drawing.Point(282, 394);
            this.textBox_pesoIdeal.Name = "textBox_pesoIdeal";
            this.textBox_pesoIdeal.Size = new System.Drawing.Size(62, 20);
            this.textBox_pesoIdeal.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(351, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Resultados";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(78, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Plano Calórico:";
            // 
            // textBox_calorias
            // 
            this.textBox_calorias.Location = new System.Drawing.Point(386, 492);
            this.textBox_calorias.Name = "textBox_calorias";
            this.textBox_calorias.Size = new System.Drawing.Size(62, 20);
            this.textBox_calorias.TabIndex = 36;
            this.textBox_calorias.TextChanged += new System.EventHandler(this.textBox_calorias_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(454, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "calorias por dia.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(302, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Para manter o seu peso deverá consumir:";
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_resultado.Location = new System.Drawing.Point(83, 558);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(0, 20);
            this.label_resultado.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(78, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Calculadora de Calorias:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(83, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Calculadora de peso ideal:";
            // 
            // CalculadoraPlanoCalorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_calorias);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_pesoIdeal);
            this.Controls.Add(this.numericUpDown_peso);
            this.Controls.Add(this.numericUpDown_altura);
            this.Controls.Add(this.numericUpDown_idade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.comboBox_genero);
            this.Controls.Add(this.comboBox_atividadeFisica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "CalculadoraPlanoCalorico";
            this.Text = "CalculadoraPlanoCalorico";
            this.Load += new System.EventHandler(this.CalculadoraPlanoCalorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_peso;
        private System.Windows.Forms.NumericUpDown numericUpDown_altura;
        private System.Windows.Forms.NumericUpDown numericUpDown_idade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.ComboBox comboBox_atividadeFisica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_pesoIdeal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_calorias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}