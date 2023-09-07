namespace CedisurB.Reportes
{
    partial class ReportesFacturas
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
            this.dsSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CedisurB.Reportes.DsSistema();
            this.DT_MostrarFacturasActualizadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTMostrarFacturasActualizadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_MostrarFacturasActualizadaTableAdapter = new CedisurB.Reportes.DsSistemaTableAdapters.DT_MostrarFacturasActualizadaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MostrarFacturasActualizadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTMostrarFacturasActualizadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSistemaBindingSource
            // 
            this.dsSistemaBindingSource.DataSource = this.dsSistema;
            this.dsSistemaBindingSource.Position = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DT_MostrarFacturasActualizadaBindingSource
            // 
            this.DT_MostrarFacturasActualizadaBindingSource.DataMember = "DT_MostrarFacturasActualizada";
            this.DT_MostrarFacturasActualizadaBindingSource.DataSource = this.dsSistema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsFacturas";
            reportDataSource1.Value = this.dTMostrarFacturasActualizadaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dTMostrarFacturasActualizadaBindingSource
            // 
            this.dTMostrarFacturasActualizadaBindingSource.DataMember = "DT_MostrarFacturasActualizada";
            this.dTMostrarFacturasActualizadaBindingSource.DataSource = this.dsSistemaBindingSource;
            // 
            // dT_MostrarFacturasActualizadaTableAdapter
            // 
            this.dT_MostrarFacturasActualizadaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesFacturas";
            this.Text = "ReportesFacturas";
            this.Load += new System.EventHandler(this.ReportesFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MostrarFacturasActualizadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTMostrarFacturasActualizadaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dsSistemaBindingSource;
        private DsSistema dsSistema;
        private System.Windows.Forms.BindingSource DT_MostrarFacturasActualizadaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dTMostrarFacturasActualizadaBindingSource;
        private DsSistemaTableAdapters.DT_MostrarFacturasActualizadaTableAdapter dT_MostrarFacturasActualizadaTableAdapter;
    }
}