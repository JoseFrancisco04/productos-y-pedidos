namespace LoginCRUMAR
{
    partial class gestionVentas
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
            this.dbEmpresaWXDataSet = new LoginCRUMAR.dbEmpresaWXDataSet();
            this.dbEmpresaWXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbEmpresaWXDataSet
            // 
            this.dbEmpresaWXDataSet.DataSetName = "dbEmpresaWXDataSet";
            this.dbEmpresaWXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbEmpresaWXDataSetBindingSource
            // 
            this.dbEmpresaWXDataSetBindingSource.DataSource = this.dbEmpresaWXDataSet;
            this.dbEmpresaWXDataSetBindingSource.Position = 0;
            // 
            // gestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "gestionVentas";
            this.Text = "gestionVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbEmpresaWXDataSetBindingSource;
        private dbEmpresaWXDataSet dbEmpresaWXDataSet;
    }
}