
namespace SWE_Form1
{
    partial class AddVacancies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVacancies));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vacanciesNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_JobTitle = new System.Windows.Forms.TextBox();
            this.rdb_FullTime = new System.Windows.Forms.RadioButton();
            this.rdb_Internship = new System.Windows.Forms.RadioButton();
            this.cmb_companyName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(170, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job title :";
            // 
            // txt_vacanciesNo
            // 
            this.txt_vacanciesNo.Location = new System.Drawing.Point(412, 297);
            this.txt_vacanciesNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_vacanciesNo.Name = "txt_vacanciesNo";
            this.txt_vacanciesNo.Size = new System.Drawing.Size(146, 20);
            this.txt_vacanciesNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(170, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(168, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of vacancies :";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Location = new System.Drawing.Point(301, 364);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(148, 35);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add New";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_JobTitle
            // 
            this.txt_JobTitle.Location = new System.Drawing.Point(412, 137);
            this.txt_JobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txt_JobTitle.Name = "txt_JobTitle";
            this.txt_JobTitle.Size = new System.Drawing.Size(146, 20);
            this.txt_JobTitle.TabIndex = 1;
            // 
            // rdb_FullTime
            // 
            this.rdb_FullTime.AutoSize = true;
            this.rdb_FullTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_FullTime.Location = new System.Drawing.Point(385, 193);
            this.rdb_FullTime.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_FullTime.Name = "rdb_FullTime";
            this.rdb_FullTime.Size = new System.Drawing.Size(90, 24);
            this.rdb_FullTime.TabIndex = 6;
            this.rdb_FullTime.TabStop = true;
            this.rdb_FullTime.Text = "Full Time";
            this.rdb_FullTime.UseVisualStyleBackColor = true;
            // 
            // rdb_Internship
            // 
            this.rdb_Internship.AutoSize = true;
            this.rdb_Internship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Internship.Location = new System.Drawing.Point(498, 193);
            this.rdb_Internship.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Internship.Name = "rdb_Internship";
            this.rdb_Internship.Size = new System.Drawing.Size(98, 24);
            this.rdb_Internship.TabIndex = 7;
            this.rdb_Internship.TabStop = true;
            this.rdb_Internship.Text = "Internship";
            this.rdb_Internship.UseVisualStyleBackColor = true;
            // 
            // cmb_companyName
            // 
            this.cmb_companyName.FormattingEnabled = true;
            this.cmb_companyName.Location = new System.Drawing.Point(412, 246);
            this.cmb_companyName.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_companyName.Name = "cmb_companyName";
            this.cmb_companyName.Size = new System.Drawing.Size(146, 21);
            this.cmb_companyName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adding New Vacancy Form";
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(8, 8);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 44);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modify.Location = new System.Drawing.Point(11, 430);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(118, 32);
            this.btn_modify.TabIndex = 26;
            this.btn_modify.Text = "Report 1";
            this.btn_modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // AddVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 485);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_companyName);
            this.Controls.Add(this.rdb_Internship);
            this.Controls.Add(this.rdb_FullTime);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_vacanciesNo);
            this.Controls.Add(this.txt_JobTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(762, 524);
            this.MinimumSize = new System.Drawing.Size(762, 524);
            this.Name = "AddVacancies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vacancies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddVacancies_FormClosing);
            this.Load += new System.EventHandler(this.AddVacancies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vacanciesNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_JobTitle;
        private System.Windows.Forms.RadioButton rdb_FullTime;
        private System.Windows.Forms.RadioButton rdb_Internship;
        private System.Windows.Forms.ComboBox cmb_companyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_modify;
    }
}