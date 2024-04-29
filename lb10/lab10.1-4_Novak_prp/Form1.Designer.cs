
namespace lab10._1_4_Novak_prp
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
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.txtDX = new System.Windows.Forms.TextBox();
            this.txtZMin = new System.Windows.Forms.TextBox();
            this.txtZMax = new System.Windows.Forms.TextBox();
            this.txtDZ = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSumOfNegatives = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXMin
            // 
            this.txtXMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtXMin.Location = new System.Drawing.Point(79, 46);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(60, 23);
            this.txtXMin.TabIndex = 0;
            // 
            // txtXMax
            // 
            this.txtXMax.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtXMax.Location = new System.Drawing.Point(194, 46);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(56, 23);
            this.txtXMax.TabIndex = 1;
            // 
            // txtDX
            // 
            this.txtDX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDX.Location = new System.Drawing.Point(289, 46);
            this.txtDX.Name = "txtDX";
            this.txtDX.Size = new System.Drawing.Size(63, 23);
            this.txtDX.TabIndex = 2;
            // 
            // txtZMin
            // 
            this.txtZMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtZMin.Location = new System.Drawing.Point(79, 111);
            this.txtZMin.Name = "txtZMin";
            this.txtZMin.Size = new System.Drawing.Size(60, 23);
            this.txtZMin.TabIndex = 3;
            // 
            // txtZMax
            // 
            this.txtZMax.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtZMax.Location = new System.Drawing.Point(194, 111);
            this.txtZMax.Name = "txtZMax";
            this.txtZMax.Size = new System.Drawing.Size(56, 23);
            this.txtZMax.TabIndex = 4;
            // 
            // txtDZ
            // 
            this.txtDZ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDZ.Location = new System.Drawing.Point(289, 111);
            this.txtDZ.Name = "txtDZ";
            this.txtDZ.Size = new System.Drawing.Size(63, 23);
            this.txtDZ.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(395, 161);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(395, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "X1min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(145, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "X1max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(256, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "dX1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(32, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "X2min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "X2max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "dX2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 377);
            this.dataGridView1.TabIndex = 15;
            // 
            // lblSumOfNegatives
            // 
            this.lblSumOfNegatives.AutoSize = true;
            this.lblSumOfNegatives.Location = new System.Drawing.Point(32, 554);
            this.lblSumOfNegatives.Name = "lblSumOfNegatives";
            this.lblSumOfNegatives.Size = new System.Drawing.Size(58, 15);
            this.lblSumOfNegatives.TabIndex = 16;
            this.lblSumOfNegatives.Text = "Завдання";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(531, 588);
            this.Controls.Add(this.lblSumOfNegatives);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDZ);
            this.Controls.Add(this.txtZMax);
            this.Controls.Add(this.txtZMin);
            this.Controls.Add(this.txtDX);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.txtXMin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.TextBox txtDX;
        private System.Windows.Forms.TextBox txtZMin;
        private System.Windows.Forms.TextBox txtZMax;
        private System.Windows.Forms.TextBox txtDZ;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSumOfNegatives;
    }
}

