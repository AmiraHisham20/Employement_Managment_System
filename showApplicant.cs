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
            string cmdstr = @"select job_name,Seeker_ssn,SEEKER_NAME,SEEKER_NUMBER, SEEKER_MAIL, SEEKER_ADDRESS, 
                            FIELD_STUDY,GRAD_YEAR,GRAD_STAT,YEARS_EXPERIENCE from company c, jobseeker j where c.comp_id=:n and j.comp_name=c.comp_name";
            adaptor = new OracleDataAdapter(cmdstr, ordb);
            adaptor.SelectCommand.Parameters.Add("n", txt_compId.Text);
            ds = new DataSet();
            adaptor.Fill(ds);
            dgv_showApplicant.DataSource = ds.Tables[0];
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
