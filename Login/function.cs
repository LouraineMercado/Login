using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class function
    {
        protected SQLiteConnection getConnection()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db;Version=3;");
            con.ConnectionString = "Data Source=C:\\Users\\merca\\Downloads\\OOPfinals-FINALREALTALAGA\\OOPfinals-FINALREALTALAGA\\Login\\bin\\Debug\\oopDB.db;Version=3;database=oopDB;integrated security =True";
            return con;
        }
        public DataSet getData(String query ) //get data from database
        {
            SQLiteConnection con = getConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message) //insert, update, delete data from database
        {
            SQLiteConnection con = getConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'"+message+"'","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   

        public SQLiteDataReader getForCombo(String query) //get data for combobox
        {
            SQLiteConnection con = getConnection();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SQLiteCommand(query, con);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }


    }
}
