using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Form1
{
    public partial class companyRegister : Form
    {
        OracleConnection conn;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";

        public companyRegister()
        {
            InitializeComponent();
        }

        private void companyRegister_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_comp_reg_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "insert_company";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("comp_id", txt_compID.Text);
            cmd.Parameters.Add("comp_name", txt_compname.Text);
            cmd.Parameters.Add("comp_mail", txt_compmail.Text);
            cmd.Parameters.Add("comp_phone", txt_comp_number.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Company successfully added");
        }

        private void companyRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page form = new home_page();
            form.ShowDialog();

            this.Close();
        }
    }
}