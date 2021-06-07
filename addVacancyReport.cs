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
    public partial class Report1 : Form
    {
        CrystalReport1 CR1;

        public Report1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport1();
            foreach (ParameterDiscreteValue V in CR1.ParameterFields[0].DefaultValues)
                cmb_report1.Items.Add(V.Value);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            CR1.SetParameterValue(0, cmb_report1.Text);
            crystalReportViewer1.ReportSource = CR1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddVacancies form = new AddVacancies();
            form.ShowDialog();
            this.Close();

        }
    }
}
