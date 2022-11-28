namespace WindowsFormsApp1
{
    partial class FormQL_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQL_KhachHang));
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.lbRecord = new System.Windows.Forms.Label();
            this.cbSearch = new NoteWrapper.FlatCombobox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new ePOSOne.btnProduct.Button_WOC();
            this.btnUpdate = new ePOSOne.btnProduct.Button_WOC();
            this.btnAdd = new ePOSOne.btnProduct.Button_WOC();
            this.dgvListCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.dtpDob = new WindowsFormsApp1.CustomControls.RJDatePicker();
            this.lbDob = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.tbDob = new WindowsFormsApp1.Resources.RJTextBox();
            this.cbGender = new NoteWrapper.FlatCombobox();
            this.tbGender = new WindowsFormsApp1.Resources.RJTextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbAddress = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbPhone = new WindowsFormsApp1.Resources.RJTextBox();
            this.lbIDCard = new System.Windows.Forms.Label();
            this.tbIDCard = new WindowsFormsApp1.Resources.RJTextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.tbName = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbCustomerID = new WindowsFormsApp1.Resources.RJTextBox();
            this.btnCancel = new ePOSOne.btnProduct.Button_WOC();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).BeginInit();
            this.tabPageEdit.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageList
            // 
            this.tabPageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.tabPageList.Controls.Add(this.lbRecord);
            this.tabPageList.Controls.Add(this.cbSearch);
            this.tabPageList.Controls.Add(this.label9);
            this.tabPageList.Controls.Add(this.tbSearch);
            this.tabPageList.Controls.Add(this.btnDelete);
            this.tabPageList.Controls.Add(this.btnUpdate);
            this.tabPageList.Controls.Add(this.btnAdd);
            this.tabPageList.Controls.Add(this.dgvListCustomer);
            this.tabPageList.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageList.Location = new System.Drawing.Point(4, 25);
            this.tabPageList.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageList.Size = new System.Drawing.Size(1065, 548);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Danh sách khách hàng";
            // 
            // lbRecord
            // 
            this.lbRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRecord.Location = new System.Drawing.Point(852, 18);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(213, 25);
            this.lbRecord.TabIndex = 12;
            this.lbRecord.Text = "Số lượng khách hàng 0";
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.cbSearch.BorderColor = System.Drawing.Color.DimGray;
            this.cbSearch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ForeColor = System.Drawing.Color.Black;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            " Mã khách hàng",
            " Họ tên",
            " Số điện thoại",
            " CMND"});
            this.cbSearch.Location = new System.Drawing.Point(23, 16);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(195, 30);
            this.cbSearch.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(232, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(613, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺" +
    "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tbSearch.Location = new System.Drawing.Point(235, 19);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(544, 25);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.Text = "Tìm kiếm";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(922, 199);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnDelete.Size = new System.Drawing.Size(124, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnUpdate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(922, 150);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnUpdate.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.Size = new System.Drawing.Size(124, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(922, 101);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnAdd.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(15)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.Size = new System.Drawing.Size(124, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvListCustomer
            // 
            this.dgvListCustomer.AllowUserToAddRows = false;
            this.dgvListCustomer.AllowUserToDeleteRows = false;
            this.dgvListCustomer.AllowUserToOrderColumns = true;
            this.dgvListCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.dgvListCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.dgvListCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCustomer.ColumnHeadersHeight = 30;
            this.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column7,
            this.Column6,
            this.Column5});
            this.dgvListCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCustomer.EnableHeadersVisualStyles = false;
            this.dgvListCustomer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListCustomer.Location = new System.Drawing.Point(23, 67);
            this.dgvListCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListCustomer.Name = "dgvListCustomer";
            this.dgvListCustomer.ReadOnly = true;
            this.dgvListCustomer.RowHeadersVisible = false;
            this.dgvListCustomer.RowHeadersWidth = 51;
            this.dgvListCustomer.RowTemplate.Height = 40;
            this.dgvListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCustomer.Size = new System.Drawing.Size(883, 441);
            this.dgvListCustomer.TabIndex = 1;
            this.dgvListCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCustomer_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "PersonID";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Dob";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Address";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Phone";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "IDCard";
            this.Column5.HeaderText = "CMND";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tabPageEdit.Controls.Add(this.lbName);
            this.tabPageEdit.Controls.Add(this.lbAddress);
            this.tabPageEdit.Controls.Add(this.dtpDob);
            this.tabPageEdit.Controls.Add(this.lbDob);
            this.tabPageEdit.Controls.Add(this.lbGender);
            this.tabPageEdit.Controls.Add(this.tbDob);
            this.tabPageEdit.Controls.Add(this.cbGender);
            this.tabPageEdit.Controls.Add(this.tbGender);
            this.tabPageEdit.Controls.Add(this.lbPhone);
            this.tabPageEdit.Controls.Add(this.tbAddress);
            this.tabPageEdit.Controls.Add(this.tbPhone);
            this.tabPageEdit.Controls.Add(this.lbIDCard);
            this.tabPageEdit.Controls.Add(this.tbIDCard);
            this.tabPageEdit.Controls.Add(this.lbCustomerID);
            this.tabPageEdit.Controls.Add(this.tbName);
            this.tabPageEdit.Controls.Add(this.tbCustomerID);
            this.tabPageEdit.Controls.Add(this.btnCancel);
            this.tabPageEdit.Controls.Add(this.btnSave);
            this.tabPageEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEdit.Size = new System.Drawing.Size(1065, 548);
            this.tabPageEdit.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(62, 131);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 16);
            this.lbName.TabIndex = 118;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbAddress.Location = new System.Drawing.Point(62, 426);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(0, 16);
            this.lbAddress.TabIndex = 135;
            // 
            // dtpDob
            // 
            this.dtpDob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpDob.BorderSize = 0;
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(57, 338);
            this.dtpDob.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtpDob.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpDob.MinimumSize = new System.Drawing.Size(4, 20);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(376, 30);
            this.dtpDob.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dtpDob.TabIndex = 4;
            this.dtpDob.TextColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDob.Value = new System.DateTime(1950, 1, 25, 0, 0, 0, 0);
            this.dtpDob.Enter += new System.EventHandler(this.dtpDob_Enter);
            this.dtpDob.Leave += new System.EventHandler(this.dtpDob_Leave);
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbDob.ForeColor = System.Drawing.Color.DarkGray;
            this.lbDob.Location = new System.Drawing.Point(62, 319);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(67, 16);
            this.lbDob.TabIndex = 134;
            this.lbDob.Text = "Ngày sinh";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbGender.ForeColor = System.Drawing.Color.DarkGray;
            this.lbGender.Location = new System.Drawing.Point(62, 223);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(54, 16);
            this.lbGender.TabIndex = 133;
            this.lbGender.Text = "Giới tính";
            // 
            // tbDob
            // 
            this.tbDob.BorderColor = System.Drawing.Color.DimGray;
            this.tbDob.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbDob.BorderRadius = 6;
            this.tbDob.BorderSize = 1;
            this.tbDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDob.ForeColor = System.Drawing.Color.DarkGray;
            this.tbDob.Location = new System.Drawing.Point(51, 330);
            this.tbDob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDob.Multiline = false;
            this.tbDob.Name = "tbDob";
            this.tbDob.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbDob.PasswordChar = false;
            this.tbDob.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbDob.PlaceholderText = "";
            this.tbDob.Size = new System.Drawing.Size(390, 48);
            this.tbDob.TabIndex = 132;
            this.tbDob.Texts = "";
            this.tbDob.UnderlinedStyle = false;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbGender.ButtonColor = System.Drawing.Color.Silver;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(66, 242);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(360, 33);
            this.cbGender.TabIndex = 3;
            this.cbGender.Enter += new System.EventHandler(this.cbGender_Enter);
            this.cbGender.Leave += new System.EventHandler(this.cbGender_Leave);
            // 
            // tbGender
            // 
            this.tbGender.BorderColor = System.Drawing.Color.DimGray;
            this.tbGender.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbGender.BorderRadius = 6;
            this.tbGender.BorderSize = 1;
            this.tbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbGender.ForeColor = System.Drawing.Color.DarkGray;
            this.tbGender.Location = new System.Drawing.Point(51, 234);
            this.tbGender.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbGender.Multiline = false;
            this.tbGender.Name = "tbGender";
            this.tbGender.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbGender.PasswordChar = false;
            this.tbGender.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbGender.PlaceholderText = "";
            this.tbGender.Size = new System.Drawing.Size(390, 48);
            this.tbGender.TabIndex = 131;
            this.tbGender.Texts = "";
            this.tbGender.UnderlinedStyle = false;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbPhone.Location = new System.Drawing.Point(568, 131);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(0, 16);
            this.lbPhone.TabIndex = 128;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderColor = System.Drawing.Color.DimGray;
            this.tbAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbAddress.BorderRadius = 6;
            this.tbAddress.BorderSize = 1;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAddress.ForeColor = System.Drawing.Color.DimGray;
            this.tbAddress.Location = new System.Drawing.Point(51, 437);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbAddress.Multiline = false;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbAddress.PasswordChar = false;
            this.tbAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbAddress.PlaceholderText = "";
            this.tbAddress.Size = new System.Drawing.Size(390, 48);
            this.tbAddress.TabIndex = 5;
            this.tbAddress.Texts = "Địa chỉ";
            this.tbAddress.UnderlinedStyle = false;
            this.tbAddress.Enter += new System.EventHandler(this.tbAddress_Enter);
            this.tbAddress.Leave += new System.EventHandler(this.tbAddress_Leave);
            // 
            // tbPhone
            // 
            this.tbPhone.BorderColor = System.Drawing.Color.DimGray;
            this.tbPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPhone.BorderRadius = 6;
            this.tbPhone.BorderSize = 1;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPhone.ForeColor = System.Drawing.Color.DimGray;
            this.tbPhone.Location = new System.Drawing.Point(557, 142);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPhone.Multiline = false;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbPhone.PasswordChar = false;
            this.tbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPhone.PlaceholderText = "";
            this.tbPhone.Size = new System.Drawing.Size(390, 48);
            this.tbPhone.TabIndex = 7;
            this.tbPhone.Texts = "SĐT";
            this.tbPhone.UnderlinedStyle = false;
            this.tbPhone.Enter += new System.EventHandler(this.tbPhone_Enter);
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
            // 
            // lbIDCard
            // 
            this.lbIDCard.AutoSize = true;
            this.lbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbIDCard.Location = new System.Drawing.Point(568, 37);
            this.lbIDCard.Name = "lbIDCard";
            this.lbIDCard.Size = new System.Drawing.Size(0, 16);
            this.lbIDCard.TabIndex = 124;
            // 
            // tbIDCard
            // 
            this.tbIDCard.BorderColor = System.Drawing.Color.DimGray;
            this.tbIDCard.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbIDCard.BorderRadius = 6;
            this.tbIDCard.BorderSize = 1;
            this.tbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbIDCard.ForeColor = System.Drawing.Color.DimGray;
            this.tbIDCard.Location = new System.Drawing.Point(557, 48);
            this.tbIDCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbIDCard.Multiline = false;
            this.tbIDCard.Name = "tbIDCard";
            this.tbIDCard.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbIDCard.PasswordChar = false;
            this.tbIDCard.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbIDCard.PlaceholderText = "";
            this.tbIDCard.Size = new System.Drawing.Size(390, 48);
            this.tbIDCard.TabIndex = 6;
            this.tbIDCard.Texts = "CMND";
            this.tbIDCard.UnderlinedStyle = false;
            this.tbIDCard.Enter += new System.EventHandler(this.tbIDCard_Enter);
            this.tbIDCard.Leave += new System.EventHandler(this.tbIDCard_Leave);
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbCustomerID.ForeColor = System.Drawing.Color.Silver;
            this.lbCustomerID.Location = new System.Drawing.Point(62, 37);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lbCustomerID.TabIndex = 120;
            this.lbCustomerID.Text = "Mã khách hàng";
            // 
            // tbName
            // 
            this.tbName.BorderColor = System.Drawing.Color.DimGray;
            this.tbName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbName.BorderRadius = 6;
            this.tbName.BorderSize = 1;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName.ForeColor = System.Drawing.Color.DimGray;
            this.tbName.Location = new System.Drawing.Point(51, 142);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbName.PasswordChar = false;
            this.tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbName.PlaceholderText = "";
            this.tbName.Size = new System.Drawing.Size(390, 48);
            this.tbName.TabIndex = 2;
            this.tbName.Texts = "Họ tên";
            this.tbName.UnderlinedStyle = false;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.BorderColor = System.Drawing.Color.DimGray;
            this.tbCustomerID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbCustomerID.BorderRadius = 6;
            this.tbCustomerID.BorderSize = 1;
            this.tbCustomerID.Enabled = false;
            this.tbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCustomerID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCustomerID.Location = new System.Drawing.Point(51, 48);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCustomerID.Multiline = false;
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbCustomerID.PasswordChar = false;
            this.tbCustomerID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbCustomerID.PlaceholderText = "";
            this.tbCustomerID.Size = new System.Drawing.Size(390, 48);
            this.tbCustomerID.TabIndex = 1;
            this.tbCustomerID.Texts = "Mã khách hàng";
            this.tbCustomerID.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(169)))), ((int)(((byte)(29)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(788, 401);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnCancel.Size = new System.Drawing.Size(201, 84);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(169)))), ((int)(((byte)(29)))));
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(169)))), ((int)(((byte)(29)))));
            this.btnSave.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(543, 401);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnSave.Size = new System.Drawing.Size(200, 84);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(169)))), ((int)(((byte)(29)))));
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageList);
            this.tabControl.Controls.Add(this.tabPageEdit);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1073, 577);
            this.tabControl.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 57);
            this.panel1.TabIndex = 17;
            // 
            // FormQL_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1073, 634);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQL_KhachHang";
            this.Text = "FormQL_KhachHang";
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).EndInit();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC btnDelete;
        private ePOSOne.btnProduct.Button_WOC btnUpdate;
        private ePOSOne.btnProduct.Button_WOC btnAdd;
        private ePOSOne.btnProduct.Button_WOC btnCancel;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbRecord;
        private NoteWrapper.FlatCombobox cbSearch;
        private Resources.RJTextBox tbAddress;
        private System.Windows.Forms.Label lbPhone;
        private Resources.RJTextBox tbPhone;
        private System.Windows.Forms.Label lbIDCard;
        private Resources.RJTextBox tbIDCard;
        private System.Windows.Forms.Label lbCustomerID;
        private Resources.RJTextBox tbName;
        private System.Windows.Forms.Label lbName;
        private Resources.RJTextBox tbCustomerID;
        private CustomControls.RJDatePicker dtpDob;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.Label lbGender;
        private Resources.RJTextBox tbDob;
        private NoteWrapper.FlatCombobox cbGender;
        private Resources.RJTextBox tbGender;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.DataGridView dgvListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}