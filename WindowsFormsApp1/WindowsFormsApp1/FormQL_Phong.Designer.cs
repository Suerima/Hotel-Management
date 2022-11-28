namespace WindowsFormsApp1
{
    partial class FormQL_Phong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQL_Phong));
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.cbSearch = new NoteWrapper.FlatCombobox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbRecord = new System.Windows.Forms.Label();
            this.btnAdd = new ePOSOne.btnProduct.Button_WOC();
            this.btnDelete = new ePOSOne.btnProduct.Button_WOC();
            this.btnUpdate = new ePOSOne.btnProduct.Button_WOC();
            this.dgvListRoom = new System.Windows.Forms.DataGridView();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbCountImage = new System.Windows.Forms.Label();
            this.sPanel1 = new WindowsFormsApp1.Resources.SPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeft = new ePOSOne.btnProduct.Button_WOC();
            this.btnRight = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbAmenities = new System.Windows.Forms.CheckedListBox();
            this.lbBed = new System.Windows.Forms.Label();
            this.cbTypeBed = new NoteWrapper.FlatCombobox();
            this.tbBed = new WindowsFormsApp1.Resources.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPerson = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tbRoomID = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbPrice = new WindowsFormsApp1.Resources.RJTextBox();
            this.cbPerson = new NoteWrapper.FlatCombobox();
            this.tbPerson = new WindowsFormsApp1.Resources.RJTextBox();
            this.cbType = new NoteWrapper.FlatCombobox();
            this.tbType = new WindowsFormsApp1.Resources.RJTextBox();
            this.btnCancel = new ePOSOne.btnProduct.Button_WOC();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).BeginInit();
            this.tabPageEdit.SuspendLayout();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageList
            // 
            this.tabPageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tabPageList.Controls.Add(this.cbSearch);
            this.tabPageList.Controls.Add(this.label9);
            this.tabPageList.Controls.Add(this.tbSearch);
            this.tabPageList.Controls.Add(this.lbRecord);
            this.tabPageList.Controls.Add(this.btnAdd);
            this.tabPageList.Controls.Add(this.btnDelete);
            this.tabPageList.Controls.Add(this.btnUpdate);
            this.tabPageList.Controls.Add(this.dgvListRoom);
            this.tabPageList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageList.Location = new System.Drawing.Point(4, 25);
            this.tabPageList.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageList.Size = new System.Drawing.Size(1501, 839);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Danh sách phòng";
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.cbSearch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            " Mã phòng",
            " Loại phòng",
            " Số người",
            " Giá",
            " Tình trạng"});
            this.cbSearch.Location = new System.Drawing.Point(23, 16);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(195, 33);
            this.cbSearch.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(232, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(493, 16);
            this.label9.TabIndex = 80;
            this.label9.Text = "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺" +
    "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺" +
    "⎺";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbSearch.Location = new System.Drawing.Point(235, 19);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(544, 23);
            this.tbSearch.TabIndex = 79;
            this.tbSearch.Text = "Tìm kiếm";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRecord.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbRecord.Location = new System.Drawing.Point(920, 24);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(106, 25);
            this.lbRecord.TabIndex = 78;
            this.lbRecord.Text = "Records: 0";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1349, 101);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnAdd.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnAdd.Size = new System.Drawing.Size(124, 41);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1349, 199);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnDelete.Size = new System.Drawing.Size(124, 41);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnUpdate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1349, 150);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnUpdate.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnUpdate.Size = new System.Drawing.Size(124, 41);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvListRoom
            // 
            this.dgvListRoom.AllowUserToAddRows = false;
            this.dgvListRoom.AllowUserToDeleteRows = false;
            this.dgvListRoom.AllowUserToOrderColumns = true;
            this.dgvListRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvListRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvListRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dgvListRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(131)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvListRoom.ColumnHeadersHeight = 30;
            this.dgvListRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvListRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle36.Format = "N0";
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListRoom.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvListRoom.EnableHeadersVisualStyles = false;
            this.dgvListRoom.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListRoom.Location = new System.Drawing.Point(23, 67);
            this.dgvListRoom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListRoom.Name = "dgvListRoom";
            this.dgvListRoom.ReadOnly = true;
            this.dgvListRoom.RowHeadersVisible = false;
            this.dgvListRoom.RowHeadersWidth = 51;
            this.dgvListRoom.RowTemplate.Height = 40;
            this.dgvListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListRoom.Size = new System.Drawing.Size(1302, 747);
            this.dgvListRoom.TabIndex = 1;
            this.dgvListRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListRoom_CellClick);
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tabPageEdit.Controls.Add(this.linkLabel1);
            this.tabPageEdit.Controls.Add(this.lbCountImage);
            this.tabPageEdit.Controls.Add(this.sPanel1);
            this.tabPageEdit.Controls.Add(this.btnLeft);
            this.tabPageEdit.Controls.Add(this.btnRight);
            this.tabPageEdit.Controls.Add(this.groupBox1);
            this.tabPageEdit.Controls.Add(this.lbBed);
            this.tabPageEdit.Controls.Add(this.cbTypeBed);
            this.tabPageEdit.Controls.Add(this.tbBed);
            this.tabPageEdit.Controls.Add(this.label2);
            this.tabPageEdit.Controls.Add(this.lbPrice);
            this.tabPageEdit.Controls.Add(this.lbPerson);
            this.tabPageEdit.Controls.Add(this.lbType);
            this.tabPageEdit.Controls.Add(this.tbRoomID);
            this.tabPageEdit.Controls.Add(this.tbPrice);
            this.tabPageEdit.Controls.Add(this.cbPerson);
            this.tabPageEdit.Controls.Add(this.tbPerson);
            this.tabPageEdit.Controls.Add(this.cbType);
            this.tabPageEdit.Controls.Add(this.tbType);
            this.tabPageEdit.Controls.Add(this.btnCancel);
            this.tabPageEdit.Controls.Add(this.btnSave);
            this.tabPageEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tabPageEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEdit.Size = new System.Drawing.Size(1501, 839);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "EDIT";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(615, 525);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 23);
            this.linkLabel1.TabIndex = 173;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Thêm ảnh";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbCountImage
            // 
            this.lbCountImage.AutoSize = true;
            this.lbCountImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbCountImage.Location = new System.Drawing.Point(551, 160);
            this.lbCountImage.Name = "lbCountImage";
            this.lbCountImage.Size = new System.Drawing.Size(0, 23);
            this.lbCountImage.TabIndex = 172;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.pictureBox1);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(619, 29);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(600, 483);
            this.sPanel1.TabIndex = 171;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnLeft.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLeft.Location = new System.Drawing.Point(524, 232);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnLeft.OnHoverButtonColor = System.Drawing.Color.Empty;
            this.btnLeft.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnLeft.Size = new System.Drawing.Size(70, 64);
            this.btnLeft.TabIndex = 170;
            this.btnLeft.Text = "<";
            this.btnLeft.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnRight.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRight.Location = new System.Drawing.Point(1245, 232);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnRight.OnHoverButtonColor = System.Drawing.Color.Empty;
            this.btnRight.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnRight.Size = new System.Drawing.Size(70, 64);
            this.btnRight.TabIndex = 169;
            this.btnRight.Text = ">";
            this.btnRight.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbAmenities);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(32, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 227);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiện nghi";
            // 
            // clbAmenities
            // 
            this.clbAmenities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.clbAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAmenities.CheckOnClick = true;
            this.clbAmenities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clbAmenities.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.clbAmenities.FormattingEnabled = true;
            this.clbAmenities.Items.AddRange(new object[] {
            "Hướng ra biển",
            "Hướng ra phố",
            "Bồn tắm",
            "Hồ bơi riêng",
            "Ban công",
            "Máy pha cafe",
            "Hệ thống sưởi"});
            this.clbAmenities.Location = new System.Drawing.Point(23, 32);
            this.clbAmenities.Name = "clbAmenities";
            this.clbAmenities.Size = new System.Drawing.Size(337, 200);
            this.clbAmenities.TabIndex = 166;
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbBed.ForeColor = System.Drawing.Color.DarkGray;
            this.lbBed.Location = new System.Drawing.Point(41, 301);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(77, 16);
            this.lbBed.TabIndex = 165;
            this.lbBed.Text = "Loại giường";
            // 
            // cbTypeBed
            // 
            this.cbTypeBed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbTypeBed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbTypeBed.ButtonColor = System.Drawing.Color.Silver;
            this.cbTypeBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTypeBed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbTypeBed.FormattingEnabled = true;
            this.cbTypeBed.Items.AddRange(new object[] {
            "Hai giường đơn",
            "Giường đôi"});
            this.cbTypeBed.Location = new System.Drawing.Point(46, 320);
            this.cbTypeBed.Name = "cbTypeBed";
            this.cbTypeBed.Size = new System.Drawing.Size(360, 33);
            this.cbTypeBed.TabIndex = 163;
            this.cbTypeBed.Enter += new System.EventHandler(this.cbTypeBed_Enter);
            this.cbTypeBed.Leave += new System.EventHandler(this.cbTypeBed_Leave);
            // 
            // tbBed
            // 
            this.tbBed.BorderColor = System.Drawing.Color.DimGray;
            this.tbBed.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbBed.BorderRadius = 6;
            this.tbBed.BorderSize = 1;
            this.tbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBed.ForeColor = System.Drawing.Color.DarkGray;
            this.tbBed.Location = new System.Drawing.Point(30, 312);
            this.tbBed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbBed.Multiline = false;
            this.tbBed.Name = "tbBed";
            this.tbBed.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbBed.PasswordChar = false;
            this.tbBed.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbBed.PlaceholderText = "";
            this.tbBed.Size = new System.Drawing.Size(390, 48);
            this.tbBed.TabIndex = 164;
            this.tbBed.Texts = "";
            this.tbBed.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 161;
            this.label2.Text = "Mã phòng";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lbPrice.Location = new System.Drawing.Point(41, 637);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(0, 16);
            this.lbPrice.TabIndex = 157;
            // 
            // lbPerson
            // 
            this.lbPerson.AutoSize = true;
            this.lbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbPerson.ForeColor = System.Drawing.Color.DarkGray;
            this.lbPerson.Location = new System.Drawing.Point(43, 213);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(71, 16);
            this.lbPerson.TabIndex = 155;
            this.lbPerson.Text = "Số người ở";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbType.ForeColor = System.Drawing.Color.DarkGray;
            this.lbType.Location = new System.Drawing.Point(43, 124);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(74, 16);
            this.lbType.TabIndex = 152;
            this.lbType.Text = "Loại phòng";
            // 
            // tbRoomID
            // 
            this.tbRoomID.BorderColor = System.Drawing.Color.DimGray;
            this.tbRoomID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbRoomID.BorderRadius = 6;
            this.tbRoomID.BorderSize = 1;
            this.tbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbRoomID.ForeColor = System.Drawing.Color.DimGray;
            this.tbRoomID.Location = new System.Drawing.Point(32, 29);
            this.tbRoomID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbRoomID.Multiline = true;
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbRoomID.PasswordChar = false;
            this.tbRoomID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbRoomID.PlaceholderText = "";
            this.tbRoomID.Size = new System.Drawing.Size(390, 48);
            this.tbRoomID.TabIndex = 160;
            this.tbRoomID.Texts = "";
            this.tbRoomID.UnderlinedStyle = false;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.DimGray;
            this.tbPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPrice.BorderRadius = 6;
            this.tbPrice.BorderSize = 1;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbPrice.Location = new System.Drawing.Point(32, 647);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbPrice.PasswordChar = false;
            this.tbPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.Size = new System.Drawing.Size(390, 48);
            this.tbPrice.TabIndex = 156;
            this.tbPrice.Texts = "Giá phòng";
            this.tbPrice.UnderlinedStyle = false;
            this.tbPrice.Enter += new System.EventHandler(this.tbPrice_Enter);
            this.tbPrice.Leave += new System.EventHandler(this.tbPrice_Leave);
            // 
            // cbPerson
            // 
            this.cbPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbPerson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbPerson.ButtonColor = System.Drawing.Color.Silver;
            this.cbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPerson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cbPerson.Location = new System.Drawing.Point(48, 232);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(360, 33);
            this.cbPerson.TabIndex = 153;
            this.cbPerson.Enter += new System.EventHandler(this.cbPerson_Enter);
            this.cbPerson.Leave += new System.EventHandler(this.cbPerson_Leave);
            // 
            // tbPerson
            // 
            this.tbPerson.BorderColor = System.Drawing.Color.DimGray;
            this.tbPerson.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPerson.BorderRadius = 6;
            this.tbPerson.BorderSize = 1;
            this.tbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPerson.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPerson.Location = new System.Drawing.Point(32, 224);
            this.tbPerson.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPerson.Multiline = false;
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbPerson.PasswordChar = false;
            this.tbPerson.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPerson.PlaceholderText = "";
            this.tbPerson.Size = new System.Drawing.Size(390, 48);
            this.tbPerson.TabIndex = 154;
            this.tbPerson.Texts = "";
            this.tbPerson.UnderlinedStyle = false;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbType.ButtonColor = System.Drawing.Color.Silver;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Standard",
            "Superior",
            "Deluxe"});
            this.cbType.Location = new System.Drawing.Point(48, 143);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(360, 33);
            this.cbType.TabIndex = 150;
            this.cbType.Enter += new System.EventHandler(this.cbType_Enter);
            this.cbType.Leave += new System.EventHandler(this.cbType_Leave);
            // 
            // tbType
            // 
            this.tbType.BorderColor = System.Drawing.Color.DimGray;
            this.tbType.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbType.BorderRadius = 6;
            this.tbType.BorderSize = 1;
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbType.ForeColor = System.Drawing.Color.DarkGray;
            this.tbType.Location = new System.Drawing.Point(32, 135);
            this.tbType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbType.Multiline = false;
            this.tbType.Name = "tbType";
            this.tbType.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbType.PasswordChar = false;
            this.tbType.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbType.PlaceholderText = "";
            this.tbType.Size = new System.Drawing.Size(390, 48);
            this.tbType.TabIndex = 151;
            this.tbType.Texts = "";
            this.tbType.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancel.Location = new System.Drawing.Point(970, 573);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnCancel.Size = new System.Drawing.Size(235, 70);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnSave.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSave.Location = new System.Drawing.Point(660, 573);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnSave.Size = new System.Drawing.Size(235, 70);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
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
            this.tabControl.Size = new System.Drawing.Size(1509, 868);
            this.tabControl.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "THÔNG TIN PHÒNG";
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
            this.panel1.Size = new System.Drawing.Size(1509, 57);
            this.panel1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "RoomID";
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Type";
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Person";
            this.Column3.HeaderText = "Số người ở";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Status";
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FormQL_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1509, 925);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQL_Phong";
            this.Text = "FormQL_Phong";
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoom)).EndInit();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.sPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvListRoom;
        private ePOSOne.btnProduct.Button_WOC btnUpdate;
        private ePOSOne.btnProduct.Button_WOC btnDelete;
        private ePOSOne.btnProduct.Button_WOC btnCancel;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private ePOSOne.btnProduct.Button_WOC btnAdd;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label9;
        private NoteWrapper.FlatCombobox cbSearch;
        private System.Windows.Forms.Label lbType;
        private NoteWrapper.FlatCombobox cbType;
        private Resources.RJTextBox tbType;
        private System.Windows.Forms.Label lbPerson;
        private NoteWrapper.FlatCombobox cbPerson;
        private Resources.RJTextBox tbPerson;
        private System.Windows.Forms.Label lbPrice;
        private Resources.RJTextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private Resources.RJTextBox tbRoomID;
        private System.Windows.Forms.Label lbBed;
        private NoteWrapper.FlatCombobox cbTypeBed;
        private Resources.RJTextBox tbBed;
        private System.Windows.Forms.CheckedListBox clbAmenities;
        private System.Windows.Forms.GroupBox groupBox1;
        private Resources.SPanel sPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnLeft;
        private ePOSOne.btnProduct.Button_WOC btnRight;
        private System.Windows.Forms.Label lbCountImage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}