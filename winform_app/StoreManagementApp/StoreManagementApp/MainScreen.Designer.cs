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
            this.btnReloadStore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteStore = new System.Windows.Forms.Button();
            this.btnEditStore = new System.Windows.Forms.Button();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.dgvStoreInquiry = new System.Windows.Forms.DataGridView();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.btnReloadItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvItemInquiry = new System.Windows.Forms.DataGridView();
            this.tabStoreItem = new System.Windows.Forms.TabPage();
            this.btnReloadStoreItem = new System.Windows.Forms.Button();
            this.btnDeleteStoreItem = new System.Windows.Forms.Button();
            this.btnEditStoreItem = new System.Windows.Forms.Button();
            this.btnAddStoreItem = new System.Windows.Forms.Button();
            this.dgvStoreItemInquiry = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.btnReloadCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomerInquiry = new System.Windows.Forms.DataGridView();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnReloadEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvEmployeeInquiry = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreInquiry)).BeginInit();
            this.tabItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInquiry)).BeginInit();
            this.tabStoreItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreItemInquiry)).BeginInit();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInquiry)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStore);
            this.tabControl.Controls.Add(this.tabItem);
            this.tabControl.Controls.Add(this.tabStoreItem);
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
            this.tabStore.Controls.Add(this.btnDeleteStore);
            this.tabStore.Controls.Add(this.btnEditStore);
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
            // btnReloadStore
            // 
            this.btnReloadStore.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadStore.Location = new System.Drawing.Point(440, 337);
            this.btnReloadStore.Name = "btnReloadStore";
            this.btnReloadStore.Size = new System.Drawing.Size(67, 34);
            this.btnReloadStore.TabIndex = 1;
            this.btnReloadStore.Text = "Reload";
            this.btnReloadStore.UseVisualStyleBackColor = false;
            this.btnReloadStore.Click += new System.EventHandler(this.btnReloadStore_Click);
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
            // btnDeleteStore
            // 
            this.btnDeleteStore.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteStore.Location = new System.Drawing.Point(663, 337);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Size = new System.Drawing.Size(67, 34);
            this.btnDeleteStore.TabIndex = 4;
            this.btnDeleteStore.Text = "Delete";
            this.btnDeleteStore.UseVisualStyleBackColor = false;
            // 
            // btnEditStore
            // 
            this.btnEditStore.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditStore.Location = new System.Drawing.Point(586, 337);
            this.btnEditStore.Name = "btnEditStore";
            this.btnEditStore.Size = new System.Drawing.Size(67, 34);
            this.btnEditStore.TabIndex = 3;
            this.btnEditStore.Text = "Edit";
            this.btnEditStore.UseVisualStyleBackColor = false;
            this.btnEditStore.Click += new System.EventHandler(this.btnEditStore_Click);
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddStore.Location = new System.Drawing.Point(513, 337);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(67, 34);
            this.btnAddStore.TabIndex = 2;
            this.btnAddStore.Text = "Add";
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // dgvStoreInquiry
            // 
            this.dgvStoreInquiry.AllowUserToAddRows = false;
            this.dgvStoreInquiry.AllowUserToDeleteRows = false;
            this.dgvStoreInquiry.AllowUserToResizeRows = false;
            this.dgvStoreInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvStoreInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvStoreInquiry.MultiSelect = false;
            this.dgvStoreInquiry.Name = "dgvStoreInquiry";
            this.dgvStoreInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvStoreInquiry.TabIndex = 0;
            // 
            // tabItem
            // 
            this.tabItem.BackColor = System.Drawing.Color.White;
            this.tabItem.Controls.Add(this.btnReloadItem);
            this.tabItem.Controls.Add(this.label1);
            this.tabItem.Controls.Add(this.btnDeleteItem);
            this.tabItem.Controls.Add(this.btnEditItem);
            this.tabItem.Controls.Add(this.btnAddItem);
            this.tabItem.Controls.Add(this.dgvItemInquiry);
            this.tabItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(736, 377);
            this.tabItem.TabIndex = 1;
            this.tabItem.Text = "Item";
            // 
            // btnReloadItem
            // 
            this.btnReloadItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadItem.Location = new System.Drawing.Point(440, 337);
            this.btnReloadItem.Name = "btnReloadItem";
            this.btnReloadItem.Size = new System.Drawing.Size(67, 34);
            this.btnReloadItem.TabIndex = 10;
            this.btnReloadItem.Text = "Reload";
            this.btnReloadItem.UseVisualStyleBackColor = false;
            this.btnReloadItem.Click += new System.EventHandler(this.btnReloadItem_Click);
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
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteItem.Location = new System.Drawing.Point(663, 337);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(67, 34);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditItem.Location = new System.Drawing.Point(586, 337);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(67, 34);
            this.btnEditItem.TabIndex = 5;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddItem.Location = new System.Drawing.Point(513, 337);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(67, 34);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvItemInquiry
            // 
            this.dgvItemInquiry.AllowUserToAddRows = false;
            this.dgvItemInquiry.AllowUserToDeleteRows = false;
            this.dgvItemInquiry.AllowUserToResizeRows = false;
            this.dgvItemInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvItemInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvItemInquiry.MultiSelect = false;
            this.dgvItemInquiry.Name = "dgvItemInquiry";
            this.dgvItemInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvItemInquiry.TabIndex = 1;
            // 
            // tabStoreItem
            // 
            this.tabStoreItem.Controls.Add(this.btnReloadStoreItem);
            this.tabStoreItem.Controls.Add(this.btnDeleteStoreItem);
            this.tabStoreItem.Controls.Add(this.btnEditStoreItem);
            this.tabStoreItem.Controls.Add(this.btnAddStoreItem);
            this.tabStoreItem.Controls.Add(this.dgvStoreItemInquiry);
            this.tabStoreItem.Controls.Add(this.label5);
            this.tabStoreItem.Location = new System.Drawing.Point(4, 22);
            this.tabStoreItem.Name = "tabStoreItem";
            this.tabStoreItem.Size = new System.Drawing.Size(736, 377);
            this.tabStoreItem.TabIndex = 4;
            this.tabStoreItem.Text = "Store Item";
            this.tabStoreItem.UseVisualStyleBackColor = true;
            // 
            // btnReloadStoreItem
            // 
            this.btnReloadStoreItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadStoreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadStoreItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadStoreItem.Location = new System.Drawing.Point(440, 337);
            this.btnReloadStoreItem.Name = "btnReloadStoreItem";
            this.btnReloadStoreItem.Size = new System.Drawing.Size(67, 34);
            this.btnReloadStoreItem.TabIndex = 14;
            this.btnReloadStoreItem.Text = "Reload";
            this.btnReloadStoreItem.UseVisualStyleBackColor = false;
            // 
            // btnDeleteStoreItem
            // 
            this.btnDeleteStoreItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteStoreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteStoreItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteStoreItem.Location = new System.Drawing.Point(663, 337);
            this.btnDeleteStoreItem.Name = "btnDeleteStoreItem";
            this.btnDeleteStoreItem.Size = new System.Drawing.Size(67, 34);
            this.btnDeleteStoreItem.TabIndex = 13;
            this.btnDeleteStoreItem.Text = "Delete";
            this.btnDeleteStoreItem.UseVisualStyleBackColor = false;
            // 
            // btnEditStoreItem
            // 
            this.btnEditStoreItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditStoreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditStoreItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditStoreItem.Location = new System.Drawing.Point(586, 337);
            this.btnEditStoreItem.Name = "btnEditStoreItem";
            this.btnEditStoreItem.Size = new System.Drawing.Size(67, 34);
            this.btnEditStoreItem.TabIndex = 12;
            this.btnEditStoreItem.Text = "Edit";
            this.btnEditStoreItem.UseVisualStyleBackColor = false;
            this.btnEditStoreItem.Click += new System.EventHandler(this.btnEditStoreItem_Click);
            // 
            // btnAddStoreItem
            // 
            this.btnAddStoreItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddStoreItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddStoreItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddStoreItem.Location = new System.Drawing.Point(513, 337);
            this.btnAddStoreItem.Name = "btnAddStoreItem";
            this.btnAddStoreItem.Size = new System.Drawing.Size(67, 34);
            this.btnAddStoreItem.TabIndex = 11;
            this.btnAddStoreItem.Text = "Add";
            this.btnAddStoreItem.UseVisualStyleBackColor = false;
            this.btnAddStoreItem.Click += new System.EventHandler(this.btnAddStoreItem_Click);
            // 
            // dgvStoreItemInquiry
            // 
            this.dgvStoreItemInquiry.AllowUserToAddRows = false;
            this.dgvStoreItemInquiry.AllowUserToDeleteRows = false;
            this.dgvStoreItemInquiry.AllowUserToResizeRows = false;
            this.dgvStoreItemInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvStoreItemInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreItemInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvStoreItemInquiry.MultiSelect = false;
            this.dgvStoreItemInquiry.Name = "dgvStoreItemInquiry";
            this.dgvStoreItemInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreItemInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvStoreItemInquiry.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item list";
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.White;
            this.tabCustomer.Controls.Add(this.btnReloadCustomer);
            this.tabCustomer.Controls.Add(this.label3);
            this.tabCustomer.Controls.Add(this.btnDeleteCustomer);
            this.tabCustomer.Controls.Add(this.btnEditCustomer);
            this.tabCustomer.Controls.Add(this.btnAddCustomer);
            this.tabCustomer.Controls.Add(this.dgvCustomerInquiry);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(736, 377);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer";
            // 
            // btnReloadCustomer
            // 
            this.btnReloadCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadCustomer.Location = new System.Drawing.Point(440, 337);
            this.btnReloadCustomer.Name = "btnReloadCustomer";
            this.btnReloadCustomer.Size = new System.Drawing.Size(67, 34);
            this.btnReloadCustomer.TabIndex = 11;
            this.btnReloadCustomer.Text = "Reload";
            this.btnReloadCustomer.UseVisualStyleBackColor = false;
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
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(663, 337);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(67, 34);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditCustomer.Location = new System.Drawing.Point(586, 337);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(67, 34);
            this.btnEditCustomer.TabIndex = 8;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCustomer.Location = new System.Drawing.Point(513, 337);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(67, 34);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgvCustomerInquiry
            // 
            this.dgvCustomerInquiry.AllowUserToAddRows = false;
            this.dgvCustomerInquiry.AllowUserToDeleteRows = false;
            this.dgvCustomerInquiry.AllowUserToResizeRows = false;
            this.dgvCustomerInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCustomerInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvCustomerInquiry.MultiSelect = false;
            this.dgvCustomerInquiry.Name = "dgvCustomerInquiry";
            this.dgvCustomerInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvCustomerInquiry.TabIndex = 2;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.White;
            this.tabEmployee.Controls.Add(this.btnReloadEmployee);
            this.tabEmployee.Controls.Add(this.btnDeleteEmployee);
            this.tabEmployee.Controls.Add(this.btnEditEmployee);
            this.tabEmployee.Controls.Add(this.btnAddEmployee);
            this.tabEmployee.Controls.Add(this.dgvEmployeeInquiry);
            this.tabEmployee.Controls.Add(this.label4);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(736, 377);
            this.tabEmployee.TabIndex = 3;
            this.tabEmployee.Text = "Employee";
            // 
            // btnReloadEmployee
            // 
            this.btnReloadEmployee.BackColor = System.Drawing.Color.LightBlue;
            this.btnReloadEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReloadEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadEmployee.Location = new System.Drawing.Point(440, 337);
            this.btnReloadEmployee.Name = "btnReloadEmployee";
            this.btnReloadEmployee.Size = new System.Drawing.Size(67, 34);
            this.btnReloadEmployee.TabIndex = 17;
            this.btnReloadEmployee.Text = "Reload";
            this.btnReloadEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(663, 337);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(67, 34);
            this.btnDeleteEmployee.TabIndex = 16;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditEmployee.Location = new System.Drawing.Point(586, 337);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(67, 34);
            this.btnEditEmployee.TabIndex = 15;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEmployee.Location = new System.Drawing.Point(513, 337);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(67, 34);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dgvEmployeeInquiry
            // 
            this.dgvEmployeeInquiry.AllowUserToAddRows = false;
            this.dgvEmployeeInquiry.AllowUserToDeleteRows = false;
            this.dgvEmployeeInquiry.AllowUserToResizeRows = false;
            this.dgvEmployeeInquiry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmployeeInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInquiry.Location = new System.Drawing.Point(6, 31);
            this.dgvEmployeeInquiry.MultiSelect = false;
            this.dgvEmployeeInquiry.Name = "dgvEmployeeInquiry";
            this.dgvEmployeeInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInquiry.Size = new System.Drawing.Size(724, 300);
            this.dgvEmployeeInquiry.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee list";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 425);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStore.ResumeLayout(false);
            this.tabStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreInquiry)).EndInit();
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInquiry)).EndInit();
            this.tabStoreItem.ResumeLayout(false);
            this.tabStoreItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreItemInquiry)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInquiry)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInquiry)).EndInit();
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
        private System.Windows.Forms.Button btnEditStore;
        private System.Windows.Forms.Button btnDeleteStore;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvItemInquiry;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerInquiry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReloadStore;
        private System.Windows.Forms.Button btnReloadItem;
        private System.Windows.Forms.Button btnReloadCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEmployeeInquiry;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnReloadEmployee;
        private System.Windows.Forms.TabPage tabStoreItem;
        private System.Windows.Forms.Button btnReloadStoreItem;
        private System.Windows.Forms.Button btnDeleteStoreItem;
        private System.Windows.Forms.Button btnEditStoreItem;
        private System.Windows.Forms.Button btnAddStoreItem;
        private System.Windows.Forms.DataGridView dgvStoreItemInquiry;
        private System.Windows.Forms.Label label5;
    }
}

