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
    public partial class showStudentNames : Form
    {
        public showStudentNames()
        {
            InitializeComponent();
        }

        private void showStudentNames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            // this.decTblTableAdapter.Fill(this.dataDataSet.decTbl);
            // TODO: This line of code loads data into the 'dataDataSet.decTbl' table. You can move, or remove it, as needed.
            this.decTblTableAdapter.FillByExamAndHerman(this.dataDataSet.decTbl, "الفلسفة", 2);
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


    }
}
