using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Views.utilidades;

namespace Views.Formularios
{
    public partial class frmProducto : Form
    {

        private CategoriaController categoriaController = new CategoriaController();
        private ProductoController productoController = new ProductoController();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarProductos();
            cargarCmbCategorias();
            cargarCmbHabilitado();
            mostrarTab(tabPageListar.Name);

        }

        private void cargarCmbCategorias()
        {
            var listaCategorias = categoriaController.ListarCategorias("")
                .Where(cat => cat.Activo == 1).ToList();
            cmbCategoriaNuevo.DataSource = listaCategorias;
            cmbCategoriaNuevo.DisplayMember = "Nombre";
            cmbCategoriaNuevo.ValueMember = "IdCategoria";

            cmbCategoriaEditar.DataSource = listaCategorias;
            cmbCategoriaEditar.DisplayMember = "Nombre";
            cmbCategoriaEditar.ValueMember = "IdCategoria";
        }



        private void cargarCmbHabilitado()
        {
            List<OpcionCombo> opciones = new List<OpcionCombo> {
                new OpcionCombo { Texto = "SI", Valor = 1 },
                new OpcionCombo { Texto = "NO", Valor = 0 }

            };
            cmbHabilitado.DataSource = opciones;
            cmbHabilitado.DisplayMember = "Texto";
            cmbHabilitado.ValueMember = "Valor";
        }
        private void cargarProductos()
        {
            dgvProductos.DataSource = productoController.ListarProductos("");

        }

        public void mostrarTab(string tabNombre)
        {
            var tabMenu = new TabPage[] { tabPageListar, tabPageNuevo, tabPageEditar };
            foreach (var tab in tabMenu)
            {
                if (tab.Name != tabNombre)
                {
                    tab.Parent = null;

                }
                else
                {
                    tab.Parent = tabPrincipal;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mostrarTab(tabPageNuevo.Name);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = productoController.ListarProductos(txtBuscar.Text);
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            mostrarTab(tabPageListar.Name);
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            mostrarTab(tabPageListar.Name);
        }
    }
}
