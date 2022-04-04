using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
//using PopupControl;

namespace CRP_Invoice
{    
    public partial class frm_Invoice : Form, IMessageFilter
    {

        #region IMessageFilter Members

        private const UInt32 WM_KEYDOWN = 0x0100;

        public bool PreFilterMessage(ref Message m)

        {
            if (m.Msg == WM_KEYDOWN)
            {
                Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                switch (keyCode)
                {
                    case Keys.Enter:
                        selectedInfor();
                        return true;
                    case Keys.Escape:
                        pl_Popup.Visible = false;
                        return false;
                        //break;
                    default:
                        return false;
                        //break;
                }
                //if (keyCode == Keys.Enter)
                //{
                //    //if (pl_Popup.Visible && pl_Popup.Tag.ToString().Equals("Services", StringComparison.OrdinalIgnoreCase))
                //    //{
                //    //    //get row data and grant to invoice service
                //    //    if (grv_Popup.SelectedRows != null && grv_Popup.SelectedRows.Count > 0)
                //    //    {
                //    //        DataRow dr = ((DataRowView)grv_InvoiceServices.Rows[grv_InvoiceServices.CurrentCell.RowIndex].DataBoundItem).Row;
                //    //        DataRow dr1 = ((DataRowView)grv_Popup.SelectedRows[0].DataBoundItem).Row;
                //    //        dr[grdCol_ProductName.DataPropertyName] = dr1["Service_Name"];
                //    //        dr[grdCol_ProductUnit.DataPropertyName] = dr1["Unit"];
                //    //        dr[grdCol_UnitPrice.DataPropertyName] = dr1["Unit_Price"];
                //    //        dr["Service_ID"] = dr1["Service_ID"];
                //    //        grv_InvoiceServices.CurrentCell = grv_InvoiceServices["grdCol_ProductQuantity", grv_InvoiceServices.CurrentCell.RowIndex];
                //    //    }
                //    //    pl_Popup.Visible = false;
                //    //}
                //    //return true;
                //}
                //return false;
            }
            return false;
        }
        #endregion
        private clsInvoices _instOfInvoice;
        public clsInvoices instOfInvoice
        {
            set { _instOfInvoice = value; }
            get { return _instOfInvoice; }
        }
        clsCustomers instOfCustomer;
        clsServices instOfService;
        DataView dv_Invoices;
        DataView dv_InvoiceServices;
        //Popup popup;
        public frm_Invoice()
        {
            InitializeComponent();
            grv_InvoiceServices.AutoGenerateColumns = false;
            grv_Popup.AutoGenerateColumns = false;
            Load += frm_Invoices_Load;
            btn_CloseForm.Click += btn_CloseForm_Click;
            btn_Release.Click += btn_Release_Click;
            btn_Save.Click += btn_Save_Click;
            btn_View.Click += btn_View_Click;
            btn_Add.Click += btn_Add_Click;
            grv_InvoiceServices.DefaultValuesNeeded += grv_InvoiceServices_DefaultValuesNeeded;
            this.Shown += frm_Invoice_Shown;
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("TM", "Tiền mặt");
            items.Add("CK", "Chuyển khoản");
            items.Add("TM,CK", "Tiền mặt hoặc chuyển khoản");
            cbo_PaymentType.DataSource = new BindingSource(items, null);
            cbo_PaymentType.DisplayMember = "Value";
            cbo_PaymentType.ValueMember = "Key";
            txt_InvoiceNo.TextChanged += txt_InvoiceNo_TextChanged;
        }

        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            
        }

