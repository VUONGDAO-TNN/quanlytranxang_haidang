namespace CRP_Invoice
{
    partial class frm_Main
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
            this.ms_Main = new System.Windows.Forms.MenuStrip();
            this.mnu_System = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnu_Invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.bmnu_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bmnu_InvToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Main
            // 
            this.ms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_System,
            this.mnu_Management,
            this.mnu_Windows});
            this.ms_Main.Location = new System.Drawing.Point(0, 0);
            this.ms_Main.Name = "ms_Main";
            this.ms_Main.Size = new System.Drawing.Size(884, 24);
            this.ms_Main.TabIndex = 1;
            this.ms_Main.Text = "menuStrip1";
            // 
            // mnu_System
            // 
            this.mnu_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmnu_Setting,
            this.bmnu_exit});
            this.mnu_System.Name = "mnu_System";
            this.mnu_System.Size = new System.Drawing.Size(69, 20);
            this.mnu_System.Text = "Hệ thống";
            // 
            // bmnu_Setting
            // 
            this.bmnu_Setting.Name = "bmnu_Setting";
            this.bmnu_Setting.Size = new System.Drawing.Size(180, 22);
            this.bmnu_Setting.Text = "Thông số";
            this.bmnu_Setting.Visible = false;
            // 
            // bmnu_exit
            // 
            this.bmnu_exit.Name = "bmnu_exit";
            this.bmnu_exit.Size = new System.Drawing.Size(180, 22);
            this.bmnu_exit.Text = "Thoát";
            // 
            // mnu_Management
            // 
            this.mnu_Management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmnu_Invoice,
            this.bmnu_Customer,
            this.toolStripSeparator1,
            this.bmnu_InvToExcel});
            this.mnu_Management.Name = "mnu_Management";
            this.mnu_Management.Size = new System.Drawing.Size(60, 20);
            this.mnu_Management.Text = "Quản lý";
            // 
            // bmnu_Invoice
            // 
            this.bmnu_Invoice.Name = "bmnu_Invoice";
            this.bmnu_Invoice.Size = new System.Drawing.Size(206, 22);
            this.bmnu_Invoice.Text = "Hóa đơn";
            // 
            // bmnu_Customer
            // 
            this.bmnu_Customer.Name = "bmnu_Customer";
            this.bmnu_Customer.Size = new System.Drawing.Size(206, 22);
            this.bmnu_Customer.Text = "Khách hàng";
            this.bmnu_Customer.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // bmnu_InvToExcel
            // 
            this.bmnu_InvToExcel.Name = "bmnu_InvToExcel";
            this.bmnu_InvToExcel.Size = new System.Drawing.Size(206, 22);
            this.bmnu_InvToExcel.Text = "Xuất hóa đơn ra file excel";
            this.bmnu_InvToExcel.Visible = false;
            // 
            // mnu_Windows
            // 
            this.mnu_Windows.Name = "mnu_Windows";
            this.mnu_Windows.Size = new System.Drawing.Size(55, 20);
            this.mnu_Windows.Text = "Cửa sổ";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 544);
            this.Controls.Add(this.ms_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Main;
            this.Name = "frm_Main";
            this.Text = "Quản lý hóa đơn";
            this.ms_Main.ResumeLayout(false);
            this.ms_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Main;
        private System.Windows.Forms.ToolStripMenuItem mnu_System;
        private System.Windows.Forms.ToolStripMenuItem bmnu_exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_Management;
        private System.Windows.Forms.ToolStripMenuItem bmnu_Invoice;
        private System.Windows.Forms.ToolStripMenuItem bmnu_Customer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem bmnu_InvToExcel;
        private System.Windows.Forms.ToolStripMenuItem mnu_Windows;
        private System.Windows.Forms.ToolStripMenuItem bmnu_Setting;
    }
}

