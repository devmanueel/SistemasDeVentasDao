namespace Views.Formularios
{
    partial class frmProducto
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageListar = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPageNuevo = new System.Windows.Forms.TabPage();
            this.cmbCategoriaNuevo = new System.Windows.Forms.ComboBox();
            this.btnVolverNuevo = new System.Windows.Forms.Button();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCompraNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEditar = new System.Windows.Forms.TabPage();
            this.btnVolverEditar = new System.Windows.Forms.Button();
            this.btnGuardarEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcionNuevo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioVentaNuevo = new System.Windows.Forms.TextBox();
            this.txtCantidadNuevo = new System.Windows.Forms.NumericUpDown();
            this.txtCantidadEditar = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVentaEditar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionEditar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoEditar = new System.Windows.Forms.TextBox();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioCompraEcitar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbHabilitado = new System.Windows.Forms.ComboBox();
            this.tabPrincipal.SuspendLayout();
            this.tabPageListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPageNuevo.SuspendLayout();
            this.tabPageEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPageListar);
            this.tabPrincipal.Controls.Add(this.tabPageNuevo);
            this.tabPrincipal.Controls.Add(this.tabPageEditar);
            this.tabPrincipal.ItemSize = new System.Drawing.Size(80, 20);
            this.tabPrincipal.Location = new System.Drawing.Point(28, 62);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(945, 466);
            this.tabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPrincipal.TabIndex = 8;
            // 
            // tabPageListar
            // 
            this.tabPageListar.BackColor = System.Drawing.Color.Wheat;
            this.tabPageListar.Controls.Add(this.btnNuevo);
            this.tabPageListar.Controls.Add(this.btnBuscar);
            this.tabPageListar.Controls.Add(this.dgvProductos);
            this.tabPageListar.Controls.Add(this.txtBuscar);
            this.tabPageListar.Location = new System.Drawing.Point(4, 24);
            this.tabPageListar.Name = "tabPageListar";
            this.tabPageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListar.Size = new System.Drawing.Size(937, 438);
            this.tabPageListar.TabIndex = 3;
            this.tabPageListar.Text = "Lista";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Aqua;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(53, 36);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(190, 34);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NuevaProducto";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(673, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 34);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(53, 94);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(839, 318);
            this.dgvProductos.TabIndex = 5;
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
            this.tabPageNuevo.Controls.Add(this.txtCantidadNuevo);
            this.tabPageNuevo.Controls.Add(this.txtPrecioVentaNuevo);
            this.tabPageNuevo.Controls.Add(this.label10);
            this.tabPageNuevo.Controls.Add(this.label9);
            this.tabPageNuevo.Controls.Add(this.txtDescripcionNuevo);
            this.tabPageNuevo.Controls.Add(this.label8);
            this.tabPageNuevo.Controls.Add(this.label2);
            this.tabPageNuevo.Controls.Add(this.txtCodigoNuevo);
            this.tabPageNuevo.Controls.Add(this.cmbCategoriaNuevo);
            this.tabPageNuevo.Controls.Add(this.btnVolverNuevo);
            this.tabPageNuevo.Controls.Add(this.btnGuardarNuevo);
            this.tabPageNuevo.Controls.Add(this.label4);
            this.tabPageNuevo.Controls.Add(this.txtPrecioCompraNuevo);
            this.tabPageNuevo.Controls.Add(this.label1);
            this.tabPageNuevo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageNuevo.Location = new System.Drawing.Point(4, 24);
            this.tabPageNuevo.Name = "tabPageNuevo";
            this.tabPageNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNuevo.Size = new System.Drawing.Size(937, 438);
            this.tabPageNuevo.TabIndex = 1;
            this.tabPageNuevo.Text = "Nuevo";
            // 
            // cmbCategoriaNuevo
            // 
            this.cmbCategoriaNuevo.FormattingEnabled = true;
            this.cmbCategoriaNuevo.Location = new System.Drawing.Point(146, 55);
            this.cmbCategoriaNuevo.Name = "cmbCategoriaNuevo";
            this.cmbCategoriaNuevo.Size = new System.Drawing.Size(237, 24);
            this.cmbCategoriaNuevo.TabIndex = 7;
            // 
            // btnVolverNuevo
            // 
            this.btnVolverNuevo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolverNuevo.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverNuevo.Location = new System.Drawing.Point(52, 256);
            this.btnVolverNuevo.Name = "btnVolverNuevo";
            this.btnVolverNuevo.Size = new System.Drawing.Size(110, 39);
            this.btnVolverNuevo.TabIndex = 6;
            this.btnVolverNuevo.Text = "Volver";
            this.btnVolverNuevo.UseVisualStyleBackColor = false;
            this.btnVolverNuevo.Click += new System.EventHandler(this.btnVolverNuevo_Click);
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGuardarNuevo.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevo.Location = new System.Drawing.Point(650, 256);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(119, 39);
            this.btnGuardarNuevo.TabIndex = 5;
            this.btnGuardarNuevo.Text = "Guardar";
            this.btnGuardarNuevo.UseVisualStyleBackColor = false;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio De Compra";
            // 
            // txtPrecioCompraNuevo
            // 
            this.txtPrecioCompraNuevo.Location = new System.Drawing.Point(590, 57);
            this.txtPrecioCompraNuevo.Name = "txtPrecioCompraNuevo";
            this.txtPrecioCompraNuevo.Size = new System.Drawing.Size(237, 22);
            this.txtPrecioCompraNuevo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // tabPageEditar
            // 
            this.tabPageEditar.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPageEditar.Controls.Add(this.cmbHabilitado);
            this.tabPageEditar.Controls.Add(this.label14);
            this.tabPageEditar.Controls.Add(this.txtCantidadEditar);
            this.tabPageEditar.Controls.Add(this.txtPrecioVentaEditar);
            this.tabPageEditar.Controls.Add(this.label5);
            this.tabPageEditar.Controls.Add(this.label6);
            this.tabPageEditar.Controls.Add(this.txtDescripcionEditar);
            this.tabPageEditar.Controls.Add(this.label7);
            this.tabPageEditar.Controls.Add(this.label11);
            this.tabPageEditar.Controls.Add(this.txtCodigoEditar);
            this.tabPageEditar.Controls.Add(this.cmbCategoriaEditar);
            this.tabPageEditar.Controls.Add(this.label12);
            this.tabPageEditar.Controls.Add(this.txtPrecioCompraEcitar);
            this.tabPageEditar.Controls.Add(this.label13);
            this.tabPageEditar.Controls.Add(this.btnVolverEditar);
            this.tabPageEditar.Controls.Add(this.btnGuardarEditar);
            this.tabPageEditar.Location = new System.Drawing.Point(4, 24);
            this.tabPageEditar.Name = "tabPageEditar";
            this.tabPageEditar.Size = new System.Drawing.Size(937, 438);
            this.tabPageEditar.TabIndex = 2;
            this.tabPageEditar.Text = "Editar";
            // 
            // btnVolverEditar
            // 
            this.btnVolverEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolverEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEditar.Location = new System.Drawing.Point(685, 357);
            this.btnVolverEditar.Name = "btnVolverEditar";
            this.btnVolverEditar.Size = new System.Drawing.Size(164, 39);
            this.btnVolverEditar.TabIndex = 10;
            this.btnVolverEditar.Text = "Volver";
            this.btnVolverEditar.UseVisualStyleBackColor = false;
            this.btnVolverEditar.Click += new System.EventHandler(this.btnVolverEditar_Click);
            // 
            // btnGuardarEditar
            // 
            this.btnGuardarEditar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGuardarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEditar.Location = new System.Drawing.Point(65, 357);
            this.btnGuardarEditar.Name = "btnGuardarEditar";
            this.btnGuardarEditar.Size = new System.Drawing.Size(157, 39);
            this.btnGuardarEditar.TabIndex = 9;
            this.btnGuardarEditar.Text = "Guardar";
            this.btnGuardarEditar.UseVisualStyleBackColor = false;
            this.btnGuardarEditar.Click += new System.EventHandler(this.btnGuardarEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventario /Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio de Venta";
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(146, 117);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(237, 22);
            this.txtCodigoNuevo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Descripcion";
            // 
            // txtDescripcionNuevo
            // 
            this.txtDescripcionNuevo.Location = new System.Drawing.Point(146, 179);
            this.txtDescripcionNuevo.Name = "txtDescripcionNuevo";
            this.txtDescripcionNuevo.Size = new System.Drawing.Size(237, 22);
            this.txtDescripcionNuevo.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cantidad";
            // 
            // txtPrecioVentaNuevo
            // 
            this.txtPrecioVentaNuevo.Location = new System.Drawing.Point(590, 125);
            this.txtPrecioVentaNuevo.Name = "txtPrecioVentaNuevo";
            this.txtPrecioVentaNuevo.Size = new System.Drawing.Size(237, 22);
            this.txtPrecioVentaNuevo.TabIndex = 16;
            // 
            // txtCantidadNuevo
            // 
            this.txtCantidadNuevo.Location = new System.Drawing.Point(590, 181);
            this.txtCantidadNuevo.Name = "txtCantidadNuevo";
            this.txtCantidadNuevo.Size = new System.Drawing.Size(120, 22);
            this.txtCantidadNuevo.TabIndex = 17;
            // 
            // txtCantidadEditar
            // 
            this.txtCantidadEditar.Location = new System.Drawing.Point(612, 171);
            this.txtCantidadEditar.Name = "txtCantidadEditar";
            this.txtCantidadEditar.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadEditar.TabIndex = 29;
            // 
            // txtPrecioVentaEditar
            // 
            this.txtPrecioVentaEditar.Location = new System.Drawing.Point(612, 115);
            this.txtPrecioVentaEditar.Name = "txtPrecioVentaEditar";
            this.txtPrecioVentaEditar.Size = new System.Drawing.Size(237, 20);
            this.txtPrecioVentaEditar.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Descripcion";
            // 
            // txtDescripcionEditar
            // 
            this.txtDescripcionEditar.Location = new System.Drawing.Point(168, 169);
            this.txtDescripcionEditar.Name = "txtDescripcionEditar";
            this.txtDescripcionEditar.Size = new System.Drawing.Size(237, 20);
            this.txtDescripcionEditar.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(454, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio de Venta";
            // 
            // txtCodigoEditar
            // 
            this.txtCodigoEditar.Location = new System.Drawing.Point(168, 107);
            this.txtCodigoEditar.Name = "txtCodigoEditar";
            this.txtCodigoEditar.Size = new System.Drawing.Size(237, 20);
            this.txtCodigoEditar.TabIndex = 22;
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(168, 45);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(237, 21);
            this.cmbCategoriaEditar.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(437, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Precio De Compra";
            // 
            // txtPrecioCompraEcitar
            // 
            this.txtPrecioCompraEcitar.Location = new System.Drawing.Point(612, 47);
            this.txtPrecioCompraEcitar.Name = "txtPrecioCompraEcitar";
            this.txtPrecioCompraEcitar.Size = new System.Drawing.Size(237, 20);
            this.txtPrecioCompraEcitar.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "Categoria";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(497, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "Habilitado";
            // 
            // cmbHabilitado
            // 
            this.cmbHabilitado.FormattingEnabled = true;
            this.cmbHabilitado.Location = new System.Drawing.Point(612, 231);
            this.cmbHabilitado.Name = "cmbHabilitado";
            this.cmbHabilitado.Size = new System.Drawing.Size(237, 21);
            this.cmbHabilitado.TabIndex = 32;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 582);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.label3);
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageListar.ResumeLayout(false);
            this.tabPageListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPageNuevo.ResumeLayout(false);
            this.tabPageNuevo.PerformLayout();
            this.tabPageEditar.ResumeLayout(false);
            this.tabPageEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPageListar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPageNuevo;
        private System.Windows.Forms.ComboBox cmbCategoriaNuevo;
        private System.Windows.Forms.Button btnVolverNuevo;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCompraNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageEditar;
        private System.Windows.Forms.Button btnVolverEditar;
        private System.Windows.Forms.Button btnGuardarEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtCantidadNuevo;
        private System.Windows.Forms.TextBox txtPrecioVentaNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcionNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtCantidadEditar;
        private System.Windows.Forms.TextBox txtPrecioVentaEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioCompraEcitar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbHabilitado;
    }
}