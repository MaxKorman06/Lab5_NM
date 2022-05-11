
namespace Lab5_NM
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
            this.button_clear = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_LX0 = new System.Windows.Forms.TextBox();
            this.textBox_LY0 = new System.Windows.Forms.TextBox();
            this.textBox_LY1 = new System.Windows.Forms.TextBox();
            this.textBox_LX1 = new System.Windows.Forms.TextBox();
            this.textBox_LY4 = new System.Windows.Forms.TextBox();
            this.textBox_LX4 = new System.Windows.Forms.TextBox();
            this.textBox_LY3 = new System.Windows.Forms.TextBox();
            this.textBox_LX3 = new System.Windows.Forms.TextBox();
            this.textBox_LY2 = new System.Windows.Forms.TextBox();
            this.textBox_LX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_fin = new System.Windows.Forms.TextBox();
            this.button_swap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(168, 340);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(66, 66);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "AC";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.UseWaitCursor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calculate.Location = new System.Drawing.Point(12, 340);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(150, 30);
            this.button_calculate.TabIndex = 15;
            this.button_calculate.Text = "Обчислити";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.UseWaitCursor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(12, 376);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 30);
            this.button_exit.TabIndex = 14;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.UseWaitCursor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(344, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Інтерполяційний поліном Лагранжа ";
            this.label6.UseWaitCursor = true;
            // 
            // textBox_LX0
            // 
            this.textBox_LX0.Location = new System.Drawing.Point(39, 155);
            this.textBox_LX0.Name = "textBox_LX0";
            this.textBox_LX0.Size = new System.Drawing.Size(45, 20);
            this.textBox_LX0.TabIndex = 50;
            this.textBox_LX0.Text = "4,5";
            this.textBox_LX0.UseWaitCursor = true;
            // 
            // textBox_LY0
            // 
            this.textBox_LY0.Location = new System.Drawing.Point(39, 181);
            this.textBox_LY0.Name = "textBox_LY0";
            this.textBox_LY0.Size = new System.Drawing.Size(45, 20);
            this.textBox_LY0.TabIndex = 51;
            this.textBox_LY0.Text = "12,9";
            this.textBox_LY0.UseWaitCursor = true;
            // 
            // textBox_LY1
            // 
            this.textBox_LY1.Location = new System.Drawing.Point(90, 181);
            this.textBox_LY1.Name = "textBox_LY1";
            this.textBox_LY1.Size = new System.Drawing.Size(45, 20);
            this.textBox_LY1.TabIndex = 53;
            this.textBox_LY1.Text = "13,7";
            this.textBox_LY1.UseWaitCursor = true;
            // 
            // textBox_LX1
            // 
            this.textBox_LX1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_LX1.Location = new System.Drawing.Point(90, 155);
            this.textBox_LX1.Name = "textBox_LX1";
            this.textBox_LX1.Size = new System.Drawing.Size(45, 20);
            this.textBox_LX1.TabIndex = 52;
            this.textBox_LX1.Text = "5,6";
            this.textBox_LX1.UseWaitCursor = true;
            // 
            // textBox_LY4
            // 
            this.textBox_LY4.Location = new System.Drawing.Point(243, 181);
            this.textBox_LY4.Name = "textBox_LY4";
            this.textBox_LY4.Size = new System.Drawing.Size(45, 20);
            this.textBox_LY4.TabIndex = 55;
            this.textBox_LY4.Text = "14,5";
            this.textBox_LY4.UseWaitCursor = true;
            // 
            // textBox_LX4
            // 
            this.textBox_LX4.Location = new System.Drawing.Point(243, 155);
            this.textBox_LX4.Name = "textBox_LX4";
            this.textBox_LX4.Size = new System.Drawing.Size(45, 20);
            this.textBox_LX4.TabIndex = 54;
            this.textBox_LX4.Text = "8,9";
            this.textBox_LX4.UseWaitCursor = true;
            // 
            // textBox_LY3
            // 
            this.textBox_LY3.Location = new System.Drawing.Point(192, 181);
            this.textBox_LY3.Name = "textBox_LY3";
            this.textBox_LY3.Size = new System.Drawing.Size(45, 20);
            this.textBox_LY3.TabIndex = 61;
            this.textBox_LY3.Text = "11,3";
            this.textBox_LY3.UseWaitCursor = true;
            // 
            // textBox_LX3
            // 
            this.textBox_LX3.Location = new System.Drawing.Point(192, 155);
            this.textBox_LX3.Name = "textBox_LX3";
            this.textBox_LX3.Size = new System.Drawing.Size(45, 20);
            this.textBox_LX3.TabIndex = 60;
            this.textBox_LX3.Text = "7,8";
            this.textBox_LX3.UseWaitCursor = true;
            // 
            // textBox_LY2
            // 
            this.textBox_LY2.Location = new System.Drawing.Point(141, 181);
            this.textBox_LY2.Name = "textBox_LY2";
            this.textBox_LY2.Size = new System.Drawing.Size(45, 20);
            this.textBox_LY2.TabIndex = 59;
            this.textBox_LY2.Text = "9,3";
            this.textBox_LY2.UseWaitCursor = true;
            // 
            // textBox_LX2
            // 
            this.textBox_LX2.Location = new System.Drawing.Point(141, 155);
            this.textBox_LX2.Name = "textBox_LX2";
            this.textBox_LX2.Size = new System.Drawing.Size(45, 20);
            this.textBox_LX2.TabIndex = 58;
            this.textBox_LX2.Text = "6,7";
            this.textBox_LX2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "X";
            this.label1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Y";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "X = ";
            this.label4.UseWaitCursor = true;
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(55, 129);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(45, 20);
            this.textBox_X.TabIndex = 66;
            this.textBox_X.Text = "5,67";
            this.textBox_X.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(344, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Розвязок";
            this.label5.UseWaitCursor = true;
            // 
            // textBox_fin
            // 
            this.textBox_fin.AcceptsTab = true;
            this.textBox_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fin.Location = new System.Drawing.Point(348, 155);
            this.textBox_fin.Multiline = true;
            this.textBox_fin.Name = "textBox_fin";
            this.textBox_fin.ReadOnly = true;
            this.textBox_fin.Size = new System.Drawing.Size(614, 287);
            this.textBox_fin.TabIndex = 68;
            this.textBox_fin.UseWaitCursor = true;
            // 
            // button_swap
            // 
            this.button_swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_swap.Location = new System.Drawing.Point(12, 412);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(225, 30);
            this.button_swap.TabIndex = 69;
            this.button_swap.Text = "Завдання 2";
            this.button_swap.UseVisualStyleBackColor = true;
            this.button_swap.UseWaitCursor = true;
            this.button_swap.Click += new System.EventHandler(this.button_swap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 606);
            this.Controls.Add(this.button_swap);
            this.Controls.Add(this.textBox_fin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_LY3);
            this.Controls.Add(this.textBox_LX3);
            this.Controls.Add(this.textBox_LY2);
            this.Controls.Add(this.textBox_LX2);
            this.Controls.Add(this.textBox_LY4);
            this.Controls.Add(this.textBox_LX4);
            this.Controls.Add(this.textBox_LY1);
            this.Controls.Add(this.textBox_LX1);
            this.Controls.Add(this.textBox_LY0);
            this.Controls.Add(this.textBox_LX0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_LX0;
        private System.Windows.Forms.TextBox textBox_LY0;
        private System.Windows.Forms.TextBox textBox_LY1;
        private System.Windows.Forms.TextBox textBox_LX1;
        private System.Windows.Forms.TextBox textBox_LY4;
        private System.Windows.Forms.TextBox textBox_LX4;
        private System.Windows.Forms.TextBox textBox_LY3;
        private System.Windows.Forms.TextBox textBox_LX3;
        private System.Windows.Forms.TextBox textBox_LY2;
        private System.Windows.Forms.TextBox textBox_LX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_fin;
        private System.Windows.Forms.Button button_swap;
    }
}

