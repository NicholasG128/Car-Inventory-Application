namespace Collection_Application
{
    partial class frmCollectionItem
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
            lblName = new Label();
            lblDescription = new Label();
            lblDate = new Label();
            lblCustom = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtCustom = new TextBox();
            rdoRadio1 = new RadioButton();
            rdoRadio2 = new RadioButton();
            chkCheckBox = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            dtpDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "&Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(29, 82);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "&Description";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(29, 128);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(76, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date &Aquired";
            // 
            // lblCustom
            // 
            lblCustom.AutoSize = true;
            lblCustom.Location = new Point(29, 174);
            lblCustom.Name = "lblCustom";
            lblCustom.Size = new Size(77, 15);
            lblCustom.TabIndex = 3;
            lblCustom.Text = "Custom &Field";
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 79);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 5;
            // 
            // txtCustom
            // 
            txtCustom.Location = new Point(111, 171);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(100, 23);
            txtCustom.TabIndex = 7;
            // 
            // rdoRadio1
            // 
            rdoRadio1.AutoSize = true;
            rdoRadio1.Location = new Point(29, 237);
            rdoRadio1.Name = "rdoRadio1";
            rdoRadio1.Size = new Size(94, 19);
            rdoRadio1.TabIndex = 8;
            rdoRadio1.TabStop = true;
            rdoRadio1.Text = "Radio Button";
            rdoRadio1.UseVisualStyleBackColor = true;
            // 
            // rdoRadio2
            // 
            rdoRadio2.AutoSize = true;
            rdoRadio2.Location = new Point(129, 237);
            rdoRadio2.Name = "rdoRadio2";
            rdoRadio2.Size = new Size(94, 19);
            rdoRadio2.TabIndex = 9;
            rdoRadio2.TabStop = true;
            rdoRadio2.Text = "Radio Button";
            rdoRadio2.UseVisualStyleBackColor = true;
            // 
            // chkCheckBox
            // 
            chkCheckBox.AutoSize = true;
            chkCheckBox.Location = new Point(29, 304);
            chkCheckBox.Name = "chkCheckBox";
            chkCheckBox.Size = new Size(79, 19);
            chkCheckBox.TabIndex = 10;
            chkCheckBox.Text = "Checkbox";
            chkCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(115, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(196, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(110, 122);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(101, 23);
            dtpDate.TabIndex = 13;
            // 
            // frmCollectionItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 338);
            Controls.Add(dtpDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkCheckBox);
            Controls.Add(rdoRadio2);
            Controls.Add(rdoRadio1);
            Controls.Add(txtCustom);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblCustom);
            Controls.Add(lblDate);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Name = "frmCollectionItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collection Application Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDescription;
        private Label lblDate;
        private Label lblCustom;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtCustom;
        private RadioButton rdoRadio1;
        private RadioButton rdoRadio2;
        private CheckBox chkCheckBox;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpDate;
    }
}