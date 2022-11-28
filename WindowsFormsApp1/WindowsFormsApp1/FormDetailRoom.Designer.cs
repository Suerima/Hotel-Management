namespace WindowsFormsApp1
{
    partial class FormDetailRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLeft = new ePOSOne.btnProduct.Button_WOC();
            this.btnRight = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sPanel2 = new WindowsFormsApp1.Resources.SPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDetails = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lbPerson = new System.Windows.Forms.Label();
            this.lbBed = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sPanel1 = new WindowsFormsApp1.Resources.SPanel();
            this.btnDetail = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.btnBooking = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 475);
            this.panel1.TabIndex = 3;
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
            this.btnLeft.Location = new System.Drawing.Point(0, 161);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnLeft.OnHoverButtonColor = System.Drawing.Color.Empty;
            this.btnLeft.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnLeft.Size = new System.Drawing.Size(70, 64);
            this.btnLeft.TabIndex = 11;
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
            this.btnRight.Location = new System.Drawing.Point(581, 161);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnRight.OnHoverButtonColor = System.Drawing.Color.Empty;
            this.btnRight.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnRight.Size = new System.Drawing.Size(70, 64);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = ">";
            this.btnRight.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sPanel2);
            this.panel2.Controls.Add(this.sPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(654, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 475);
            this.panel2.TabIndex = 4;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.Controls.Add(this.groupBox1);
            this.sPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sPanel2.Edge = 25;
            this.sPanel2.Location = new System.Drawing.Point(0, 0);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(540, 336);
            this.sPanel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.lbDetails);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCustomerID);
            this.groupBox1.Controls.Add(this.lbPerson);
            this.groupBox1.Controls.Add(this.lbBed);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặc điểm";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Location = new System.Drawing.Point(145, 129);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(0, 20);
            this.lbDetails.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(307, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "- Mã khách hàng";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tbCustomerID.Location = new System.Drawing.Point(311, 61);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(168, 28);
            this.tbCustomerID.TabIndex = 13;
            // 
            // lbPerson
            // 
            this.lbPerson.AutoSize = true;
            this.lbPerson.Location = new System.Drawing.Point(145, 69);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(19, 20);
            this.lbPerson.TabIndex = 5;
            this.lbPerson.Text = "2";
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Location = new System.Drawing.Point(145, 99);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(104, 20);
            this.lbBed.TabIndex = 6;
            this.lbBed.Text = "Giường đơn";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(145, 39);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(84, 20);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Standard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "- Tiện nghi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "- Loại giường: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Số người: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Loại phòng: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "người";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.btnDetail);
            this.sPanel1.Controls.Add(this.button_WOC1);
            this.sPanel1.Controls.Add(this.btnBooking);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(23, 367);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(495, 108);
            this.sPanel1.TabIndex = 13;
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.btnDetail.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(23, 16);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDetail.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.btnDetail.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnDetail.Size = new System.Drawing.Size(171, 70);
            this.btnDetail.TabIndex = 13;
            this.btnDetail.Text = "Detail";
            this.btnDetail.TextColor = System.Drawing.Color.White;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(276, 16);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(4);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.button_WOC1.Size = new System.Drawing.Size(176, 70);
            this.button_WOC1.TabIndex = 13;
            this.button_WOC1.Text = "Cancel";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.btnBooking.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(23, 17);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBooking.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(214)))), ((int)(((byte)(146)))));
            this.btnBooking.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnBooking.Size = new System.Drawing.Size(171, 70);
            this.btnBooking.TabIndex = 12;
            this.btnBooking.Text = "Book";
            this.btnBooking.TextColor = System.Drawing.Color.White;
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // FormDetailRoom
            // 
            this.AcceptButton = this.btnBooking;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetailRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailRoom";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.sPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnRight;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC btnLeft;
        private ePOSOne.btnProduct.Button_WOC btnBooking;
        private Resources.SPanel sPanel1;
        private Resources.SPanel sPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPerson;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCustomerID;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Label lbDetails;
        private ePOSOne.btnProduct.Button_WOC btnDetail;
    }
}