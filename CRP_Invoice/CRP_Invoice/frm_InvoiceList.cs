using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CRP_Invoice
{
    public partial class frm_InvoiceList : Form
    {
        DataRowView focusedInvoice;
        frm_Invoice f_Invoice;
        clsInvoices instOfInvoice;
        public frm_InvoiceList()
        {
            InitializeComponent();
            Load += frm_InvoiceList_Load;
            grv_InvoiceList.AutoGenerateColumns = false;
            btn_Search.Click += btn_Search_Click;
            txt_Keyword.TextChanged += Txt_Keyword_TextChanged;
            btn_Add.Click += btn_Add_Click;
            btn_Close.Click += btn_Close_Click;
            btn_Print.Click += btn_Print_Click;
            btn_Update.Click += btn_Update_Click;
            btn_Delete.Click += btn_Delete_Click;            
            grv_InvoiceList.SelectionChanged += Grv_InvoiceList_SelectionChanged;
            f_Invoice = new frm_Invoice();
            f_Invoice.FormClosed += f_Invoice_FormClosed;
        }

        private void f_Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_Search_Click(btn_Search, new EventArgs());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (grv_InvoiceList.CurrentCell.OwningRow.IsNewRow)
            {
                return;
            }
            string invNo = focusedInvoice["Invoice_No"].ToString();
            if (!string.IsNullOrEmpty(invNo) && int.TryParse(invNo, out int i)) {
                btn_Delete.Enabled = false;
                MessageBox.Show("Hóa đơn đã phát hành.\r\nKhông thể xóa.");
            }
            else
            {
                DialogResult drl = MessageBox.Show("Bạn có muốn xóa hóa đơn đang chọn không?", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (drl != DialogResult.No) {
                    int delResult= instOfInvoice.deleteInvoice(focusedInvoice["Invoice_Key"].ToString());
                    if (delResult > 0)
                    {
                        MessageBox.Show("Hóa đơn đã được xóa.");
                        btn_Search_Click(btn_Search, new EventArgs());
                    }
                    else {
                        MessageBox.Show("Không hóa đơn nào được xóa.\r\nMã hóa đơn:"+focusedInvoice["Invoice_Key"].ToString()+" không tồn tại.");
                    }
                }
            }
        }

        private void Grv_InvoiceList_SelectionChanged(object sender, EventArgs e)
        {
            if (!(grv_InvoiceList.Rows.Count > 0)) {
                focusedInvoice = null;
                return;
            }
            if (!(grv_InvoiceList.SelectedRows.Count > 0)) {
                return;
            }
            //focusedInvoice = ((DataRowView)(grv_InvoiceList.Rows[grv_InvoiceList.CurrentCell.RowIndex].DataBoundItem)) != null ?
            //((DataRowView)(grv_InvoiceList.Rows[grv_InvoiceList.CurrentCell.RowIndex].DataBoundItem)) : null;
            focusedInvoice = (DataRowView) grv_InvoiceList.SelectedRows[0].DataBoundItem;
            string invNo = focusedInvoice["Invoice_No"].ToString();
            btn_Delete.Enabled = !(!string.IsNullOrEmpty(invNo) && int.TryParse(invNo, out int i));
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (focusedInvoice == null)
            {
                return;
            }
            if (f_Invoice == null) {
                f_Invoice = new frm_Invoice();
            }
            clsInvoices instINV = new clsInvoices();
            instINV.getInvoice(focusedInvoice["Invoice_Key"].ToString());
            f_Invoice.instOfInvoice = instINV;
            f_Invoice.StartPosition = FormStartPosition.CenterScreen;
            f_Invoice.ShowDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            
            frm_PriviewInvoice f = new frm_PriviewInvoice();
            f.InvoicePattern = focusedInvoice!=null? focusedInvoice["Invoice_Pattern"].ToString():"";
            f.InvoiceSerial = focusedInvoice != null ? focusedInvoice["Invoice_Serial"].ToString() : "";
            f.InvoiceNo = focusedInvoice != null ? focusedInvoice["Invoice_No"].ToString():"";
            f.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (f_Invoice == null)
            {
                f_Invoice = new frm_Invoice();
            }
            f_Invoice.instOfInvoice = new clsInvoices();
            f_Invoice.StartPosition = FormStartPosition.CenterScreen;
            f_Invoice.ShowDialog();
        }

        private void Txt_Keyword_TextChanged(object sender, EventArgs e)
        {
            btn_Search_Click(this, new EventArgs());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sCriteria = buildCritearia();
            if (instOfInvoice == null) {
                instOfInvoice = new clsInvoices();
            }
            instOfInvoice.tblInvoice.Rows.Clear(); 
            instOfInvoice.getInvoices(sCriteria+ " order by Arissing_Date DESC");
            //instOfInvoice.getInvoices(sCriteria + " order by Invoice_No DESC");
        }

        private void frm_InvoiceList_Load(object sender, EventArgs e)
        {
            dtp_From.Value = DateTime.Now;
            dtp_To.Value = DateTime.Now;
            btn_Search_Click(this, new EventArgs());
            DataTable tblInv = instOfInvoice.tblInvoice;

            DataTable dt1 = tblInv.Clone();
            if (tblInv.Rows.Count > 0)
            {
                dt1.Columns["Arissing_Date"].DataType = typeof(DateTime);
                foreach (DataRow row in tblInv.Rows)
                {
                    dt1.ImportRow(row);
                }
            }
            grv_InvoiceList.DataSource = dt1;
        }
        string buildCritearia() {
            string sF, sT, sK;
            if (dtp_From.Checked) {
                sF = "julianday(" + String.Format("{0,4}-{1,2:00}-{2,2:00}", dtp_From.Value.Year, dtp_From.Value.Month, dtp_From.Value.Day) +
                    ") - julianday(ArissingDate)>=0";
            }
            if (dtp_To.Checked) {
                sT = "julianday(" + String.Format("{0,4}-{1,2:00}-{2,2:00}", dtp_To.Value.Year, dtp_To.Value.Month, dtp_To.Value.Day) +
                    ") - julianday(ArissingDate)<=0";
            }
            sK = "(Customer_Code like '%" + txt_Keyword.Text + "%' or Customer_Name like '%" + txt_Keyword.Text + "%' or Customer_Address like '%" + txt_Keyword.Text + "%' or Customer_TaxCode like '%" + txt_Keyword.Text + "%')";
            sK += dtp_From.Checked ? (" and " + "julianday(" + String.Format("{0,4}-{1,2:00}-{2,2:00}", dtp_From.Value.Year, dtp_From.Value.Month, dtp_From.Value.Day) +
                    ") - julianday(Arissing_Date)<=0") : "";
            sK += dtp_To.Checked ? " and " + "julianday(" + String.Format("{0,4}-{1,2:00}-{2,2:00}", dtp_To.Value.Year, dtp_To.Value.Month, dtp_To.Value.Day) +
                    ") - julianday(Arissing_Date)<=0" : "";
            return " where "+sK;
        }
    }
}
