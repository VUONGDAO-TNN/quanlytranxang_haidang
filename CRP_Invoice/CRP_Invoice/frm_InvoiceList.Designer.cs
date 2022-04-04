namespace CRP_Invoice
{
    partial class frm_InvoiceList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grv_InvoiceList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grdCol_Invoice_Pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Invoice_Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Invoice_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Arissing_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Customer_CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Customer_TaxCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_InvoiceList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_Keyword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_To);
            this.groupBox1.Controls.Add(this.dtp_From);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(20, 30);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(321, 20);
            this.txt_Keyword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày:";
            this.label1.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(347, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 32);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // dtp_To
            // 
            this.dtp_To.Checked = false;
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(618, 19);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.ShowCheckBox = true;
            this.dtp_To.Size = new System.Drawing.Size(133, 20);
            this.dtp_To.TabIndex = 0;
            this.dtp_To.Visible = false;
            // 
            // dtp_From
            // 
            this.dtp_From.Checked = false;
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(618, 54);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.ShowCheckBox = true;
            this.dtp_From.Size = new System.Drawing.Size(133, 20);
            this.dtp_From.TabIndex = 0;
            this.dtp_From.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grv_InvoiceList);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 539);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // grv_InvoiceList
            // 
            this.grv_InvoiceList.AllowUserToAddRows = false;
            this.grv_InvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_InvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_InvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdCol_Invoice_Pattern,
            this.grdCol_Invoice_Serial,
            this.grdCol_Invoice_No,
            this.grdCol_Arissing_Date,
            this.grdCol_Customer_CompanyName,
            this.grdCol_Customer_Name,
            this.grdCol_Customer_TaxCode,
            this.grdCol_Customer_Address});
            this.grv_InvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_InvoiceList.Location = new System.Drawing.Point(3, 16);
            this.grv_InvoiceList.MultiSelect = false;
            this.grv_InvoiceList.Name = "grv_InvoiceList";
            this.grv_InvoiceList.ReadOnly = true;
            this.grv_InvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_InvoiceList.Size = new System.Drawing.Size(751, 520);
            this.grv_InvoiceList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_Close);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Controls.Add(this.btn_Print);
            this.groupBox3.Controls.Add(this.btn_Update);
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Location = new System.Drawing.Point(12, 636);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 85);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(422, 19);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 32);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Thoát";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(214, 19);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 32);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(318, 19);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(98, 32);
            this.btn_Print.TabIndex = 1;
            this.btn_Print.Text = "In hóa đơn";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(110, 19);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 32);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa hóa đơn";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 32);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm hóa đơn";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // grdCol_Invoice_Pattern
            // 
            this.grdCol_Invoice_Pattern.DataPropertyName = "Invoice_Pattern";
            this.grdCol_Invoice_Pattern.HeaderText = "Mẫu số";
            this.grdCol_Invoice_Pattern.Name = "grdCol_Invoice_Pattern";
            this.grdCol_Invoice_Pattern.ReadOnly = true;
            // 
            // grdCol_Invoice_Serial
            // 
            this.grdCol_Invoice_Serial.DataPropertyName = "Invoice_Serial";
            this.grdCol_Invoice_Serial.HeaderText = "Serial";
            this.grdCol_Invoice_Serial.Name = "grdCol_Invoice_Serial";
            this.grdCol_Invoice_Serial.ReadOnly = true;
            // 
            // grdCol_Invoice_No
            // 
            this.grdCol_Invoice_No.DataPropertyName = "Invoice_No";
            this.grdCol_Invoice_No.HeaderText = "Số hóa đơn";
            this.grdCol_Invoice_No.Name = "grdCol_Invoice_No";
            this.grdCol_Invoice_No.ReadOnly = true;
            // 
            // grdCol_Arissing_Date
            // 
            this.grdCol_Arissing_Date.DataPropertyName = "Arissing_Date";
            this.grdCol_Arissing_Date.HeaderText = "Ngày lập";
            this.grdCol_Arissing_Date.Name = "grdCol_Arissing_Date";
            this.grdCol_Arissing_Date.ReadOnly = true;
            // 
            // grdCol_Customer_CompanyName
            // 
            this.grdCol_Customer_CompanyName.DataPropertyName = "Customer_CompanyName";
            this.grdCol_Customer_CompanyName.HeaderText = "Đơn vị mua hàng";
            this.grdCol_Customer_CompanyName.Name = "grdCol_Customer_CompanyName";
            this.grdCol_Customer_CompanyName.ReadOnly = true;
            // 
            // grdCol_Customer_Name
            // 
            this.grdCol_Customer_Name.DataPropertyName = "Customer_Name";
            this.grdCol_Customer_Name.HeaderText = "Người mua hàng";
            this.grdCol_Customer_Name.Name = "grdCol_Customer_Name";
            this.grdCol_Customer_Name.ReadOnly = true;
            // 
            // grdCol_Customer_TaxCode
            // 
            this.grdCol_Customer_TaxCode.DataPropertyName = "Customer_TaxCode";
            this.grdCol_Customer_TaxCode.HeaderText = "MST";
            this.grdCol_Customer_TaxCode.Name = "grdCol_Customer_TaxCode";
            this.grdCol_Customer_TaxCode.ReadOnly = true;
            // 
            // grdCol_Customer_Address
            // 
            this.grdCol_Customer_Address.DataPropertyName = "Customer_Address";
            this.grdCol_Customer_Address.HeaderText = "Địa chỉ";
            this.grdCol_Customer_Address.Name = "grdCol_Customer_Address";
            this.grdCol_Customer_Address.ReadOnly = true;
            // 
            // frm_InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(781, 733);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_InvoiceList";
            this.Text = "Danh sách hóa đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_InvoiceList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grv_InvoiceList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Invoice_Pattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Invoice_Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Invoice_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Arissing_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Customer_CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Customer_TaxCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Customer_Address;
    }
}