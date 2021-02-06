namespace Ciclen_Method
{
    partial class InputControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SolveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.N_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.eps_textbox = new System.Windows.Forms.TextBox();
            this.y0_textbox = new System.Windows.Forms.TextBox();
            this.b_textbox = new System.Windows.Forms.TextBox();
            this.x0_textbox = new System.Windows.Forms.TextBox();
            this.a_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.ChordBox = new System.Windows.Forms.CheckBox();
            this.EulerBox = new System.Windows.Forms.CheckBox();
            this.dif_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_numUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дифференциальное уравнение\r\n";
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(685, 306);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(75, 23);
            this.SolveButton.TabIndex = 9;
            this.SolveButton.Text = "Решить";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.Solve_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.N_numUpDown);
            this.groupBox2.Controls.Add(this.eps_textbox);
            this.groupBox2.Controls.Add(this.y0_textbox);
            this.groupBox2.Controls.Add(this.b_textbox);
            this.groupBox2.Controls.Add(this.x0_textbox);
            this.groupBox2.Controls.Add(this.a_textbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(131, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 136);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // N_numUpDown
            // 
            this.N_numUpDown.Location = new System.Drawing.Point(37, 106);
            this.N_numUpDown.Name = "N_numUpDown";
            this.N_numUpDown.Size = new System.Drawing.Size(83, 22);
            this.N_numUpDown.TabIndex = 2;
            // 
            // eps_textbox
            // 
            this.eps_textbox.Location = new System.Drawing.Point(212, 106);
            this.eps_textbox.Name = "eps_textbox";
            this.eps_textbox.Size = new System.Drawing.Size(85, 22);
            this.eps_textbox.TabIndex = 1;
            this.eps_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // y0_textbox
            // 
            this.y0_textbox.Location = new System.Drawing.Point(212, 65);
            this.y0_textbox.Name = "y0_textbox";
            this.y0_textbox.Size = new System.Drawing.Size(85, 22);
            this.y0_textbox.TabIndex = 1;
            this.y0_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // b_textbox
            // 
            this.b_textbox.Location = new System.Drawing.Point(212, 27);
            this.b_textbox.Name = "b_textbox";
            this.b_textbox.Size = new System.Drawing.Size(85, 22);
            this.b_textbox.TabIndex = 1;
            this.b_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // x0_textbox
            // 
            this.x0_textbox.Location = new System.Drawing.Point(35, 66);
            this.x0_textbox.Name = "x0_textbox";
            this.x0_textbox.Size = new System.Drawing.Size(85, 22);
            this.x0_textbox.TabIndex = 1;
            this.x0_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // a_textbox
            // 
            this.a_textbox.Location = new System.Drawing.Point(35, 29);
            this.a_textbox.Name = "a_textbox";
            this.a_textbox.Size = new System.Drawing.Size(85, 22);
            this.a_textbox.TabIndex = 1;
            this.a_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(182, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "E=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(182, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "y0=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(182, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "b=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "N=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "x0=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "a=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.ChordBox);
            this.groupBox1.Controls.Add(this.EulerBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(526, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Методы";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 141);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(76, 20);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Адемса";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 118);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 20);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Милна";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(19, 95);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 20);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Рунге кутта";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(169, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Эйлера с пересчётом";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // ChordBox
            // 
            this.ChordBox.AutoSize = true;
            this.ChordBox.Location = new System.Drawing.Point(19, 49);
            this.ChordBox.Name = "ChordBox";
            this.ChordBox.Size = new System.Drawing.Size(59, 20);
            this.ChordBox.TabIndex = 0;
            this.ChordBox.Text = "Хорд";
            this.ChordBox.UseVisualStyleBackColor = true;
            // 
            // EulerBox
            // 
            this.EulerBox.AutoSize = true;
            this.EulerBox.Location = new System.Drawing.Point(19, 26);
            this.EulerBox.Name = "EulerBox";
            this.EulerBox.Size = new System.Drawing.Size(77, 20);
            this.EulerBox.TabIndex = 0;
            this.EulerBox.Text = "Эйлера";
            this.EulerBox.UseVisualStyleBackColor = true;
            // 
            // dif_textbox
            // 
            this.dif_textbox.Location = new System.Drawing.Point(131, 117);
            this.dif_textbox.Name = "dif_textbox";
            this.dif_textbox.Size = new System.Drawing.Size(234, 20);
            this.dif_textbox.TabIndex = 7;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dif_textbox);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(1058, 512);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_numUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button SolveButton;
        protected internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown N_numUpDown;
        private System.Windows.Forms.TextBox eps_textbox;
        private System.Windows.Forms.TextBox y0_textbox;
        private System.Windows.Forms.TextBox b_textbox;
        private System.Windows.Forms.TextBox x0_textbox;
        private System.Windows.Forms.TextBox a_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox ChordBox;
        private System.Windows.Forms.CheckBox EulerBox;
        protected internal System.Windows.Forms.TextBox dif_textbox;
    }
}
