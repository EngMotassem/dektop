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
    public partial class finalFormmahder : Form

    {

        public DataTable dt = new DataTable();

        public finalFormmahder(DataTable datatable)
        {

            InitializeComponent();
            dt = datatable;

            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rts2 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);


            reportViewer1.LocalReport.DataSources.Add(rts2);

            this.Hide();
            this.reportViewer1.RefreshReport();
        }

        private void FinalFormmahder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);
            // TODO: This line of code loads data into the 'dataDataSet.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.dataDataSet.studentData);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            //  this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);
            // TODO: This line of code loads data into the 'dataDataSet.studentData' table. You can move, or remove it, as needed.
            //   this.studentDataTableAdapter.Fill(this.dataDataSet.studentData);


            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
           reportViewer1.PrintDialog();
        }
    }
}
