using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRP_Invoice
{
    public partial class UC_Popup : UserControl
    {
        public UC_Popup()
        {
            InitializeComponent();
        }
        public void setDataSource(DataView ds) {
            grv_Popup.DataSource = ds;
        }
    }
}
