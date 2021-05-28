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
    public partial class showApplicant : Form
    {
        OracleDataAdapter adaptor;
        DataSet ds;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";
        public showApplicant()
        {
            InitializeComponent();
        }

        private void showApplicant_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cmdstr = @"select seeker_ssn, job_name, SEEKER_NUMBER, YEARS_EXPERIENCE from company c, jobseeker j where c.comp_id=:n and j.comp_name=c.comp_name";
            adaptor = new OracleDataAdapter(cmdstr, ordb);
            adaptor.SelectCommand.Parameters.Add("n", txt_compId.Text);
            ds = new DataSet();
            adaptor.Fill(ds);
            dgv_showApplicant.DataSource = ds.Tables[0];
        }
    }
}
