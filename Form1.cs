using System.Data.Odbc;
using System.Diagnostics;

namespace cs_form_mtn_012_vs2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool MysqlConnect(OdbcConnection myCon, OdbcCommand myCommand)
        {
            bool result = true;


            // 接続文字列の作成
            string server = "localhost";
            string database = "lightbox";
            string user = "root";
            string pass = "";
            string strCon = $"Driver={{MySQL ODBC 8.0 Unicode Driver}};SERVER={server};DATABASE={database};UID={user};PWD={pass}";
            Debug.WriteLine($"DBG:{strCon}");

            myCon.ConnectionString = strCon;

            bool functionExit = false;
            try
            {
                // 接続 
                myCon.Open();
            }
            catch (Exception ex)
            {
                functionExit = true;
                MessageBox.Show($"接続エラー : {ex.Message}");
            }
            // 接続エラーの為
            if (functionExit)
            {
                result = false;
            }

            return result;
        }

    }
}
