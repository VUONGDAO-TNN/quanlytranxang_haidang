using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraHoaDon
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(Request.QueryString["er"]))
            //{
            //    viewError.InnerHtml = "<p style='color:red; font-size:15px'>Có lỗi xảy ra, vui lòng kiểm tra lại mã tra cứu và thao tác lại</p>";
            //}
            //if (!String.IsNullOrEmpty(Request.QueryString["k"]))
            //{
            //    txtFkey.Value = Request.QueryString["k"];
            //}
        }
        protected void btnTraCuu_Click(object sender, EventArgs e)
        {
            //string fkey = txtFkey.Value;
            //if (fkey.Trim() != "")
            //    Response.Redirect("XemHD.aspx?key=" + fkey);
            //else
            //    viewError.InnerHtml = "<p style='color:red; font-size:15px'>Vui lòng nhập vào mã tra cứu</p>";
        }
    }
}