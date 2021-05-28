
namespace SWE_Form1
{
    partial class ShowApplicants
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
            this.dgv_Applicants = new System.Windows.Forms.DataGridView();
            this.txt_cmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Applicants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Applicants
            // 
            this.dgv_Applicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Applicants.Location = new System.Drawing.Point(12, 183);
            this.dgv_Applicants.Name = "dgv_Applicants";
            this.dgv_Applicants.RowHeadersWidth = 62;
            this.dgv_Applicants.RowTemplate.Height = 28;
            this.dgv_Applicants.Size = new System.Drawing.Size(964, 347);
            this.dgv_Applicants.TabIndex = 0;
            // 
            // txt_cmpID
            // 
            this.txt_cmpID.Location = new System.Drawing.Point(303, 37);
            this.txt_cmpID.Name = "txt_cmpID";
            this.txt_cmpID.Size = new System.Drawing.Size(369, 26);
            this.txt_cmpID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company ID";
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(303, 125);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(244, 52);
            this.btn_Show.TabIndex = 3;
            this.btn_Show.Text = "Show applicants";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(74, 26);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ShowApplicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 580);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cmpID);
            this.Controls.Add(this.dgv_Applicants);
            this.Name = "ShowApplicants";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Applicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Applicants;
        private System.Windows.Forms.TextBox txt_cmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_back;
    }
}