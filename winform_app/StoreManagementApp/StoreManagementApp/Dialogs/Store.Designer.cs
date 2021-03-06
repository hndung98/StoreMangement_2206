namespace StoreManagementApp.Dialogs
{
    partial class Store
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxStoreName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxRentalCost = new System.Windows.Forms.TextBox();
            this.cbxManager = new System.Windows.Forms.ComboBox();
            this.dtpOpenningDate = new System.Windows.Forms.DateTimePicker();
            this.dtpClosingDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxWard = new System.Windows.Forms.ComboBox();
            this.tbxDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(92, 369);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 29);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(61, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 23);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxStoreName
            // 
            this.tbxStoreName.Location = new System.Drawing.Point(132, 42);
            this.tbxStoreName.MaxLength = 50;
            this.tbxStoreName.Name = "tbxStoreName";
            this.tbxStoreName.Size = new System.Drawing.Size(257, 19);
            this.tbxStoreName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manager:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(23, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rental Cost:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(23, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Openning Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(23, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Closing Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(132, 69);
            this.tbxPhoneNumber.MaxLength = 15;
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(257, 19);
            this.tbxPhoneNumber.TabIndex = 2;
            this.tbxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(132, 96);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(257, 19);
            this.tbxEmail.TabIndex = 3;
            // 
            // tbxRentalCost
            // 
            this.tbxRentalCost.Location = new System.Drawing.Point(132, 153);
            this.tbxRentalCost.MaxLength = 15;
            this.tbxRentalCost.Name = "tbxRentalCost";
            this.tbxRentalCost.Size = new System.Drawing.Size(257, 19);
            this.tbxRentalCost.TabIndex = 5;
            this.tbxRentalCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRentalCost_KeyPress);
            // 
            // cbxManager
            // 
            this.cbxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManager.FormattingEnabled = true;
            this.cbxManager.Location = new System.Drawing.Point(132, 125);
            this.cbxManager.Name = "cbxManager";
            this.cbxManager.Size = new System.Drawing.Size(257, 20);
            this.cbxManager.TabIndex = 4;
            // 
            // dtpOpenningDate
            // 
            this.dtpOpenningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpenningDate.Location = new System.Drawing.Point(132, 186);
            this.dtpOpenningDate.Name = "dtpOpenningDate";
            this.dtpOpenningDate.Size = new System.Drawing.Size(257, 19);
            this.dtpOpenningDate.TabIndex = 6;
            this.dtpOpenningDate.ValueChanged += new System.EventHandler(this.dtpOpenningDate_ValueChanged);
            // 
            // dtpClosingDate
            // 
            this.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClosingDate.Location = new System.Drawing.Point(132, 218);
            this.dtpClosingDate.Name = "dtpClosingDate";
            this.dtpClosingDate.Size = new System.Drawing.Size(257, 19);
            this.dtpClosingDate.TabIndex = 7;
            this.dtpClosingDate.ValueChanged += new System.EventHandler(this.dtpClosingDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(23, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Province:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(23, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "District:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(23, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ward:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(23, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Details:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProvince
            // 
            this.cbxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(132, 249);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(257, 20);
            this.cbxProvince.TabIndex = 8;
            this.cbxProvince.TextChanged += new System.EventHandler(this.cbxProvince_TextChanged);
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(132, 280);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(257, 20);
            this.cbxDistrict.TabIndex = 9;
            this.cbxDistrict.TextChanged += new System.EventHandler(this.cbxDistrict_TextChanged);
            // 
            // cbxWard
            // 
            this.cbxWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWard.FormattingEnabled = true;
            this.cbxWard.Location = new System.Drawing.Point(132, 308);
            this.cbxWard.Name = "cbxWard";
            this.cbxWard.Size = new System.Drawing.Size(257, 20);
            this.cbxWard.TabIndex = 10;
            // 
            // tbxDetails
            // 
            this.tbxDetails.Location = new System.Drawing.Point(132, 336);
            this.tbxDetails.MaxLength = 50;
            this.tbxDetails.Name = "tbxDetails";
            this.tbxDetails.Size = new System.Drawing.Size(257, 19);
            this.tbxDetails.TabIndex = 11;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 420);
            this.Controls.Add(this.tbxDetails);
            this.Controls.Add(this.cbxWard);
            this.Controls.Add(this.cbxDistrict);
            this.Controls.Add(this.cbxProvince);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpClosingDate);
            this.Controls.Add(this.dtpOpenningDate);
            this.Controls.Add(this.cbxManager);
            this.Controls.Add(this.tbxRentalCost);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxStoreName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxStoreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxRentalCost;
        private System.Windows.Forms.ComboBox cbxManager;
        private System.Windows.Forms.DateTimePicker dtpOpenningDate;
        private System.Windows.Forms.DateTimePicker dtpClosingDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxWard;
        private System.Windows.Forms.TextBox tbxDetails;
    }
}