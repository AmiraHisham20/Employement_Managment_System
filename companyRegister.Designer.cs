
namespace SWE_Form1
{
    partial class companyRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companyRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_compID = new System.Windows.Forms.TextBox();
            this.txt_compname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_compmail = new System.Windows.Forms.TextBox();
            this.txt_comp_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_comp_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Registering Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txt_compID
            // 
            this.txt_compID.Location = new System.Drawing.Point(572, 136);
            this.txt_compID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_compID.Name = "txt_compID";
            this.txt_compID.Size = new System.Drawing.Size(112, 26);
            this.txt_compID.TabIndex = 2;
            // 
            // txt_compname
            // 
            this.txt_compname.Location = new System.Drawing.Point(572, 201);
            this.txt_compname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_compname.Name = "txt_compname";
            this.txt_compname.Size = new System.Drawing.Size(112, 26);
            this.txt_compname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail";
            // 
            // txt_compmail
            // 
            this.txt_compmail.Location = new System.Drawing.Point(572, 264);
            this.txt_compmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_compmail.Name = "txt_compmail";
            this.txt_compmail.Size = new System.Drawing.Size(112, 26);
            this.txt_compmail.TabIndex = 6;
            // 
            // txt_comp_number
            // 
            this.txt_comp_number.Location = new System.Drawing.Point(572, 332);
            this.txt_comp_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_comp_number.Name = "txt_comp_number";
            this.txt_comp_number.Size = new System.Drawing.Size(112, 26);
            this.txt_comp_number.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number";
            // 
            // btn_comp_reg
            // 
            this.btn_comp_reg.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comp_reg.Location = new System.Drawing.Point(356, 410);
            this.btn_comp_reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_comp_reg.Name = "btn_comp_reg";
            this.btn_comp_reg.Size = new System.Drawing.Size(124, 44);
            this.btn_comp_reg.TabIndex = 9;
            this.btn_comp_reg.Text = "Register";
            this.btn_comp_reg.UseVisualStyleBackColor = true;
            this.btn_comp_reg.Click += new System.EventHandler(this.btn_comp_reg_Click);
            // 
            // companyRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(144)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 580);
            this.Controls.Add(this.btn_comp_reg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_comp_number);
            this.Controls.Add(this.txt_compmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_compname);
            this.Controls.Add(this.txt_compID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "companyRegister";
            this.Text = "Company\'s Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.companyRegister_FormClosing);
            this.Load += new System.EventHandler(this.companyRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_compID;
        private System.Windows.Forms.TextBox txt_compname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_compmail;
        private System.Windows.Forms.TextBox txt_comp_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_comp_reg;
    }
}