using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printSystem
{
    public partial class FormStatics : Form


    {

        public DataTable dt = new DataTable();

        public FormStatics(DataTable datatable)
        {
            InitializeComponent();
            dt = datatable;

            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

           // this.Hide();
            this.reportViewer1.RefreshReport();
        }

        private void FormStatics_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
