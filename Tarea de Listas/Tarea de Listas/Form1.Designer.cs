namespace Tarea_de_Listas
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
            this.btn_anadir_sinorden = new System.Windows.Forms.Button();
            this.btn_borrrar_sinorden = new System.Windows.Forms.Button();
            this.btn_borrarList_sinorden = new System.Windows.Forms.Button();
            this.btn_borrarlist_orden = new System.Windows.Forms.Button();
            this.btn_borrar_orden = new System.Windows.Forms.Button();
            this.btn_anadir_orden = new System.Windows.Forms.Button();
            this.btn_para_desordenar = new System.Windows.Forms.Button();
            this.btn_para_ordenar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anadir_sinorden
            // 
            this.btn_anadir_sinorden.Location = new System.Drawing.Point(87, 348);
            this.btn_anadir_sinorden.Name = "btn_anadir_sinorden";
            this.btn_anadir_sinorden.Size = new System.Drawing.Size(143, 26);
            this.btn_anadir_sinorden.TabIndex = 0;
            this.btn_anadir_sinorden.Text = "Anadir Elemento";
            this.btn_anadir_sinorden.UseVisualStyleBackColor = true;
            this.btn_anadir_sinorden.Click += new System.EventHandler(this.btn_anadir_sinorden_Click);
            // 
            // btn_borrrar_sinorden
            // 
            this.btn_borrrar_sinorden.Location = new System.Drawing.Point(87, 380);
            this.btn_borrrar_sinorden.Name = "btn_borrrar_sinorden";
            this.btn_borrrar_sinorden.Size = new System.Drawing.Size(143, 26);
            this.btn_borrrar_sinorden.TabIndex = 1;
            this.btn_borrrar_sinorden.Text = "Borrar Elemento";
            this.btn_borrrar_sinorden.UseVisualStyleBackColor = true;
            this.btn_borrrar_sinorden.Click += new System.EventHandler(this.btn_borrrar_sinorden_Click);
            // 
            // btn_borrarList_sinorden
            // 
            this.btn_borrarList_sinorden.Location = new System.Drawing.Point(87, 412);
            this.btn_borrarList_sinorden.Name = "btn_borrarList_sinorden";
            this.btn_borrarList_sinorden.Size = new System.Drawing.Size(143, 26);
            this.btn_borrarList_sinorden.TabIndex = 2;
            this.btn_borrarList_sinorden.Text = "Borrar Lista";
            this.btn_borrarList_sinorden.UseVisualStyleBackColor = true;
            this.btn_borrarList_sinorden.Click += new System.EventHandler(this.btn_borrarList_sinorden_Click);
            // 
            // btn_borrarlist_orden
            // 
            this.btn_borrarlist_orden.Location = new System.Drawing.Point(475, 412);
            this.btn_borrarlist_orden.Name = "btn_borrarlist_orden";
            this.btn_borrarlist_orden.Size = new System.Drawing.Size(143, 26);
            this.btn_borrarlist_orden.TabIndex = 5;
            this.btn_borrarlist_orden.Text = "Borrar Lista";
            this.btn_borrarlist_orden.UseVisualStyleBackColor = true;
            this.btn_borrarlist_orden.Click += new System.EventHandler(this.btn_borrarlist_orden_Click);
            // 
            // btn_borrar_orden
            // 
            this.btn_borrar_orden.Location = new System.Drawing.Point(475, 380);
            this.btn_borrar_orden.Name = "btn_borrar_orden";
            this.btn_borrar_orden.Size = new System.Drawing.Size(143, 26);
            this.btn_borrar_orden.TabIndex = 4;
            this.btn_borrar_orden.Text = "Borrar Elemento";
            this.btn_borrar_orden.UseVisualStyleBackColor = true;
            this.btn_borrar_orden.Click += new System.EventHandler(this.btn_borrar_orden_Click);
            // 
            // btn_anadir_orden
            // 
            this.btn_anadir_orden.Location = new System.Drawing.Point(475, 348);
            this.btn_anadir_orden.Name = "btn_anadir_orden";
            this.btn_anadir_orden.Size = new System.Drawing.Size(143, 26);
            this.btn_anadir_orden.TabIndex = 3;
            this.btn_anadir_orden.Text = "Anadir Elemento";
            this.btn_anadir_orden.UseVisualStyleBackColor = true;
            this.btn_anadir_orden.Click += new System.EventHandler(this.btn_anadir_orden_Click);
            // 
            // btn_para_desordenar
            // 
            this.btn_para_desordenar.Location = new System.Drawing.Point(323, 176);
            this.btn_para_desordenar.Name = "btn_para_desordenar";
            this.btn_para_desordenar.Size = new System.Drawing.Size(54, 27);
            this.btn_para_desordenar.TabIndex = 6;
            this.btn_para_desordenar.Text = "<<";
            this.btn_para_desordenar.UseVisualStyleBackColor = true;
            this.btn_para_desordenar.Click += new System.EventHandler(this.btn_para_desordenar_Click);
            // 
            // btn_para_ordenar
            // 
            this.btn_para_ordenar.Location = new System.Drawing.Point(323, 209);
            this.btn_para_ordenar.Name = "btn_para_ordenar";
            this.btn_para_ordenar.Size = new System.Drawing.Size(54, 27);
            this.btn_para_ordenar.TabIndex = 7;
            this.btn_para_ordenar.Text = ">>";
            this.btn_para_ordenar.UseVisualStyleBackColor = true;
            this.btn_para_ordenar.Click += new System.EventHandler(this.btn_para_ordenar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 316);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(425, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(221, 316);
            this.listBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sin Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ordenada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_para_ordenar);
            this.Controls.Add(this.btn_para_desordenar);
            this.Controls.Add(this.btn_borrarlist_orden);
            this.Controls.Add(this.btn_borrar_orden);
            this.Controls.Add(this.btn_anadir_orden);
            this.Controls.Add(this.btn_borrarList_sinorden);
            this.Controls.Add(this.btn_borrrar_sinorden);
            this.Controls.Add(this.btn_anadir_sinorden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anadir_sinorden;
        private System.Windows.Forms.Button btn_borrrar_sinorden;
        private System.Windows.Forms.Button btn_borrarList_sinorden;
        private System.Windows.Forms.Button btn_borrarlist_orden;
        private System.Windows.Forms.Button btn_borrar_orden;
        private System.Windows.Forms.Button btn_anadir_orden;
        private System.Windows.Forms.Button btn_para_desordenar;
        private System.Windows.Forms.Button btn_para_ordenar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

