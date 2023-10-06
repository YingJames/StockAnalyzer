namespace COP4365_P1
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
            this.openFileDialog_stockLoader = new System.Windows.Forms.OpenFileDialog();
            this.button_loadStock = new System.Windows.Forms.Button();
            this.dataGridView_candlesticks = new System.Windows.Forms.DataGridView();
            this.dataGridView_second = new System.Windows.Forms.DataGridView();
            this.comboBox_stockSymbols = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_daily = new System.Windows.Forms.RadioButton();
            this.radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_candlesticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_stockLoader
            // 
            this.openFileDialog_stockLoader.Filter = "All Stock files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Sto" +
    "cks|*-Month.csv";
            this.openFileDialog_stockLoader.Multiselect = true;
            // 
            // button_loadStock
            // 
            this.button_loadStock.Location = new System.Drawing.Point(697, 422);
            this.button_loadStock.Margin = new System.Windows.Forms.Padding(2);
            this.button_loadStock.Name = "button_loadStock";
            this.button_loadStock.Size = new System.Drawing.Size(135, 77);
            this.button_loadStock.TabIndex = 0;
            this.button_loadStock.Text = "Load OpenFileDialog";
            this.button_loadStock.UseVisualStyleBackColor = true;
            this.button_loadStock.Click += new System.EventHandler(this.button_openStockOnClick);
            // 
            // dataGridView_candlesticks
            // 
            this.dataGridView_candlesticks.AllowUserToAddRows = false;
            this.dataGridView_candlesticks.AllowUserToDeleteRows = false;
            this.dataGridView_candlesticks.AutoGenerateColumns = false;
            this.dataGridView_candlesticks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_candlesticks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView_candlesticks.DataSource = this.candlestickBindingSource;
            this.dataGridView_candlesticks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_candlesticks.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_candlesticks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_candlesticks.Name = "dataGridView_candlesticks";
            this.dataGridView_candlesticks.ReadOnly = true;
            this.dataGridView_candlesticks.RowHeadersWidth = 62;
            this.dataGridView_candlesticks.RowTemplate.Height = 28;
            this.dataGridView_candlesticks.Size = new System.Drawing.Size(246, 523);
            this.dataGridView_candlesticks.TabIndex = 3;
            // 
            // dataGridView_second
            // 
            this.dataGridView_second.AutoGenerateColumns = false;
            this.dataGridView_second.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_second.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.openDataGridViewTextBoxColumn1,
            this.highDataGridViewTextBoxColumn1,
            this.lowDataGridViewTextBoxColumn1,
            this.closeDataGridViewTextBoxColumn1,
            this.volumeDataGridViewTextBoxColumn1});
            this.dataGridView_second.DataSource = this.candlestickBindingSource;
            this.dataGridView_second.Location = new System.Drawing.Point(250, 0);
            this.dataGridView_second.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_second.Name = "dataGridView_second";
            this.dataGridView_second.RowHeadersWidth = 62;
            this.dataGridView_second.RowTemplate.Height = 28;
            this.dataGridView_second.Size = new System.Drawing.Size(649, 295);
            this.dataGridView_second.TabIndex = 4;
            // 
            // comboBox_stockSymbols
            // 
            this.comboBox_stockSymbols.FormattingEnabled = true;
            this.comboBox_stockSymbols.Items.AddRange(new object[] {
            "ABT",
            "ACN",
            "ADBE",
            "IBM",
            "LUV",
            "MSFT",
            "NVDA",
            "ORCL",
            "ORLY",
            "WMT"});
            this.comboBox_stockSymbols.Location = new System.Drawing.Point(278, 330);
            this.comboBox_stockSymbols.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_stockSymbols.Name = "comboBox_stockSymbols";
            this.comboBox_stockSymbols.Size = new System.Drawing.Size(82, 21);
            this.comboBox_stockSymbols.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 355);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // radioButton_daily
            // 
            this.radioButton_daily.AutoSize = true;
            this.radioButton_daily.Checked = true;
            this.radioButton_daily.Location = new System.Drawing.Point(454, 336);
            this.radioButton_daily.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_daily.Name = "radioButton_daily";
            this.radioButton_daily.Size = new System.Drawing.Size(48, 17);
            this.radioButton_daily.TabIndex = 7;
            this.radioButton_daily.TabStop = true;
            this.radioButton_daily.Text = "Daily";
            this.radioButton_daily.UseVisualStyleBackColor = true;
            // 
            // radioButton_weekly
            // 
            this.radioButton_weekly.AutoSize = true;
            this.radioButton_weekly.Location = new System.Drawing.Point(454, 356);
            this.radioButton_weekly.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_weekly.Name = "radioButton_weekly";
            this.radioButton_weekly.Size = new System.Drawing.Size(61, 17);
            this.radioButton_weekly.TabIndex = 8;
            this.radioButton_weekly.Text = "Weekly";
            this.radioButton_weekly.UseVisualStyleBackColor = true;
            // 
            // radioButton_monthly
            // 
            this.radioButton_monthly.AutoSize = true;
            this.radioButton_monthly.Location = new System.Drawing.Point(454, 376);
            this.radioButton_monthly.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_monthly.Name = "radioButton_monthly";
            this.radioButton_monthly.Size = new System.Drawing.Size(62, 17);
            this.radioButton_monthly.TabIndex = 9;
            this.radioButton_monthly.Text = "Monthly";
            this.radioButton_monthly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Symbols";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Period";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // openDataGridViewTextBoxColumn1
            // 
            this.openDataGridViewTextBoxColumn1.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn1.HeaderText = "open";
            this.openDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.openDataGridViewTextBoxColumn1.Name = "openDataGridViewTextBoxColumn1";
            this.openDataGridViewTextBoxColumn1.ReadOnly = true;
            this.openDataGridViewTextBoxColumn1.Width = 150;
            // 
            // highDataGridViewTextBoxColumn1
            // 
            this.highDataGridViewTextBoxColumn1.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn1.HeaderText = "high";
            this.highDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.highDataGridViewTextBoxColumn1.Name = "highDataGridViewTextBoxColumn1";
            this.highDataGridViewTextBoxColumn1.ReadOnly = true;
            this.highDataGridViewTextBoxColumn1.Width = 150;
            // 
            // lowDataGridViewTextBoxColumn1
            // 
            this.lowDataGridViewTextBoxColumn1.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn1.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.lowDataGridViewTextBoxColumn1.Name = "lowDataGridViewTextBoxColumn1";
            this.lowDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn1.Width = 150;
            // 
            // closeDataGridViewTextBoxColumn1
            // 
            this.closeDataGridViewTextBoxColumn1.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn1.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.closeDataGridViewTextBoxColumn1.Name = "closeDataGridViewTextBoxColumn1";
            this.closeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.closeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // volumeDataGridViewTextBoxColumn1
            // 
            this.volumeDataGridViewTextBoxColumn1.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn1.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn1.Name = "volumeDataGridViewTextBoxColumn1";
            this.volumeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(COP4365_P1.candlestick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            this.openDataGridViewTextBoxColumn.Width = 150;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.ReadOnly = true;
            this.highDataGridViewTextBoxColumn.Width = 150;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn.Width = 150;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeDataGridViewTextBoxColumn.Width = 150;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_monthly);
            this.Controls.Add(this.radioButton_weekly);
            this.Controls.Add(this.radioButton_daily);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_stockSymbols);
            this.Controls.Add(this.dataGridView_second);
            this.Controls.Add(this.dataGridView_candlesticks);
            this.Controls.Add(this.button_loadStock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_candlesticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_stockLoader;
        private System.Windows.Forms.Button button_loadStock;
        private System.Windows.Forms.DataGridView dataGridView_candlesticks;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_second;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox_stockSymbols;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_daily;
        private System.Windows.Forms.RadioButton radioButton_weekly;
        private System.Windows.Forms.RadioButton radioButton_monthly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

