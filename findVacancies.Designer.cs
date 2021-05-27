
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
            this.btn_Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_applay = new System.Windows.Forms.Button();
            this.txt_SSN = new System.Windows.Forms.TextBox();
            this.cmb_compName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_Jtitle
            // 
            this.cmb_Jtitle.FormattingEnabled = true;
            this.cmb_Jtitle.Location = new System.Drawing.Point(308, 79);
            this.cmb_Jtitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Jtitle.Name = "cmb_Jtitle";
            this.cmb_Jtitle.Size = new System.Drawing.Size(258, 28);
            this.cmb_Jtitle.TabIndex = 0;
            // 
            // cmb_JType
            // 
            this.cmb_JType.FormattingEnabled = true;
            this.cmb_JType.Location = new System.Drawing.Point(308, 162);
            this.cmb_JType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_JType.Name = "cmb_JType";
            this.cmb_JType.Size = new System.Drawing.Size(258, 28);
            this.cmb_JType.TabIndex = 2;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(332, 582);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(233, 70);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Job title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job type";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(679, 110);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(185, 52);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_applay
            // 
            this.btn_applay.Location = new System.Drawing.Point(297, 376);
            this.btn_applay.Name = "btn_applay";
            this.btn_applay.Size = new System.Drawing.Size(293, 74);
            this.btn_applay.TabIndex = 8;
            this.btn_applay.Text = "apply";
            this.btn_applay.UseVisualStyleBackColor = true;
            this.btn_applay.Click += new System.EventHandler(this.btn_applay_Click);
            // 
            // txt_SSN
            // 
            this.txt_SSN.Location = new System.Drawing.Point(308, 312);
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.Size = new System.Drawing.Size(258, 26);
            this.txt_SSN.TabIndex = 9;
            // 
            // cmb_compName
            // 
            this.cmb_compName.FormattingEnabled = true;
            this.cmb_compName.Location = new System.Drawing.Point(306, 239);
            this.cmb_compName.Name = "cmb_compName";
            this.cmb_compName.Size = new System.Drawing.Size(259, 28);
            this.cmb_compName.TabIndex = 10;
            // 
            // FindVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 580);
            this.Controls.Add(this.cmb_compName);
            this.Controls.Add(this.txt_SSN);
            this.Controls.Add(this.btn_applay);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.cmb_JType);
            this.Controls.Add(this.cmb_Jtitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FindVacancies";
            this.Text = "Find Vacancies";
            this.Load += new System.EventHandler(this.FindVacancies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Jtitle;
        private System.Windows.Forms.ComboBox cmb_JType;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_applay;
        private System.Windows.Forms.TextBox txt_SSN;
        private System.Windows.Forms.ComboBox cmb_compName;
    }
}