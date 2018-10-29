namespace eNutrideal_desktop
{
    partial class eNutrideal
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
            this.button_calorias = new System.Windows.Forms.Button();
            this.button_peso = new System.Windows.Forms.Button();
            this.button_gestor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calorias
            // 
            this.button_calorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calorias.Location = new System.Drawing.Point(75, 98);
            this.button_calorias.Name = "button_calorias";
            this.button_calorias.Size = new System.Drawing.Size(204, 38);
            this.button_calorias.TabIndex = 0;
            this.button_calorias.Text = "Calculadora de Calorias";
            this.button_calorias.UseVisualStyleBackColor = true;
            this.button_calorias.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_peso
            // 
            this.button_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_peso.Location = new System.Drawing.Point(75, 142);
            this.button_peso.Name = "button_peso";
            this.button_peso.Size = new System.Drawing.Size(204, 37);
            this.button_peso.TabIndex = 1;
            this.button_peso.Text = "Calculadora de Peso Ideal";
            this.button_peso.UseVisualStyleBackColor = true;
            this.button_peso.Click += new System.EventHandler(this.button_peso_Click);
            // 
            // button_gestor
            // 
            this.button_gestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gestor.Location = new System.Drawing.Point(75, 185);
            this.button_gestor.Name = "button_gestor";
            this.button_gestor.Size = new System.Drawing.Size(204, 32);
            this.button_gestor.TabIndex = 2;
            this.button_gestor.Text = " Gestor de Informação Calórica de Refeições fast food";
            this.button_gestor.UseVisualStyleBackColor = true;
            this.button_gestor.Click += new System.EventHandler(this.button_gestor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Funcionalidades:";
            // 
            // eNutrideal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_gestor);
            this.Controls.Add(this.button_peso);
            this.Controls.Add(this.button_calorias);
            this.Name = "eNutrideal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNutrideal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calorias;
        private System.Windows.Forms.Button button_peso;
        private System.Windows.Forms.Button button_gestor;
        private System.Windows.Forms.Label label1;
    }
}

