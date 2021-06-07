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

namespace SWE_Form1
{
    
    public partial class Report2 : Form
    {
        CrystalReport2 CR2;
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            CR2 = new CrystalReport2();
            foreach (ParameterDiscreteValue V2 in CR2.ParameterFields[0].DefaultValues)
                cmb_report2.Items.Add(V2.Value);
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
