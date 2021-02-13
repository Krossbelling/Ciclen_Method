﻿namespace Ciclen_Method.Forms
{
    partial class ResultMainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.AdamsButton = new FontAwesome.Sharp.IconButton();
            this.MilnaButton = new FontAwesome.Sharp.IconButton();
            this.Runge_kuttaButton = new FontAwesome.Sharp.IconButton();
            this.Euler_recalButton = new FontAwesome.Sharp.IconButton();
            this.ChordButton = new FontAwesome.Sharp.IconButton();
            this.EulerButton = new FontAwesome.Sharp.IconButton();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMenu.SuspendLayout();
            this.PanelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelMenu.Controls.Add(this.iconButton7);
            this.PanelMenu.Controls.Add(this.AdamsButton);
            this.PanelMenu.Controls.Add(this.MilnaButton);
            this.PanelMenu.Controls.Add(this.Runge_kuttaButton);
            this.PanelMenu.Controls.Add(this.Euler_recalButton);
            this.PanelMenu.Controls.Add(this.ChordButton);
            this.PanelMenu.Controls.Add(this.EulerButton);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1131, 55);
            this.PanelMenu.TabIndex = 0;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.iconButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton7.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton7.FlatAppearance.BorderSize = 2;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton7.ForeColor = System.Drawing.Color.Black;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.iconButton7.IconSize = 40;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(970, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(161, 55);
            this.iconButton7.TabIndex = 19;
            this.iconButton7.Text = "Все графики";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // AdamsButton
            // 
            this.AdamsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.AdamsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdamsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdamsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdamsButton.FlatAppearance.BorderSize = 2;
            this.AdamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdamsButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdamsButton.ForeColor = System.Drawing.Color.Black;
            this.AdamsButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.AdamsButton.IconColor = System.Drawing.Color.Black;
            this.AdamsButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.AdamsButton.IconSize = 40;
            this.AdamsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdamsButton.Location = new System.Drawing.Point(810, 0);
            this.AdamsButton.Name = "AdamsButton";
            this.AdamsButton.Size = new System.Drawing.Size(160, 55);
            this.AdamsButton.TabIndex = 18;
            this.AdamsButton.Text = "Метод Адемса";
            this.AdamsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdamsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdamsButton.UseVisualStyleBackColor = false;
            this.AdamsButton.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // MilnaButton
            // 
            this.MilnaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.MilnaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MilnaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MilnaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MilnaButton.FlatAppearance.BorderSize = 2;
            this.MilnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MilnaButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MilnaButton.ForeColor = System.Drawing.Color.Black;
            this.MilnaButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.MilnaButton.IconColor = System.Drawing.Color.Black;
            this.MilnaButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.MilnaButton.IconSize = 40;
            this.MilnaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MilnaButton.Location = new System.Drawing.Point(648, 0);
            this.MilnaButton.Name = "MilnaButton";
            this.MilnaButton.Size = new System.Drawing.Size(162, 55);
            this.MilnaButton.TabIndex = 17;
            this.MilnaButton.Text = "Метод Милна";
            this.MilnaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MilnaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MilnaButton.UseVisualStyleBackColor = false;
            this.MilnaButton.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // Runge_kuttaButton
            // 
            this.Runge_kuttaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.Runge_kuttaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Runge_kuttaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Runge_kuttaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.Runge_kuttaButton.FlatAppearance.BorderSize = 2;
            this.Runge_kuttaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Runge_kuttaButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Runge_kuttaButton.ForeColor = System.Drawing.Color.Black;
            this.Runge_kuttaButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.Runge_kuttaButton.IconColor = System.Drawing.Color.Black;
            this.Runge_kuttaButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.Runge_kuttaButton.IconSize = 40;
            this.Runge_kuttaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Runge_kuttaButton.Location = new System.Drawing.Point(486, 0);
            this.Runge_kuttaButton.Name = "Runge_kuttaButton";
            this.Runge_kuttaButton.Size = new System.Drawing.Size(162, 55);
            this.Runge_kuttaButton.TabIndex = 16;
            this.Runge_kuttaButton.Text = "Метод Рунге кутта";
            this.Runge_kuttaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Runge_kuttaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Runge_kuttaButton.UseVisualStyleBackColor = false;
            this.Runge_kuttaButton.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // Euler_recalButton
            // 
            this.Euler_recalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.Euler_recalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Euler_recalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Euler_recalButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.Euler_recalButton.FlatAppearance.BorderSize = 2;
            this.Euler_recalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Euler_recalButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Euler_recalButton.ForeColor = System.Drawing.Color.Black;
            this.Euler_recalButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.Euler_recalButton.IconColor = System.Drawing.Color.Black;
            this.Euler_recalButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.Euler_recalButton.IconSize = 40;
            this.Euler_recalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Euler_recalButton.Location = new System.Drawing.Point(324, 0);
            this.Euler_recalButton.Name = "Euler_recalButton";
            this.Euler_recalButton.Size = new System.Drawing.Size(162, 55);
            this.Euler_recalButton.TabIndex = 15;
            this.Euler_recalButton.Text = "Метод Эйлера с пересчётом";
            this.Euler_recalButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Euler_recalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Euler_recalButton.UseVisualStyleBackColor = false;
            this.Euler_recalButton.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ChordButton
            // 
            this.ChordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.ChordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChordButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChordButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChordButton.FlatAppearance.BorderSize = 2;
            this.ChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChordButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChordButton.ForeColor = System.Drawing.Color.Black;
            this.ChordButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.ChordButton.IconColor = System.Drawing.Color.Black;
            this.ChordButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.ChordButton.IconSize = 40;
            this.ChordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChordButton.Location = new System.Drawing.Point(162, 0);
            this.ChordButton.Name = "ChordButton";
            this.ChordButton.Size = new System.Drawing.Size(162, 55);
            this.ChordButton.TabIndex = 14;
            this.ChordButton.Text = "Метод Хорд";
            this.ChordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChordButton.UseVisualStyleBackColor = false;
            this.ChordButton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // EulerButton
            // 
            this.EulerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.EulerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EulerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EulerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EulerButton.FlatAppearance.BorderSize = 2;
            this.EulerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EulerButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EulerButton.ForeColor = System.Drawing.Color.Black;
            this.EulerButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.EulerButton.IconColor = System.Drawing.Color.Black;
            this.EulerButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.EulerButton.IconSize = 40;
            this.EulerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EulerButton.Location = new System.Drawing.Point(0, 0);
            this.EulerButton.Name = "EulerButton";
            this.EulerButton.Size = new System.Drawing.Size(162, 55);
            this.EulerButton.TabIndex = 13;
            this.EulerButton.Text = "Метод Эйлера";
            this.EulerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EulerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EulerButton.UseVisualStyleBackColor = false;
            this.EulerButton.Click += new System.EventHandler(this.EulerButton_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PanelResult.Controls.Add(this.Chart);
            this.PanelResult.Controls.Add(this.dataGridView1);
            this.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelResult.Location = new System.Drawing.Point(0, 55);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(1131, 491);
            this.PanelResult.TabIndex = 1;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Wheat;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Location = new System.Drawing.Point(452, 74);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(620, 343);
            this.Chart.TabIndex = 16;
            this.Chart.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            this.Chart.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.X,
            this.Y});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(59, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(263, 343);
            this.dataGridView1.TabIndex = 15;
            // 
            // i
            // 
            this.i.Frozen = true;
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            this.i.Width = 50;
            // 
            // X
            // 
            this.X.Frozen = true;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 85;
            // 
            // Y
            // 
            this.Y.Frozen = true;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 85;
            // 
            // ResultMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 546);
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultMainForm";
            this.PanelMenu.ResumeLayout(false);
            this.PanelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelResult;
        private FontAwesome.Sharp.IconButton EulerButton;
        private FontAwesome.Sharp.IconButton AdamsButton;
        private FontAwesome.Sharp.IconButton MilnaButton;
        private FontAwesome.Sharp.IconButton Runge_kuttaButton;
        private FontAwesome.Sharp.IconButton Euler_recalButton;
        private FontAwesome.Sharp.IconButton ChordButton;
        private FontAwesome.Sharp.IconButton iconButton7;
        protected internal System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}