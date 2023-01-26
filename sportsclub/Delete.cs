using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sportsclub
{
    //削除フォーム
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///指定のデータを削除する。 
        /// </summary>
        private void DataDeleteClick(object sender, EventArgs e)
        {
            //データ削除
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "DELETE FROM t_product WHERE bangou = @Bangou;";
                    // パラメータセット
                    cmd.Parameters.Add("Bangou", System.Data.DbType.Int64);
                    // データ削除
                    cmd.Parameters["Bangou"].Value = int.Parse(textBox1.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
            }
        }

        /// <summary>
        ///ビューを生成させ、t_productの内容を表示させる。
        /// </summary>
        private void SearchButtonClick(object sender, EventArgs e)//確認ボタン
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

        
        /// <summary>
        ///メイン画面に戻る。 
        /// </summary>
        private void BackClick(object sender, EventArgs e)//メイン画面に戻る
        {
            //次画面を非表示
            this.Visible = false;

            //Form2を表示

            MainForm f1 = new MainForm();
            f1.Show();
        }

       
    }
}