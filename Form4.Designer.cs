
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job title";
            // 
            // txt_vacanciesNo
            // 
            this.txt_vacanciesNo.Location = new System.Drawing.Point(423, 316);
            this.txt_vacanciesNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_vacanciesNo.Name = "txt_vacanciesNo";
            this.txt_vacanciesNo.Size = new System.Drawing.Size(195, 26);
            this.txt_vacanciesNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of vacancies";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(342, 435);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(162, 54);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_JobTitle
            // 
            this.txt_JobTitle.Location = new System.Drawing.Point(423, 98);
            this.txt_JobTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_JobTitle.Name = "txt_JobTitle";
            this.txt_JobTitle.Size = new System.Drawing.Size(195, 26);
            this.txt_JobTitle.TabIndex = 1;
            // 
            // rdb_FullTime
            // 
            this.rdb_FullTime.AutoSize = true;
            this.rdb_FullTime.Location = new System.Drawing.Point(407, 162);
            this.rdb_FullTime.Name = "rdb_FullTime";
            this.rdb_FullTime.Size = new System.Drawing.Size(97, 24);
            this.rdb_FullTime.TabIndex = 6;
            this.rdb_FullTime.TabStop = true;
            this.rdb_FullTime.Text = "Full Time";
            this.rdb_FullTime.UseVisualStyleBackColor = true;
            // 
            // rdb_Internship
            // 
            this.rdb_Internship.AutoSize = true;
            this.rdb_Internship.Location = new System.Drawing.Point(577, 162);
            this.rdb_Internship.Name = "rdb_Internship";
            this.rdb_Internship.Size = new System.Drawing.Size(105, 24);
            this.rdb_Internship.TabIndex = 7;
            this.rdb_Internship.TabStop = true;
            this.rdb_Internship.Text = "Internship";
            this.rdb_Internship.UseVisualStyleBackColor = true;
            // 
            // cmb_companyName
            // 
            this.cmb_companyName.FormattingEnabled = true;
            this.cmb_companyName.Location = new System.Drawing.Point(415, 242);
            this.cmb_companyName.Name = "cmb_companyName";
            this.cmb_companyName.Size = new System.Drawing.Size(202, 28);
            this.cmb_companyName.TabIndex = 8;
            // 
            // AddVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddVacancies";
            this.Text = "Add Vacancies";
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
    }
}