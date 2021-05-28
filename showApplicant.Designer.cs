
namespace SWE_Form1
{
    partial class showApplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showApplicant));
            this.txt_compId = new System.Windows.Forms.TextBox();
            this.dgv_showApplicant = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showApplicant)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_compId
            // 
            this.txt_compId.Location = new System.Drawing.Point(547, 113);
            this.txt_compId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_compId.Name = "txt_compId";
            this.txt_compId.Size = new System.Drawing.Size(205, 26);
            this.txt_compId.TabIndex = 0;
            // 
            // dgv_showApplicant
            // 
            this.dgv_showApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showApplicant.Location = new System.Drawing.Point(167, 312);
            this.dgv_showApplicant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_showApplicant.Name = "dgv_showApplicant";
            this.dgv_showApplicant.RowHeadersWidth = 51;
            this.dgv_showApplicant.RowTemplate.Height = 24;
            this.dgv_showApplicant.Size = new System.Drawing.Size(762, 330);
            this.dgv_showApplicant.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(435, 209);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(171, 49);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Company ID :";
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
            // showApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 736);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_showApplicant);
            this.Controls.Add(this.txt_compId);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "showApplicant";
            this.Text = "showApplicant";
            this.Load += new System.EventHandler(this.showApplicant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showApplicant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_compId;
        private System.Windows.Forms.DataGridView dgv_showApplicant;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}