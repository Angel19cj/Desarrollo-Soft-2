namespace StudentGradeAPP
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnNumeric = new System.Windows.Forms.RadioButton();
            this.rbnLetter = new System.Windows.Forms.RadioButton();
            this.lstResutls = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClassAverage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddGrade);
            this.groupBox1.Controls.Add(this.txtTest3);
            this.groupBox1.Controls.Add(this.txtTest2);
            this.groupBox1.Controls.Add(this.txtTest1);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Grades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test 2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test 3: ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(130, 45);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(143, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(179, 81);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(94, 20);
            this.txtTest1.TabIndex = 5;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(179, 118);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(94, 20);
            this.txtTest2.TabIndex = 6;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(179, 158);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(94, 20);
            this.txtTest3.TabIndex = 7;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(89, 208);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 8;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnLetter);
            this.groupBox2.Controls.Add(this.rbnNumeric);
            this.groupBox2.Location = new System.Drawing.Point(12, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // rbnNumeric
            // 
            this.rbnNumeric.AutoSize = true;
            this.rbnNumeric.Checked = true;
            this.rbnNumeric.Location = new System.Drawing.Point(24, 28);
            this.rbnNumeric.Name = "rbnNumeric";
            this.rbnNumeric.Size = new System.Drawing.Size(64, 17);
            this.rbnNumeric.TabIndex = 0;
            this.rbnNumeric.TabStop = true;
            this.rbnNumeric.Text = "Numeric";
            this.rbnNumeric.UseVisualStyleBackColor = true;
            this.rbnNumeric.CheckedChanged += new System.EventHandler(this.rbnNumeric_CheckedChanged);
            // 
            // rbnLetter
            // 
            this.rbnLetter.AutoSize = true;
            this.rbnLetter.Location = new System.Drawing.Point(188, 28);
            this.rbnLetter.Name = "rbnLetter";
            this.rbnLetter.Size = new System.Drawing.Size(52, 17);
            this.rbnLetter.TabIndex = 1;
            this.rbnLetter.Text = "Letter";
            this.rbnLetter.UseVisualStyleBackColor = true;
            this.rbnLetter.CheckedChanged += new System.EventHandler(this.rbnLetter_CheckedChanged);
            // 
            // lstResutls
            // 
            this.lstResutls.FormattingEnabled = true;
            this.lstResutls.Location = new System.Drawing.Point(325, 12);
            this.lstResutls.Name = "lstResutls";
            this.lstResutls.Size = new System.Drawing.Size(252, 329);
            this.lstResutls.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class Average: ";
            // 
            // lblClassAverage
            // 
            this.lblClassAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassAverage.Location = new System.Drawing.Point(412, 348);
            this.lblClassAverage.Name = "lblClassAverage";
            this.lblClassAverage.Size = new System.Drawing.Size(165, 23);
            this.lblClassAverage.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 419);
            this.Controls.Add(this.lblClassAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstResutls);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Student Grade APP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnLetter;
        private System.Windows.Forms.RadioButton rbnNumeric;
        private System.Windows.Forms.ListBox lstResutls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClassAverage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

