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
            searchTextBox = new TextBox();
            regionComboBox = new ComboBox();
            comboBoxFilter = new ComboBox();
            btnSearch = new Button();
            pageNumberLabel = new Label();
            paginationPanel = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(1447, 449);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(10, 27);
            searchTextBox.TabIndex = 2;
            // 
            // regionComboBox
            // 
            regionComboBox.FormattingEnabled = true;
            regionComboBox.Location = new Point(98, 58);
            regionComboBox.Name = "regionComboBox";
            regionComboBox.Size = new Size(165, 28);
            regionComboBox.TabIndex = 1;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Name", "Country", "City" });
            comboBoxFilter.Location = new Point(1447, 482);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(10, 28);
            comboBoxFilter.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1226, 385);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(10, 10);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // pageNumberLabel
            // 
            pageNumberLabel.AutoSize = true;
            pageNumberLabel.Location = new Point(1432, 513);
            pageNumberLabel.Name = "pageNumberLabel";
            pageNumberLabel.Size = new Size(50, 20);
            pageNumberLabel.TabIndex = 5;
            pageNumberLabel.Text = "label1";
            // 
            // paginationPanel
            // 
            paginationPanel.Location = new Point(1461, 385);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(10, 10);
            paginationPanel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1447, 418);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 0;
            // 
            // TourManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 535);
            Controls.Add(pageNumberLabel);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxFilter);
            Controls.Add(paginationPanel);
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

        private TextBox searchTextBox;
        private ComboBox regionComboBox;
        private ComboBox comboBoxFilter;
        private Button btnSearch;
        private Label pageNumberLabel;
        private FlowLayoutPanel paginationPanel;
        private DataGridView dataGridView1;
    }
}