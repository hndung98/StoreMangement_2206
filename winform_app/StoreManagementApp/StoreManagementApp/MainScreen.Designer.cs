namespace StoreManagementApp
{
    partial class MainScreen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgvStoreInquiry = new System.Windows.Forms.DataGridView();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvItemInquiry = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvCustomerInquiry = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReloadStore = new System.Windows.Forms.Button();
            this.btnReloadItem = new System.Windows.Forms.Button();
            this.btnReloadCustomer = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabStore.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreInquiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInquiry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStore);
            this.tabControl.Controls.Add(this.tabItem);
            this.tabControl.Controls.Add(this.tabCustomer);
            this.tabControl.Controls.Add(this.tabEmployee);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 403);
            this.tabControl.TabIndex = 0;
            // 
            // tabStore
            // 
            this.tabStore.BackColor = System.Drawing.Color.White;
            this.tabStore.Controls.Add(this.btnReloadStore);
            this.tabStore.Controls.Add(this.label2);
            this.tabStore.Controls.Add(this.btnDelete);
            this.tabStore.Controls.Add(this.btnEdit);
            this.tabStore.Controls.Add(this.btnAddStore);
            this.tabStore.Controls.Add(this.dgvStoreInquiry);
            this.tabStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabStore.Location = new System.Drawing.Point(4, 22);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabStore.Size = new System.Drawing.Size(736, 377);
            this.tabStore.TabIndex = 0;
            this.tabStore.Text = "Store";
            // 
            // tabItem
            // 
            this.tabItem.BackColor = System.Drawing.Color.White;
            this.tabItem.Controls.Add(this.btnReloadItem);
            this.tabItem.Controls.Add(this.label1);
            this.tabItem.Controls.Add(this.button1);
            this.tabItem.Controls.Add(this.button2);
            this.tabItem.Controls.Add(this.button3);
            this.tabItem.Controls.Add(this.dgvItemInquiry);
            this.tabItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(736, 377);
            this.tabItem.TabIndex = 1;
            this.tabItem.Text = "Item";
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.White;
            this.tabCustomer.Controls.Add(this.btnReloadCustomer);
            this.tabCustomer.Controls.Add(this.label3);
            this.tabCustomer.Controls.Add(this.button4);
            this.tabCustomer.Controls.Add(this.button5);
            this.tabCustomer.Controls.Add(this.button6);
            this.tabCustomer.Controls.Add(this.dgvCustomerInquiry);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(736, 377);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer";
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.White;
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(736, 377);
            this.tabEmployee.TabIndex = 3;
            this.tabEmployee.Text = "Employee";
            // 
            // dgvStoreInquiry
            // 
            this.dgvStoreInquiry.AllowUserToAddRows = false;
            this.dgvStoreInquiry.AllowUserToDeleteRows = false;
            this.dgvStoreInquiry.AllowUserToResizeRows = false;
            this.dgvStoreInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvStoreInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvStoreInquiry.Name = "dgvStoreInquiry";
            this.dgvStoreInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvStoreInquiry.TabIndex = 0;
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddStore.Location = new System.Drawing.Point(513, 337);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(67, 34);
            this.btnAddStore.TabIndex = 1;
            this.btnAddStore.Text = "Add";
            this.btnAddStore.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(586, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(663, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvItemInquiry
            // 
            this.dgvItemInquiry.AllowUserToAddRows = false;
            this.dgvItemInquiry.AllowUserToDeleteRows = false;
            this.dgvItemInquiry.AllowUserToResizeRows = false;
            this.dgvItemInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvItemInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvItemInquiry.Name = "dgvItemInquiry";
            this.dgvItemInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvItemInquiry.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(663, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(586, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(513, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvCustomerInquiry
            // 
            this.dgvCustomerInquiry.AllowUserToAddRows = false;
            this.dgvCustomerInquiry.AllowUserToDeleteRows = false;
            this.dgvCustomerInquiry.AllowUserToResizeRows = false;
            this.dgvCustomerInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCustomerInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvCustomerInquiry.Name = "dgvCustomerInquiry";
            this.dgvCustomerInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvCustomerInquiry.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(663, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(586, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(513, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Store list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer list";
            // 
            // btnReloadStore
            // 
            this.btnReloadStore.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadStore.Location = new System.Drawing.Point(140, 4);
            this.btnReloadStore.Name = "btnReloadStore";
            this.btnReloadStore.Size = new System.Drawing.Size(103, 24);
            this.btnReloadStore.TabIndex = 9;
            this.btnReloadStore.Text = "Reload data";
            this.btnReloadStore.UseVisualStyleBackColor = false;
            this.btnReloadStore.Click += new System.EventHandler(this.btnReloadStore_Click);
            // 
            // btnReloadItem
            // 
            this.btnReloadItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadItem.Location = new System.Drawing.Point(140, 4);
            this.btnReloadItem.Name = "btnReloadItem";
            this.btnReloadItem.Size = new System.Drawing.Size(103, 24);
            this.btnReloadItem.TabIndex = 10;
            this.btnReloadItem.Text = "Reload data";
            this.btnReloadItem.UseVisualStyleBackColor = false;
            this.btnReloadItem.Click += new System.EventHandler(this.btnReloadItem_Click);
            // 
            // btnReloadCustomer
            // 
            this.btnReloadCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadCustomer.Location = new System.Drawing.Point(140, 4);
            this.btnReloadCustomer.Name = "btnReloadCustomer";
            this.btnReloadCustomer.Size = new System.Drawing.Size(103, 24);
            this.btnReloadCustomer.TabIndex = 11;
            this.btnReloadCustomer.Text = "Reload data";
            this.btnReloadCustomer.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 425);
            this.Controls.Add(this.tabControl);
            this.Name = "MainScreen";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStore.ResumeLayout(false);
            this.tabStore.PerformLayout();
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreInquiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInquiry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInquiry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStore;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.DataGridView dgvStoreInquiry;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvItemInquiry;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvCustomerInquiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReloadStore;
        private System.Windows.Forms.Button btnReloadItem;
        private System.Windows.Forms.Button btnReloadCustomer;
    }
}

