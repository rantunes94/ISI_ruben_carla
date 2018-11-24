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
            this.comboBox_atividadeFisica = new System.Windows.Forms.ComboBox();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_idade = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_altura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_peso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade(19-78)";
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
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura(cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso(kg)";
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
            this.button_calcular.Location = new System.Drawing.Point(96, 272);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(84, 27);
            this.button_calcular.TabIndex = 12;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 272);
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
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(92, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Calculadora de Calorias(por dia)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Para fazer manutenção do seu peso deverá consumir ";
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Location = new System.Drawing.Point(488, 327);
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.Size = new System.Drawing.Size(62, 20);
            this.textBox_resultado.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "calorias por dia";
            // 
            // numericUpDown_idade
            // 
            this.numericUpDown_idade.Location = new System.Drawing.Point(277, 89);
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
            this.numericUpDown_idade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_idade.TabIndex = 18;
            this.numericUpDown_idade.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDown_idade.ValueChanged += new System.EventHandler(this.numericUpDown_idade_ValueChanged);
            // 
            // numericUpDown_altura
            // 
            this.numericUpDown_altura.Location = new System.Drawing.Point(277, 159);
            this.numericUpDown_altura.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown_altura.Name = "numericUpDown_altura";
            this.numericUpDown_altura.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_altura.TabIndex = 19;
            // 
            // numericUpDown_peso
            // 
            this.numericUpDown_peso.DecimalPlaces = 1;
            this.numericUpDown_peso.Increment = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            this.numericUpDown_peso.Location = new System.Drawing.Point(277, 191);
            this.numericUpDown_peso.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_peso.Name = "numericUpDown_peso";
            this.numericUpDown_peso.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_peso.TabIndex = 20;
            // 
            // CalculadoraCalorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown_peso);
            this.Controls.Add(this.numericUpDown_altura);
            this.Controls.Add(this.numericUpDown_idade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.comboBox_genero);
            this.Controls.Add(this.comboBox_atividadeFisica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculadoraCalorias";
            this.Text = "eNutrideal";
            this.Load += new System.EventHandler(this.CalculadoraCalorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_atividadeFisica;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_resultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_idade;
        private System.Windows.Forms.NumericUpDown numericUpDown_altura;
        private System.Windows.Forms.NumericUpDown numericUpDown_peso;
    }
}