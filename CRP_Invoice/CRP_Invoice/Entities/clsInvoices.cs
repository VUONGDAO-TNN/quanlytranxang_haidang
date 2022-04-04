using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CRP_Invoice
{
    public class clsInvoices
    {
        private DataTable _tblInvoice;
        public DataTable tblInvoice
        {
            set { _tblInvoice = value; }
            get { return _tblInvoice; }
        }
        private clsInvoiceServices _instOfIS;
        public clsInvoiceServices instOfIS
        {
            set { _instOfIS = value; }
            get { return _instOfIS; }
        }
        SQLiteDataAdapter sqliteDA = new SQLiteDataAdapter();
        SQLiteCommand sqliteSelectCMD = new SQLiteCommand();
        SQLiteCommand sqliteUpdateCMD = new SQLiteCommand();
        SQLiteCommand sqliteInsertCMD = new SQLiteCommand();
        SQLiteCommand sqliteDeleteCMD = new SQLiteCommand();
        public clsInvoices()
        {
            selectCMDBuider();
            updateCMDBuider();
            insertCMDBuider();
            deleteCMDBuider();
            sqliteDA.SelectCommand = sqliteSelectCMD;
            sqliteDA.InsertCommand = sqliteInsertCMD;
            sqliteDA.UpdateCommand = sqliteUpdateCMD;
            sqliteDA.DeleteCommand = sqliteDeleteCMD;
            sqliteDA.RowUpdating += sqliteDA_RowUpdating;
            _tblInvoice = new DataTable();
            _instOfIS = new clsInvoiceServices();
            sqliteDA.Fill(_tblInvoice);
        }
        public DataTable AddNewInvoice() {
            if (_tblInvoice != null)
            {
                DataRow dr = _tblInvoice.NewRow();
                DateTime dNow = DateTime.Now;
                dr["Arissing_Date"] = dNow;// string.Format("{0}{1:00}{2:00}", dNow.Year, dNow.Month, dNow.Day);
                dr["Invoice_Key"] = Ultils.UUIDGenerate(); //string.Format("{0}{1:00}{2:00}{3:00}{4:00}{5:00}{6:000}", dNow.Year, dNow.Month, dNow.Day, dNow.Hour, dNow.Minute, dNow.Second, dNow.Minute);
                //dr["Lookup_Code"] = dr["Invoice_Key"];
                dr["Customer_Code"] = dr["Invoice_Key"];
                dr["Invoice_Pattern"] = "01GTKT0/002";
                dr["Invoice_Serial"] = @"HD/"+dNow.Year.ToString().Substring(2)+"E";
                dr["Company_Name"] = "CÔNG TY CỔ PHẦN HẢI ĐĂNG";
                dr["MST"] = "4600388423";
                dr["Address"] = "Xóm bãi Á 1, Thị Trấn Chợ Chu, Huyện Định Hóa, Tỉnh Thái Nguyên,Việt Nam";
                dr["Phone"] = "0989182222";
                dr["Account"] = "8502201000674 tại Ngân hàng Agribank - Chi nhánh huyện Định Hóa\r\n" +
                    "39010000429680 tại Ngân hàng BIDV - Chi nhánh Thái Nguyên";
                dr["Payment_Type"] = "TM";
                dr["VAT_Rate"] = 10;
                _tblInvoice.Rows.Add(dr);
                _instOfIS = new clsInvoiceServices();
                _instOfIS.AddNewInvoiceService(dr["Invoice_Key"].ToString());
            }
            return _tblInvoice;
        }
        private void sqliteDA_RowUpdating(object sender, System.Data.Common.RowUpdatingEventArgs e)
        {
            string s = e.Row["Arissing_Date"].ToString();
            DateTime dt = DateTime.Parse(s);
            e.Row["Arissing_Date"] = string.Format("{0:0000}-{1:00}-{2:00}", dt.Year, dt.Month, dt.Day);
        }
        
        private void selectCMDBuider()
        {
            sqliteSelectCMD.CommandText = "select * from invoices where Invoice_Key='####'";
            sqliteSelectCMD.CommandType = CommandType.Text;
            sqliteSelectCMD.Connection = Ultils.cnn();
        }
        private void selectCMDBuider(string criteria)
        {
            sqliteSelectCMD.CommandText = "select * from invoices " + criteria;
        }
        private void insertCMDBuider()
        {
            sqliteInsertCMD.CommandText = "INSERT INTO Invoices(Invoice_Key, Invoice_No, Invoice_Pattern, Invoice_Serial, Lookup_Code, Arissing_Date, " +
                "Customer_Code, Customer_Name, Customer_CompanyName, Customer_Address, Customer_TaxCode, Payment_Type, Customer_Account, " +
                "Customer_BankName, VAT_Rate, Total_Amount, Total_VAT, Grand_Total, Company_Name, Account, MST, Address, Phone)" +
                "VALUES(@Invoice_Key, @Invoice_No, @Invoice_Pattern, @Invoice_Serial, @Invoice_Key, @Arissing_Date, @Customer_Code, " +
                "@Customer_Name, @Customer_CompanyName, @Customer_Address, @Customer_TaxCode, @Payment_Type, @Customer_Account, @Customer_BankName, " +
                "@VAT_Rate, @Total_Amount, @Total_VAT, @Grand_Total, @Company_Name, @Account, @MST, @Address, @Phone)";
            string[] prs = { "@Invoice_Key", "@Invoice_No", "@Invoice_Pattern", "@Invoice_Serial", "@Arissing_Date",
                "@Customer_Code", "@Customer_Name", "@Customer_CompanyName", "@Customer_Address", "@Customer_TaxCode", "@Payment_Type",
                "@Customer_Account", "@Customer_BankName", "@VAT_Rate", "@Total_Amount", "@Total_VAT", "@Grand_Total", "@Company_Name",
                "@Account", "@MST", "@Address", "@Phone" };
            buildParameters(prs, sqliteInsertCMD);
            sqliteInsertCMD.Connection = Ultils.cnn();
        }
        private void updateCMDBuider()
        {
            sqliteUpdateCMD.CommandText = "UPDATE [Invoices] SET [Invoice_Key] = @Invoice_Key, [Invoice_No] = @Invoice_No, " +
                "[Invoice_Pattern] = @Invoice_Pattern, [Invoice_Serial] = @Invoice_Serial, [Lookup_Code] = @Lookup_Code, " +
                "[Arissing_Date] = @Arissing_Date, [Customer_Code] = @Customer_Code, [Customer_Name] = @Customer_Name, " +
                "[Customer_CompanyName] = @Customer_CompanyName, [Customer_Address] = @Customer_Address, [Customer_TaxCode] = @Customer_TaxCode, " +
                "[Payment_Type] = @Payment_Type, [Customer_Account] = @Customer_Account, [Customer_BankName] = @Customer_BankName, " +
                "[VAT_Rate] = @VAT_Rate, [Total_Amount] = @Total_Amount, [Total_VAT] = @Total_VAT, [Grand_Total] = @Grand_Total, " +
                "[Company_Name] = @Company_Name, [Account] = @Account, [MST] = @MST, [Address] = @Address, [Phone] = @Phone WHERE [Invoice_Key] = @Invoice_Key_Old ";
            string[] prs = { "@Invoice_Key", "@Invoice_No", "@Invoice_Pattern", "@Invoice_Serial", "@Lookup_Code", "@Arissing_Date",
                "@Customer_Code", "@Customer_Name", "@Customer_CompanyName", "@Customer_Address", "@Customer_TaxCode", "@Payment_Type",
                "@Customer_Account", "@Customer_BankName", "@VAT_Rate", "@Total_Amount", "@Total_VAT", "@Grand_Total", "@Invoice_Key_Old",
                "@Company_Name", "@Account", "@MST", "@Address", "@Phone" };
            buildParameters(prs,sqliteUpdateCMD);
            sqliteUpdateCMD.Connection = Ultils.cnn();
        }
        private void buildParameters(string[] prs, SQLiteCommand cmm)
        {
            foreach (string pr in prs)
            {
                cmm.Parameters.Add(new SQLiteParameter(pr));
                if (pr.EndsWith("_Old", StringComparison.OrdinalIgnoreCase))
                {
                    cmm.Parameters[cmm.Parameters.Count - 1].SourceVersion = DataRowVersion.Original;
                }
                cmm.Parameters[cmm.Parameters.Count - 1].SourceColumn = pr.Replace("_Old", "").Replace("@", "");
            }
        }

        private void deleteCMDBuider()
        {
            sqliteDeleteCMD.CommandText = "Delete from Invoices where Invoice_Key=@Invoice_Key";
            string[] prs = { "@Invoice_Key"};
            buildParameters(prs, sqliteDeleteCMD);
            sqliteDeleteCMD.Connection = Ultils.cnn();
        }
        public DataTable getInvoices()
        {
            sqliteSelectCMD.CommandText = "select * from invoice";
            try
            {
                sqliteDA.Fill(_tblInvoice);
            }
            catch (Exception ex){ throw ex; }
            return _tblInvoice;
        }
        public DataTable getInvoices(string strCriteria)
        {
            selectCMDBuider(strCriteria);
            //executeSelectCMD();
            if (_tblInvoice == null)
            {
                tblInvoice = new DataTable();
            }
           // _tblInvoice.Columns["Arissing_Date"].DataType = typeof(DateTime);
            sqliteDA.Fill(_tblInvoice);
            return _tblInvoice;
        }
        public DataTable getInvoices(string strCriteria, string strOrderby)
        {
            selectCMDBuider(strCriteria+" "+strOrderby);
            //executeSelectCMD();
            if (_tblInvoice == null)
            {
                tblInvoice = new DataTable();
            }
            sqliteDA.Fill(_tblInvoice);
            return _tblInvoice;
        }
        public clsInvoices getInvoice(string invoiceKey) {
            selectCMDBuider("where Invoice_Key = '"+invoiceKey+"'");
            try
            {
                _tblInvoice.Clear();
                sqliteDA.Fill(_tblInvoice);
                _instOfIS = new clsInvoiceServices();
                _instOfIS.getInvoiceServices("where Invoice_Key = '" + invoiceKey + "'");
            }
            catch (Exception ex) {
                throw ex;
            }
            return this;
        }
        public int updateInvoice_NoAcceptChanges(DataRow drInvoice, DataTable services)
        {
            int intResult = 0;
            try
            {
                if (drInvoice != null)
                {
                    intResult = sqliteDA.Update(drInvoice.Table);
                }
                if (services != null && services.GetChanges() != null)
                {
                    intResult += _instOfIS.updateInvoiceService(services);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int updateInvoice(DataRow drInvoice, DataTable services)
        {
            int intResult = 0;
            try
            {
                if (drInvoice != null)
                {
                    intResult = sqliteDA.Update(drInvoice.Table);
                }
                if (services != null&& services.GetChanges()!=null) {
                    _instOfIS.updateInvoiceService(services);
                }
                _instOfIS.tblInvoiceService.AcceptChanges();
                _tblInvoice.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int updateInvoice()
        {
            int intResult = 0;
            try
            {
                DataTable dt = _tblInvoice.GetChanges();
                if (dt != null)
                {
                    intResult = sqliteDA.Update(dt);
                    _tblInvoice.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int insertInvoice(DataRow drInvoice)
        {
            return 0;
        }
        public string releaseInvoice(string invoiceKey)
        {
            publishwebservice.PublishServiceSoapClient ps = new publishwebservice.PublishServiceSoapClient();            

            //string ImportInv = "publishservice.asmx?op=ImportAndPublishInv";
            //string str = "https://haidangtnnadmindemo.vnpt-invoice.com.vn";
            //string[] lines = Regex.Split(str, "//");
            //string[] lines1 = Regex.Split(lines[1], "/");
            //string link = lines[0] + "//" + lines1[0] + "/" + ImportInv;
            clsInvoices inv = new clsInvoices();
            clsInvoiceServices invServices = new clsInvoiceServices();
            inv.getInvoice(invoiceKey);
            if (inv.tblInvoice.Rows.Count < 1)
            {
                return "";
            }
            string sServices = "";
            DataRow drInv = inv.tblInvoice.Rows[0];
            invServices.getInvoiceServices("where Invoice_Key = '" + invoiceKey + "'");
            foreach (DataRow drService in invServices.tblInvoiceService.Rows) {
                double dblQuantity = 0, dblUnit_Price=0, dblAmount=0;
                double.TryParse(drService["Quantity"].ToString(), out dblQuantity);
                double.TryParse(drService["Unit_Price"].ToString(), out dblUnit_Price);
                double.TryParse(drService["Amount"].ToString(), out dblAmount);
                sServices += "<Product>" +
                        "<ProdName><![CDATA[" + escape(drService["Service_Name"].ToString()) + "]]></ProdName>" +
                        "<ProdUnit><![CDATA[" + escape(drService["Unit"].ToString()) + "]]></ProdUnit>" +
                        "<ProdQuantity>" + dblQuantity.ToString("F2", CultureInfo.InvariantCulture) + "</ProdQuantity>" +
                        "<ProdPrice>" + dblUnit_Price.ToString("F2", CultureInfo.InvariantCulture) + "</ProdPrice>" +
                        "<Amount>" + dblAmount.ToString("F2", CultureInfo.InvariantCulture) + "</Amount>" +
                    "</Product>";
            }
            //WebClient client = new WebClient();
            //client.Headers.Add("SOAPAction", "\"http://tempuri.org/publishInvFkey\"");
            //client.Headers.Add("Content-Type", "text/xml; charset=utf-8");
            DateTime dArisingDate;
            if (!DateTime.TryParse(drInv["Arissing_Date"].ToString(), out dArisingDate)) {
                dArisingDate = DateTime.Now;
            }
            double dblGrandTotal = 0, dblTotal_VAT=0, dblVAT_Rate=0, dblTotal_Amount=0;
            double.TryParse(drInv["Grand_Total"].ToString(), out dblGrandTotal);
            double.TryParse(drInv["Total_VAT"].ToString(), out dblTotal_VAT);
            double.TryParse(drInv["VAT_Rate"].ToString(), out dblVAT_Rate);
            double.TryParse(drInv["Total_Amount"].ToString(), out dblTotal_Amount);            
            string body = "<Invoices>" +
                    "<Inv>" +
                        "<key>" + invoiceKey + "</key>" +
                        "<Invoice>" +
                            "<CusCode><![CDATA[" + escape(drInv["Customer_Code"].ToString()) + "]]></CusCode>" +
                            "<CusName><![CDATA[" + escape(drInv["Customer_CompanyName"].ToString()) + "]]></CusName>" +
                            "<Buyer><![CDATA[" + escape(drInv["Customer_Name"].ToString()) + "]]></Buyer>" +
                            "<CusAddress><![CDATA[" + escape(drInv["Customer_Address"].ToString()) + "]]></CusAddress>" +
                            "<CusTaxCode><![CDATA[" + escape(drInv["Customer_TaxCode"].ToString()) + "]]></CusTaxCode>" +
                            "<PaymentMethod><![CDATA[" + escape(drInv["Payment_Type"].ToString()) + "]]></PaymentMethod>" +
                            "<Extra><![CDATA[" + escape(invoiceKey) + "]]></Extra>" +
                            "<CusCom><![CDATA[" + escape(drInv["Customer_CompanyName"].ToString()) + "]]></CusCom>" +
                            "<Products>"+sServices+"</Products>" +
                            "<Total>" + dblTotal_Amount.ToString("F2", CultureInfo.InvariantCulture) + "</Total>" +
                            //"<VatAmount0>" + dblTotal_VAT.ToString("F2", CultureInfo.InvariantCulture) + "</VatAmount0>" +
                            "<KindOfService>"+string.Format("{0:00}",dArisingDate.Month)+"</KindOfService>" +
                            "<VATRate>" + dblVAT_Rate.ToString("F0", CultureInfo.InvariantCulture) + "</VATRate>" +
                            "<VATAmount>" + dblTotal_VAT.ToString("F2", CultureInfo.InvariantCulture) + "</VATAmount>" +
                            "<Amount>" + dblGrandTotal.ToString("F0", CultureInfo.InvariantCulture) + "</Amount>" +
                            "<AmountInWords><![CDATA[" + escape(Ultils.NumberToText(drInv["Grand_Total"].ToString()))+"]]></AmountInWords>" +
                            "<ArisingDate><![CDATA[" + string.Format("{0:00}/{1:00}/{2:0000}",dArisingDate.Day,dArisingDate.Month,dArisingDate.Year)+"]]></ArisingDate>" +
                        "</Invoice>" +
                    "</Inv>" +
                "</Invoices>";
            try
            {
                string sResult = ps.ImportAndPublishInv(Program.SysUsername,Program.SysPassword, body, Program.WsUsername, Program.WsPassword,
                    drInv["Invoice_Pattern"].ToString(), drInv["Invoice_Serial"].ToString(), 0);
                return sResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string getExistInvoice(string invoiceKey) {
            portalwebservice.PortalServiceSoapClient ps = new portalwebservice.PortalServiceSoapClient();
            string sResult = "ERR:1";
            int i = 0;
            while (i<20 && sResult.Equals("ERR:1", StringComparison.OrdinalIgnoreCase))
            {
                i++;
                sResult = ps.downloadInvFkeyNoPay(invoiceKey, Program.WsUsername, Program.WsPassword);
            }
            return sResult;
        }
        public void printInvoice(string invoiceKey)
        {

        }
        public int deleteInvoice(string invoiceKey) {
            SQLiteCommand cmm = new SQLiteCommand();
            cmm.Connection = Ultils.cnn();
            int delResult = 0;
            try
            {
                cmm.CommandText = "Delete from InvoiceServices where Invoice_Key = '" + invoiceKey + "'";
                if (cmm.Connection.State == ConnectionState.Closed)
                {
                    cmm.Connection.Open();
                }
                delResult = cmm.ExecuteNonQuery();
                cmm.CommandText = "Delete from Invoices where Invoice_Key = '" + invoiceKey + "'";
                delResult += cmm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                cmm.Connection.Close();
            }
            return delResult;
        }
        private string escape(string s)
        {
            return s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("\'", "&apos;");
        }
    }
}
