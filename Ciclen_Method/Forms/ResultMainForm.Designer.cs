namespace Ciclen_Method.Forms
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
            this.AllChartButton = new FontAwesome.Sharp.IconButton();
            this.AdemsButton = new FontAwesome.Sharp.IconButton();
            this.MilnaButton = new FontAwesome.Sharp.IconButton();
            this.Runge_kuttaButton = new FontAwesome.Sharp.IconButton();
            this.IterButton = new FontAwesome.Sharp.IconButton();
            this.Euler_recalButton = new FontAwesome.Sharp.IconButton();
            this.ChordButton = new FontAwesome.Sharp.IconButton();
            this.EulerButton = new FontAwesome.Sharp.IconButton();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.MessageSelectLabel = new System.Windows.Forms.Label();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelMenu.SuspendLayout();
            this.PanelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelMenu.Controls.Add(this.AllChartButton);
            this.PanelMenu.Controls.Add(this.AdemsButton);
            this.PanelMenu.Controls.Add(this.MilnaButton);
            this.PanelMenu.Controls.Add(this.Runge_kuttaButton);
            this.PanelMenu.Controls.Add(this.IterButton);
            this.PanelMenu.Controls.Add(this.Euler_recalButton);
            this.PanelMenu.Controls.Add(this.ChordButton);
            this.PanelMenu.Controls.Add(this.EulerButton);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1151, 64);
            this.PanelMenu.TabIndex = 0;
            // 
            // AllChartButton
            // 
            this.AllChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.AllChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllChartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllChartButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AllChartButton.FlatAppearance.BorderSize = 2;
            this.AllChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllChartButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllChartButton.ForeColor = System.Drawing.Color.Black;
            this.AllChartButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.AllChartButton.IconColor = System.Drawing.Color.Black;
            this.AllChartButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.AllChartButton.IconSize = 40;
            this.AllChartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllChartButton.Location = new System.Drawing.Point(1007, 0);
            this.AllChartButton.Name = "AllChartButton";
            this.AllChartButton.Size = new System.Drawing.Size(144, 64);
            this.AllChartButton.TabIndex = 16;
            this.AllChartButton.Text = "Все графики";
            this.AllChartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AllChartButton.UseVisualStyleBackColor = false;
            this.AllChartButton.Click += new System.EventHandler(this.AllChartButton_Click);
            // 
            // AdemsButton
            // 
            this.AdemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.AdemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdemsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdemsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdemsButton.FlatAppearance.BorderSize = 2;
            this.AdemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdemsButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdemsButton.ForeColor = System.Drawing.Color.Black;
            this.AdemsButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.AdemsButton.IconColor = System.Drawing.Color.Black;
            this.AdemsButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.AdemsButton.IconSize = 40;
            this.AdemsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdemsButton.Location = new System.Drawing.Point(864, 0);
            this.AdemsButton.Name = "AdemsButton";
            this.AdemsButton.Size = new System.Drawing.Size(143, 64);
            this.AdemsButton.TabIndex = 17;
            this.AdemsButton.Text = "Метод Адемса";
            this.AdemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdemsButton.UseVisualStyleBackColor = false;
            this.AdemsButton.Click += new System.EventHandler(this.AdamsButton_Click);
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
            this.MilnaButton.Location = new System.Drawing.Point(722, 0);
            this.MilnaButton.Name = "MilnaButton";
            this.MilnaButton.Size = new System.Drawing.Size(142, 64);
            this.MilnaButton.TabIndex = 19;
            this.MilnaButton.Text = "Метод Милна";
            this.MilnaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MilnaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MilnaButton.UseVisualStyleBackColor = false;
            this.MilnaButton.Click += new System.EventHandler(this.MilnaButton_Click);
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
            this.Runge_kuttaButton.Location = new System.Drawing.Point(579, 0);
            this.Runge_kuttaButton.Name = "Runge_kuttaButton";
            this.Runge_kuttaButton.Size = new System.Drawing.Size(143, 64);
            this.Runge_kuttaButton.TabIndex = 18;
            this.Runge_kuttaButton.Text = "Метод Рунге кутта";
            this.Runge_kuttaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Runge_kuttaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Runge_kuttaButton.UseVisualStyleBackColor = false;
            this.Runge_kuttaButton.Click += new System.EventHandler(this.RungeButton_Click);
            // 
            // IterButton
            // 
            this.IterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.IterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IterButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.IterButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.IterButton.FlatAppearance.BorderSize = 2;
            this.IterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IterButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IterButton.ForeColor = System.Drawing.Color.Black;
            this.IterButton.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.IterButton.IconColor = System.Drawing.Color.Black;
            this.IterButton.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.IterButton.IconSize = 40;
            this.IterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IterButton.Location = new System.Drawing.Point(434, 0);
            this.IterButton.Name = "IterButton";
            this.IterButton.Size = new System.Drawing.Size(145, 64);
            this.IterButton.TabIndex = 2;
            this.IterButton.Text = "Метод с итерационной обработкой";
            this.IterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IterButton.UseVisualStyleBackColor = false;
            this.IterButton.Click += new System.EventHandler(this.IterButton_Click);
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
            this.Euler_recalButton.Location = new System.Drawing.Point(289, 0);
            this.Euler_recalButton.Name = "Euler_recalButton";
            this.Euler_recalButton.Size = new System.Drawing.Size(145, 64);
            this.Euler_recalButton.TabIndex = 1;
            this.Euler_recalButton.Text = "Метод Эйлера с пересчётом";
            this.Euler_recalButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Euler_recalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Euler_recalButton.UseVisualStyleBackColor = false;
            this.Euler_recalButton.Click += new System.EventHandler(this.Euler_recalButton_Click);
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
            this.ChordButton.Location = new System.Drawing.Point(144, 0);
            this.ChordButton.Name = "ChordButton";
            this.ChordButton.Size = new System.Drawing.Size(145, 64);
            this.ChordButton.TabIndex = 14;
            this.ChordButton.Text = "Метод Хорд";
            this.ChordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChordButton.UseVisualStyleBackColor = false;
            this.ChordButton.Click += new System.EventHandler(this.ChordButton_Click);
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
            this.EulerButton.Size = new System.Drawing.Size(144, 64);
            this.EulerButton.TabIndex = 20;
            this.EulerButton.Text = "Метод Эйлера";
            this.EulerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EulerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EulerButton.UseVisualStyleBackColor = false;
            this.EulerButton.Click += new System.EventHandler(this.EulerButton_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PanelResult.Controls.Add(this.MessageSelectLabel);
            this.PanelResult.Controls.Add(this.ResultChart);
            this.PanelResult.Controls.Add(this.ResultDataGridView);
            this.PanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelResult.Location = new System.Drawing.Point(0, 64);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(1151, 482);
            this.PanelResult.TabIndex = 1;
            this.PanelResult.Click += new System.EventHandler(this.RungeButton_Click);
            // 
            // MessageSelectLabel
            // 
            this.MessageSelectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageSelectLabel.AutoSize = true;
            this.MessageSelectLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageSelectLabel.Location = new System.Drawing.Point(330, 188);
            this.MessageSelectLabel.Name = "MessageSelectLabel";
            this.MessageSelectLabel.Size = new System.Drawing.Size(484, 23);
            this.MessageSelectLabel.TabIndex = 17;
            this.MessageSelectLabel.Text = "Выберите, результат какого метода хотели бы увидеть\r\n";
            this.MessageSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultChart
            // 
            this.ResultChart.BackColor = System.Drawing.Color.Wheat;
            chartArea1.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea1);
            this.ResultChart.Location = new System.Drawing.Point(453, 74);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Size = new System.Drawing.Size(619, 343);
            this.ResultChart.TabIndex = 16;
            this.ResultChart.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            this.ResultChart.Titles.Add(title1);
            this.ResultChart.Visible = false;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.X,
            this.Y});
            this.ResultDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ResultDataGridView.Location = new System.Drawing.Point(59, 74);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.Size = new System.Drawing.Size(263, 343);
            this.ResultDataGridView.TabIndex = 15;
            this.ResultDataGridView.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(1151, 546);
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ResultMainForm";
            this.PanelMenu.ResumeLayout(false);
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelResult;
        private FontAwesome.Sharp.IconButton Euler_recalButton;
        private FontAwesome.Sharp.IconButton Runge_kuttaButton;
        private FontAwesome.Sharp.IconButton AdemsButton;
        private FontAwesome.Sharp.IconButton IterButton;
        private FontAwesome.Sharp.IconButton ChordButton;
        private FontAwesome.Sharp.IconButton MilnaButton;
        protected internal System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label MessageSelectLabel;
        private FontAwesome.Sharp.IconButton EulerButton;
        private FontAwesome.Sharp.IconButton AllChartButton;
    }
}