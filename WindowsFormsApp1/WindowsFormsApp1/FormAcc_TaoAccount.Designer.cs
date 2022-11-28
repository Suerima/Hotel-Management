namespace WindowsFormsApp1
{
    partial class FormAcc_TaoAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbIDCard = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbAuthority = new System.Windows.Forms.Label();
            this.dtpDob = new WindowsFormsApp1.CustomControls.RJDatePicker();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbDob = new System.Windows.Forms.Label();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbIDCard = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.tbxDob = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxFullname = new WindowsFormsApp1.Resources.RJTextBox();
            this.cbGender = new NoteWrapper.FlatCombobox();
            this.cbAuthority = new NoteWrapper.FlatCombobox();
            this.tbxAuthority = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxConfirm = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxPassword = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxEmail = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxUsername = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxIDCard = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxPhone = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxAddress = new WindowsFormsApp1.Resources.RJTextBox();
            this.tbxGender = new WindowsFormsApp1.Resources.RJTextBox();
            this.btnReset = new ePOSOne.btnProduct.Button_WOC();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new ePOSOne.btnProduct.Button_WOC();
            this.cbSearch = new NoteWrapper.FlatCombobox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvListAccount = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAuthori = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 57);
            this.panel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "TẠO TÀI KHOẢN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName.ForeColor = System.Drawing.Color.Transparent;
            this.tbName.Location = new System.Drawing.Point(20, 10);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(357, 23);
            this.tbName.TabIndex = 1;
            // 
            // tbBirthday
            // 
            this.tbBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBirthday.ForeColor = System.Drawing.Color.Transparent;
            this.tbBirthday.Location = new System.Drawing.Point(20, 10);
            this.tbBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(357, 23);
            this.tbBirthday.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAddress.ForeColor = System.Drawing.Color.Transparent;
            this.tbAddress.Location = new System.Drawing.Point(20, 10);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(357, 23);
            this.tbAddress.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPhone.ForeColor = System.Drawing.Color.Transparent;
            this.tbPhone.Location = new System.Drawing.Point(20, 10);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(357, 23);
            this.tbPhone.TabIndex = 4;
            // 
            // tbIDCard
            // 
            this.tbIDCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbIDCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbIDCard.ForeColor = System.Drawing.Color.Transparent;
            this.tbIDCard.Location = new System.Drawing.Point(20, 10);
            this.tbIDCard.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDCard.Name = "tbIDCard";
            this.tbIDCard.Size = new System.Drawing.Size(357, 23);
            this.tbIDCard.TabIndex = 6;
            // 
            // tbGender
            // 
            this.tbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbGender.ForeColor = System.Drawing.Color.Transparent;
            this.tbGender.Location = new System.Drawing.Point(20, 10);
            this.tbGender.Margin = new System.Windows.Forms.Padding(4);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(357, 23);
            this.tbGender.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 577);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tabPage1.Controls.Add(this.lbAuthority);
            this.tabPage1.Controls.Add(this.dtpDob);
            this.tabPage1.Controls.Add(this.lbUsername);
            this.tabPage1.Controls.Add(this.lbDob);
            this.tabPage1.Controls.Add(this.lbConfirm);
            this.tabPage1.Controls.Add(this.lbPassword);
            this.tabPage1.Controls.Add(this.lbIDCard);
            this.tabPage1.Controls.Add(this.lbPhone);
            this.tabPage1.Controls.Add(this.lbAddress);
            this.tabPage1.Controls.Add(this.lbEmail);
            this.tabPage1.Controls.Add(this.lbGender);
            this.tabPage1.Controls.Add(this.lbFullname);
            this.tabPage1.Controls.Add(this.tbxDob);
            this.tabPage1.Controls.Add(this.tbxFullname);
            this.tabPage1.Controls.Add(this.cbGender);
            this.tabPage1.Controls.Add(this.cbAuthority);
            this.tabPage1.Controls.Add(this.tbxAuthority);
            this.tabPage1.Controls.Add(this.tbxConfirm);
            this.tabPage1.Controls.Add(this.tbxPassword);
            this.tabPage1.Controls.Add(this.tbxEmail);
            this.tabPage1.Controls.Add(this.tbxUsername);
            this.tabPage1.Controls.Add(this.tbxIDCard);
            this.tabPage1.Controls.Add(this.tbxPhone);
            this.tabPage1.Controls.Add(this.tbxAddress);
            this.tabPage1.Controls.Add(this.tbxGender);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo tài khoản";
            // 
            // lbAuthority
            // 
            this.lbAuthority.AutoSize = true;
            this.lbAuthority.ForeColor = System.Drawing.Color.DarkGray;
            this.lbAuthority.Location = new System.Drawing.Point(556, 32);
            this.lbAuthority.Name = "lbAuthority";
            this.lbAuthority.Size = new System.Drawing.Size(54, 16);
            this.lbAuthority.TabIndex = 127;
            this.lbAuthority.Text = "Chức vụ";
            // 
            // dtpDob
            // 
            this.dtpDob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpDob.BorderSize = 0;
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(32, 212);
            this.dtpDob.MaxDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtpDob.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpDob.MinimumSize = new System.Drawing.Size(4, 20);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(376, 30);
            this.dtpDob.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dtpDob.TabIndex = 3;
            this.dtpDob.TextColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDob.Value = new System.DateTime(1950, 1, 25, 0, 0, 0, 0);
            this.dtpDob.Enter += new System.EventHandler(this.dtpDob_Enter);
            this.dtpDob.Leave += new System.EventHandler(this.dtpDob_Leave);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbUsername.Location = new System.Drawing.Point(556, 108);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 16);
            this.lbUsername.TabIndex = 126;
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.ForeColor = System.Drawing.Color.Silver;
            this.lbDob.Location = new System.Drawing.Point(37, 193);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(67, 16);
            this.lbDob.TabIndex = 125;
            this.lbDob.Text = "Ngày sinh";
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbConfirm.Location = new System.Drawing.Point(556, 367);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(0, 16);
            this.lbConfirm.TabIndex = 124;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbPassword.Location = new System.Drawing.Point(556, 281);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(0, 16);
            this.lbPassword.TabIndex = 123;
            // 
            // lbIDCard
            // 
            this.lbIDCard.AutoSize = true;
            this.lbIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbIDCard.Location = new System.Drawing.Point(38, 448);
            this.lbIDCard.Name = "lbIDCard";
            this.lbIDCard.Size = new System.Drawing.Size(0, 16);
            this.lbIDCard.TabIndex = 122;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbPhone.Location = new System.Drawing.Point(38, 367);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(0, 16);
            this.lbPhone.TabIndex = 121;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbAddress.Location = new System.Drawing.Point(38, 281);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(0, 16);
            this.lbAddress.TabIndex = 120;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbEmail.Location = new System.Drawing.Point(556, 193);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 16);
            this.lbEmail.TabIndex = 119;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.ForeColor = System.Drawing.Color.Silver;
            this.lbGender.Location = new System.Drawing.Point(37, 109);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(54, 16);
            this.lbGender.TabIndex = 117;
            this.lbGender.Text = "Giới tính";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbFullname.Location = new System.Drawing.Point(37, 25);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(0, 16);
            this.lbFullname.TabIndex = 116;
            // 
            // tbxDob
            // 
            this.tbxDob.BorderColor = System.Drawing.Color.DimGray;
            this.tbxDob.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxDob.BorderRadius = 6;
            this.tbxDob.BorderSize = 1;
            this.tbxDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxDob.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxDob.Location = new System.Drawing.Point(26, 204);
            this.tbxDob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxDob.Multiline = false;
            this.tbxDob.Name = "tbxDob";
            this.tbxDob.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxDob.PasswordChar = false;
            this.tbxDob.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDob.PlaceholderText = "";
            this.tbxDob.Size = new System.Drawing.Size(390, 48);
            this.tbxDob.TabIndex = 111;
            this.tbxDob.Texts = "";
            this.tbxDob.UnderlinedStyle = false;
            // 
            // tbxFullname
            // 
            this.tbxFullname.BorderColor = System.Drawing.Color.DimGray;
            this.tbxFullname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxFullname.BorderRadius = 6;
            this.tbxFullname.BorderSize = 1;
            this.tbxFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxFullname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxFullname.Location = new System.Drawing.Point(26, 36);
            this.tbxFullname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxFullname.Multiline = false;
            this.tbxFullname.Name = "tbxFullname";
            this.tbxFullname.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxFullname.PasswordChar = false;
            this.tbxFullname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxFullname.PlaceholderText = "";
            this.tbxFullname.Size = new System.Drawing.Size(390, 48);
            this.tbxFullname.TabIndex = 1;
            this.tbxFullname.Texts = "Họ tên";
            this.tbxFullname.UnderlinedStyle = false;
            this.tbxFullname.Enter += new System.EventHandler(this.tbxFullname_Enter);
            this.tbxFullname.Leave += new System.EventHandler(this.tbxFullname_Leave);
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
            this.cbGender.Location = new System.Drawing.Point(41, 127);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(360, 33);
            this.cbGender.TabIndex = 2;
            this.cbGender.Enter += new System.EventHandler(this.cbGender_Enter);
            this.cbGender.Leave += new System.EventHandler(this.cbGender_Leave);
            // 
            // cbAuthority
            // 
            this.cbAuthority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbAuthority.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.cbAuthority.ButtonColor = System.Drawing.Color.Silver;
            this.cbAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbAuthority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbAuthority.Location = new System.Drawing.Point(561, 51);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(360, 33);
            this.cbAuthority.TabIndex = 7;
            this.cbAuthority.Enter += new System.EventHandler(this.cbAuthority_Enter);
            this.cbAuthority.Leave += new System.EventHandler(this.cbAuthority_Leave);
            // 
            // tbxAuthority
            // 
            this.tbxAuthority.BorderColor = System.Drawing.Color.DimGray;
            this.tbxAuthority.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxAuthority.BorderRadius = 6;
            this.tbxAuthority.BorderSize = 1;
            this.tbxAuthority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAuthority.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxAuthority.Location = new System.Drawing.Point(545, 43);
            this.tbxAuthority.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxAuthority.Multiline = false;
            this.tbxAuthority.Name = "tbxAuthority";
            this.tbxAuthority.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxAuthority.PasswordChar = false;
            this.tbxAuthority.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxAuthority.PlaceholderText = "";
            this.tbxAuthority.Size = new System.Drawing.Size(390, 48);
            this.tbxAuthority.TabIndex = 104;
            this.tbxAuthority.Texts = "";
            this.tbxAuthority.UnderlinedStyle = false;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.BorderColor = System.Drawing.Color.DimGray;
            this.tbxConfirm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxConfirm.BorderRadius = 6;
            this.tbxConfirm.BorderSize = 1;
            this.tbxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.tbxConfirm.Location = new System.Drawing.Point(545, 378);
            this.tbxConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxConfirm.Multiline = false;
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxConfirm.PasswordChar = false;
            this.tbxConfirm.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxConfirm.PlaceholderText = "";
            this.tbxConfirm.Size = new System.Drawing.Size(390, 48);
            this.tbxConfirm.TabIndex = 11;
            this.tbxConfirm.Texts = "Xác nhận mật khẩu";
            this.tbxConfirm.UnderlinedStyle = false;
            this.tbxConfirm.Enter += new System.EventHandler(this.tbxConfirm_Enter);
            this.tbxConfirm.Leave += new System.EventHandler(this.tbxConfirm_Leave);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderColor = System.Drawing.Color.DimGray;
            this.tbxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxPassword.BorderRadius = 6;
            this.tbxPassword.BorderSize = 1;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPassword.Location = new System.Drawing.Point(545, 292);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxPassword.PasswordChar = false;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxPassword.PlaceholderText = "";
            this.tbxPassword.Size = new System.Drawing.Size(390, 48);
            this.tbxPassword.TabIndex = 10;
            this.tbxPassword.Texts = "Mật khẩu mới";
            this.tbxPassword.UnderlinedStyle = false;
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BorderColor = System.Drawing.Color.DimGray;
            this.tbxEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxEmail.BorderRadius = 6;
            this.tbxEmail.BorderSize = 1;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.tbxEmail.Location = new System.Drawing.Point(545, 204);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxEmail.Multiline = false;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxEmail.PasswordChar = false;
            this.tbxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxEmail.PlaceholderText = "";
            this.tbxEmail.Size = new System.Drawing.Size(390, 48);
            this.tbxEmail.TabIndex = 9;
            this.tbxEmail.Texts = "Email";
            this.tbxEmail.UnderlinedStyle = false;
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Enter);
            this.tbxEmail.Leave += new System.EventHandler(this.tbxEmail_Leave);
            // 
            // tbxUsername
            // 
            this.tbxUsername.BorderColor = System.Drawing.Color.DimGray;
            this.tbxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxUsername.BorderRadius = 6;
            this.tbxUsername.BorderSize = 1;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUsername.Location = new System.Drawing.Point(545, 119);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxUsername.PasswordChar = false;
            this.tbxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUsername.PlaceholderText = "";
            this.tbxUsername.Size = new System.Drawing.Size(390, 48);
            this.tbxUsername.TabIndex = 8;
            this.tbxUsername.Texts = "Tên tài khoản";
            this.tbxUsername.UnderlinedStyle = false;
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // tbxIDCard
            // 
            this.tbxIDCard.BorderColor = System.Drawing.Color.DimGray;
            this.tbxIDCard.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxIDCard.BorderRadius = 6;
            this.tbxIDCard.BorderSize = 1;
            this.tbxIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxIDCard.ForeColor = System.Drawing.Color.DimGray;
            this.tbxIDCard.Location = new System.Drawing.Point(26, 459);
            this.tbxIDCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxIDCard.Multiline = false;
            this.tbxIDCard.Name = "tbxIDCard";
            this.tbxIDCard.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxIDCard.PasswordChar = false;
            this.tbxIDCard.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxIDCard.PlaceholderText = "";
            this.tbxIDCard.Size = new System.Drawing.Size(390, 48);
            this.tbxIDCard.TabIndex = 6;
            this.tbxIDCard.Texts = "CMND";
            this.tbxIDCard.UnderlinedStyle = false;
            this.tbxIDCard.Enter += new System.EventHandler(this.tbxIDCard_Enter);
            this.tbxIDCard.Leave += new System.EventHandler(this.tbxIDCard_Leave);
            // 
            // tbxPhone
            // 
            this.tbxPhone.BorderColor = System.Drawing.Color.DimGray;
            this.tbxPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxPhone.BorderRadius = 6;
            this.tbxPhone.BorderSize = 1;
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxPhone.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPhone.Location = new System.Drawing.Point(26, 378);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxPhone.Multiline = false;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxPhone.PasswordChar = false;
            this.tbxPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPhone.PlaceholderText = "";
            this.tbxPhone.Size = new System.Drawing.Size(390, 48);
            this.tbxPhone.TabIndex = 5;
            this.tbxPhone.Texts = "SĐT";
            this.tbxPhone.UnderlinedStyle = false;
            this.tbxPhone.Enter += new System.EventHandler(this.tbxPhone_Enter);
            this.tbxPhone.Leave += new System.EventHandler(this.tbxPhone_Leave);
            // 
            // tbxAddress
            // 
            this.tbxAddress.BorderColor = System.Drawing.Color.DimGray;
            this.tbxAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxAddress.BorderRadius = 6;
            this.tbxAddress.BorderSize = 1;
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAddress.ForeColor = System.Drawing.Color.DimGray;
            this.tbxAddress.Location = new System.Drawing.Point(26, 292);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxAddress.Multiline = false;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxAddress.PasswordChar = false;
            this.tbxAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxAddress.PlaceholderText = "";
            this.tbxAddress.Size = new System.Drawing.Size(390, 48);
            this.tbxAddress.TabIndex = 4;
            this.tbxAddress.Texts = "Địa chỉ";
            this.tbxAddress.UnderlinedStyle = false;
            this.tbxAddress.Enter += new System.EventHandler(this.tbxAddress_Enter);
            this.tbxAddress.Leave += new System.EventHandler(this.tbxAddress_Leave);
            // 
            // tbxGender
            // 
            this.tbxGender.BorderColor = System.Drawing.Color.DimGray;
            this.tbxGender.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxGender.BorderRadius = 6;
            this.tbxGender.BorderSize = 1;
            this.tbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxGender.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxGender.Location = new System.Drawing.Point(26, 119);
            this.tbxGender.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxGender.Multiline = false;
            this.tbxGender.Name = "tbxGender";
            this.tbxGender.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tbxGender.PasswordChar = false;
            this.tbxGender.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxGender.PlaceholderText = "";
            this.tbxGender.Size = new System.Drawing.Size(390, 48);
            this.tbxGender.TabIndex = 95;
            this.tbxGender.Texts = "";
            this.tbxGender.UnderlinedStyle = false;
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnReset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(746, 459);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnReset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnReset.Size = new System.Drawing.Size(189, 65);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnSave.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(545, 459);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnSave.Size = new System.Drawing.Size(183, 65);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.cbSearch);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Controls.Add(this.dgvListAccount);
            this.tabPage2.Controls.Add(this.lbAuthori);
            this.tabPage2.Controls.Add(this.lbUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(824, 24);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(104)))));
            this.btnDelete.Size = new System.Drawing.Size(124, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            " Họ tên",
            " SĐT",
            " Chức vụ"});
            this.cbSearch.Location = new System.Drawing.Point(32, 24);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(195, 33);
            this.cbSearch.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(241, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(460, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺" +
    "⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbSearch.Location = new System.Drawing.Point(244, 27);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(544, 25);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.Text = "Tìm kiếm";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // dgvListAccount
            // 
            this.dgvListAccount.AllowUserToAddRows = false;
            this.dgvListAccount.AllowUserToDeleteRows = false;
            this.dgvListAccount.AllowUserToOrderColumns = true;
            this.dgvListAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvListAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvListAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.dgvListAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(131)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvListAccount.ColumnHeadersHeight = 30;
            this.dgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            this.dgvListAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListAccount.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvListAccount.EnableHeadersVisualStyles = false;
            this.dgvListAccount.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvListAccount.Location = new System.Drawing.Point(32, 93);
            this.dgvListAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListAccount.Name = "dgvListAccount";
            this.dgvListAccount.ReadOnly = true;
            this.dgvListAccount.RowHeadersVisible = false;
            this.dgvListAccount.RowHeadersWidth = 51;
            this.dgvListAccount.RowTemplate.Height = 40;
            this.dgvListAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAccount.Size = new System.Drawing.Size(916, 427);
            this.dgvListAccount.TabIndex = 2;
            this.dgvListAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListAccount_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Họ tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Username";
            this.Column2.HeaderText = "Tài khoản";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Authority";
            this.Column7.HeaderText = "Chức vụ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lbAuthori
            // 
            this.lbAuthori.AutoSize = true;
            this.lbAuthori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbAuthori.Location = new System.Drawing.Point(929, 49);
            this.lbAuthori.Name = "lbAuthori";
            this.lbAuthori.Size = new System.Drawing.Size(44, 16);
            this.lbAuthori.TabIndex = 21;
            this.lbAuthori.Text = "label1";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbUser.Location = new System.Drawing.Point(929, 25);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(44, 16);
            this.lbUser.TabIndex = 20;
            this.lbUser.Text = "label1";
            // 
            // FormAcc_TaoAccount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(989, 634);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAcc_TaoAccount";
            this.Text = "FormAcc_BaoMat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbIDCard;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private ePOSOne.btnProduct.Button_WOC btnReset;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private Resources.RJTextBox tbxIDCard;
        private Resources.RJTextBox tbxPhone;
        private Resources.RJTextBox tbxAddress;
        private Resources.RJTextBox tbxGender;
        private Resources.RJTextBox tbxConfirm;
        private Resources.RJTextBox tbxPassword;
        private Resources.RJTextBox tbxEmail;
        private Resources.RJTextBox tbxUsername;
        private Resources.RJTextBox tbxAuthority;
        private NoteWrapper.FlatCombobox cbAuthority;
        private NoteWrapper.FlatCombobox cbGender;
        private Resources.RJTextBox tbxFullname;
        private System.Windows.Forms.Label lbFullname;
        private Resources.RJTextBox tbxDob;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbIDCard;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbUsername;
        private CustomControls.RJDatePicker dtpDob;
        private System.Windows.Forms.DataGridView dgvListAccount;
        private System.Windows.Forms.Label lbAuthority;
        private ePOSOne.btnProduct.Button_WOC btnDelete;
        private NoteWrapper.FlatCombobox cbSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbAuthori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}