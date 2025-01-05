namespace travelApp1.PageForm
{
    partial class TourManagement
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
            dataGridView1 = new DataGridView();
            regionComboBox = new ComboBox();
            searchTextBox = new TextBox();
            pageNumberLabel = new Label();
            paginationPanel = new FlowLayoutPanel();
            comboBoxFilter = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1020, 452);
            dataGridView1.TabIndex = 0;
            // 
            // regionComboBox
            // 
            regionComboBox.FormattingEnabled = true;
            regionComboBox.Location = new Point(31, 48);
            regionComboBox.Name = "regionComboBox";
            regionComboBox.Size = new Size(151, 28);
            regionComboBox.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(47, 97);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(125, 27);
            searchTextBox.TabIndex = 2;
            // 
            // pageNumberLabel
            // 
            pageNumberLabel.AutoSize = true;
            pageNumberLabel.Location = new Point(198, 248);
            pageNumberLabel.Name = "pageNumberLabel";
            pageNumberLabel.Size = new Size(50, 20);
            pageNumberLabel.TabIndex = 5;
            pageNumberLabel.Text = "label1";
            // 
            // paginationPanel
            // 
            paginationPanel.Location = new Point(31, 351);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(250, 125);
            paginationPanel.TabIndex = 7;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Name", "Country", "City" });
            comboBoxFilter.Location = new Point(219, 48);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(151, 28);
            comboBoxFilter.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(140, 155);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // TourManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 535);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxFilter);
            Controls.Add(paginationPanel);
            Controls.Add(pageNumberLabel);
            Controls.Add(searchTextBox);
            Controls.Add(regionComboBox);
            Controls.Add(dataGridView1);
            Name = "TourManagement";
            Text = "TourManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox regionComboBox;
        private TextBox searchTextBox;
        private Label pageNumberLabel;
        private FlowLayoutPanel paginationPanel;
        private ComboBox comboBoxFilter;
        private Button btnSearch;
    }
}