using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Form1
{
    
    public partial class Report2 : Form
    {
        CrystalReport4 CR2;
        OracleConnection conn;
        string ordb = "Data Source=PESO;User Id=hr;Password=hr;";
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select distinct JOB_NAME from jobvacancies";

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_report2.Items.Add(dr[0]);
            }

            dr.Close();

            CR2 = new CrystalReport4();
            //foreach (ParameterDiscreteValue V2 in CR2.ParameterFields[0].DefaultValues)
            //    cmb_report2.Items.Add(V2.Value);
        }

        private void btn_report2_Click(object sender, EventArgs e)
        {
            CR2.SetParameterValue(0, cmb_report2.Text);
            crystalReportViewer1.ReportSource = CR2;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindVacancies form = new FindVacancies();
            form.ShowDialog();

            this.Close();
        }
    }
}
