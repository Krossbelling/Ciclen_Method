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
            this.ParametrGroupBox = new System.Windows.Forms.GroupBox();
            this.N_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.eps_textbox = new System.Windows.Forms.TextBox();
            this.y0_textbox = new System.Windows.Forms.TextBox();
            this.b_textbox = new System.Windows.Forms.TextBox();
            this.x0_textbox = new System.Windows.Forms.TextBox();
            this.a_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MethodGroupBox = new System.Windows.Forms.GroupBox();
            this.AdamsBox = new System.Windows.Forms.CheckBox();
            this.MilnaBox = new System.Windows.Forms.CheckBox();
            this.Runge_kuttaBox = new System.Windows.Forms.CheckBox();
            this.Euler_recalBox = new System.Windows.Forms.CheckBox();
            this.ChordBox = new System.Windows.Forms.CheckBox();
            this.EulerBox = new System.Windows.Forms.CheckBox();
            this.dif_textbox = new System.Windows.Forms.TextBox();
            this.ParametrGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_numUpDown)).BeginInit();
            this.MethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(455, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дифференциальное уравнение\r\n";
            // 
            // SolveButton
            // 
            this.SolveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SolveButton.FlatAppearance.BorderSize = 0;
            this.SolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.SolveButton.Location = new System.Drawing.Point(527, 365);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(124, 34);
            this.SolveButton.TabIndex = 9;
            this.SolveButton.Text = "Решить";
            this.SolveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SolveButton.UseVisualStyleBackColor = false;
            this.SolveButton.Click += new System.EventHandler(this.Solve_Click);
            // 
            // ParametrGroupBox
            // 
            this.ParametrGroupBox.Controls.Add(this.N_numUpDown);
            this.ParametrGroupBox.Controls.Add(this.eps_textbox);
            this.ParametrGroupBox.Controls.Add(this.y0_textbox);
            this.ParametrGroupBox.Controls.Add(this.b_textbox);
            this.ParametrGroupBox.Controls.Add(this.x0_textbox);
            this.ParametrGroupBox.Controls.Add(this.a_textbox);
            this.ParametrGroupBox.Controls.Add(this.label9);
            this.ParametrGroupBox.Controls.Add(this.label8);
            this.ParametrGroupBox.Controls.Add(this.label7);
            this.ParametrGroupBox.Controls.Add(this.label6);
            this.ParametrGroupBox.Controls.Add(this.label5);
            this.ParametrGroupBox.Controls.Add(this.label4);
            this.ParametrGroupBox.Controls.Add(this.label3);
            this.ParametrGroupBox.Controls.Add(this.label2);
            this.ParametrGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametrGroupBox.Location = new System.Drawing.Point(183, 147);
            this.ParametrGroupBox.Name = "ParametrGroupBox";
            this.ParametrGroupBox.Size = new System.Drawing.Size(319, 170);
            this.ParametrGroupBox.TabIndex = 8;
            this.ParametrGroupBox.TabStop = false;
            this.ParametrGroupBox.Text = "Параметры";
            // 
            // N_numUpDown
            // 
            this.N_numUpDown.Location = new System.Drawing.Point(38, 113);
            this.N_numUpDown.Name = "N_numUpDown";
            this.N_numUpDown.Size = new System.Drawing.Size(83, 26);
            this.N_numUpDown.TabIndex = 2;
            // 
            // eps_textbox
            // 
            this.eps_textbox.Location = new System.Drawing.Point(243, 102);
            this.eps_textbox.Name = "eps_textbox";
            this.eps_textbox.Size = new System.Drawing.Size(29, 26);
            this.eps_textbox.TabIndex = 1;
            this.eps_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // y0_textbox
            // 
            this.y0_textbox.Location = new System.Drawing.Point(213, 72);
            this.y0_textbox.Name = "y0_textbox";
            this.y0_textbox.Size = new System.Drawing.Size(85, 26);
            this.y0_textbox.TabIndex = 1;
            this.y0_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // b_textbox
            // 
            this.b_textbox.Location = new System.Drawing.Point(213, 34);
            this.b_textbox.Name = "b_textbox";
            this.b_textbox.Size = new System.Drawing.Size(85, 26);
            this.b_textbox.TabIndex = 1;
            this.b_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // x0_textbox
            // 
            this.x0_textbox.Location = new System.Drawing.Point(36, 73);
            this.x0_textbox.Name = "x0_textbox";
            this.x0_textbox.Size = new System.Drawing.Size(85, 26);
            this.x0_textbox.TabIndex = 1;
            this.x0_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // a_textbox
            // 
            this.a_textbox.Location = new System.Drawing.Point(36, 36);
            this.a_textbox.Name = "a_textbox";
            this.a_textbox.Size = new System.Drawing.Size(85, 26);
            this.a_textbox.TabIndex = 1;
            this.a_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(232, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(210, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(183, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "E=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(183, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "y0=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(183, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "b=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "N=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "x0=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "a=";
            // 
            // MethodGroupBox
            // 
            this.MethodGroupBox.Controls.Add(this.AdamsBox);
            this.MethodGroupBox.Controls.Add(this.MilnaBox);
            this.MethodGroupBox.Controls.Add(this.Runge_kuttaBox);
            this.MethodGroupBox.Controls.Add(this.Euler_recalBox);
            this.MethodGroupBox.Controls.Add(this.ChordBox);
            this.MethodGroupBox.Controls.Add(this.EulerBox);
            this.MethodGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodGroupBox.Location = new System.Drawing.Point(674, 147);
            this.MethodGroupBox.Name = "MethodGroupBox";
            this.MethodGroupBox.Size = new System.Drawing.Size(234, 170);
            this.MethodGroupBox.TabIndex = 6;
            this.MethodGroupBox.TabStop = false;
            this.MethodGroupBox.Text = "Методы";
            // 
            // AdamsBox
            // 
            this.AdamsBox.AutoSize = true;
            this.AdamsBox.Location = new System.Drawing.Point(19, 141);
            this.AdamsBox.Name = "AdamsBox";
            this.AdamsBox.Size = new System.Drawing.Size(87, 24);
            this.AdamsBox.TabIndex = 0;
            this.AdamsBox.Text = "Адемса";
            this.AdamsBox.UseVisualStyleBackColor = true;
            // 
            // MilnaBox
            // 
            this.MilnaBox.AutoSize = true;
            this.MilnaBox.Location = new System.Drawing.Point(19, 118);
            this.MilnaBox.Name = "MilnaBox";
            this.MilnaBox.Size = new System.Drawing.Size(78, 24);
            this.MilnaBox.TabIndex = 0;
            this.MilnaBox.Text = "Милна";
            this.MilnaBox.UseVisualStyleBackColor = true;
            // 
            // Runge_kuttaBox
            // 
            this.Runge_kuttaBox.AutoSize = true;
            this.Runge_kuttaBox.Location = new System.Drawing.Point(19, 95);
            this.Runge_kuttaBox.Name = "Runge_kuttaBox";
            this.Runge_kuttaBox.Size = new System.Drawing.Size(116, 24);
            this.Runge_kuttaBox.TabIndex = 0;
            this.Runge_kuttaBox.Text = "Рунге кутта";
            this.Runge_kuttaBox.UseVisualStyleBackColor = true;
            // 
            // Euler_recalBox
            // 
            this.Euler_recalBox.AutoSize = true;
            this.Euler_recalBox.Location = new System.Drawing.Point(19, 72);
            this.Euler_recalBox.Name = "Euler_recalBox";
            this.Euler_recalBox.Size = new System.Drawing.Size(193, 24);
            this.Euler_recalBox.TabIndex = 0;
            this.Euler_recalBox.Text = "Эйлера с пересчётом";
            this.Euler_recalBox.UseVisualStyleBackColor = true;
            // 
            // ChordBox
            // 
            this.ChordBox.AutoSize = true;
            this.ChordBox.Location = new System.Drawing.Point(19, 49);
            this.ChordBox.Name = "ChordBox";
            this.ChordBox.Size = new System.Drawing.Size(68, 24);
            this.ChordBox.TabIndex = 0;
            this.ChordBox.Text = "Хорд";
            this.ChordBox.UseVisualStyleBackColor = true;
            // 
            // EulerBox
            // 
            this.EulerBox.AutoSize = true;
            this.EulerBox.Location = new System.Drawing.Point(19, 26);
            this.EulerBox.Name = "EulerBox";
            this.EulerBox.Size = new System.Drawing.Size(86, 24);
            this.EulerBox.TabIndex = 0;
            this.EulerBox.Text = "Эйлера";
            this.EulerBox.UseVisualStyleBackColor = true;
            // 
            // dif_textbox
            // 
            this.dif_textbox.Location = new System.Drawing.Point(400, 96);
            this.dif_textbox.Name = "dif_textbox";
            this.dif_textbox.Size = new System.Drawing.Size(330, 20);
            this.dif_textbox.TabIndex = 7;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.ParametrGroupBox);
            this.Controls.Add(this.MethodGroupBox);
            this.Controls.Add(this.dif_textbox);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(1048, 502);
            this.ParametrGroupBox.ResumeLayout(false);
            this.ParametrGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_numUpDown)).EndInit();
            this.MethodGroupBox.ResumeLayout(false);
            this.MethodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button SolveButton;
        protected internal System.Windows.Forms.GroupBox ParametrGroupBox;
        private System.Windows.Forms.NumericUpDown N_numUpDown;
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
        protected internal System.Windows.Forms.GroupBox MethodGroupBox;
        private System.Windows.Forms.CheckBox AdamsBox;
        private System.Windows.Forms.CheckBox MilnaBox;
        private System.Windows.Forms.CheckBox Runge_kuttaBox;
        private System.Windows.Forms.CheckBox Euler_recalBox;
        private System.Windows.Forms.CheckBox ChordBox;
        private System.Windows.Forms.CheckBox EulerBox;
        protected internal System.Windows.Forms.TextBox dif_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox eps_textbox;
    }
}
