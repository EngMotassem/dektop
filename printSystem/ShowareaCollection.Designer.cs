namespace printSystem
{
    partial class ShowareaCollection
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
            this.medicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new printSystem.dataDataSet();
            this.decTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.decTblTableAdapter = new printSystem.dataDataSetTableAdapters.decTblTableAdapter();
            this.medicalTableAdapter = new printSystem.dataDataSetTableAdapters.medicalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalBindingSource
            // 
            this.medicalBindingSource.DataMember = "medical";
            this.medicalBindingSource.DataSource = this.dataDataSet;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.decTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printSystem.ReportOfStudentnames.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(780, 525);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // decTblTableAdapter
            // 
            this.decTblTableAdapter.ClearBeforeFill = true;
            // 
            // medicalTableAdapter
            // 
            this.medicalTableAdapter.ClearBeforeFill = true;
            // 
            // ShowareaCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 525);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ShowareaCollection";
            this.Text = "ShowareaCollection";
            this.Load += new System.EventHandler(this.ShowareaCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource decTblBindingSource;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.decTblTableAdapter decTblTableAdapter;
        private System.Windows.Forms.BindingSource medicalBindingSource;
        private dataDataSetTableAdapters.medicalTableAdapter medicalTableAdapter;
    }
}