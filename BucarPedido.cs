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
    public partial class BucarPedido : Form
    {
        ConexionProductos coBD = new ConexionProductos();
        public BucarPedido()
        {
            InitializeComponent();
        }
        private void CargarPedidos()
        {
            try
            {

                DataSet ds = coBD.ConsultarPedidos();

                dgvPedidos.Rows.Clear();


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        int indice = dgvPedidos.Rows.Add();
                        DataGridViewRow row = dgvPedidos.Rows[indice];


                        row.Cells["idProveedor"].Value = fila["idProveedor"].ToString();
                        row.Cells["codigpBarras"].Value = fila["codigpBarras"].ToString();
                        row.Cells["fecha"].Value = fila["fecha"].ToString();
                        row.Cells["idProductoProve"].Value = fila["idProductoProve"].ToString();
                        row.Cells["cantidadProducto"].Value = fila["cantidadProducto"].ToString();
                        row.Cells["nombre"].Value = fila["nombre"].ToString();
                        row.Cells["nombrePro"].Value = fila["nombrePro"].ToString();


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

                foreach (DataGridViewRow row in dgvPedidos.Rows)
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

        private void BucarPedido_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            foreach (DataGridViewColumn column in dgvPedidos.Columns)
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

        private void btLimpiar2_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "Busca Aqui";
            txtBuscar.ForeColor = Color.DimGray;
            CargarPedidos();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}
