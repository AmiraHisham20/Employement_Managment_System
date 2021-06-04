
namespace SWE_Form1
{
    partial class manageVacancies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageVacancies));
            this.dgv_vacancies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_compId = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_showVacancies = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vacancies
            // 
            this.dgv_vacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vacancies.Location = new System.Drawing.Point(263, 261);
            this.dgv_vacancies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vacancies.Name = "dgv_vacancies";
            this.dgv_vacancies.RowHeadersWidth = 62;
            this.dgv_vacancies.RowTemplate.Height = 28;
            this.dgv_vacancies.Size = new System.Drawing.Size(587, 265);
            this.dgv_vacancies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(280, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company ID :";
            // 
            // txt_compId
            // 
            this.txt_compId.Location = new System.Drawing.Point(553, 113);
            this.txt_compId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_compId.Name = "txt_compId";
            this.txt_compId.Size = new System.Drawing.Size(205, 26);
            this.txt_compId.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(140, 68);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_showVacancies
            // 
            this.btn_showVacancies.FlatAppearance.BorderSize = 0;
            this.btn_showVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showVacancies.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_showVacancies.Image = ((System.Drawing.Image)(resources.GetObject("btn_showVacancies.Image")));
            this.btn_showVacancies.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_showVacancies.Location = new System.Drawing.Point(483, 185);
            this.btn_showVacancies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showVacancies.Name = "btn_showVacancies";
            this.btn_showVacancies.Size = new System.Drawing.Size(153, 50);
            this.btn_showVacancies.TabIndex = 24;
            this.btn_showVacancies.Text = "Show vacancies";
            this.btn_showVacancies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showVacancies.UseVisualStyleBackColor = true;
            this.btn_showVacancies.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_modify.Image = ((System.Drawing.Image)(resources.GetObject("btn_modify.Image")));
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modify.Location = new System.Drawing.Point(469, 549);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(177, 49);
            this.btn_modify.TabIndex = 25;
            this.btn_modify.Text = "Modify";
            this.btn_modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // manageVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 725);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_showVacancies);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_compId);
            this.Controls.Add(this.dgv_vacancies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1134, 781);
            this.MinimumSize = new System.Drawing.Size(1134, 781);
            this.Name = "manageVacancies";
            this.Text = "Manage Vacancies";
            this.Load += new System.EventHandler(this.manageVacancies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vacancies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vacancies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_compId;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_showVacancies;
        private System.Windows.Forms.Button btn_modify;
    }
}