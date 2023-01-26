using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sportsclub
{
    //検索フォーム
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }


        /// <summary>
        ///指定の番号を検索する。 
        /// </summary>
        private void DataSearchClick(object sender, EventArgs e)//データ検索ボタン
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE bangou = " + SearchNumber.Text, con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        /// <summary>
        ///メイン画面に戻る。 
        /// </summary>
        private void BackClick(object sender, EventArgs e)//戻るボタン
        {
            //次画面を非表示
            this.Visible = false;

            //Form1を表示
            MainForm f1 = new MainForm();
            f1.Show();
        }

        /// <summary>
        /// ビューを起動してt_productを表示させる
        /// </summary>
        private void CheckClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                con.Open();
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }
    }
}

