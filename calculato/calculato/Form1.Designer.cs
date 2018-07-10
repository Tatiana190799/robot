namespace calculato
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.devision = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.conclusion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // devision
            // 
            this.devision.Location = new System.Drawing.Point(204, 98);
            this.devision.Name = "devision";
            this.devision.Size = new System.Drawing.Size(68, 42);
            this.devision.TabIndex = 0;
            this.devision.Text = "/";
            this.devision.UseVisualStyleBackColor = true;
            this.devision.Click += new System.EventHandler(this.button4_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(135, 98);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(63, 42);
            this.multiply.TabIndex = 1;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button4_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(68, 98);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(61, 42);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button4_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(0, 98);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(62, 42);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // conclusion
            // 
            this.conclusion.AutoSize = true;
            this.conclusion.Location = new System.Drawing.Point(237, 16);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(0, 13);
            this.conclusion.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.devision);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button devision;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label conclusion;
    }
}

