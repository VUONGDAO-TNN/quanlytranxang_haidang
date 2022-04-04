using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace CRP_Invoice
{
    class clsServices
    {
        private DataTable _tblService;
        public DataTable tblService
        {
            set { _tblService = value; }
            get { return _tblService; }
        }        
        SQLiteDataAdapter sqliteDA = new SQLiteDataAdapter();
        SQLiteCommand sqliteSelectCMD = new SQLiteCommand();
        SQLiteCommand sqliteUpdateCMD = new SQLiteCommand();
        SQLiteCommand sqliteInsertCMD = new SQLiteCommand();
        SQLiteCommand sqliteDeleteCMD = new SQLiteCommand();
        public clsServices()
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
            _tblService = new DataTable();
            sqliteDA.Fill(_tblService);
        }
        public DataTable AddNewService()
        {
            if (_tblService != null)
            {
                DataRow dr = _tblService.NewRow();
                _tblService.Rows.Add(dr);
            }
            return _tblService;
        }
        private void sqliteDA_RowUpdating(object sender, System.Data.Common.RowUpdatingEventArgs e)
        {
        }

        private void selectCMDBuider()
        {
            sqliteSelectCMD.CommandText = "select * from Services where Service_ID='####'";
            sqliteSelectCMD.CommandType = CommandType.Text;
            sqliteSelectCMD.Connection = Ultils.cnn();
        }
        private void selectCMDBuider(string criteria)
        {
            sqliteSelectCMD.CommandText = "select * from Services " + criteria;
        }
        private void insertCMDBuider()
        {
            sqliteInsertCMD.CommandText = "INSERT INTO Services(Service_Name, Unit, Unit_Price, Discount)" +
                "VALUES(@Service_Name, @Unit, @Unit_Price, @Discount)";
            string[] prs = { "@Service_Name", "@Unit", "@Unit_Price", "@Discount" };
            buildParameters(prs, sqliteInsertCMD);
            sqliteInsertCMD.Connection = Ultils.cnn();
        }
        private void updateCMDBuider()
        {
            sqliteUpdateCMD.CommandText = "UPDATE [Services] SET Service_Name = @Service_Name, Unit = @Unit, " +
                "Unit_Price = @Unit_Price, Discount = @Discount WHERE [Service_ID] = @Service_ID";
            string[] prs = { "@Service_Name", "@Unit", "@Unit_Price", "@Discount", "@Service_ID" };
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
            sqliteDeleteCMD.CommandText = "Delete from Services where Service_ID=@Service_ID";
            string[] prs = { "@Service_ID" };
            buildParameters(prs, sqliteDeleteCMD);
            sqliteDeleteCMD.Connection = Ultils.cnn();
        }
        public DataTable getService(string serviceID)
        {
            sqliteSelectCMD.CommandText = "select * from Services where Service_ID = ";
            sqliteSelectCMD.CommandText += string.IsNullOrEmpty(serviceID) ? "0" : serviceID;
            try
            {
                _tblService.Clear();
                sqliteDA.Fill(_tblService);
            }
            catch (Exception ex) { throw ex; }
            return _tblService;
        }
        public DataTable getServices()
        {
            sqliteSelectCMD.CommandText = "select * from Services";
            try
            {
                _tblService.Clear();
                sqliteDA.Fill(_tblService);
            }
            catch (Exception ex) { throw ex; }
            return _tblService;
        }
        public DataTable getServices(string strCriteria)
        {
            selectCMDBuider(strCriteria);
            if (_tblService == null)
            {
                tblService = new DataTable();
            }
            _tblService.Clear();
            sqliteDA.Fill(_tblService);
            return _tblService;
        }
        public int updateService(DataTable services)
        {
            int intResult = 0;
            try
            {
                intResult = sqliteDA.Update(services.GetChanges());
                _tblService.AcceptChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int updateServiceAndGetID()
        {            
            int intResult = 0;
            try
            {
                if (_tblService != null)
                {
                    intResult = sqliteDA.Update(_tblService);
                    if (intResult > 0)
                    {
                        SQLiteCommand cmm = new SQLiteCommand();
                        cmm.CommandText = "SELECT seq from sqlite_sequence WHERE name='Services'";
                        cmm.Connection = Ultils.cnn();
                        if (cmm.Connection.State == ConnectionState.Closed)
                        {
                            cmm.Connection.Open();
                        }
                        SQLiteDataAdapter da = new SQLiteDataAdapter();
                        DataTable dt = new DataTable();
                        da.SelectCommand = cmm;
                        da.Fill(dt);
                        intResult = 0;
                        if (dt.Rows.Count > 0) {
                            intResult = int.Parse(dt.Rows[0]["seq"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int updateService()
        {
            int intResult = 0;
            try
            {
                if (_tblService != null)
                {
                    intResult = sqliteDA.Update(_tblService);
                    _tblService.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intResult;
        }
        public int insertService(DataRow drService)
        {
            return 0;
        }
        public void printService(string ServiceKey)
        {

        }
    }
}
