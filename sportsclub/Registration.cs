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
    public partial class MemberRegistrationForm : Form
    {
        public MemberRegistrationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ビューを生成させ、 t_productの中身を表示する。
        /// </summary>
        private void CheckClick(object sender, EventArgs e)//確定ボタン
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source= karen.db"))
            {
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                DataGridView.DataSource = dataTable;
            }
        }
        /// <summary>
        ///新しい情報を登録する。 
        /// </summary>
        private void RegistrationClick(object sender, EventArgs e)//登録ボタン
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "INSERT INTO t_product (Jusyo, Name) VALUES (@Jusyo, @Name)";

                    // パラメータセット
                    cmd.Parameters.Add("Jusyo", System.Data.DbType.String);//住所
                    cmd.Parameters.Add("Name", System.Data.DbType.String);//名前
                    // データ追加
                    cmd.Parameters["Jusyo"].Value = textBox1.Text;//住所入力
                    cmd.Parameters["Name"].Value = textBox2.Text;//名前入力
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
                con.Close();
            }
        }
        /// <summary>
        ///新しいテーブルを追加する。 
        /// </summary>
        private void NewRegistrationClick(object sender, EventArgs e)//新規登録ボタン
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table t_product(bangou INTEGER  PRIMARY KEY AUTOINCREMENT, Jusyo TEXT,Name TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void AddressTextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        ///メイン画面に戻る。 
        /// </summary>
        private void BackClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //Form2を表示
            MainForm f1 = new MainForm();
            f1.Show();

        }
    }
}


