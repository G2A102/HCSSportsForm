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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指定のIDのデータを更新する。
        /// </summary>
        private void UpdateButtonClick(object sender, EventArgs e)//変更ボタン
        {
            {
                //情報を変更
                using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        // インサート
                        cmd.CommandText = "UPDATE t_product set name = @Name, jusyo = @Jusyo Where bangou = @Bangou;";

                        // パラメータセット
                        cmd.Parameters.Add("Name", System.Data.DbType.String);//名前
                        cmd.Parameters.Add("Jusyo", System.Data.DbType.String);//住所
                        cmd.Parameters.Add("Bangou", System.Data.DbType.Int64);//検索番号

                        // データ修正
                        cmd.Parameters["Name"].Value = NameTextBox.Text;//名前入力
                        cmd.Parameters["Jusyo"].Value = AddressTextBox.Text;//住所入力
                        cmd.Parameters["Bangou"].Value = int.Parse(SearchIDTextBox.Text);//検索番号入力
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                    }
                }
            }
        }


        /// <summary>
        /// ビューを生成させ、 t_productの中身を表示する。
        /// </summary>
        private void SearchButtonClick(object sender, EventArgs e)//データ確認ボタン
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                // DataTableを生成します。
                DataTable dataTable = new DataTable();
                // SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                DataGridView.DataSource = dataTable;
            }
        }


       /// <summary>
       /// メイン画面に戻る
       /// </summary>
        private void BackButtonClick(object sender, EventArgs e)//戻るボタン
        {
            //次画面を非表示
            this.Visible = false;

            //Form2を表示
            MainForm f1 = new MainForm();
            f1.Show();

        }

        private void UpDateGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

    
