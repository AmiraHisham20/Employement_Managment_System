
namespace SWE_Form1
{
    partial class FindVacancies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindVacancies));
            this.cmb_Jtitle = new System.Windows.Forms.ComboBox();
            this.cmb_JType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_applay = new System.Windows.Forms.Button();
            this.txt_SSN = new System.Windows.Forms.TextBox();
            this.cmb_compName = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Jtitle
            // 
            this.cmb_Jtitle.FormattingEnabled = true;
            this.cmb_Jtitle.Location = new System.Drawing.Point(465, 130);
            this.cmb_Jtitle.Name = "cmb_Jtitle";
            this.cmb_Jtitle.Size = new System.Drawing.Size(230, 24);
            this.cmb_Jtitle.TabIndex = 0;
            // 
            // cmb_JType
            // 
            this.cmb_JType.FormattingEnabled = true;
            this.cmb_JType.Location = new System.Drawing.Point(465, 201);
            this.cmb_JType.Name = "cmb_JType";
            this.cmb_JType.Size = new System.Drawing.Size(231, 24);
            this.cmb_JType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(270, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Job Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(270, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job Type :";
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(404, 254);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(157, 42);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_applay
            // 
            this.btn_applay.FlatAppearance.BorderSize = 0;
            this.btn_applay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_applay.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_applay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_applay.Image = ((System.Drawing.Image)(resources.GetObject("btn_applay.Image")));
            this.btn_applay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_applay.Location = new System.Drawing.Point(414, 461);
            this.btn_applay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_applay.Name = "btn_applay";
            this.btn_applay.Size = new System.Drawing.Size(138, 59);
            this.btn_applay.TabIndex = 8;
            this.btn_applay.Text = "Apply";
            this.btn_applay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applay.UseVisualStyleBackColor = true;
            this.btn_applay.Click += new System.EventHandler(this.btn_applay_Click);
            // 
            // txt_SSN
            // 
            this.txt_SSN.Location = new System.Drawing.Point(465, 401);
            this.txt_SSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SSN.Multiline = true;
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.Size = new System.Drawing.Size(230, 33);
            this.txt_SSN.TabIndex = 9;
            // 
            // cmb_compName
            // 
            this.cmb_compName.FormattingEnabled = true;
            this.cmb_compName.Location = new System.Drawing.Point(464, 325);
            this.cmb_compName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_compName.Name = "cmb_compName";
            this.cmb_compName.Size = new System.Drawing.Size(231, 24);
            this.cmb_compName.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(11, 10);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(124, 54);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 52);
            this.label3.TabIndex = 22;
            this.label3.Text = "Job Application";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(270, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Companies :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(270, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seeker SSN :";
            // 
            // FindVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cmb_compName);
            this.Controls.Add(this.txt_SSN);
            this.Controls.Add(this.btn_applay);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_JType);
            this.Controls.Add(this.cmb_Jtitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1010, 636);
            this.MinimumSize = new System.Drawing.Size(1010, 636);
            this.Name = "FindVacancies";
            this.Text = "Find Vacancies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindVacancies_FormClosing);
            this.Load += new System.EventHandler(this.FindVacancies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Jtitle;
        private System.Windows.Forms.ComboBox cmb_JType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_applay;
        private System.Windows.Forms.TextBox txt_SSN;
        private System.Windows.Forms.ComboBox cmb_compName;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}