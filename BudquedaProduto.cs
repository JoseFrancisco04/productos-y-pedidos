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
    public partial class BudquedaProduto : Form
    {
        ConexionProductos coBD = new ConexionProductos();
        public BudquedaProduto()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            try
            {

                DataSet ds = coBD.ConsultarProductos();

                dgvProductos.Rows.Clear();


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        int indice = dgvProductos.Rows.Add();
                        DataGridViewRow row = dgvProductos.Rows[indice];


                        row.Cells["codigoBarras"].Value = fila["codigoBarras"].ToString();
                        row.Cells["nombre"].Value = fila["nombre"].ToString();
                        row.Cells["marca"].Value = fila["marca"].ToString();
                        row.Cells["iva"].Value = fila["iva"].ToString();
                        row.Cells["existencia"].Value = fila["existencia"].ToString();
                        row.Cells["precioCompra"].Value = fila["precioCompra"].ToString();
                        row.Cells["precioVenta"].Value = fila["precioVenta"].ToString();
                        row.Cells["fechaCaducidad"].Value = fila["fechaCaducidad"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
                string textoBuscar = txtBuscar.Text.Trim().ToUpper();

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null)
                    {
                        string valor = row.Cells[columnaFiltro].Value.ToString().ToUpper();
                        row.Visible = valor.Contains(textoBuscar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiar2_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "Busca Aqui";
            txtBuscar.ForeColor = Color.DimGray;
            CargarProductos();
        }

        private void BudquedaProduto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                if (column.Visible == true)
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });

                }

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Busca Aqui")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightGray;

            }

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Busca Aqui";
                txtBuscar.ForeColor = Color.DimGray;

            }
        }

        private void txtBuscar_ModifiedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }
    }
}
