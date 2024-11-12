using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class gestionInventario : Form
    {
        public gestionInventario()
        {
            InitializeComponent();
        }

        private void gestionInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbEmpresaWXDataSet.tbProductos' Puede moverla o quitarla según sea necesario.
            this.tbProductosTableAdapter.Fill(this.dbEmpresaWXDataSet.tbProductos);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarInventario editInven = Owner as EditarInventario;
            editInven.tbIdFab.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            editInven.tbIdProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            editInven.tbDescrip.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            editInven.tbPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            editInven.tbExis.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }
    }
}
