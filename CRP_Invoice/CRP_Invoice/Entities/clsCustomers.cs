using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace CRP_Invoice
{
    class clsCustomers
    {
        private DataTable _tblCustomer;
        public DataTable tblCustomer
        {
            set { _tblCustomer = value; }
            get { return _tblCustomer; }
        }
        SQLiteDataAdapter sqliteDA = new SQLiteDataAdapter();
        SQLiteCommand sqliteSelectCMD = new SQLiteCommand();
        SQLiteCommand sqliteUpdateCMD = new SQLiteCommand();
        SQLiteCommand sqliteInsertCMD = new SQLiteCommand();
        SQLiteCommand sqliteDeleteCMD = new SQLiteCommand();
        public clsCustomers()
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
            _tblCustomer = new DataTable();
            sqliteDA.Fill(_tblCustomer);
        }
        public DataTable AddNewCustomer()
        {
            if (_tblCustomer != null)
            {
                DataRow dr = _tblCustomer.NewRow();
                _tblCustomer.Rows.Add(dr);
            }
            return _tblCustomer;
        }
        private void sqliteDA_RowUpdating(object sender, System.Data.Common.RowUpdatingEventArgs e)
        {
        }

        private void selectCMDBuider()
        {
            sqliteSelectCMD.CommandText = "select * from Customers where Customer_ID='####'";
            sqliteSelectCMD.CommandType = CommandType.Text;
            sqliteSelectCMD.Connection = Ultils.cnn();
        }
        private void selectCMDBuider(string criteria)
        {
            sqliteSelectCMD.CommandText = "select * from Customers " + criteria;
        }
        private void insertCMDBuider()
        {
            sqliteInsertCMD.CommandText = "INSERT INTO Customers(Customer_Code,	Customer_Name, Address, Taxcode, Bank_Account, Bank_Name, Company_Name)" +
                "VALUES(@Customer_Code,	@Customer_Name, @Address, @Taxcode, @Bank_Account, @Bank_Name, @Company_Name)";
            string[] prs = { "@Customer_Code", "@Customer_Name", "@Address", "@Taxcode", "@Bank_Account", "@Bank_Name", "@Company_Name" };
            buildParameters(prs, sqliteInsertCMD);
            sqliteInsertCMD.Connection = Ultils.cnn();
        }
        private void updateCMDBuider()
        {
            sqliteUpdateCMD.CommandText = "UPDATE [Customers] SET Customer_Code = @Customer_Code, Customer_Name = @Customer_Name, " +
                "Address = @Address, Taxcode = @Taxcode, Bank_Account = @Bank_Account, Bank_Name = @Bank_Name, Company_Name = @Company_Name " +
                "WHERE [Customer_ID] = @Customer_ID";
            string[] prs = { "@Customer_Code", "@Customer_Name", "@Address", "@Taxcode", "@Bank_Account", "@Bank_Name", "@Company_Name", "@Customer_ID" };
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
            sqliteDeleteCMD.CommandText = "Delete from Customers where Customer_ID=@Customer_ID";
            string[] prs = { "@Customer_ID" };
            buildParameters(prs, sqliteDeleteCMD);
            sqliteDeleteCMD.Connection = Ultils.cnn();
        }
        public DataTable getCustomer(string customerCode)
        {
            sqliteSelectCMD.CommandText = "select * from Customers where Customer_Code = '"+customerCode+"'";
            try
            {
                tblCustomer.Clear();
                sqliteDA.Fill(_tblCustomer);
            }
            catch (Exception ex) { throw ex; }
            return _tblCustomer;
        }
        public DataTable getCustomers()
        {
            sqliteSelectCMD.CommandText = "select * from Customers";
            try
            {
                tblCustomer.Clear();
                sqliteDA.Fill(_tblCustomer);
            }
            catch (Exception ex) { throw ex; }
            return _tblCustomer;
        }
        public DataTable getCustomers(string strCriteria)
        {
            selectCMDBuider(strCriteria);
            if (_tblCustomer == null)
            {
                tblCustomer = new DataTable();
            }
            tblCustomer.Clear();
            sqliteDA.Fill(_tblCustomer);
            return _tblCustomer;
        }
        public DataTable getCustomers_FullCommand(string strSQL)
        {
            sqliteSelectCMD.CommandText = strSQL;
            if (_tblCustomer == null)
            {
                tblCustomer = new DataTable();
            }
            tblCustomer.Clear();
            sqliteDA.Fill(_tblCustomer);
            return _tblCustomer;
        }
        public int updateCustomer(DataTable Customers)
        {
            int intResult = 0;
            try
            {
                intResult = sqliteDA.Update(Customers.GetChanges());
                _tblCustomer.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int updateCustomer()
        {
            int intResult = 0;
            try
            {
                DataTable dt = _tblCustomer.GetChanges();
                if (dt != null)
                {
                    intResult = sqliteDA.Update(dt);
                    _tblCustomer.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int insertCustomer(DataRow drCustomer)
        {
            return 0;
        }
        public void printCustomer(string CustomerKey)
        {

        }
        public static string GetCustomerCode() {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            SQLiteCommand cmm = new SQLiteCommand();
            string customerCode = "KH";
            cmm.CommandText = "select max(customer_id)+1 NextCustomerID from Customers";
            cmm.Connection = Ultils.cnn();
            da.SelectCommand = cmm;
            if (cmm.Connection.State == ConnectionState.Closed)
            {
                cmm.Connection.Open();
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0) {
                customerCode += string.IsNullOrEmpty(dt.Rows[0][0].ToString()) ? "0" : string.Format("{0:000000000}",dt.Rows[0][0].ToString());
            }
            return customerCode;
        }
    }
}
