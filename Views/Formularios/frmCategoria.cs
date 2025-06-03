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
using Entities;
using Views.utilidades;

namespace Views.Formularios
{
    public partial class frmCategoria : Form

    {
        private CategoriaController categoriaController = new CategoriaController();

        private MedidaController medidaController = new Controllers.MedidaController();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarMendidas();
            motrarTab(tabPageListar.Name);
            cargarCmbHabilitado();
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

        private void cargarMendidas()
        {
            cmbMedidaNuevo.DataSource = medidaController.ListarMedidas();
            cmbMedidaNuevo.DisplayMember = "Nombre";
            cmbMedidaNuevo.ValueMember = "IdMedida";

            cmbMedidaEditar.DataSource = medidaController.ListarMedidas();
            cmbMedidaEditar.DisplayMember = "Nombre";
            cmbMedidaEditar.ValueMember = "IdMedida";
        }

        public void motrarTab(string tabNombre)
        {
            var tabMenu = new TabPage[] { tabPageListar, tabPageNuevo, tabPageEditar };
            foreach (var tab in tabMenu)
            {
                if (tab.Name != tabNombre)
                {
                    tab.Parent = null;

                }
                else{
                    tab.Parent = tabPrincipal;
                }
            }
        }

        private void cargarCategorias()
        {
            
            dgvCategorias.DataSource = categoriaController.ListarCategorias("");

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //tabPrincipal.SelectedTab = tabPrincipal.TabPages[tabPageNuevo.Name];
            //tabPageListar.Parent = null;
            //tabPageEditar.Parent = null;
            motrarTab(tabPageNuevo.Name);
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            motrarTab(tabPageListar.Name);
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreNuevo.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre para la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var medida = (Medida)cmbMedidaNuevo.SelectedItem;
                Categoria categoriaNueva = new Categoria();
                categoriaNueva.Nombre = txtNombreNuevo.Text;
                categoriaNueva.oMedida = new Medida
                {
                    IdMedida = medida.IdMedida
                };
                int resultado = categoriaController.AgregarCategoria(categoriaNueva);
                if (resultado == 1)
                {
                    MessageBox.Show("Categoria agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCategorias();
                    motrarTab(tabPageListar.Name);
                    limpiarCampos();

                }
                else
                {
                    MessageBox.Show("Error al agregar la categoria Ya existe el Elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al agregar la categoria, No se puedo crear la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            txtNombreNuevo.Clear();
            cmbMedidaNuevo.SelectedIndex = 0;
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            motrarTab(tabPageListar.Name);
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                txtNombreEditar.Text = categoriaSeleccionada.Nombre;
                cmbMedidaEditar.SelectedValue = categoriaSeleccionada.oMedida.IdMedida;
                cmbHabilitado.SelectedValue = categoriaSeleccionada.Activo;
                motrarTab(tabPageEditar.Name);
            }
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreEditar.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre para la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var medida = (Medida)cmbMedidaEditar.SelectedItem;
                var categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                Categoria categoria = new Categoria();
                categoria.IdCategoria = categoriaSeleccionada.IdCategoria;
                categoria.Nombre = txtNombreEditar.Text;
                categoria.oMedida = new Medida
                {
                    IdMedida = medida.IdMedida
                };
                categoria.Activo = Convert.ToInt32(cmbHabilitado.SelectedValue);
                int resultado = categoriaController.EditarCategoria(categoria);

                if (resultado == 1)
                {
                    MessageBox.Show("Categoria Editada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCategorias();
                    motrarTab(tabPageListar.Name);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoria Ya existe el Elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al Editar la categoria, No se puedo editar la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = categoriaController.ListarCategorias(txtBuscar.Text);

        }
    }
}
