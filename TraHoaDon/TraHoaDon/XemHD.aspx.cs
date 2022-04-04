using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Xml;


namespace TraHoaDon
{
    public partial class XemHD : System.Web.UI.Page
    {
        private string url = "";
        private string fkey = "";
        private string AC = "";
        private string pass = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Request.QueryString["key"]))
                {
                    AC = ConfigurationManager.AppSettings["serviceACC"].ToString();
                    pass = ConfigurationManager.AppSettings["servicePass"].ToString();
                    string key = Request.QueryString["key"];
                    fkey = decodeFkey(key);
                    if (fkey != "")
                    {
                        int dem = 0;
                        string result = callWebservice_getInvViewNoPay(url, fkey, AC, pass);
                        while (result.StartsWith("ERR:1") && dem <= 20)
                        {
                            result = callWebservice_getInvViewNoPay(url, fkey, AC, pass);
                            dem++;
                        }
                        if (result.StartsWith("ERR"))
                            Server.Transfer("Index.aspx?er=2");
                        else
                            viewInv.InnerHtml = result;
                    }
                    else
                        Response.Redirect("index.aspx?er=3");
                }
            }
            catch (Exception)
            {
                Response.Redirect("index.aspx?er=1&k="+ Request.QueryString["key"]);
            }
        }
        private string callWebservice_convertForStoreFkey(string link, string fkey, string txtACservice, string txtPass)
        {
            WebClient client = new WebClient();
            client.Headers.Add("SOAPAction", "\"http://tempuri.org/convertForStoreFkey\"");
            client.Headers.Add("Content-Type", "text/xml; charset=utf-8");
            string body = "<convertForStoreFkey xmlns=" + "'" + "http://tempuri.org" + "/'>" +
                            "<fkey>" + fkey + "</fkey>" +
                            "<userName>" + txtACservice + "</userName>" +
                            "<userPass>" + txtPass + "</userPass>" +
                        "</convertForStoreFkey>";
            string content = PostWS(body);
            var data = Encoding.UTF8.GetBytes(content);

            try
            {
                var result = client.UploadData(link, data);

                string kq = Encoding.UTF8.GetString(result);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(kq);
                client.Dispose();
                return doc.InnerText;
            }
            catch (Exception)
            {
                // MessageBox.Show("Sai link website!");
                return null;
            }
        }
        private string callWebservice_getInvViewNoPay(string link, string token, string txtACservice, string txtPass)
        {
            invoices.portalservice.PortalService ps = new invoices.portalservice.PortalService();
            return ps.getInvViewNoPay(fkey,txtACservice,txtPass);
            //WebClient client = new WebClient();
            //client.Headers.Add("SOAPAction", "\"http://tempuri.org/getInvViewNoPay\"");
            //client.Headers.Add("Content-Type", "text/xml; charset=utf-8");
            //string body = "<getInvViewNoPay xmlns=" + "'" + "http://tempuri.org" + "/'>" +
            //                "<invToken>" + token + "</invToken>" +
            //                "<userName>" + txtACservice + "</userName>" +
            //                "<userPass>" + txtPass + "</userPass>" +
            //            "</getInvViewNoPay>";
            //string content = PostWS(body);
            //var data = Encoding.UTF8.GetBytes(content);

            //try
            //{
            //    var result = client.UploadData(link, data);

            //    string kq = Encoding.UTF8.GetString(result);
            //    XmlDocument doc = new XmlDocument();
            //    doc.LoadXml(kq);
            //    client.Dispose();
            //    return doc.InnerText;
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
        }
        private string PostWS(string body)
        {
            string soap =
                    @"<?xml version=""1.0"" encoding=""utf-8""?>
                        <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
                        xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" 
                        xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                          <soap:Body>"
                            + body +
                          "</soap:Body>"
                        + "</soap:Envelope>";
            return soap;
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
                    return pattern+"/"+subPattern+";"+serial+"/"+subSerial+"E;"+invNo;
                }
                else
                    return "";
                
            }
            catch (Exception)
            {
                return "";
            }
            
        }
    }
}