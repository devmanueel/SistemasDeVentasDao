namespace Views.Formularios
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageListar = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPageNuevo = new System.Windows.Forms.TabPage();
            this.cmbMedidaNuevo = new System.Windows.Forms.ComboBox();
            this.btnVolverNuevo = new System.Windows.Forms.Button();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEditar = new System.Windows.Forms.TabPage();
            this.cmbHabilitado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMedidaEditar = new System.Windows.Forms.ComboBox();
            this.btnVolverEditar = new System.Windows.Forms.Button();
            this.btnGuardarEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EDITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HABILITADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPrincipal.SuspendLayout();
            this.tabPageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tabPageNuevo.SuspendLayout();
            this.tabPageEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageListar);
            this.tabPrincipal.Controls.Add(this.tabPageNuevo);
            this.tabPrincipal.Controls.Add(this.tabPageEditar);
            this.tabPrincipal.ItemSize = new System.Drawing.Size(80, 20);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 48);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(776, 390);
            this.tabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPageListar
            // 
            this.tabPageListar.BackColor = System.Drawing.Color.Wheat;
            this.tabPageListar.Controls.Add(this.btnNuevo);
            this.tabPageListar.Controls.Add(this.btnBuscar);
            this.tabPageListar.Controls.Add(this.dgvCategorias);
            this.tabPageListar.Controls.Add(this.txtBuscar);
            this.tabPageListar.Location = new System.Drawing.Point(4, 24);
            this.tabPageListar.Name = "tabPageListar";
            this.tabPageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListar.Size = new System.Drawing.Size(768, 362);
            this.tabPageListar.TabIndex = 3;
            this.tabPageListar.Text = "Lista";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Aqua;
            this.btnNuevo.Location = new System.Drawing.Point(6, 36);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(137, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NuevaCategoria";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.Location = new System.Drawing.Point(673, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ID,
            this.NOMBRE,
            this.OMEDIDA,
            this.MEDIDA,
            this.ACTIVO,
            this.HABILITADO});
            this.dgvCategorias.Location = new System.Drawing.Point(6, 76);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(742, 268);
            this.dgvCategorias.TabIndex = 5;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(449, 36);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(202, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // tabPageNuevo
            // 
            this.tabPageNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageNuevo.Controls.Add(this.cmbMedidaNuevo);
            this.tabPageNuevo.Controls.Add(this.btnVolverNuevo);
            this.tabPageNuevo.Controls.Add(this.btnGuardarNuevo);
            this.tabPageNuevo.Controls.Add(this.label4);
            this.tabPageNuevo.Controls.Add(this.txtNombreNuevo);
            this.tabPageNuevo.Controls.Add(this.label1);
            this.tabPageNuevo.Location = new System.Drawing.Point(4, 24);
            this.tabPageNuevo.Name = "tabPageNuevo";
            this.tabPageNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNuevo.Size = new System.Drawing.Size(768, 362);
            this.tabPageNuevo.TabIndex = 1;
            this.tabPageNuevo.Text = "Nuevo";
            // 
            // cmbMedidaNuevo
            // 
            this.cmbMedidaNuevo.FormattingEnabled = true;
            this.cmbMedidaNuevo.Location = new System.Drawing.Point(128, 100);
            this.cmbMedidaNuevo.Name = "cmbMedidaNuevo";
            this.cmbMedidaNuevo.Size = new System.Drawing.Size(237, 21);
            this.cmbMedidaNuevo.TabIndex = 7;
            // 
            // btnVolverNuevo
            // 
            this.btnVolverNuevo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolverNuevo.Location = new System.Drawing.Point(626, 150);
            this.btnVolverNuevo.Name = "btnVolverNuevo";
            this.btnVolverNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnVolverNuevo.TabIndex = 6;
            this.btnVolverNuevo.Text = "Volver";
            this.btnVolverNuevo.UseVisualStyleBackColor = false;
            this.btnVolverNuevo.Click += new System.EventHandler(this.btnVolverNuevo_Click);
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(52, 150);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNuevo.TabIndex = 5;
            this.btnGuardarNuevo.Text = "Guardar";
            this.btnGuardarNuevo.UseVisualStyleBackColor = false;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medida";
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(128, 54);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(237, 20);
            this.txtNombreNuevo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // tabPageEditar
            // 
            this.tabPageEditar.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPageEditar.Controls.Add(this.cmbHabilitado);
            this.tabPageEditar.Controls.Add(this.label7);
            this.tabPageEditar.Controls.Add(this.cmbMedidaEditar);
            this.tabPageEditar.Controls.Add(this.btnVolverEditar);
            this.tabPageEditar.Controls.Add(this.btnGuardarEditar);
            this.tabPageEditar.Controls.Add(this.label6);
            this.tabPageEditar.Controls.Add(this.txtNombreEditar);
            this.tabPageEditar.Controls.Add(this.label5);
            this.tabPageEditar.Location = new System.Drawing.Point(4, 24);
            this.tabPageEditar.Name = "tabPageEditar";
            this.tabPageEditar.Size = new System.Drawing.Size(768, 362);
            this.tabPageEditar.TabIndex = 2;
            this.tabPageEditar.Text = "Editar";
            // 
            // cmbHabilitado
            // 
            this.cmbHabilitado.FormattingEnabled = true;
            this.cmbHabilitado.Location = new System.Drawing.Point(108, 128);
            this.cmbHabilitado.Name = "cmbHabilitado";
            this.cmbHabilitado.Size = new System.Drawing.Size(237, 21);
            this.cmbHabilitado.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Habilitado";
            // 
            // cmbMedidaEditar
            // 
            this.cmbMedidaEditar.FormattingEnabled = true;
            this.cmbMedidaEditar.Location = new System.Drawing.Point(108, 80);
            this.cmbMedidaEditar.Name = "cmbMedidaEditar";
            this.cmbMedidaEditar.Size = new System.Drawing.Size(237, 21);
            this.cmbMedidaEditar.TabIndex = 11;
            // 
            // btnVolverEditar
            // 
            this.btnVolverEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolverEditar.Location = new System.Drawing.Point(614, 171);
            this.btnVolverEditar.Name = "btnVolverEditar";
            this.btnVolverEditar.Size = new System.Drawing.Size(75, 23);
            this.btnVolverEditar.TabIndex = 10;
            this.btnVolverEditar.Text = "Volver";
            this.btnVolverEditar.UseVisualStyleBackColor = false;
            this.btnVolverEditar.Click += new System.EventHandler(this.btnVolverEditar_Click);
            // 
            // btnGuardarEditar
            // 
            this.btnGuardarEditar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGuardarEditar.Location = new System.Drawing.Point(41, 164);
            this.btnGuardarEditar.Name = "btnGuardarEditar";
            this.btnGuardarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEditar.TabIndex = 9;
            this.btnGuardarEditar.Text = "Guardar";
            this.btnGuardarEditar.UseVisualStyleBackColor = false;
            this.btnGuardarEditar.Click += new System.EventHandler(this.btnGuardarEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Medida";
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Location = new System.Drawing.Point(108, 29);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(237, 20);
            this.txtNombreEditar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inventario /Categoria";
            // 
            // EDITAR
            // 
            this.EDITAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EDITAR.DefaultCellStyle = dataGridViewCellStyle3;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Text = "Edit";
            this.EDITAR.UseColumnTextForButtonValue = true;
            this.EDITAR.Width = 53;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idCategoria";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "nombre";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // OMEDIDA
            // 
            this.OMEDIDA.DataPropertyName = "Omedida";
            this.OMEDIDA.HeaderText = "OMEDIDA";
            this.OMEDIDA.Name = "OMEDIDA";
            this.OMEDIDA.Visible = false;
            // 
            // MEDIDA
            // 
            this.MEDIDA.DataPropertyName = "MedidaNombre";
            this.MEDIDA.HeaderText = "MEDIDA";
            this.MEDIDA.Name = "MEDIDA";
            // 
            // ACTIVO
            // 
            this.ACTIVO.DataPropertyName = "Activo";
            this.ACTIVO.HeaderText = "ACTIVO";
            this.ACTIVO.Name = "ACTIVO";
            this.ACTIVO.Visible = false;
            // 
            // HABILITADO
            // 
            this.HABILITADO.DataPropertyName = "Habilitado";
            this.HABILITADO.HeaderText = "HABILITADO";
            this.HABILITADO.Name = "HABILITADO";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageListar.ResumeLayout(false);
            this.tabPageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tabPageNuevo.ResumeLayout(false);
            this.tabPageNuevo.PerformLayout();
            this.tabPageEditar.ResumeLayout(false);
            this.tabPageEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPageNuevo;
        private System.Windows.Forms.TabPage tabPageEditar;
        private System.Windows.Forms.TabPage tabPageListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolverNuevo;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.ComboBox cmbMedidaNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedidaEditar;
        private System.Windows.Forms.Button btnVolverEditar;
        private System.Windows.Forms.Button btnGuardarEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHabilitado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn EDITAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HABILITADO;
    }
}