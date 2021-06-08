namespace SWE_Form1
{
    partial class HomeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeReport));
            this.btn_back = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_report2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(11, 11);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 44);
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 83);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(705, 387);
            this.crystalReportViewer1.TabIndex = 26;
            // 
            // btn_report2
            // 
            this.btn_report2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.btn_report2.FlatAppearance.BorderSize = 0;
            this.btn_report2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report2.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_report2.Image = ((System.Drawing.Image)(resources.GetObject("btn_report2.Image")));
            this.btn_report2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report2.Location = new System.Drawing.Point(300, 22);
            this.btn_report2.Name = "btn_report2";
            this.btn_report2.Size = new System.Drawing.Size(138, 46);
            this.btn_report2.TabIndex = 23;
            this.btn_report2.Text = "Generate";
            this.btn_report2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report2.UseVisualStyleBackColor = false;
            this.btn_report2.Click += new System.EventHandler(this.btn_report2_Click);
            // 
            // HomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 477);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_report2);
            this.Name = "HomeReport";
            this.Text = "HomeReport";
            this.Load += new System.EventHandler(this.HomeReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btn_report2;
    }
}