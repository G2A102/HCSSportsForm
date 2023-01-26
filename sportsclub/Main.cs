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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登録画面へとぶボタン。
        /// </summary>
        private void RegistrationClick(object sender, EventArgs e)//登録画面へ遷移
        {
            //次画面を非表示
            this.Visible = false;

            //Form2を表示
            MemberRegistrationForm f3 = new MemberRegistrationForm();
            f3.Show();
            
        }

        /// <summary>
        /// 変更画面へとぶボタン。
        /// </summary>
        private void UpdateClick1(object sender, EventArgs e)//変更画面へ遷移
        {
            // コネクションを開いてテーブル削除して閉じる  
            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                //次画面を非表示
                this.Visible = false;

                //Form2を表示
                UpdateForm f4 = new UpdateForm();
                f4.Show();

            }
        }

        /// <summary>
        /// 削除画面へとぶボタン
        /// </summary>
        private void DeleteClick(object sender, EventArgs e)//削除画面へ遷移
        {

            using (SQLiteConnection con = new SQLiteConnection("Data Source=karen.db"))
            {
                //次画面を非表示
                this.Visible = false;

                //Form2を表示
                DeleteForm f5 = new DeleteForm();
                f5.Show();
               
            }

        }

        /// <summary>
        ///検索画面にとぶボタン。 
        /// </summary>
        private void SearchClick(object sender, EventArgs e)// 検索画面へ遷移
        {

            //次画面を非表示
            this.Visible = false;

            //Form2を表示

            SearchForm f6 = new SearchForm();
            f6.Show();
        }

        /// <summary>
        /// フォームを終了する
        /// </summary>
        private void CloseClick(object sender, EventArgs e)//終了ボタン
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}


       
    
    
    




