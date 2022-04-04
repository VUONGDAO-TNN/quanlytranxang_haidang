namespace CRP_Invoice
{
    partial class UC_Popup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grv_Popup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Popup)).BeginInit();
            this.SuspendLayout();
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
            this.grv_Popup.Size = new System.Drawing.Size(390, 204);
            this.grv_Popup.TabIndex = 1;
            // 
            // UC_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grv_Popup);
            this.Name = "UC_Popup";
            this.Size = new System.Drawing.Size(390, 204);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Popup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_Popup;
    }
}
