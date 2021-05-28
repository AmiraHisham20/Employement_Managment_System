
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(177, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job title :";
            // 
            // txt_vacanciesNo
            // 
            this.txt_vacanciesNo.Location = new System.Drawing.Point(501, 340);
            this.txt_vacanciesNo.Name = "txt_vacanciesNo";
            this.txt_vacanciesNo.Size = new System.Drawing.Size(194, 22);
            this.txt_vacanciesNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(177, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(177, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of vacancies :";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Location = new System.Drawing.Point(371, 436);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(222, 43);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add New";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_JobTitle
            // 
            this.txt_JobTitle.Location = new System.Drawing.Point(501, 160);
            this.txt_JobTitle.Name = "txt_JobTitle";
            this.txt_JobTitle.Size = new System.Drawing.Size(194, 22);
            this.txt_JobTitle.TabIndex = 1;
            // 
            // rdb_FullTime
            // 
            this.rdb_FullTime.AutoSize = true;
            this.rdb_FullTime.Location = new System.Drawing.Point(478, 219);
            this.rdb_FullTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_FullTime.Name = "rdb_FullTime";
            this.rdb_FullTime.Size = new System.Drawing.Size(86, 21);
            this.rdb_FullTime.TabIndex = 6;
            this.rdb_FullTime.TabStop = true;
            this.rdb_FullTime.Text = "Full Time";
            this.rdb_FullTime.UseVisualStyleBackColor = true;
            // 
            // rdb_Internship
            // 
            this.rdb_Internship.AutoSize = true;
            this.rdb_Internship.Location = new System.Drawing.Point(629, 219);
            this.rdb_Internship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_Internship.Name = "rdb_Internship";
            this.rdb_Internship.Size = new System.Drawing.Size(91, 21);
            this.rdb_Internship.TabIndex = 7;
            this.rdb_Internship.TabStop = true;
            this.rdb_Internship.Text = "Internship";
            this.rdb_Internship.UseVisualStyleBackColor = true;
            // 
            // cmb_companyName
            // 
            this.cmb_companyName.FormattingEnabled = true;
            this.cmb_companyName.Location = new System.Drawing.Point(501, 283);
            this.cmb_companyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_companyName.Name = "cmb_companyName";
            this.cmb_companyName.Size = new System.Drawing.Size(194, 24);
            this.cmb_companyName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adding New Vacancy Form";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(11, 10);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(66, 21);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(992, 589);
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
            this.Name = "AddVacancies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
    }
}