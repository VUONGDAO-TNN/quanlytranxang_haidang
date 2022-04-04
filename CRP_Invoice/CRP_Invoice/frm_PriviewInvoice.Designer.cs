namespace CRP_Invoice
{
    partial class frm_PriviewInvoice
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
            this.btn_Print = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Pattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Serial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_InvoiceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(0, 0);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 29);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1165, 713);
            this.webBrowser1.TabIndex = 1;
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(81, 0);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 23);
            this.btn_Reload.TabIndex = 1;
            this.btn_Reload.Text = "Refresh";
            this.btn_Reload.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // txt_Pattern
            // 
            this.txt_Pattern.Location = new System.Drawing.Point(222, 2);
            this.txt_Pattern.Name = "txt_Pattern";
            this.txt_Pattern.Size = new System.Drawing.Size(100, 20);
            this.txt_Pattern.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mẫu số:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.Location = new System.Drawing.Point(384, 2);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(100, 20);
            this.txt_Serial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ký hiệu:";
            // 
            // txt_InvoiceNo
            // 
            this.txt_InvoiceNo.Location = new System.Drawing.Point(557, 3);
            this.txt_InvoiceNo.Name = "txt_InvoiceNo";
            this.txt_InvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.txt_InvoiceNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số HĐ:";
            // 
            // frm_PriviewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 743);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_InvoiceNo);
            this.Controls.Add(this.txt_Serial);
            this.Controls.Add(this.txt_Pattern);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Print);
            this.Name = "frm_PriviewInvoice";
            this.Text = "frm_PriviewInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Pattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InvoiceNo;
        private System.Windows.Forms.Label label3;
    }
}