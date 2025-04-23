namespace Tarea_calculadora_de_temperatura
{
    partial class Form1
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
            this.btn_Cacular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_farengeith = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cacular
            // 
            this.btn_Cacular.Location = new System.Drawing.Point(251, 93);
            this.btn_Cacular.Name = "btn_Cacular";
            this.btn_Cacular.Size = new System.Drawing.Size(75, 23);
            this.btn_Cacular.TabIndex = 0;
            this.btn_Cacular.Text = "Calcular";
            this.btn_Cacular.UseVisualStyleBackColor = true;
            this.btn_Cacular.Click += new System.EventHandler(this.btn_Cacular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura en Farengeith:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatura de Celcius: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_celsius
            // 
            this.txt_celsius.Location = new System.Drawing.Point(192, 23);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(134, 20);
            this.txt_celsius.TabIndex = 3;
            this.txt_celsius.Text = "0";
            // 
            // txt_farengeith
            // 
            this.txt_farengeith.Location = new System.Drawing.Point(192, 59);
            this.txt_farengeith.Name = "txt_farengeith";
            this.txt_farengeith.Size = new System.Drawing.Size(134, 20);
            this.txt_farengeith.TabIndex = 4;
            this.txt_farengeith.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 128);
            this.Controls.Add(this.txt_farengeith);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cacular);
            this.Name = "Form1";
            this.Text = "Calculadora de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cacular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_farengeith;
    }
}

