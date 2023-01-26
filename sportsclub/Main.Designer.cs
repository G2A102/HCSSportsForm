
namespace Sportsclub
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Touroku = new System.Windows.Forms.Button();
            this.Henkoou = new System.Windows.Forms.Button();
            this.Sakujo = new System.Windows.Forms.Button();
            this.Kensaku = new System.Windows.Forms.Button();
            this.Syuuryo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "HCSスポーツクラブ会員システム";
            // 
            // Touroku
            // 
            this.Touroku.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Touroku.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Touroku.Location = new System.Drawing.Point(12, 165);
            this.Touroku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Touroku.Name = "Touroku";
            this.Touroku.Size = new System.Drawing.Size(187, 80);
            this.Touroku.TabIndex = 2;
            this.Touroku.Text = "登録";
            this.Touroku.UseVisualStyleBackColor = false;
            this.Touroku.Click += new System.EventHandler(this.RegistrationClick);
            // 
            // Henkoou
            // 
            this.Henkoou.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Henkoou.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Henkoou.Location = new System.Drawing.Point(236, 165);
            this.Henkoou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Henkoou.Name = "Henkoou";
            this.Henkoou.Size = new System.Drawing.Size(187, 80);
            this.Henkoou.TabIndex = 17;
            this.Henkoou.Text = "変更";
            this.Henkoou.UseVisualStyleBackColor = false;
            this.Henkoou.Click += new System.EventHandler(this.UpdateClick1);
            // 
            // Sakujo
            // 
            this.Sakujo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sakujo.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Sakujo.Location = new System.Drawing.Point(472, 165);
            this.Sakujo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sakujo.Name = "Sakujo";
            this.Sakujo.Size = new System.Drawing.Size(187, 80);
            this.Sakujo.TabIndex = 19;
            this.Sakujo.Text = "削除";
            this.Sakujo.UseVisualStyleBackColor = false;
            this.Sakujo.Click += new System.EventHandler(this.DeleteClick);
            // 
            // Kensaku
            // 
            this.Kensaku.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Kensaku.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Kensaku.Location = new System.Drawing.Point(678, 165);
            this.Kensaku.Name = "Kensaku";
            this.Kensaku.Size = new System.Drawing.Size(191, 80);
            this.Kensaku.TabIndex = 20;
            this.Kensaku.Text = "検索";
            this.Kensaku.UseVisualStyleBackColor = false;
            this.Kensaku.Click += new System.EventHandler(this.SearchClick);
            // 
            // Syuuryo
            // 
            this.Syuuryo.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Syuuryo.ForeColor = System.Drawing.Color.Red;
            this.Syuuryo.Location = new System.Drawing.Point(695, 381);
            this.Syuuryo.Name = "Syuuryo";
            this.Syuuryo.Size = new System.Drawing.Size(174, 77);
            this.Syuuryo.TabIndex = 21;
            this.Syuuryo.Text = "終了";
            this.Syuuryo.UseVisualStyleBackColor = true;
            this.Syuuryo.Click += new System.EventHandler(this.CloseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(881, 481);
            this.Controls.Add(this.Syuuryo);
            this.Controls.Add(this.Kensaku);
            this.Controls.Add(this.Sakujo);
            this.Controls.Add(this.Henkoou);
            this.Controls.Add(this.Touroku);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Touroku;
        private System.Windows.Forms.Button Henkoou;
        private System.Windows.Forms.Button Sakujo;
        private System.Windows.Forms.Button Kensaku;
        private System.Windows.Forms.Button Syuuryo;
    }
}

