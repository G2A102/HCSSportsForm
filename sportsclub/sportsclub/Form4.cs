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

namespace sportsclub
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // コネクションを開いてテーブル削除して閉じる  
                using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        // インサート
                        cmd.CommandText = "UPDATE t_product set Name = @Jusyo, Jusyo = @bangou, bangou = @Name;";
                        // パラメータセット
                        cmd.Parameters.Add("Name", System.Data.DbType.String);
                        cmd.Parameters.Add("Jusyo", System.Data.DbType.Int64);
                        cmd.Parameters.Add("bangou", System.Data.DbType.Int64);
                        // データ修正
                        cmd.Parameters["Name"].Value = textBox1.Text;
                        cmd.Parameters["Jusyo"].Value = int.Parse(textBox3.Text);
                        cmd.Parameters["bangou"].Value = int.Parse(textBox2.Text);
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    
