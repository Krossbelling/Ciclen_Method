namespace Ciclen_Method
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.ItterBox = new System.Windows.Forms.CheckBox();
            this.PanelDesktop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ParametrGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_numUpDown)).BeginInit();
            this.MethodGroupBox.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.Goldenrod;
            this.PanelDesktop.Controls.Add(this.groupBox1);
            this.PanelDesktop.Controls.Add(this.label1);
            this.PanelDesktop.Controls.Add(this.SolveButton);
            this.PanelDesktop.Controls.Add(this.ParametrGroupBox);
            this.PanelDesktop.Controls.Add(this.MethodGroupBox);
            this.PanelDesktop.Controls.Add(this.dif_textbox);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 51);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(1150, 569);
            this.PanelDesktop.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(674, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 161);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функции для ввода";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 126);
            this.label10.TabIndex = 16;
            this.label10.Text = "pi - Значение величины Pi\r\nsin(x) - Синус x\r\nexp(x) - Экспонента в степени x \r\nab" +
    "s(x) - Модуль x \r\nsqrt(x) - Квадратный корень из х \r\npow(x,y) - Возвести x в сте" +
    "пень y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дифференциальное уравнение\r\n";
            // 
            // SolveButton
            // 
            this.SolveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SolveButton.FlatAppearance.BorderSize = 0;
            this.SolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.SolveButton.Location = new System.Drawing.Point(814, 458);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(124, 34);
            this.SolveButton.TabIndex = 15;
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
            this.ParametrGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametrGroupBox.Location = new System.Drawing.Point(237, 228);
            this.ParametrGroupBox.Name = "ParametrGroupBox";
            this.ParametrGroupBox.Size = new System.Drawing.Size(319, 196);
            this.ParametrGroupBox.TabIndex = 14;
            this.ParametrGroupBox.TabStop = false;
            this.ParametrGroupBox.Text = "Параметры";
            // 
            // N_numUpDown
            // 
            this.N_numUpDown.BackColor = System.Drawing.Color.Wheat;
            this.N_numUpDown.Location = new System.Drawing.Point(38, 113);
            this.N_numUpDown.Name = "N_numUpDown";
            this.N_numUpDown.Size = new System.Drawing.Size(83, 29);
            this.N_numUpDown.TabIndex = 2;
            // 
            // eps_textbox
            // 
            this.eps_textbox.BackColor = System.Drawing.Color.Wheat;
            this.eps_textbox.Location = new System.Drawing.Point(243, 103);
            this.eps_textbox.Name = "eps_textbox";
            this.eps_textbox.Size = new System.Drawing.Size(29, 29);
            this.eps_textbox.TabIndex = 1;
            this.eps_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // y0_textbox
            // 
            this.y0_textbox.BackColor = System.Drawing.Color.Wheat;
            this.y0_textbox.Location = new System.Drawing.Point(213, 72);
            this.y0_textbox.Name = "y0_textbox";
            this.y0_textbox.Size = new System.Drawing.Size(85, 29);
            this.y0_textbox.TabIndex = 1;
            this.y0_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // b_textbox
            // 
            this.b_textbox.BackColor = System.Drawing.Color.Wheat;
            this.b_textbox.Location = new System.Drawing.Point(213, 34);
            this.b_textbox.Name = "b_textbox";
            this.b_textbox.Size = new System.Drawing.Size(85, 29);
            this.b_textbox.TabIndex = 1;
            this.b_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // x0_textbox
            // 
            this.x0_textbox.BackColor = System.Drawing.Color.Wheat;
            this.x0_textbox.Location = new System.Drawing.Point(36, 73);
            this.x0_textbox.Name = "x0_textbox";
            this.x0_textbox.Size = new System.Drawing.Size(85, 29);
            this.x0_textbox.TabIndex = 1;
            this.x0_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // a_textbox
            // 
            this.a_textbox.BackColor = System.Drawing.Color.Wheat;
            this.a_textbox.Location = new System.Drawing.Point(36, 36);
            this.a_textbox.Name = "a_textbox";
            this.a_textbox.Size = new System.Drawing.Size(85, 29);
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
            this.label9.Location = new System.Drawing.Point(231, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(209, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(183, 115);
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
            this.MethodGroupBox.Controls.Add(this.ItterBox);
            this.MethodGroupBox.Controls.Add(this.Runge_kuttaBox);
            this.MethodGroupBox.Controls.Add(this.Euler_recalBox);
            this.MethodGroupBox.Controls.Add(this.ChordBox);
            this.MethodGroupBox.Controls.Add(this.EulerBox);
            this.MethodGroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodGroupBox.Location = new System.Drawing.Point(674, 228);
            this.MethodGroupBox.Name = "MethodGroupBox";
            this.MethodGroupBox.Size = new System.Drawing.Size(334, 196);
            this.MethodGroupBox.TabIndex = 12;
            this.MethodGroupBox.TabStop = false;
            this.MethodGroupBox.Text = "Методы";
            // 
            // AdamsBox
            // 
            this.AdamsBox.AutoSize = true;
            this.AdamsBox.Location = new System.Drawing.Point(19, 165);
            this.AdamsBox.Name = "AdamsBox";
            this.AdamsBox.Size = new System.Drawing.Size(89, 25);
            this.AdamsBox.TabIndex = 0;
            this.AdamsBox.Text = "Адемса";
            this.AdamsBox.UseVisualStyleBackColor = true;
            // 
            // MilnaBox
            // 
            this.MilnaBox.AutoSize = true;
            this.MilnaBox.Location = new System.Drawing.Point(19, 143);
            this.MilnaBox.Name = "MilnaBox";
            this.MilnaBox.Size = new System.Drawing.Size(82, 25);
            this.MilnaBox.TabIndex = 0;
            this.MilnaBox.Text = "Милна";
            this.MilnaBox.UseVisualStyleBackColor = true;
            // 
            // Runge_kuttaBox
            // 
            this.Runge_kuttaBox.AutoSize = true;
            this.Runge_kuttaBox.Location = new System.Drawing.Point(19, 121);
            this.Runge_kuttaBox.Name = "Runge_kuttaBox";
            this.Runge_kuttaBox.Size = new System.Drawing.Size(122, 25);
            this.Runge_kuttaBox.TabIndex = 0;
            this.Runge_kuttaBox.Text = "Рунге кутта";
            this.Runge_kuttaBox.UseVisualStyleBackColor = true;
            // 
            // Euler_recalBox
            // 
            this.Euler_recalBox.AutoSize = true;
            this.Euler_recalBox.Location = new System.Drawing.Point(19, 72);
            this.Euler_recalBox.Name = "Euler_recalBox";
            this.Euler_recalBox.Size = new System.Drawing.Size(199, 25);
            this.Euler_recalBox.TabIndex = 0;
            this.Euler_recalBox.Text = "Эйлера с пересчётом";
            this.Euler_recalBox.UseVisualStyleBackColor = true;
            // 
            // ChordBox
            // 
            this.ChordBox.AutoSize = true;
            this.ChordBox.Location = new System.Drawing.Point(19, 49);
            this.ChordBox.Name = "ChordBox";
            this.ChordBox.Size = new System.Drawing.Size(71, 25);
            this.ChordBox.TabIndex = 0;
            this.ChordBox.Text = "Хорд";
            this.ChordBox.UseVisualStyleBackColor = true;
            // 
            // EulerBox
            // 
            this.EulerBox.AutoSize = true;
            this.EulerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EulerBox.Location = new System.Drawing.Point(19, 26);
            this.EulerBox.Name = "EulerBox";
            this.EulerBox.Size = new System.Drawing.Size(87, 25);
            this.EulerBox.TabIndex = 0;
            this.EulerBox.Text = "Эйлера";
            this.EulerBox.UseVisualStyleBackColor = true;
            // 
            // dif_textbox
            // 
            this.dif_textbox.BackColor = System.Drawing.Color.Wheat;
            this.dif_textbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dif_textbox.Location = new System.Drawing.Point(237, 123);
            this.dif_textbox.Name = "dif_textbox";
            this.dif_textbox.Size = new System.Drawing.Size(330, 29);
            this.dif_textbox.TabIndex = 13;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitleBar.Controls.Add(this.BackButton);
            this.panelTitleBar.Controls.Add(this.Out);
            this.panelTitleBar.Controls.Add(this.Title_label);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1150, 51);
            this.panelTitleBar.TabIndex = 6;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(42, 54);
            this.BackButton.TabIndex = 17;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.Color.Transparent;
            this.Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Out.BackgroundImage")));
            this.Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Out.Cursor = System.Windows.Forms.Cursors.Default;
            this.Out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Out.Location = new System.Drawing.Point(1124, 0);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(27, 20);
            this.Out.TabIndex = 1;
            this.Out.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(326, 12);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(544, 26);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "РЕШЕНИЕ ДИФФЕРЕНЦИАЛЬНОГО УРАВНЕНИЯ";
            this.Title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // ItterBox
            // 
            this.ItterBox.AutoSize = true;
            this.ItterBox.Location = new System.Drawing.Point(19, 96);
            this.ItterBox.Name = "ItterBox";
            this.ItterBox.Size = new System.Drawing.Size(260, 25);
            this.ItterBox.TabIndex = 0;
            this.ItterBox.Text = "С итерационной обработкой";
            this.ItterBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 620);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение дифференциального уравнения";
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ParametrGroupBox.ResumeLayout(false);
            this.ParametrGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_numUpDown)).EndInit();
            this.MethodGroupBox.ResumeLayout(false);
            this.MethodGroupBox.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button SolveButton;
        protected internal System.Windows.Forms.GroupBox ParametrGroupBox;
        private System.Windows.Forms.NumericUpDown N_numUpDown;
        public System.Windows.Forms.TextBox eps_textbox;
        private System.Windows.Forms.TextBox y0_textbox;
        private System.Windows.Forms.TextBox b_textbox;
        private System.Windows.Forms.TextBox x0_textbox;
        private System.Windows.Forms.TextBox a_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
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
        protected internal System.Windows.Forms.TextBox dif_textbox;
        protected internal System.Windows.Forms.CheckBox EulerBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ItterBox;
    }
}