        private void frm_Invoice_Shown(object sender, EventArgs e)
        {
            txt_BuyerCode.GotFocus += txt_GotFocus;
            txt_BuyerAddress.GotFocus += txt_GotFocus;
            txt_BuyerCompany.GotFocus += txt_GotFocus;
            txt_BuyerName.GotFocus += txt_GotFocus;
            txt_BuyerTaxcode.GotFocus += txt_GotFocus;
            txt_BuyerAccount.GotFocus += txt_GotFocus;
            txt_BankName.GotFocus += txt_GotFocus;

            txt_BuyerCode.LostFocus += txt_LostFocus;
            txt_BuyerAddress.LostFocus += txt_LostFocus;
            txt_BuyerCompany.LostFocus += txt_LostFocus;
            txt_BuyerName.LostFocus += txt_LostFocus;
            txt_BuyerTaxcode.LostFocus += txt_LostFocus;
            txt_BuyerAccount.LostFocus += txt_LostFocus;
            txt_BankName.LostFocus += txt_LostFocus;
            //txt_BuyerCode.KeyPress += txt_KeyPress;
            //txt_BuyerAddress.KeyPress += txt_KeyPress;
            //txt_BuyerCompany.KeyPress += txt_KeyPress;
            //txt_BuyerName.KeyPress += txt_KeyPress;
            //txt_BuyerTaxcode.KeyPress += txt_KeyPress;
            //txt_BuyerAccount.KeyPress += txt_KeyPress;
            //txt_BankName.KeyPress += txt_KeyPress;

            txt_BuyerCode.KeyUp += txt_KeyUp;
            txt_BuyerAddress.KeyUp += txt_KeyUp;
            txt_BuyerCompany.KeyUp += txt_KeyUp;
            txt_BuyerName.KeyUp += txt_KeyUp;
            txt_BuyerTaxcode.KeyUp += txt_KeyUp;
            txt_BuyerAccount.KeyUp += txt_KeyUp;
            txt_BankName.KeyUp += txt_KeyUp;

            grv_InvoiceServices.GotFocus += grv_InvoiceServices_GotFocus;
            grv_InvoiceServices.EditingControlShowing += grv_InvoiceServices_EditingControlShowing;
            grv_InvoiceServices.KeyDown += grv_InvoiceServices_KeyDown;
            pl_Popup.VisibleChanged += pl_Popup_VisibleChanged;
            txt_GrandTotal.Validated += grantTotal_Validated;
            grv_InvoiceServices.CellValidated += grv_InvoiceServices_CellValidated;
            grv_Popup.KeyPress += Grv_Popup_KeyPress;
            txt_Amount.Validated += caclulate_GrandTotal;
            txt_VAT.Validated += caclulate_GrandTotal;
            grv_Popup.CellDoubleClick += Grv_Popup_CellDoubleClick;
            txt_GrandTotal.GotFocus += txt_SelectedAll;
            txt_Amount.GotFocus += txt_SelectedAll;
            txt_VAT.GotFocus += txt_SelectedAll;            
            txt_BuyerTaxcode.Focus();
        }


        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Enter:
                    selectedInfor();
                    break;
                case (char)Keys.Escape:
                    pl_Popup.Visible = false;
                    break;
                default:
                    if (instOfCustomer == null)
                    {
                        instOfCustomer = new clsCustomers();
                    }
                    TextBox txt = (TextBox)sender;
                    string strCriteria = "";
                    switch (txt.Name.ToLower())
                    {
                        case "txt_buyercode":
                            //strCriteria = "select customer_name, company_name, taxcode, address from customers  from customers where Customer_Code like '%" + txt.Text + "%'";
                            strCriteria = " where Customer_Code like '%" + txt.Text + "%'";
                            break;
                        case "txt_buyername":
                            //strCriteria = "select customer_name, company_name, taxcode, address from customers where Customer_Name like '%" + txt.Text + "%'";
                            strCriteria = " where Customer_Name like '%" + txt.Text + "%' or Customer_Name like '%" + txt.Text.ToUpper() + "%'";
                            break;
                        case "txt_buyercompany":
                            //strCriteria = "select company_name, customer_name, taxcode, address from customers where Company_Name like '%" + txt.Text + "%'";
                            strCriteria = " where Company_Name like '%" + txt.Text + "%' or Company_Name like '%" + txt.Text.ToUpper() + "%'";
                            break;
                        case "txt_buyeraddress":
                            //strCriteria = "select customer_name, company_name, taxcode, address from customers where Address like '%" + txt.Text + "%'";
                            strCriteria = " where Address like '%" + txt.Text + "%' or Address like '%" + txt.Text.ToUpper() + "%'";
                            break;
                        case "txt_buyertaxcode":
                            //strCriteria = "select taxcode, company_name, customer_name, address from customers where Taxcode like '%" + txt.Text + "'";
                            strCriteria = " where Taxcode like '%" + txt.Text + "'";
                            break;
                    }
                    instOfCustomer.getCustomers(strCriteria);
                    if (instOfCustomer.tblCustomer.Rows.Count > 0)
                    {
                        pl_Popup.Tag = "Customers";
                        pl_Popup.Visible = true;
                        
                        if (!pl_Popup.Visible)
                        {
                            pl_Popup.Visible = true;
                        }
                        grv_Popup.DataSource = instOfCustomer.tblCustomer.DefaultView;
                    }
                    else
                    {
                        if (pl_Popup.Visible)
                            pl_Popup.Visible = false;
                    }
                    break;
            }
        }

        private void txt_SelectedAll(object sender, EventArgs e)
        {
            TextBox txtObj = (TextBox)sender;
            double dbl = 0;
            double.TryParse(txtObj.Text, out dbl);
            if (dbl == 0) {
                txtObj.Text = "";
            }
            
        }

        private void txt_LostFocus(object sender, EventArgs e)
        {
            //grv_Popup.AutoGenerateColumns = true;
            pl_Popup.Visible = grv_Popup.Focused;
        }

        private void grantTotal_Validated(object sender, EventArgs e)
        {
            double dblVAT = 0, dblGrandTotal = 0;
            if (double.TryParse(txt_GrandTotal.Text, out dblGrandTotal)) {
                txt_GrandTotal.Text = System.Math.Round(dblGrandTotal, 0).ToString();
                dblGrandTotal = 0;
            }
            if (grv_InvoiceServices.Rows.Count != 2)
            {
                return;
            }
            double dblUnitPrice = 0;
            double.TryParse(grv_InvoiceServices.Rows[0].Cells[grdCol_UnitPrice.Name].Value.ToString(), out dblUnitPrice);
                if(!(dblUnitPrice > 0)) {
                return;
            }
            double.TryParse(txt_VAT.Text, out dblVAT);
            double.TryParse(txt_GrandTotal.Text, out dblGrandTotal);
            if (!(dblGrandTotal > 0)) {
                return;
            }

            //double dblAmount = (dblGrandTotal - dblGrandTotal * dblVAT / 100);
            double dblAmount = dblGrandTotal * 100 / (100 + dblVAT);
            txt_Amount.Text = System.Math.Round(dblAmount, 2).ToString();
            txt_VATAmount.Text = System.Math.Round(dblGrandTotal - dblAmount, 2).ToString();
            grv_InvoiceServices.Rows[0].Cells[grdCol_Amount.Name].Value = txt_Amount.Text;
            grv_InvoiceServices.Rows[0].Cells[grdCol_ProductQuantity.Name].Value = System.Math.Round(dblAmount / dblUnitPrice, 2);
        }

        private void Grv_Popup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedInfor();
            pl_Popup.Visible = false;
        }

        private void Grv_Popup_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar) {
                case (char)Keys.Enter:
                    selectedInfor();
                    break;
                case (char)Keys.Escape:
                    pl_Popup.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void selectedInfor()
        {
            if (!pl_Popup.Visible)
            {
                return;
            }
            switch (pl_Popup.Tag.ToString().ToLower())
            {
                case "customers":
                    if (grv_Popup.SelectedRows != null && grv_Popup.SelectedRows.Count > 0)
                    {
                        //DataRow dr = ((DataRowView)grv_Popup.SelectedRows[0].DataBoundItem).Row;
                        DataRow dr = ((DataRowView)grv_Popup.CurrentRow.DataBoundItem).Row;
                        if (dr != null)
                        {
                            txt_BuyerCode.Text = dr["Customer_Code"].ToString();
                            txt_BuyerName.Text = dr["Customer_Name"].ToString();
                            txt_BuyerCompany.Text = dr["Company_Name"].ToString();
                            txt_BuyerAddress.Text = dr["Address"].ToString();
                            txt_BuyerTaxcode.Text = dr["Taxcode"].ToString();
                            txt_BuyerAccount.Text = dr["Bank_Account"].ToString();
                            txt_BankName.Text = dr["Bank_Name"].ToString();
                        }
                    }
                    break;
                case "services":
                    //get row data and grant to invoice service
                    if (grv_Popup.SelectedRows != null && grv_Popup.SelectedRows.Count > 0)
                    {
                        DataRow dr = ((DataRowView)grv_InvoiceServices.Rows[grv_InvoiceServices.CurrentCell.RowIndex].DataBoundItem).Row;
                        //DataRow dr1 = ((DataRowView)grv_Popup.SelectedRows[0].DataBoundItem).Row;
                        DataRow dr1 = ((DataRowView)grv_Popup.CurrentRow.DataBoundItem).Row;
                        dr[grdCol_ProductName.DataPropertyName] = dr1["Service_Name"];
                        dr[grdCol_ProductUnit.DataPropertyName] = dr1["Unit"];
                        dr[grdCol_UnitPrice.DataPropertyName] = dr1["Unit_Price"];
                        dr["Service_ID"] = dr1["Service_ID"];
                        grv_InvoiceServices.CurrentCell = grv_InvoiceServices["grdCol_ProductQuantity", grv_InvoiceServices.CurrentCell.RowIndex];
                    }
                    break;
            }
            pl_Popup.Visible = false;
        }
        private void txt_InvoiceNo_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txt_InvoiceNo.Text, out i))
            {
                gb_Buyer.Enabled = false;
                gb_Seller.Enabled = false;
                grv_InvoiceServices.Enabled = false;
                btn_Release.Enabled = false;
                btn_Save.Enabled = false;
                grb.Enabled = false;
            }
            else
            {
                gb_Buyer.Enabled = true;
                gb_Seller.Enabled = true;
                grv_InvoiceServices.Enabled = true;
                btn_Release.Enabled = true;
                btn_Save.Enabled = true;
                grb.Enabled = true;
            }
        }

        private void caclulate_GrandTotal(object sender, EventArgs e)
        {
            double dblVAT, dblAmount;
            if (double.TryParse(txt_VAT.Text, out dblVAT) && 
                double.TryParse(txt_Amount.Text, out dblAmount))
            {
                txt_GrandTotal.Text = System.Math.Round(dblAmount + dblAmount * dblVAT / 100, 0).ToString();
                txt_VATAmount.Text = System.Math.Round(dblAmount * dblVAT / 100, 2).ToString();
            }
        }
        private void grv_InvoiceServices_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = grv_InvoiceServices.CurrentRow;
            string s = "";
            bool isNumber = false;
            Double dblNumber;
            bool isUnitPrice = false;
            Double dblUnitPrice;
            s = dr.Cells["grdCol_UnitPrice"].Value.ToString();
            isUnitPrice = Double.TryParse(s, out dblUnitPrice);
            if (!isUnitPrice)
            {
                return;
            }
            if (grv_InvoiceServices.Columns[e.ColumnIndex] == grdCol_ProductQuantity ||
                grv_InvoiceServices.Columns[e.ColumnIndex] == grdCol_UnitPrice)
            {
                s = dr.Cells["grdCol_ProductQuantity"].Value.ToString();
                isNumber = double.TryParse(s, out dblNumber);
                if (isNumber)
                {
                    dr.Cells["grdCol_Amount"].Value = dblNumber * dblUnitPrice;
                }
            }
            if (grv_InvoiceServices.Columns[e.ColumnIndex] == grdCol_Amount)
            {
                s = dr.Cells["grdCol_Amount"].Value.ToString();
                isNumber = double.TryParse(s, out dblNumber);
                if (isNumber)
                {
                    dr.Cells["grdCol_ProductQuantity"].Value = dblNumber / dblUnitPrice;
                }
            }
            if (grv_InvoiceServices.Rows.Count > 0)
            {
                Double dblAmount = 0;
                foreach (DataGridViewRow dgvr in grv_InvoiceServices.Rows)
                {
                    double dbl;
                    if (dgvr.Cells["grdCol_Amount"].Value!=null && Double.TryParse(dgvr.Cells["grdCol_Amount"].Value.ToString(), out dbl)) {
                        dblAmount += dbl;
                    }
                }
                txt_Amount.Text = dblAmount.ToString();
            }
            caclulate_GrandTotal(txt_Amount, new EventArgs());
        }
        private void pl_Popup_VisibleChanged(object sender, EventArgs e)
        {
            if (pl_Popup.Tag.ToString().Equals("Services", StringComparison.OrdinalIgnoreCase))
            {
                //grv_Popup.AutoGenerateColumns = true;
                if (pl_Popup.Visible)
                {
                    Application.AddMessageFilter(this);
                }
                else
                {
                    Application.RemoveMessageFilter(this);
                }
            }
        }
        private void grv_InvoiceServices_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                e.Handled = true;
            }
        }
        private void grv_InvoiceServices_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {            
            DataGridViewCell dvc = grv_InvoiceServices.CurrentCell;
            if (dvc.OwningColumn != grdCol_ProductName)
            {
                return;
            }            
            Point p = grv_InvoiceServices.FindForm().PointToClient(grv_InvoiceServices.Parent.PointToScreen(grv_InvoiceServices.Location));
            Rectangle rt = grv_InvoiceServices.GetCellDisplayRectangle(grv_InvoiceServices.CurrentCell.ColumnIndex, grv_InvoiceServices.CurrentCell.RowIndex, false);
            p.Y += (rt.Location.Y + dvc.OwningRow.Height);
            p.X += rt.Location.X;
            pl_Popup.Location = p;
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;            
            tb.KeyPress += new KeyPressEventHandler(editControl_KeyPress);
            pl_Popup.Tag = "Services";
            if (instOfService == null)
            {
                instOfService = new clsServices();
            }

            instOfService.getServices();
            grv_Popup.Columns.Clear();
            DataGridViewTextBoxColumn d1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn d2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn d3 = new DataGridViewTextBoxColumn();
            d1.HeaderText = "Tên sản phẩm";
            d1.DataPropertyName = "Service_Name";
            grv_Popup.Columns.Add(d1);
            d2.HeaderText = "Đơn vị tính";
            d2.DataPropertyName = "Unit";
            grv_Popup.Columns.Add(d2);
            d3.HeaderText = "Giá sản phẩm";
            d3.DataPropertyName = "Unit_Price";
            grv_Popup.Columns.Add(d3);
            grv_Popup.DataSource = instOfService.tblService.DefaultView;
            pl_Popup.Visible = true;
        }
        private void editControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar) {
                case (char)13:
                    //get row data and grant to invoice service
                    if (grv_Popup.SelectedRows != null) {
                        DataRow dr = ((DataRowView)grv_InvoiceServices.Rows[grv_InvoiceServices.CurrentCell.RowIndex].DataBoundItem).Row; 
                        DataRow dr1= ((DataRowView)grv_Popup.SelectedRows[0].DataBoundItem).Row;
                        dr[grdCol_ProductName.DataPropertyName] = dr1["Service_Name"];
                        dr[grdCol_ProductUnit.DataPropertyName] = dr1["Unit"];
                        dr[grdCol_UnitPrice.DataPropertyName] = dr1["Unit_Price"];                        
                    }
                    break;
                default:
                    TextBox txt = (TextBox)sender;
                    if (instOfService == null) {
                        instOfService = new clsServices();
                    }
                    instOfService.getServices("where Service_name like '%" + txt.Text + (char.IsControl(e.KeyChar) ? "" : e.KeyChar.ToString()) + "%'");
                    grv_Popup.DataSource = instOfService.tblService.DefaultView;
                    break;
            }
        }

        private void grv_InvoiceServices_GotFocus(object sender, EventArgs e)
        {
            pl_Popup.Width = grv_InvoiceServices.Width - 200;
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    selectedInfor();
                    break;
                case (char)Keys.Escape:
                    pl_Popup.Visible = false;
                    break;
                default:
                    if (instOfCustomer == null)
                    {
                        instOfCustomer = new clsCustomers();
                    }
                    TextBox txt = (TextBox)sender;
                    string strCriteria = "";
                    switch (txt.Name.ToLower())
                    {
                        case "txt_buyercode":
                            strCriteria = "select customer_name, company_name, taxcode, address from customers  from customers where Customer_Code like '%" + txt.Text + "%'";
                            break;
                        case "txt_buyername":
                            strCriteria = "select customer_name, company_name, taxcode, address from customers where Customer_Name like '%" + txt.Text + "%'";
                            break;
                        case "txt_buyercompany":
                            strCriteria = "select company_name, customer_name, taxcode, address from customers where Company_Name like '%" + txt.Text + "%'";
                            break;
                        case "txt_buyeraddress":
                            strCriteria = "select customer_name, company_name, taxcode, address from customers where Address like '%" + txt.Text + "%'";
                            break;
                        case "txt_buyertaxcode":
                            strCriteria = "select taxcode, company_name, customer_name, address from customers where Taxcode like '%" + txt.Text + "%'";
                            break;
                    }
                    instOfCustomer.getCustomers_FullCommand(strCriteria);
                    if (instOfCustomer.tblCustomer.Rows.Count > 0)
                    {
                        pl_Popup.Tag = "Customers";
                        pl_Popup.Visible = true;

                        if (!pl_Popup.Visible)
                        {
                            pl_Popup.Visible = true;
                        }
                        grv_Popup.DataSource = instOfCustomer.tblCustomer.DefaultView;

                        //uc_popup.setDataSource(instOfCustomer.tblCustomer.DefaultView);
                        //dgv_Popup.DataSource= instOfCustomer.tblCustomer.DefaultView;
                    }
                    else
                    {
                        if (pl_Popup.Visible)
                            pl_Popup.Visible = false;
                    }
                    break;
            }
            
        }

        private void txt_GotFocus(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            createPopupGridviewColumns(txt);

            if (instOfCustomer == null)
            {
                instOfCustomer = new clsCustomers();
            }
            build_Popup_Columns();
            grv_Popup.DataSource = instOfCustomer.tblCustomer.DefaultView;
            pl_Popup.Width = txt_BuyerCompany.Width;
            Point p;
            if (txt.Name.Equals(txt_BuyerCode.Name) || txt.Name.Equals(txt_BuyerName.Name))
            {
                p = txt_BuyerCode.FindForm().PointToClient(txt_BuyerCode.Parent.PointToScreen(txt_BuyerCode.Location));
                p.Y = p.Y + txt_BuyerCode.Height;
            }
            else
            {
                p = txt.FindForm().PointToClient(txt.Parent.PointToScreen(txt.Location)); ;
                p.Y = p.Y + txt.Height;
            }
            pl_Popup.Location = p;
        }

        private void createPopupGridviewColumns(TextBox txt)
        {
            grv_Popup.Columns.Clear();
            //grv_Popup.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn d1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn d2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn d3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn d4 = new DataGridViewTextBoxColumn();
            d1.DataPropertyName = "Company_Name";
            d1.HeaderText = "Đơn vị mua hàng";
            d1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            d2.DataPropertyName = "Customer_Name";
            d2.HeaderText = "Người mua hàng";
            d2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            d3.DataPropertyName = "Taxcode";
            d3.HeaderText = "Mã số thuế";
            d3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            d4.DataPropertyName = "Address";
            d4.HeaderText = "Địa chỉ";
            d4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            switch (txt.Name.ToLower())
            {
                case "txt_buyercode":
                    grv_Popup.Columns.Add(d2);
                    grv_Popup.Columns.Add(d1);
                    grv_Popup.Columns.Add(d3);
                    grv_Popup.Columns.Add(d4);
                    break;
                case "txt_buyername":
                    grv_Popup.Columns.Add(d2);
                    grv_Popup.Columns.Add(d1);
                    grv_Popup.Columns.Add(d3);
                    grv_Popup.Columns.Add(d4);
                    break;
                case "txt_buyercompany":
                    grv_Popup.Columns.Add(d1);
                    grv_Popup.Columns.Add(d2);
                    grv_Popup.Columns.Add(d3);
                    grv_Popup.Columns.Add(d4);
                    break;
                case "txt_buyeraddress":
                    grv_Popup.Columns.Add(d4);
                    grv_Popup.Columns.Add(d2);
                    grv_Popup.Columns.Add(d1);
                    grv_Popup.Columns.Add(d3);
                    break;
                case "txt_buyertaxcode":
                    grv_Popup.Columns.Add(d3);
                    grv_Popup.Columns.Add(d2);
                    grv_Popup.Columns.Add(d1);
                    grv_Popup.Columns.Add(d4);
                    break;
            }
        }

        private void build_Popup_Columns() {

        }
        private void grv_InvoiceServices_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //e.Row.Cells["grdCol_Invoice_Key"].Value = txt_in;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (_instOfInvoice.tblInvoice.GetChanges() != null || _instOfInvoice.instOfIS.tblInvoiceService.GetChanges() != null)
            {
                //ask to save data

                DialogResult drl = MessageBox.Show("Hóa đơn đã được thay đổi, bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNoCancel);
                switch (drl)
                {
                    case DialogResult.OK:
                        //call save data
                        btn_Save_Click(this, new EventArgs());
                        break;
                    case DialogResult.No:
                        _instOfInvoice.tblInvoice.RejectChanges();
                        _instOfInvoice.instOfIS.tblInvoiceService.RejectChanges();
                        break;
                    default:
                        return;
                }

            }
            _instOfInvoice = new clsInvoices();
            _instOfInvoice.AddNewInvoice();
            dv_Invoices = _instOfInvoice.tblInvoice.DefaultView;
            dv_InvoiceServices = _instOfInvoice.instOfIS.tblInvoiceService.DefaultView;
            grv_InvoiceServices.DataSource = dv_InvoiceServices;
            DataBindings();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            //code to view invoice here
            frm_PriviewInvoice f = new frm_PriviewInvoice();
            f.InvoiceKey = txt_LookupCode.Tag.ToString();
            f.InvoicePattern = txt_InvoicePattern.Text;
            f.InvoiceSerial = txt_InvoiceSerial.Text;
            f.InvoiceNo = txt_InvoiceNo.Text;
            f.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            BindingContext[dv_Invoices].EndCurrentEdit();
            BindingContext[dv_InvoiceServices].EndCurrentEdit();
            int iResult = _instOfInvoice.updateInvoice_NoAcceptChanges(dv_Invoices.Table.GetChanges() != null ? 
                dv_Invoices.Table.GetChanges().Rows[0] : null, dv_InvoiceServices.Table);

            if (iResult > 0) {
                MessageBox.Show("Hóa đơn cập nhật thành công");
                check_CustomerChanged();
                check_ServiceChanged();
                instOfInvoice.instOfIS.updateInvoiceService();
                instOfInvoice.tblInvoice.AcceptChanges();
                instOfInvoice.instOfIS.tblInvoiceService.AcceptChanges();
            }
            else
            {
                MessageBox.Show("Hóa đơn không cập nhật được");
            }
        }
        private void check_ServiceChanged()
        {
            if (instOfInvoice.instOfIS.tblInvoiceService == null)
            {
                return;
            }
            bool beforeAsk = true;
            clsServices service = new clsServices();
            DataRow dr1;
            foreach (DataRow dr in instOfInvoice.instOfIS.tblInvoiceService.Rows)
            {
                service.getService(dr["Service_ID"].ToString());
                if (service.tblService.Rows.Count < 1 && beforeAsk)
                {
                    DialogResult dlr = MessageBox.Show("Thông tin sản phẩm chưa có trong hệ thống.\n\rBạn có muốn lưu lại không", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr != DialogResult.Yes)
                    {
                        break;
                    }
                    service.AddNewService();
                    beforeAsk = false;
                }
                else
                {
                    if (service.tblService.Rows.Count < 1)
                    {
                        service.AddNewService();
                    }
                }
                dr1 = service.tblService.Rows[0];
                if (!dr1["Service_Name"].ToString().Equals(dr["Service_Name"].ToString()) ||
                    !dr1["Unit"].ToString().Equals(dr["Unit"].ToString()) ||
                    !dr1["Unit_Price"].ToString().Equals(dr["Unit_Price"].ToString()))
                {
                    if (beforeAsk)
                    {
                        DialogResult dlr = MessageBox.Show("Thông tin sản phẩm đã thay đổi.\n\rBạn có muốn lưu lại không", "Thông báo", MessageBoxButtons.YesNo);
                        beforeAsk = false;
                        if (dlr != DialogResult.Yes)
                        {
                            break;
                        }
                    }
                }
                else {
                    continue;
                }
                DataRowState drs = dr1.RowState;
                dr1["Service_Name"] = dr["Service_Name"];
                dr1["Unit"] = dr["Unit"];
                dr1["Unit_Price"] = dr["Unit_Price"];
                int autoID = service.updateServiceAndGetID();
                if (drs == DataRowState.Added) {
                    dr["Service_ID"] = autoID;
                }
            }
        }
        private void check_CustomerChanged() {
            clsCustomers customer = new clsCustomers();
            DataRow dr;
            DialogResult drl;
            bool doSave = false;
            customer.getCustomer(txt_BuyerCode.Text);
            if (customer.tblCustomer.Rows.Count < 1)
            {
                customer.AddNewCustomer();
                dr = customer.tblCustomer.Rows[0];
                if (!string.IsNullOrEmpty(txt_BuyerCode.Text)) {
                    drl = MessageBox.Show("Khách hàng chưa có trong hệ thống\n\rBạn có muốn thêm mới không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (drl != DialogResult.No)
                    {
                        doSave = true;
                    }
                    else {
                        return;
                    }
                }
            }
            else
            {
                dr = customer.tblCustomer.Rows[0];
                if (!txt_BuyerCode.Text.Equals(dr["Customer_Code"].ToString()) ||
                    !txt_BuyerCompany.Text.Equals(dr["Company_Name"].ToString()) ||
                    !txt_BuyerName.Text.Equals(dr["Customer_Name"].ToString()) ||
                    !txt_BuyerTaxcode.Text.Equals(dr["Taxcode"].ToString()) ||
                    !txt_BuyerAddress.Text.Equals(dr["Address"].ToString()) ||
                    !txt_BuyerAccount.Text.Equals(dr["Bank_Account"].ToString()) ||
                    !txt_BankName.Text.Equals(dr["Bank_Name"].ToString()))
                {
                    drl = MessageBox.Show("Thông tin khách hàng đã bị thay đổi\n\rBạn có muốn lưu lại thông tin khách hàng không", "Thông báo", MessageBoxButtons.YesNo);
                    if (drl != DialogResult.No)
                    {
                        doSave = true;
                    }
                    else {
                        return;
                    }
                }
            }
            if (doSave) {
                dr["Customer_Code"] = txt_BuyerCode.Text;
                dr["Company_Name"] = txt_BuyerCompany.Text;
                dr["Customer_Name"] = txt_BuyerName.Text;
                dr["Taxcode"] = txt_BuyerTaxcode.Text;
                dr["Address"] = txt_BuyerAddress.Text;
                dr["Bank_Account"] = txt_BuyerAccount.Text;
                dr["Bank_Name"] = txt_BankName.Text;
                customer.updateCustomer();
            }
        }
        private void btn_Release_Click(object sender, EventArgs e)
        {
            //code to release invoice here
            bool redo = true;
            string sResult="";
            while (redo)
            {
                sResult = instOfInvoice.getExistInvoice(txt_LookupCode.Tag.ToString());
                if (sResult.StartsWith("ERR:", StringComparison.OrdinalIgnoreCase) && !sResult.StartsWith("ERR:6", StringComparison.OrdinalIgnoreCase))
                {
                    DialogResult dr = MessageBox.Show("Lỗi khi thực hiện kiểm tra hóa đơn trên hệ thống.\n\rMã lối:" +
                        sResult + "\n\rBạn có muốn thực hiện kiểm tra lại không?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr != DialogResult.Yes)
                    {
                        redo = false;
                    }
                }
                else {
                    redo = false;
                }
            }
            if (!sResult.StartsWith("ERR:", StringComparison.OrdinalIgnoreCase))
            {
                //invoice was exsited, ask for save to db
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(sResult);
                if (doc.GetElementsByTagName("InvoiceNo").Count > 0 && !txt_InvoiceNo.Text.Equals(doc.GetElementsByTagName("InvoiceNo").Item(0).InnerText))
                {
                    DialogResult dr = MessageBox.Show("Hóa đơn có mã " + txt_LookupCode.Tag.ToString() + " đã tồn tại trên hệ thống.\n\r" +
                        "Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr != DialogResult.No)
                    {
                        //save to db
                        txt_InvoiceNo.Text = doc.GetElementsByTagName("InvoiceNo").Item(0).InnerText;
                        txt_LookupCode.Text = txt_InvoicePattern.Text.Substring(0, 2) + Regex.Split(txt_InvoicePattern.Text, "/")[1] + Regex.Split(txt_InvoiceSerial.Text, "/")[0] + (Regex.Split(txt_InvoiceSerial.Text, "/")[1]).Substring(0, 2) + txt_InvoiceNo.Text;
                        BindingContext[dv_Invoices].EndCurrentEdit();
                        instOfInvoice.updateInvoice();
                    }
                }
                else {
                    MessageBox.Show("Hóa đơn đã tồn tại trên hệ thống của VNPT.\r\nKhông thể phát hành lại.");
                }
            }
            else
            {
                if (sResult.StartsWith("ERR:6", StringComparison.OrdinalIgnoreCase))
                {
                    redo = true;
                    int i = 0;
                    while (i < 10 && redo)
                    {
                        i++;
                        sResult = instOfInvoice.releaseInvoice(txt_LookupCode.Tag.ToString());
                        if (sResult.StartsWith("ERR") )
                        {
                            if (!sResult.StartsWith("ERR:1"))
                            {
                                DialogResult dr = MessageBox.Show("Lỗi khi đồng bộ hóa đơn lên hệ thống.\r\nMã lỗi:" +
                                    sResult + "\n\rBạn có muốn thực hiện lại không?", "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (dr != DialogResult.Yes)
                                {
                                    redo = false;
                                }
                            }
                            else {
                                if (i == 10) {
                                    DialogResult dr = MessageBox.Show("Đồng bộ bị lỗi, hãy kiểm tra lại hệ thống.\r\nMã lỗi:" + sResult +
                                        "\r\nBạn có muốn thực hiện lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button1);
                                    if (dr != DialogResult.No) {
                                        i = 0;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Invoice was commited to portal, save invoiceNo to db
                            string[] arrResult = Regex.Split(sResult, "_");
                            txt_InvoiceNo.Text = arrResult[1];
                            txt_LookupCode.Text = txt_InvoicePattern.Text.Substring(0, 2) + Regex.Split(txt_InvoicePattern.Text, "/")[1] + Regex.Split(txt_InvoiceSerial.Text, "/")[0] + (Regex.Split(txt_InvoiceSerial.Text, "/")[1]).Substring(0, 2) + arrResult[1];
                            BindingContext[dv_Invoices].EndCurrentEdit();
                            int iResult = instOfInvoice.updateInvoice();
                            if (iResult > 0)
                            {
                                DialogResult dr= MessageBox.Show("Hóa đơn phát hành thành công.\n\rBạn có muốn xem hóa đơn không?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (dr != DialogResult.No) {
                                    btn_View_Click(btn_View, new EventArgs());
                                }
                            }
                            redo = false;
                        }
                    }
                }
            }

        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_Invoices_Load(object sender, EventArgs e)
        {
            //if (_Invoice != null)
            //{
            //    instOfInvoice.getInvoice(_Invoice["Invoice_Key"].ToString());                
            //}
            if (!(_instOfInvoice.tblInvoice.Rows.Count > 0))
            {
                btn_Add_Click(this, new EventArgs());
            }            
            dv_Invoices = _instOfInvoice.tblInvoice.DefaultView;
            dv_InvoiceServices = _instOfInvoice.instOfIS.tblInvoiceService.DefaultView;
            
            grv_InvoiceServices.DataSource = dv_InvoiceServices;
            DataBindings();
            //Application.AddMessageFilter(this);
        }
        private void DataBindings()
        {
            txt_BuyerCode.DataBindings.Clear();
            txt_BuyerCode.DataBindings.Add("Text", dv_Invoices, "Customer_Code");
            txt_BuyerName.DataBindings.Clear();
            txt_BuyerName.DataBindings.Add("Text", dv_Invoices, "Customer_Name");
            txt_BuyerCompany.DataBindings.Clear();
            txt_BuyerCompany.DataBindings.Add("Text", dv_Invoices, "Customer_CompanyName");
            txt_BuyerTaxcode.DataBindings.Clear();
            txt_BuyerTaxcode.DataBindings.Add("Text", dv_Invoices, "Customer_TaxCode");
            txt_BuyerAddress.DataBindings.Clear();
            txt_BuyerAddress.DataBindings.Add("Text", dv_Invoices, "Customer_Address");
            txt_BuyerAccount.DataBindings.Clear();
            txt_BuyerAccount.DataBindings.Add("Text", dv_Invoices, "Customer_Account");
            txt_BankName.DataBindings.Clear();
            txt_BankName.DataBindings.Add("Text", dv_Invoices, "Customer_BankName");
            dtp_ArisingDate.DataBindings.Clear();             
            dtp_ArisingDate.DataBindings.Add("Text", dv_Invoices, "Arissing_Date");            
            txt_InvoiceNo.DataBindings.Clear();
            txt_InvoiceNo.DataBindings.Add("Text", dv_Invoices, "Invoice_No");
            txt_InvoiceSerial.DataBindings.Clear();
            txt_InvoiceSerial.DataBindings.Add("Text", dv_Invoices, "Invoice_Serial");
            txt_InvoicePattern.DataBindings.Clear();
            txt_InvoicePattern.DataBindings.Add("Text", dv_Invoices, "Invoice_Pattern");
            cbo_PaymentType.DataBindings.Clear();            
            cbo_PaymentType.DataBindings.Add("SelectedValue", dv_Invoices, "Payment_Type");
            txt_LookupCode.DataBindings.Clear();
            txt_LookupCode.DataBindings.Add("Text", dv_Invoices, "Lookup_Code");
            txt_LookupCode.DataBindings.Add("Tag", dv_Invoices, "Invoice_Key");
            txt_Amount.DataBindings.Clear();
            txt_Amount.DataBindings.Add("Text", dv_Invoices, "Total_Amount");
            txt_VAT.DataBindings.Clear();
            txt_VAT.DataBindings.Add("Text", dv_Invoices, "VAT_Rate");
            txt_GrandTotal.DataBindings.Clear();
            txt_GrandTotal.DataBindings.Add("Text", dv_Invoices, "Grand_Total");
            txt_CompanyName.DataBindings.Clear();
            txt_CompanyName.DataBindings.Add("Text", dv_Invoices, "Company_Name");
            txt_CompanyAccount.DataBindings.Clear();
            txt_CompanyAccount.DataBindings.Add("Text", dv_Invoices, "Account");
            txt_CompanyAddress.DataBindings.Clear();
            txt_CompanyAddress.DataBindings.Add("Text", dv_Invoices, "Address");
            txt_CompanyPhone.DataBindings.Clear();
            txt_CompanyPhone.DataBindings.Add("Text", dv_Invoices, "Phone");
            txt_CompanyTaxcode.DataBindings.Clear();
            txt_CompanyTaxcode.DataBindings.Add("Text", dv_Invoices, "MST");
            txt_VATAmount.DataBindings.Clear();
            txt_VATAmount.DataBindings.Add("Text", dv_Invoices, "Total_VAT");
        }
    }
}
