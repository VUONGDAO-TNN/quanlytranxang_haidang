using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace lookupInv
{
    public partial class action_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count > 0)
            {
                string lookupCode = Request.QueryString[0].ToString();
                lookupInv(lookupCode);
            }
        }
        private void lookupInv(string lookupCode) {
            haidangtnnadmin.PortalService ps = new haidangtnnadmin.PortalService();
            string token=decodeFkey(lookupCode);
            test.InnerHtml = ps.getInvViewNoPay(token, "haidangtnnservice", "123456");

        }
        private string decodeFkey(string s)
        {
            try
            {
                string pattern = s.Substring(0, 2);
                pattern = checkPattern(pattern);
                if (pattern != "")
                {
                    string subPattern = s.Substring(2, 3);
                    string serial = s.Substring(5, 2); ;
                    string subSerial = s.Substring(7, 2);
                    string invNo = s.Substring(9, s.Length - 9);
                    return pattern + "/" + subPattern + ";" + serial + "/" + subSerial + "E;" + invNo;
                }
                else
                    return "";

            }
            catch (Exception)
            {
                return "";
            }
        }
        private string checkPattern(string s)
        {

            switch (s)
            {
                case "01":
                    s = "01GTKT0";
                    break;
                case "02":
                    s = "02GTTT0";
                    break;
                case "03":
                    s = "03XKNB0";
                    break;
                case "04":
                    s = "04HGDL0";
                    break;
                case "07":
                    s = "07KPTQ0";
                    break;
                default:
                    s = "";
                    break;
            }
            return s;
        }
    }
}
