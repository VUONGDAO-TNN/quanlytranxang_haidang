using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace CRP_Invoice
{
    public class clsInvoiceServices
    {
        private DataTable _tblInvoiceService;
        public DataTable tblInvoiceService
        {
            set { _tblInvoiceService = value; }
            get { return _tblInvoiceService; }
        }
        SQLiteDataAdapter sqliteDA = new SQLiteDataAdapter();
        SQLiteCommand sqliteSelectCMD = new SQLiteCommand();
        SQLiteCommand sqliteUpdateCMD = new SQLiteCommand();
        SQLiteCommand sqliteInsertCMD = new SQLiteCommand();
        SQLiteCommand sqliteDeleteCMD = new SQLiteCommand();
        public clsInvoiceServices()
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
            sqliteDA.RowUpdated += sqliteDA_RowUpdated;
            _tblInvoiceService = new DataTable();
            sqliteDA.Fill(_tblInvoiceService);
        }

        private void sqliteDA_RowUpdated(object sender, System.Data.Common.RowUpdatedEventArgs e)
        {
            //update invoice service id(AutoIncrement)
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            SQLiteCommand cmm = new SQLiteCommand();
            DataTable dt = new DataTable();
            da.SelectCommand = cmm;
            cmm.CommandText = "SELECT seq from sqlite_sequence WHERE name='InvoiceServices'";
            cmm.CommandType = CommandType.Text;
            cmm.Connection = Ultils.cnn();
            try
            {
                if (cmm.Connection.State == ConnectionState.Closed)
                {
                    cmm.Connection.Open();
                }
                da.Fill(dt);
                if (e.Row.RowState== DataRowState.Added && dt.Rows.Count > 0 && dt.Rows[0][0] != null)
                {
                    e.Row["InvoiceService_ID"] = Int32.Parse(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                cmm.Connection.Close();
            }
        }

        public DataTable AddNewInvoiceService()
        {
            if (_tblInvoiceService != null)
            {
                DataRow dr = _tblInvoiceService.NewRow();
                _tblInvoiceService.Rows.Add(dr);
            }
            return _tblInvoiceService;
        }
        public DataTable AddNewInvoiceService(string invoiceKey)
        {
            if (_tblInvoiceService != null)
            {
                DataRow dr = _tblInvoiceService.NewRow();
                dr["Invoice_Key"] = invoiceKey;
                _tblInvoiceService.Rows.Add(dr);
            }
            return _tblInvoiceService;
        }
        private void sqliteDA_RowUpdating(object sender, System.Data.Common.RowUpdatingEventArgs e)
        {
        }

        private void selectCMDBuider()
        {
            sqliteSelectCMD.CommandText = "select * from InvoiceServices where Invoice_Key = '####'";
            sqliteSelectCMD.CommandType = CommandType.Text;
            sqliteSelectCMD.Connection = Ultils.cnn();
        }
        private void selectCMDBuider(string criteria)
        {
            sqliteSelectCMD.CommandText = "select * from InvoiceServices " + criteria;
        }
        private void insertCMDBuider()
        {
            sqliteInsertCMD.CommandText = "INSERT INTO InvoiceServices(Invoice_Key, Service_Name, Unit, Quantity, Unit_price, Amount, Discount_Rate, Discount_Amount, Service_ID)" +
                "VALUES(@Invoice_Key, @Service_Name, @Unit, @Quantity, @Unit_price, @Amount, @Discount_Rate, @Discount_Amount, @Service_ID)";
            string[] prs = { "@Invoice_Key", "@Service_Name", "@Unit", "@Quantity", "@Unit_price", "@Amount", "@Discount_Rate", "@Discount_Amount", "@Service_ID" };
            buildParameters(prs, sqliteInsertCMD);
            sqliteInsertCMD.Connection = Ultils.cnn();
        }
        private void updateCMDBuider()
        {
            sqliteUpdateCMD.CommandText = "UPDATE [InvoiceServices] SET Invoice_Key = @Invoice_Key, Service_Name = @Service_Name, Unit = @Unit, " +
                "Quantity = @Quantity, Unit_price = @Unit_price, Amount = @Amount, Discount_Rate = @Discount_Rate, Discount_Amount = @Discount_Amount, " +
                "Service_ID = @Service_ID WHERE [InvoiceService_ID] = @InvoiceService_ID ";
            string[] prs = { "@Invoice_Key", "@Service_Name", "@Unit", "@Quantity", "@Unit_price", "@Amount", "@Discount_Rate", "@Discount_Amount", "InvoiceService_ID", "@Service_ID" };
            buildParameters(prs, sqliteUpdateCMD);
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
            sqliteDeleteCMD.CommandText = "Delete from InvoiceServices where InvoiceService_ID=@InvoiceService_ID";
            string[] prs = { "@InvoiceService_ID" };
            buildParameters(prs, sqliteDeleteCMD);
            sqliteDeleteCMD.Connection = Ultils.cnn();
        }
        public DataTable getInvoiceServices()
        {
            sqliteSelectCMD.CommandText = "select * from InvoiceServices";
            try
            {
                sqliteDA.Fill(_tblInvoiceService);
            }
            catch (Exception ex) { throw ex; }
            return _tblInvoiceService;
        }
        public DataTable getInvoiceServices(string strCriteria)
        {
            selectCMDBuider(strCriteria);
            if (_tblInvoiceService == null)
            {
                tblInvoiceService = new DataTable();
            }
            sqliteDA.Fill(_tblInvoiceService);            
            return _tblInvoiceService;
        }
        public int updateInvoiceService(DataTable InvoiceServices)
        {
            int intResult = 0;
            try
            {
                intResult = sqliteDA.Update(InvoiceServices);
                _tblInvoiceService.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int updateInvoiceService()
        {
            int intResult = 0;
            try
            {
                DataTable dt = _tblInvoiceService.GetChanges();
                if (dt != null)
                {
                    intResult = sqliteDA.Update(dt);
                    _tblInvoiceService.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int insertInvoiceService(DataRow drInvoiceService)
        {
            return 0;
        }
        public void printInvoiceService(string InvoiceServiceKey)
        {

        }
    }
}
