namespace CRP_Invoice
{
    partial class frm_Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Site = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_WsUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_WsPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SysUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SysPass = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site:";
            // 
            // txt_Site
            // 
            this.txt_Site.Location = new System.Drawing.Point(72, 9);
            this.txt_Site.Name = "txt_Site";
            this.txt_Site.Size = new System.Drawing.Size(398, 20);
            this.txt_Site.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "WS User:";
            // 
            // txt_WsUser
            // 
            this.txt_WsUser.Location = new System.Drawing.Point(72, 35);
            this.txt_WsUser.Name = "txt_WsUser";
            this.txt_WsUser.Size = new System.Drawing.Size(140, 20);
            this.txt_WsUser.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "WS Password:";
            // 
            // txt_WsPass
            // 
            this.txt_WsPass.Location = new System.Drawing.Point(330, 35);
            this.txt_WsPass.Name = "txt_WsPass";
            this.txt_WsPass.Size = new System.Drawing.Size(140, 20);
            this.txt_WsPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sys User:";
            // 
            // txt_SysUser
            // 
            this.txt_SysUser.Location = new System.Drawing.Point(72, 61);
            this.txt_SysUser.Name = "txt_SysUser";
            this.txt_SysUser.Size = new System.Drawing.Size(140, 20);
            this.txt_SysUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sys Password:";
            // 
            // txt_SysPass
            // 
            this.txt_SysPass.Location = new System.Drawing.Point(330, 61);
            this.txt_SysPass.Name = "txt_SysPass";
            this.txt_SysPass.Size = new System.Drawing.Size(140, 20);
            this.txt_SysPass.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(72, 103);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Lưu cấu hình";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 138);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_SysPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_WsPass);
            this.Controls.Add(this.txt_SysUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_WsUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Site);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Setting";
            this.Text = "Cấu hình hệ thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Site;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_WsUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_WsPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SysUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SysPass;
        private System.Windows.Forms.Button btn_Save;
    }
}