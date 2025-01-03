namespace travelApp1.PageForm
{
    partial class TourForm
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
            btnSearch = new Button();
            label1 = new Label();
            comboBoxFilter = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtSearchQuery = new TextBox();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(143, 273);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 117);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Search By";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Name", "Country", "City" });
            comboBoxFilter.Location = new Point(307, 117);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(151, 28);
            comboBoxFilter.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(477, 656);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(545, 78);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(477, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(709, 623);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(307, 160);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(147, 27);
            txtSearchQuery.TabIndex = 7;
            // 
            // TourForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 766);
            Controls.Add(txtSearchQuery);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(comboBoxFilter);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "TourForm";
            Text = "TourForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private ComboBox comboBoxFilter;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtSearchQuery;
    }
}