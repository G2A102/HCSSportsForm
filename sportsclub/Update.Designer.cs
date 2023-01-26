
namespace Sportsclub
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.SearchIDTextBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(316, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "変更";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(342, 98);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(295, 199);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpDateGridViewCellContentClick);
            // 
            // SearchIDTextBox
            // 
            this.SearchIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.SearchIDTextBox.Location = new System.Drawing.Point(92, 98);
            this.SearchIDTextBox.Name = "SearchIDTextBox";
            this.SearchIDTextBox.Size = new System.Drawing.Size(223, 32);
            this.SearchIDTextBox.TabIndex = 4;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Update.Location = new System.Drawing.Point(664, 26);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(105, 48);
            this.Update.TabIndex = 5;
            this.Update.Text = "変更";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Check.Location = new System.Drawing.Point(12, 26);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(105, 42);
            this.Check.TabIndex = 6;
            this.Check.Text = "確認";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.AddressTextBox.Location = new System.Drawing.Point(92, 176);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(223, 32);
            this.AddressTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NameTextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.NameTextBox.Location = new System.Drawing.Point(92, 268);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ShortcutsEnabled = false;
            this.NameTextBox.Size = new System.Drawing.Size(223, 25);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(157, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "検索番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(171, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(171, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "名前";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Back.Location = new System.Drawing.Point(625, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(144, 73);
            this.Back.TabIndex = 12;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.SearchIDTextBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox SearchIDTextBox;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back;
    }
}