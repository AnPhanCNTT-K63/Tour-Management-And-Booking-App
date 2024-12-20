namespace travelApp1
{
    partial class CreateTourPackage
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
            txtPackageDescription = new TextBox();
            txtPackageImage = new TextBox();
            txtActivities = new TextBox();
            txtPackageName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label8 = new Label();
            chkRefund = new CheckBox();
            nudQuantity = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            dtpTravelDay = new DateTimePicker();
            chkChangeSchedule = new CheckBox();
            btnAddPackage = new Button();
            btnSubmit = new Button();
            nudVat = new NumericUpDown();
            label11 = new Label();
            nudPrice = new NumericUpDown();
            nudDiscount = new NumericUpDown();
            label12 = new Label();
            txtVoucherTitle = new TextBox();
            txtVoucherCode = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtCheckIn = new TextBox();
            btnBack = new Button();
            btnReset = new Button();
            dgvTravelDays = new DataGridView();
            btnAddTravelDay = new Button();
            TravelDayColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTravelDays).BeginInit();
            SuspendLayout();
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(148, 182);
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(182, 31);
            txtPackageDescription.TabIndex = 25;
            // 
            // txtPackageImage
            // 
            txtPackageImage.Location = new Point(629, 125);
            txtPackageImage.Name = "txtPackageImage";
            txtPackageImage.Size = new Size(180, 31);
            txtPackageImage.TabIndex = 24;
            // 
            // txtActivities
            // 
            txtActivities.Location = new Point(629, 59);
            txtActivities.Name = "txtActivities";
            txtActivities.Size = new Size(180, 31);
            txtActivities.TabIndex = 23;
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(148, 53);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(191, 31);
            txtPackageName.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 188);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 19;
            label7.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 128);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 18;
            label6.Text = "Image:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 65);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 17;
            label5.Text = "Activities:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 16;
            label4.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 14;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.Location = new Point(488, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 39);
            label1.TabIndex = 13;
            label1.Text = "Create Tour Package";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(828, 335);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 27;
            label3.Text = "isChangeSchedule";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(828, 411);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 28;
            label8.Text = "isRefund";
            // 
            // chkRefund
            // 
            chkRefund.AutoSize = true;
            chkRefund.Location = new Point(1037, 415);
            chkRefund.Name = "chkRefund";
            chkRefund.Size = new Size(22, 21);
            chkRefund.TabIndex = 29;
            chkRefund.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(629, 182);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(180, 31);
            nudQuantity.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(488, 184);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 31;
            label9.Text = "Quantity:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 254);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 32;
            label10.Text = "Trave Day: ";
            // 
            // dtpTravelDay
            // 
            dtpTravelDay.Location = new Point(148, 253);
            dtpTravelDay.Name = "dtpTravelDay";
            dtpTravelDay.Size = new Size(299, 31);
            dtpTravelDay.TabIndex = 33;
            // 
            // chkChangeSchedule
            // 
            chkChangeSchedule.AutoSize = true;
            chkChangeSchedule.Location = new Point(1037, 339);
            chkChangeSchedule.Name = "chkChangeSchedule";
            chkChangeSchedule.Size = new Size(22, 21);
            chkChangeSchedule.TabIndex = 34;
            chkChangeSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Location = new Point(398, 576);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(189, 46);
            btnAddPackage.TabIndex = 35;
            btnAddPackage.Text = "Add Tour Package";
            btnAddPackage.UseVisualStyleBackColor = true;
            btnAddPackage.Click += btnAddPackage_Click_1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(698, 576);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(167, 47);
            btnSubmit.TabIndex = 36;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // nudVat
            // 
            nudVat.Location = new Point(629, 253);
            nudVat.Name = "nudVat";
            nudVat.Size = new Size(180, 31);
            nudVat.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(488, 255);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 38;
            label11.Text = "VAT:";
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(150, 126);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(180, 31);
            nudPrice.TabIndex = 39;
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(1008, 129);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(180, 31);
            nudDiscount.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(866, 131);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 41;
            label12.Text = "Discount";
            // 
            // txtVoucherTitle
            // 
            txtVoucherTitle.Location = new Point(1008, 185);
            txtVoucherTitle.Name = "txtVoucherTitle";
            txtVoucherTitle.Size = new Size(180, 31);
            txtVoucherTitle.TabIndex = 42;
            // 
            // txtVoucherCode
            // 
            txtVoucherCode.Location = new Point(1008, 255);
            txtVoucherCode.Name = "txtVoucherCode";
            txtVoucherCode.Size = new Size(180, 31);
            txtVoucherCode.TabIndex = 43;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(888, 188);
            label13.Name = "label13";
            label13.Size = new Size(44, 25);
            label13.TabIndex = 44;
            label13.Text = "Title";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(872, 259);
            label14.Name = "label14";
            label14.Size = new Size(76, 25);
            label14.TabIndex = 45;
            label14.Text = "Voucher";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(874, 65);
            label15.Name = "label15";
            label15.Size = new Size(74, 25);
            label15.TabIndex = 46;
            label15.Text = "CheckIn";
            // 
            // txtCheckIn
            // 
            txtCheckIn.Location = new Point(1008, 59);
            txtCheckIn.Name = "txtCheckIn";
            txtCheckIn.Size = new Size(180, 31);
            txtCheckIn.TabIndex = 47;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1209, 576);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 47);
            btnBack.TabIndex = 48;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(969, 576);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(142, 47);
            btnReset.TabIndex = 49;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvTravelDays
            // 
            dgvTravelDays.BackgroundColor = SystemColors.ActiveCaption;
            dgvTravelDays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTravelDays.Columns.AddRange(new DataGridViewColumn[] { TravelDayColumn });
            dgvTravelDays.GridColor = SystemColors.Menu;
            dgvTravelDays.Location = new Point(41, 321);
            dgvTravelDays.Name = "dgvTravelDays";
            dgvTravelDays.RowHeadersWidth = 62;
            dgvTravelDays.Size = new Size(365, 225);
            dgvTravelDays.TabIndex = 50;
            // 
            // btnAddTravelDay
            // 
            btnAddTravelDay.Location = new Point(93, 577);
            btnAddTravelDay.Name = "btnAddTravelDay";
            btnAddTravelDay.Size = new Size(189, 46);
            btnAddTravelDay.TabIndex = 51;
            btnAddTravelDay.Text = "Add Travel Day";
            btnAddTravelDay.UseVisualStyleBackColor = true;
            btnAddTravelDay.Click += btnAddTravelDay_Click;
            // 
            // TravelDayColumn
            // 
            TravelDayColumn.HeaderText = "Ngày Du Lịch";
            TravelDayColumn.MinimumWidth = 8;
            TravelDayColumn.Name = "TravelDayColumn";
            TravelDayColumn.Resizable = DataGridViewTriState.True;
            TravelDayColumn.Width = 300;
            // 
            // CreateTourPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 660);
            Controls.Add(btnAddTravelDay);
            Controls.Add(dgvTravelDays);
            Controls.Add(btnReset);
            Controls.Add(btnBack);
            Controls.Add(txtCheckIn);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtVoucherCode);
            Controls.Add(txtVoucherTitle);
            Controls.Add(label12);
            Controls.Add(nudDiscount);
            Controls.Add(nudPrice);
            Controls.Add(label11);
            Controls.Add(nudVat);
            Controls.Add(btnSubmit);
            Controls.Add(btnAddPackage);
            Controls.Add(chkChangeSchedule);
            Controls.Add(dtpTravelDay);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(nudQuantity);
            Controls.Add(chkRefund);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(txtPackageDescription);
            Controls.Add(txtPackageImage);
            Controls.Add(txtActivities);
            Controls.Add(txtPackageName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateTourPackage";
            Text = "CreateTourPackage";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTravelDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPackageDescription;
        private TextBox txtPackageImage;
        private TextBox txtActivities;
        private TextBox txtPackageName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label8;
        private CheckBox chkRefund;
        private NumericUpDown nudQuantity;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpTravelDay;
        private CheckBox chkChangeSchedule;
        private Button btnAddPackage;
        private Button btnSubmit;
        private NumericUpDown nudVat;
        private Label label11;
        private NumericUpDown nudPrice;
        private NumericUpDown nudDiscount;
        private Label label12;
        private TextBox txtVoucherTitle;
        private TextBox txtVoucherCode;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtCheckIn;
        private Button btnBack;
        private Button btnReset;
        private DataGridView dgvTravelDays;
        private Button btnAddTravelDay;
        private DataGridViewTextBoxColumn TravelDayColumn;
    }
}