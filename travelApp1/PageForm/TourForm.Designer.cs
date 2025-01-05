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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(328, 341);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 36);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 146);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 3;
            label1.Text = "Search By";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Name", "Country", "City" });
            comboBoxFilter.Location = new Point(384, 146);
            comboBoxFilter.Margin = new Padding(4, 4, 4, 4);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(188, 33);
            comboBoxFilter.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(596, 820);
            flowLayoutPanel2.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(681, 98);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(596, 34);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(886, 779);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(384, 200);
            txtSearchQuery.Margin = new Padding(4, 4, 4, 4);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(183, 31);
            txtSearchQuery.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(41, 341);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TourForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 958);
            Controls.Add(button1);
            Controls.Add(txtSearchQuery);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(comboBoxFilter);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
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
        private Button button1;
    }
}