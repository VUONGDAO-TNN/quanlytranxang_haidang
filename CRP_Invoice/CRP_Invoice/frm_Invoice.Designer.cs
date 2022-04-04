namespace CRP_Invoice
{
    partial class frm_Invoice
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
            this.gb_Seller = new System.Windows.Forms.GroupBox();
            this.txt_CompanyAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CompanyPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CompanyAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CompanyTaxcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Buyer = new System.Windows.Forms.GroupBox();
            this.txt_BankName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_BuyerAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BuyerAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_BuyerTaxcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_BuyerCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_BuyerCode = new System.Windows.Forms.TextBox();
            this.txt_BuyerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grv_InvoiceServices = new System.Windows.Forms.DataGridView();
            this.grdCol_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCol_Invoice_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb = new System.Windows.Forms.GroupBox();
            this.cbo_PaymentType = new System.Windows.Forms.ComboBox();
            this.dtp_ArisingDate = new System.Windows.Forms.DateTimePicker();
            this.txt_GrandTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_VATAmount = new System.Windows.Forms.TextBox();
            this.txt_VAT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_InvoicePattern = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_InvoiceSerial = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_LookupCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_InvoiceNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Release = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_CloseForm = new System.Windows.Forms.Button();
            this.grb_Layout = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pl_Popup = new System.Windows.Forms.Panel();
            this.grv_Popup = new System.Windows.Forms.DataGridView();
            this.gb_Seller.SuspendLayout();
            this.gb_Buyer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_InvoiceServices)).BeginInit();
            this.grb.SuspendLayout();
            this.grb_Layout.SuspendLayout();
            this.pl_Popup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Popup)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Seller
            // 
            this.gb_Seller.Controls.Add(this.txt_CompanyAccount);
            this.gb_Seller.Controls.Add(this.label5);
            this.gb_Seller.Controls.Add(this.txt_CompanyPhone);
            this.gb_Seller.Controls.Add(this.label4);
            this.gb_Seller.Controls.Add(this.txt_CompanyAddress);
            this.gb_Seller.Controls.Add(this.label3);
            this.gb_Seller.Controls.Add(this.txt_CompanyTaxcode);
            this.gb_Seller.Controls.Add(this.label2);
            this.gb_Seller.Controls.Add(this.txt_CompanyName);
            this.gb_Seller.Controls.Add(this.label1);
            this.gb_Seller.Location = new System.Drawing.Point(18, 19);
            this.gb_Seller.Name = "gb_Seller";
            this.gb_Seller.Size = new System.Drawing.Size(794, 172);
            this.gb_Seller.TabIndex = 0;
            this.gb_Seller.TabStop = false;
            this.gb_Seller.Text = "Đơn vị bán hàng";
            // 
            // txt_CompanyAccount
            // 
            this.txt_CompanyAccount.Enabled = false;
            this.txt_CompanyAccount.Location = new System.Drawing.Point(112, 117);
            this.txt_CompanyAccount.Multiline = true;
            this.txt_CompanyAccount.Name = "txt_CompanyAccount";
            this.txt_CompanyAccount.Size = new System.Drawing.Size(675, 44);
            this.txt_CompanyAccount.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số tài khoản:";
            // 
            // txt_CompanyPhone
            // 
            this.txt_CompanyPhone.Enabled = false;
            this.txt_CompanyPhone.Location = new System.Drawing.Point(112, 91);
            this.txt_CompanyPhone.Name = "txt_CompanyPhone";
            this.txt_CompanyPhone.Size = new System.Drawing.Size(675, 20);
            this.txt_CompanyPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điện thoại:";
            // 
            // txt_CompanyAddress
            // 
            this.txt_CompanyAddress.Enabled = false;
            this.txt_CompanyAddress.Location = new System.Drawing.Point(112, 65);
            this.txt_CompanyAddress.Name = "txt_CompanyAddress";
            this.txt_CompanyAddress.Size = new System.Drawing.Size(675, 20);
            this.txt_CompanyAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // txt_CompanyTaxcode
            // 
            this.txt_CompanyTaxcode.Enabled = false;
            this.txt_CompanyTaxcode.Location = new System.Drawing.Point(112, 39);
            this.txt_CompanyTaxcode.Name = "txt_CompanyTaxcode";
            this.txt_CompanyTaxcode.Size = new System.Drawing.Size(675, 20);
            this.txt_CompanyTaxcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số thuế:";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Enabled = false;
            this.txt_CompanyName.Location = new System.Drawing.Point(112, 13);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(675, 20);
            this.txt_CompanyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn vị bán hàng:";
            // 
            // gb_Buyer
            // 
            this.gb_Buyer.Controls.Add(this.txt_BankName);
            this.gb_Buyer.Controls.Add(this.label20);
            this.gb_Buyer.Controls.Add(this.txt_BuyerAccount);
            this.gb_Buyer.Controls.Add(this.label6);
            this.gb_Buyer.Controls.Add(this.txt_BuyerAddress);
            this.gb_Buyer.Controls.Add(this.label7);
            this.gb_Buyer.Controls.Add(this.txt_BuyerTaxcode);
            this.gb_Buyer.Controls.Add(this.label8);
            this.gb_Buyer.Controls.Add(this.txt_BuyerCompany);
            this.gb_Buyer.Controls.Add(this.label9);
            this.gb_Buyer.Controls.Add(this.txt_BuyerCode);
            this.gb_Buyer.Controls.Add(this.txt_BuyerName);
            this.gb_Buyer.Controls.Add(this.label10);
            this.gb_Buyer.Location = new System.Drawing.Point(18, 197);
            this.gb_Buyer.Name = "gb_Buyer";
            this.gb_Buyer.Size = new System.Drawing.Size(794, 149);
            this.gb_Buyer.TabIndex = 0;
            this.gb_Buyer.TabStop = false;
            this.gb_Buyer.Text = "Đơn vị mua hàng";
            // 
            // txt_BankName
            // 
            this.txt_BankName.Location = new System.Drawing.Point(517, 117);
            this.txt_BankName.Name = "txt_BankName";
            this.txt_BankName.Size = new System.Drawing.Size(270, 20);
            this.txt_BankName.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(441, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ngân hàng:";
            // 
            // txt_BuyerAccount
            // 
            this.txt_BuyerAccount.Location = new System.Drawing.Point(112, 117);
            this.txt_BuyerAccount.Name = "txt_BuyerAccount";
            this.txt_BuyerAccount.Size = new System.Drawing.Size(270, 20);
            this.txt_BuyerAccount.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số tài khoản:";
            // 
            // txt_BuyerAddress
            // 
            this.txt_BuyerAddress.Location = new System.Drawing.Point(112, 91);
            this.txt_BuyerAddress.Name = "txt_BuyerAddress";
            this.txt_BuyerAddress.Size = new System.Drawing.Size(675, 20);
            this.txt_BuyerAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // txt_BuyerTaxcode
            // 
            this.txt_BuyerTaxcode.Location = new System.Drawing.Point(112, 65);
            this.txt_BuyerTaxcode.Name = "txt_BuyerTaxcode";
            this.txt_BuyerTaxcode.Size = new System.Drawing.Size(675, 20);
            this.txt_BuyerTaxcode.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã số thuế:";
            // 
            // txt_BuyerCompany
            // 
            this.txt_BuyerCompany.Location = new System.Drawing.Point(112, 39);
            this.txt_BuyerCompany.Name = "txt_BuyerCompany";
            this.txt_BuyerCompany.Size = new System.Drawing.Size(675, 20);
            this.txt_BuyerCompany.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên đơn vị:";
            // 
            // txt_BuyerCode
            // 
            this.txt_BuyerCode.Location = new System.Drawing.Point(112, 13);
            this.txt_BuyerCode.Name = "txt_BuyerCode";
            this.txt_BuyerCode.Size = new System.Drawing.Size(128, 20);
            this.txt_BuyerCode.TabIndex = 5;
            // 
            // txt_BuyerName
            // 
            this.txt_BuyerName.Location = new System.Drawing.Point(246, 13);
            this.txt_BuyerName.Name = "txt_BuyerName";
            this.txt_BuyerName.Size = new System.Drawing.Size(541, 20);
            this.txt_BuyerName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Người mua hàng:";
            // 
            // grv_InvoiceServices
            // 
            this.grv_InvoiceServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_InvoiceServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdCol_ProductName,
            this.grdCol_ProductUnit,
            this.grdCol_ProductQuantity,
            this.grdCol_UnitPrice,
            this.grdCol_Amount,
            this.grdCol_Invoice_Key});
            this.grv_InvoiceServices.Location = new System.Drawing.Point(18, 352);
            this.grv_InvoiceServices.MultiSelect = false;
            this.grv_InvoiceServices.Name = "grv_InvoiceServices";
            this.grv_InvoiceServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grv_InvoiceServices.Size = new System.Drawing.Size(794, 150);
            this.grv_InvoiceServices.TabIndex = 26;
            // 
            // grdCol_ProductName
            // 
            this.grdCol_ProductName.DataPropertyName = "Service_Name";
            this.grdCol_ProductName.HeaderText = "Tên hàng hóa";
            this.grdCol_ProductName.Name = "grdCol_ProductName";
            this.grdCol_ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCol_ProductName.Width = 351;
            // 
            // grdCol_ProductUnit
            // 
            this.grdCol_ProductUnit.DataPropertyName = "Unit";
            this.grdCol_ProductUnit.HeaderText = "Đơn vị tính";
            this.grdCol_ProductUnit.Name = "grdCol_ProductUnit";
            // 
            // grdCol_ProductQuantity
            // 
            this.grdCol_ProductQuantity.DataPropertyName = "Quantity";
            this.grdCol_ProductQuantity.HeaderText = "Số lượng";
            this.grdCol_ProductQuantity.Name = "grdCol_ProductQuantity";
            // 
            // grdCol_UnitPrice
            // 
            this.grdCol_UnitPrice.DataPropertyName = "Unit_Price";
            this.grdCol_UnitPrice.HeaderText = "Đơn giá";
            this.grdCol_UnitPrice.Name = "grdCol_UnitPrice";
            // 
            // grdCol_Amount
            // 
            this.grdCol_Amount.DataPropertyName = "Amount";
            this.grdCol_Amount.HeaderText = "Thành tiền";
            this.grdCol_Amount.Name = "grdCol_Amount";
            // 
            // grdCol_Invoice_Key
            // 
            this.grdCol_Invoice_Key.DataPropertyName = "Invoice_Key";
            this.grdCol_Invoice_Key.HeaderText = "Invoice Key";
            this.grdCol_Invoice_Key.Name = "grdCol_Invoice_Key";
            this.grdCol_Invoice_Key.Visible = false;
            // 
            // grb
            // 
            this.grb.Controls.Add(this.cbo_PaymentType);
            this.grb.Controls.Add(this.dtp_ArisingDate);
            this.grb.Controls.Add(this.txt_GrandTotal);
            this.grb.Controls.Add(this.label11);
            this.grb.Controls.Add(this.txt_VATAmount);
            this.grb.Controls.Add(this.txt_VAT);
            this.grb.Controls.Add(this.label21);
            this.grb.Controls.Add(this.label12);
            this.grb.Controls.Add(this.txt_Amount);
            this.grb.Controls.Add(this.label13);
            this.grb.Controls.Add(this.label14);
            this.grb.Controls.Add(this.txt_InvoicePattern);
            this.grb.Controls.Add(this.label18);
            this.grb.Controls.Add(this.txt_InvoiceSerial);
            this.grb.Controls.Add(this.label17);
            this.grb.Controls.Add(this.txt_LookupCode);
            this.grb.Controls.Add(this.label19);
            this.grb.Controls.Add(this.txt_InvoiceNo);
            this.grb.Controls.Add(this.label16);
            this.grb.Controls.Add(this.label15);
            this.grb.Location = new System.Drawing.Point(18, 508);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(794, 119);
            this.grb.TabIndex = 0;
            this.grb.TabStop = false;
            this.grb.Text = "Thông tin hóa đơn";
            // 
            // cbo_PaymentType
            // 
            this.cbo_PaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PaymentType.FormattingEnabled = true;
            this.cbo_PaymentType.Location = new System.Drawing.Point(112, 38);
            this.cbo_PaymentType.Name = "cbo_PaymentType";
            this.cbo_PaymentType.Size = new System.Drawing.Size(220, 21);
            this.cbo_PaymentType.TabIndex = 13;
            // 
            // dtp_ArisingDate
            // 
            this.dtp_ArisingDate.CustomFormat = "yyyy-MM-dd";
            this.dtp_ArisingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ArisingDate.Location = new System.Drawing.Point(112, 13);
            this.dtp_ArisingDate.Name = "dtp_ArisingDate";
            this.dtp_ArisingDate.Size = new System.Drawing.Size(126, 20);
            this.dtp_ArisingDate.TabIndex = 12;
            // 
            // txt_GrandTotal
            // 
            this.txt_GrandTotal.Location = new System.Drawing.Point(112, 91);
            this.txt_GrandTotal.Name = "txt_GrandTotal";
            this.txt_GrandTotal.Size = new System.Drawing.Size(220, 20);
            this.txt_GrandTotal.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng cộng:";
            // 
            // txt_VATAmount
            // 
            this.txt_VATAmount.Enabled = false;
            this.txt_VATAmount.Location = new System.Drawing.Point(488, 65);
            this.txt_VATAmount.Name = "txt_VATAmount";
            this.txt_VATAmount.Size = new System.Drawing.Size(153, 20);
            this.txt_VATAmount.TabIndex = 15;
            // 
            // txt_VAT
            // 
            this.txt_VAT.Location = new System.Drawing.Point(406, 65);
            this.txt_VAT.Name = "txt_VAT";
            this.txt_VAT.Size = new System.Drawing.Size(61, 20);
            this.txt_VAT.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(467, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "VAT:";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(112, 65);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(220, 20);
            this.txt_Amount.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Cộng tiền hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Hình  thức TT:";
            // 
            // txt_InvoicePattern
            // 
            this.txt_InvoicePattern.Location = new System.Drawing.Point(561, 13);
            this.txt_InvoicePattern.Name = "txt_InvoicePattern";
            this.txt_InvoicePattern.Size = new System.Drawing.Size(80, 20);
            this.txt_InvoicePattern.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(524, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mẫu:";
            // 
            // txt_InvoiceSerial
            // 
            this.txt_InvoiceSerial.Location = new System.Drawing.Point(439, 13);
            this.txt_InvoiceSerial.Name = "txt_InvoiceSerial";
            this.txt_InvoiceSerial.Size = new System.Drawing.Size(80, 20);
            this.txt_InvoiceSerial.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(388, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ký hiệu:";
            // 
            // txt_LookupCode
            // 
            this.txt_LookupCode.Enabled = false;
            this.txt_LookupCode.Location = new System.Drawing.Point(406, 38);
            this.txt_LookupCode.Name = "txt_LookupCode";
            this.txt_LookupCode.Size = new System.Drawing.Size(235, 20);
            this.txt_LookupCode.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(339, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mã tra cứu:";
            // 
            // txt_InvoiceNo
            // 
            this.txt_InvoiceNo.Enabled = false;
            this.txt_InvoiceNo.Location = new System.Drawing.Point(302, 13);
            this.txt_InvoiceNo.Name = "txt_InvoiceNo";
            this.txt_InvoiceNo.Size = new System.Drawing.Size(80, 20);
            this.txt_InvoiceNo.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(254, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Số HĐ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ngày lập:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(159, 633);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 33);
            this.btn_Save.TabIndex = 21;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Release
            // 
            this.btn_Release.Location = new System.Drawing.Point(264, 633);
            this.btn_Release.Name = "btn_Release";
            this.btn_Release.Size = new System.Drawing.Size(99, 33);
            this.btn_Release.TabIndex = 22;
            this.btn_Release.Text = "Phát hành";
            this.btn_Release.UseVisualStyleBackColor = true;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(369, 633);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(99, 33);
            this.btn_View.TabIndex = 23;
            this.btn_View.Text = "Xem";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Location = new System.Drawing.Point(474, 633);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(99, 33);
            this.btn_CloseForm.TabIndex = 25;
            this.btn_CloseForm.Text = "Thoát";
            this.btn_CloseForm.UseVisualStyleBackColor = true;
            // 
            // grb_Layout
            // 
            this.grb_Layout.Controls.Add(this.btn_CloseForm);
            this.grb_Layout.Controls.Add(this.gb_Seller);
            this.grb_Layout.Controls.Add(this.gb_Buyer);
            this.grb_Layout.Controls.Add(this.btn_View);
            this.grb_Layout.Controls.Add(this.grb);
            this.grb_Layout.Controls.Add(this.btn_Release);
            this.grb_Layout.Controls.Add(this.grv_InvoiceServices);
            this.grb_Layout.Controls.Add(this.btn_Add);
            this.grb_Layout.Controls.Add(this.btn_Save);
            this.grb_Layout.Location = new System.Drawing.Point(12, 12);
            this.grb_Layout.Name = "grb_Layout";
            this.grb_Layout.Size = new System.Drawing.Size(826, 677);
            this.grb_Layout.TabIndex = 3;
            this.grb_Layout.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(54, 633);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 33);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // pl_Popup
            // 
            this.pl_Popup.Controls.Add(this.grv_Popup);
            this.pl_Popup.Location = new System.Drawing.Point(381, 53);
            this.pl_Popup.Name = "pl_Popup";
            this.pl_Popup.Size = new System.Drawing.Size(715, 189);
            this.pl_Popup.TabIndex = 4;
            this.pl_Popup.Visible = false;
            // 
            // grv_Popup
            // 
            this.grv_Popup.AllowUserToAddRows = false;
            this.grv_Popup.AllowUserToDeleteRows = false;
            this.grv_Popup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Popup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Popup.Location = new System.Drawing.Point(0, 0);
            this.grv_Popup.MultiSelect = false;
            this.grv_Popup.Name = "grv_Popup";
            this.grv_Popup.ReadOnly = true;
            this.grv_Popup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_Popup.Size = new System.Drawing.Size(715, 189);
            this.grv_Popup.TabIndex = 0;
            // 
            // frm_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(846, 698);
            this.Controls.Add(this.pl_Popup);
            this.Controls.Add(this.grb_Layout);
            this.KeyPreview = true;
            this.Name = "frm_Invoice";
            this.Text = "Hóa đơn";
            this.gb_Seller.ResumeLayout(false);
            this.gb_Seller.PerformLayout();
            this.gb_Buyer.ResumeLayout(false);
            this.gb_Buyer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_InvoiceServices)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.grb_Layout.ResumeLayout(false);
            this.pl_Popup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Popup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Seller;
        private System.Windows.Forms.TextBox txt_CompanyAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CompanyPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CompanyAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CompanyTaxcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Buyer;
        private System.Windows.Forms.TextBox txt_BuyerAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BuyerAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_BuyerTaxcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_BuyerCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_BuyerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grv_InvoiceServices;
        private System.Windows.Forms.TextBox txt_BuyerCode;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.ComboBox cbo_PaymentType;
        private System.Windows.Forms.DateTimePicker dtp_ArisingDate;
        private System.Windows.Forms.TextBox txt_GrandTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_VAT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_InvoicePattern;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_InvoiceSerial;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_LookupCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_InvoiceNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Release;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_CloseForm;
        private System.Windows.Forms.GroupBox grb_Layout;
        private System.Windows.Forms.TextBox txt_BankName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pl_Popup;
        private System.Windows.Forms.DataGridView grv_Popup;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_ProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCol_Invoice_Key;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_VATAmount;
    }
}