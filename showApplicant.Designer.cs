
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showApplicant)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_compId
            // 
            this.txt_compId.Location = new System.Drawing.Point(472, 107);
            this.txt_compId.Name = "txt_compId";
            this.txt_compId.Size = new System.Drawing.Size(183, 22);
            this.txt_compId.TabIndex = 0;
            // 
            // dgv_showApplicant
            // 
            this.dgv_showApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showApplicant.Location = new System.Drawing.Point(146, 286);
            this.dgv_showApplicant.Name = "dgv_showApplicant";
            this.dgv_showApplicant.RowHeadersWidth = 51;
            this.dgv_showApplicant.RowTemplate.Height = 24;
            this.dgv_showApplicant.Size = new System.Drawing.Size(677, 264);
            this.dgv_showApplicant.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(405, 210);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(152, 39);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(214, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Company ID :";
            // 
            // showApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_showApplicant);
            this.Controls.Add(this.txt_compId);
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
    }
}