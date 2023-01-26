
namespace Sportsclub
{
    partial class MemberRegistrationForm
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
            this.Check = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Registration = new System.Windows.Forms.Button();
            this.NewRegistration = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(332, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "登録";
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.Check.Location = new System.Drawing.Point(158, 12);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(157, 50);
            this.Check.TabIndex = 1;
            this.Check.Text = "確認";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.CheckClick);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(260, 127);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(510, 199);
            this.DataGridView.TabIndex = 2;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistrationGridView1CellContentClick);
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Registration.Location = new System.Drawing.Point(625, 15);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(145, 47);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "登録";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.RegistrationClick);
            // 
            // NewRegistration
            // 
            this.NewRegistration.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NewRegistration.Location = new System.Drawing.Point(1, 14);
            this.NewRegistration.Name = "NewRegistration";
            this.NewRegistration.Size = new System.Drawing.Size(130, 42);
            this.NewRegistration.TabIndex = 4;
            this.NewRegistration.Text = "新規作成";
            this.NewRegistration.UseVisualStyleBackColor = true;
            this.NewRegistration.Click += new System.EventHandler(this.NewRegistrationClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.textBox1.Location = new System.Drawing.Point(54, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.AddressTextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.textBox2.Location = new System.Drawing.Point(54, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.NameTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(133, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "住所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.label2.Location = new System.Drawing.Point(133, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "名前";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Back.Location = new System.Drawing.Point(625, 368);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(145, 58);
            this.Back.TabIndex = 10;
            this.Back.Text = "戻る";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // MemberRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NewRegistration);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Name = "MemberRegistrationForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button NewRegistration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
    }
}