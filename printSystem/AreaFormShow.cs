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
    public partial class AreaFormShow : Form
    {

        public DataTable dt = new DataTable();
        public AreaFormShow(DataTable datatable)
        {
            dt = datatable;

           reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

            // this.Hide();
            this.reportViewer1.RefreshReport();


        }

        private void AreaFormShow_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
