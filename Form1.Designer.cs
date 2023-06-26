namespace ExpressionCalculator
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
            this.Calculate = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.expressionTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(39, 274);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(337, 274);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // substract
            // 
            this.substract.Location = new System.Drawing.Point(639, 274);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(75, 23);
            this.substract.TabIndex = 2;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = true;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(39, 356);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(337, 356);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(639, 356);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Location = new System.Drawing.Point(188, 149);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(100, 22);
            this.expressionTextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(530, 149);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 22);
            this.resultLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "result";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(198, 50);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(75, 23);
            this.img.TabIndex = 10;
            this.img.Text = "img";
            this.img.UseVisualStyleBackColor = true;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(542, 50);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(75, 23);
            this.txt.TabIndex = 11;
            this.txt.Text = "txt";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.expressionTextBox);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox expressionTextBox;
        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button img;
        private System.Windows.Forms.Button txt;
    }
}

