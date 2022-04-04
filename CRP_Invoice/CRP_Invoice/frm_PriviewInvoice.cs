using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRP_Invoice
{
    public partial class frm_PriviewInvoice : Form
    {
        private string _InvoiceKey;
        public string InvoiceKey
        {
            set { _InvoiceKey = value; }
        }
        private string _InvoicePattern;
        public string InvoicePattern
        {
            set { _InvoicePattern = value; }
        }
        private string _InvoiceSerial;
        public string InvoiceSerial
        {
            set { _InvoiceSerial = value; }
        }
        private string _InvoiceNo;
        public string InvoiceNo
        {
            set { _InvoiceNo = value; }
        }
        public frm_PriviewInvoice()
        {
            InitializeComponent();
            Load += frm_PriviewInvoice_Load;
            Shown += frm_PriviewInvoice_Shown;
            btn_Print.Click += btn_Print_Click;
            btn_Reload.Click += btn_Reload_Click;
            button1.Click += Button1_Click;            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = @"<!DOCTYPE html><html><head><title>Hello World</title><style>html, body {width: 100%;height: 100%;margin: 0;padding: 0;background-color: green;}#container {width: inherit;height: inherit;margin: 0;padding: 0;background-color: pink;}h1 {margin: 0;padding: 0;}div.chapter,div.appendix{page-break-after:always;}@page{size:148mm 210 mm;margin:0 0 0 0;}</style></head><body><div id=""container""><h1>Hello World</h1></div></body></html>";
        }

        private void frm_PriviewInvoice_Shown(object sender, EventArgs e)
        {
            btn_Reload_Click(btn_Reload, new EventArgs());
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            portalwebservice.PortalServiceSoapClient ps = new portalwebservice.PortalServiceSoapClient();

            string strHTML = ps.getInvViewNoPay(txt_Pattern.Text + ";" + txt_Serial.Text + ";" + txt_InvoiceNo.Text,
                Program.WsUsername, Program.WsPassword);
            int i = 0;
            while (strHTML.StartsWith("ERR", StringComparison.OrdinalIgnoreCase))
            {
                if (strHTML.StartsWith("ERR:1", StringComparison.OrdinalIgnoreCase))
                {
                    i++;
                    if (i > 20)
                    {
                        DialogResult drl = MessageBox.Show("Không thể kết nối với hệ thống HDDT.\n\r" +
                            "Bạn có muốn thực hiện lại không?", "Thông báo", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (drl != DialogResult.Yes)
                        {
                            break;
                        }
                        else
                        {
                            i = 0;
                        }
                    }
                    strHTML = ps.getInvViewNoPay(_InvoicePattern + ";" + _InvoiceSerial + ";" + _InvoiceNo,
                        Program.WsUsername, Program.WsPassword);

                }
                else {
                    break;
                }
            }
            webBrowser1.DocumentText = strHTML;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void frm_PriviewInvoice_Load(object sender, EventArgs e)
        {
            Text = "Hóa đơn số:" + _InvoiceNo;
            txt_Pattern.Text = _InvoicePattern;
            txt_Serial.Text = _InvoiceSerial;
            txt_InvoiceNo.Text = _InvoiceNo;
        }
    }
}