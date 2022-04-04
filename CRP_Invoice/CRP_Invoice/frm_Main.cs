using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRP_Invoice
{    
    public partial class frm_Main : Form
    {
        frm_InvoiceList f_invList;
        public frm_Main()
        {
            InitializeComponent();
            bmnu_Customer.Click += bmnu_Customer_Click;
            bmnu_Invoice.Click += bmnu_Invoice_Click;
            bmnu_exit.Click += bmnu_exit_Click;
            bmnu_InvToExcel.Click += Bmnu_InvToExcel_Click;
            this.Load += frm_Main_Load;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void bmnu_Invoice_Click(object sender, EventArgs e)
        {
            try {
                if (f_invList == null) {
                    f_invList = new frm_InvoiceList();
                }
                f_invList.WindowState = FormWindowState.Maximized;
                f_invList.MdiParent = this;

                f_invList.Show();
                f_invList.FormClosed += f_invList_FormClosed;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        private void f_invList_FormClosed(object sender, FormClosedEventArgs e)
        {
            f_invList = null;
        }

        private void Bmnu_InvToExcel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bmnu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bmnu_Customer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
