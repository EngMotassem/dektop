namespace printSystem
{
    partial class finalFormmahder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataDataSet = new printSystem.dataDataSet();
            this.decTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.decTblTableAdapter = new printSystem.dataDataSetTableAdapters.decTblTableAdapter();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter = new printSystem.dataDataSetTableAdapters.studentDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.decTblBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.studentDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.RepEstlam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1039, 638);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // decTblBindingSource
            // 
            this.decTblBindingSource.DataMember = "decTbl";
            this.decTblBindingSource.DataSource = this.dataDataSet;
            // 
            // decTblTableAdapter
            // 
            this.decTblTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "studentData";
            this.studentDataBindingSource.DataSource = this.dataDataSet;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // finalFormmahder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 638);
            this.Controls.Add(this.reportViewer1);
            this.Name = "finalFormmahder";
            this.Text = "FinalFormmahder";
            this.Load += new System.EventHandler(this.FinalFormmahder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource decTblBindingSource;
        private dataDataSetTableAdapters.decTblTableAdapter decTblTableAdapter;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private dataDataSetTableAdapters.studentDataTableAdapter studentDataTableAdapter;
    }
}