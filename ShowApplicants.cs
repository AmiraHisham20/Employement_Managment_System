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
    public partial class ShowApplicants : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ShowApplicants()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string ordb = "Data Source=PESO;User Id=hr;Password=hr;";
            string cmd = @"select seeker_SSN,Seeker_name from company c,jobseeker j where c.comp_id =:n and c.comp_name = j.comp_name";
            adapter = new OracleDataAdapter( cmd,ordb);
            adapter.SelectCommand.Parameters.Add("n", txt_cmpID);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_Applicants.DataSource = ds.Tables[0];

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
