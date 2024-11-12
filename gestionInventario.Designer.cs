namespace LoginCRUMAR
{
    partial class gestionInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dbEmpresaWXDataSet = new LoginCRUMAR.dbEmpresaWXDataSet();
            this.tbProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductosTableAdapter = new LoginCRUMAR.dbEmpresaWXDataSetTableAdapters.tbProductosTableAdapter();
            this.idFabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFabDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.existenciasDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.tbProductosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.Location = new System.Drawing.Point(0, 81);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(547, 369);
            this.dgvProductos.TabIndex = 25;
            this.dgvProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // dbEmpresaWXDataSet
            // 
            this.dbEmpresaWXDataSet.DataSetName = "dbEmpresaWXDataSet";
            this.dbEmpresaWXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductosBindingSource
            // 
            this.tbProductosBindingSource.DataMember = "tbProductos";
            this.tbProductosBindingSource.DataSource = this.dbEmpresaWXDataSet;
            // 
            // tbProductosTableAdapter
            // 
            this.tbProductosTableAdapter.ClearBeforeFill = true;
            // 
            // idFabDataGridViewTextBoxColumn
            // 
            this.idFabDataGridViewTextBoxColumn.DataPropertyName = "idFab";
            this.idFabDataGridViewTextBoxColumn.HeaderText = "idFab";
            this.idFabDataGridViewTextBoxColumn.Name = "idFabDataGridViewTextBoxColumn";
            this.idFabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            this.existenciasDataGridViewTextBoxColumn.DataPropertyName = "existencias";
            this.existenciasDataGridViewTextBoxColumn.HeaderText = "existencias";
            this.existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            this.existenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionInventario";
            this.Text = "gestionInventario";
            this.Load += new System.EventHandler(this.gestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private dbEmpresaWXDataSet dbEmpresaWXDataSet;
        private System.Windows.Forms.BindingSource tbProductosBindingSource;
        private dbEmpresaWXDataSetTableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}