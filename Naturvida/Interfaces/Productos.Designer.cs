using System;

namespace Naturvida
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.texcodi = new System.Windows.Forms.TextBox();
            this.texdescripcion = new System.Windows.Forms.TextBox();
            this.texvalor = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Boxmenu = new System.Windows.Forms.GroupBox();
            this.Menu2 = new System.Windows.Forms.MenuStrip();
            this.ingresarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabla1 = new System.Windows.Forms.Panel();
            this.comProduc = new System.Windows.Forms.ComboBox();
            this.Tabla2 = new System.Windows.Forms.DataGridView();
            this.Codigo_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.paneliminar = new System.Windows.Forms.Panel();
            this.comProducto = new System.Windows.Forms.ComboBox();
            this.Bteliminar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panelModific = new System.Windows.Forms.Panel();
            this.txtProduc = new System.Windows.Forms.ComboBox();
            this.cambios = new System.Windows.Forms.Button();
            this.txvalor = new System.Windows.Forms.TextBox();
            this.texcodigo = new System.Windows.Forms.TextBox();
            this.texdescrip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btconsultar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.paneIngresar = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.Boxmenu.SuspendLayout();
            this.Menu2.SuspendLayout();
            this.Tabla1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).BeginInit();
            this.paneliminar.SuspendLayout();
            this.panelModific.SuspendLayout();
            this.paneIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // texcodi
            // 
            this.texcodi.Location = new System.Drawing.Point(173, 43);
            this.texcodi.Name = "texcodi";
            this.texcodi.Size = new System.Drawing.Size(205, 26);
            this.texcodi.TabIndex = 1;
            this.texcodi.TextChanged += new System.EventHandler(this.texcodi_TextChanged);
            // 
            // texdescripcion
            // 
            this.texdescripcion.Location = new System.Drawing.Point(174, 116);
            this.texdescripcion.Name = "texdescripcion";
            this.texdescripcion.Size = new System.Drawing.Size(205, 26);
            this.texdescripcion.TabIndex = 2;
            // 
            // texvalor
            // 
            this.texvalor.Location = new System.Drawing.Point(174, 148);
            this.texvalor.Name = "texvalor";
            this.texvalor.Size = new System.Drawing.Size(205, 26);
            this.texvalor.TabIndex = 3;
            this.texvalor.TextChanged += new System.EventHandler(this.texvalor_TextChanged);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(174, 191);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(200, 26);
            this.textCantidad.TabIndex = 4;
            this.textCantidad.TextChanged += new System.EventHandler(this.texcan_TextChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(92, 49);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(71, 19);
            this.Codigo.TabIndex = 5;
            this.Codigo.Text = "Codigo:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(61, 123);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(107, 19);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Descripcion:";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(84, 198);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(84, 19);
            this.Cantidad.TabIndex = 7;
            this.Cantidad.Text = "Cantidad:";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(102, 155);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(54, 19);
            this.Valor.TabIndex = 8;
            this.Valor.Text = "Valor:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(137, 246);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(91, 24);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(264, 246);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(86, 24);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gestion Productos";
            // 
            // Boxmenu
            // 
            this.Boxmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boxmenu.BackgroundImage")));
            this.Boxmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Boxmenu.Controls.Add(this.Menu2);
            this.Boxmenu.Controls.Add(this.panelModific);
            this.Boxmenu.Controls.Add(this.paneIngresar);
            this.Boxmenu.Controls.Add(this.Tabla1);
            this.Boxmenu.Controls.Add(this.paneliminar);
            this.Boxmenu.Location = new System.Drawing.Point(30, 25);
            this.Boxmenu.Name = "Boxmenu";
            this.Boxmenu.Size = new System.Drawing.Size(626, 384);
            this.Boxmenu.TabIndex = 12;
            this.Boxmenu.TabStop = false;
            this.Boxmenu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Menu2
            // 
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProducto,
            this.consultrarProductosToolStripMenuItem,
            this.modificarProductosToolStripMenuItem,
            this.eliminarProductosToolStripMenuItem});
            this.Menu2.Location = new System.Drawing.Point(3, 22);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(620, 25);
            this.Menu2.TabIndex = 11;
            this.Menu2.Text = "menuStrip1";
            // 
            // ingresarProducto
            // 
            this.ingresarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarProducto.Name = "ingresarProducto";
            this.ingresarProducto.Size = new System.Drawing.Size(136, 21);
            this.ingresarProducto.Text = "Ingresar Productos";
            this.ingresarProducto.Click += new System.EventHandler(this.ingrToolStripMenuItem_Click);
            // 
            // consultrarProductosToolStripMenuItem
            // 
            this.consultrarProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultrarProductosToolStripMenuItem.Name = "consultrarProductosToolStripMenuItem";
            this.consultrarProductosToolStripMenuItem.Size = new System.Drawing.Size(150, 21);
            this.consultrarProductosToolStripMenuItem.Text = "Consultrar Productos";
            this.consultrarProductosToolStripMenuItem.Click += new System.EventHandler(this.consultrarProductosToolStripMenuItem_Click);
            // 
            // modificarProductosToolStripMenuItem
            // 
            this.modificarProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarProductosToolStripMenuItem.Name = "modificarProductosToolStripMenuItem";
            this.modificarProductosToolStripMenuItem.Size = new System.Drawing.Size(145, 21);
            this.modificarProductosToolStripMenuItem.Text = "Modificar Productos";
            this.modificarProductosToolStripMenuItem.Click += new System.EventHandler(this.modificarProductosToolStripMenuItem_Click);
            // 
            // eliminarProductosToolStripMenuItem
            // 
            this.eliminarProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProductosToolStripMenuItem.Name = "eliminarProductosToolStripMenuItem";
            this.eliminarProductosToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.eliminarProductosToolStripMenuItem.Text = "Eliminar Productos";
            this.eliminarProductosToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductosToolStripMenuItem_Click);
            // 
            // Tabla1
            // 
            this.Tabla1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tabla1.BackgroundImage")));
            this.Tabla1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tabla1.Controls.Add(this.comProduc);
            this.Tabla1.Controls.Add(this.Tabla2);
            this.Tabla1.Controls.Add(this.btnConsultar1);
            this.Tabla1.Controls.Add(this.label8);
            this.Tabla1.Location = new System.Drawing.Point(26, 50);
            this.Tabla1.Name = "Tabla1";
            this.Tabla1.Size = new System.Drawing.Size(594, 309);
            this.Tabla1.TabIndex = 13;
            this.Tabla1.Visible = false;
            // 
            // comProduc
            // 
            this.comProduc.FormattingEnabled = true;
            this.comProduc.Location = new System.Drawing.Point(169, 47);
            this.comProduc.Name = "comProduc";
            this.comProduc.Size = new System.Drawing.Size(201, 27);
            this.comProduc.TabIndex = 8;
            // 
            // Tabla2
            // 
            this.Tabla2.BackgroundColor = System.Drawing.Color.LightCyan;
            this.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_pro,
            this.Nombre_pro,
            this.Descripcion_pro,
            this.Valor_pro,
            this.Cantidad_pro});
            this.Tabla2.Location = new System.Drawing.Point(52, 145);
            this.Tabla2.Name = "Tabla2";
            this.Tabla2.Size = new System.Drawing.Size(446, 139);
            this.Tabla2.TabIndex = 7;
            // 
            // Codigo_pro
            // 
            this.Codigo_pro.HeaderText = "Codigo";
            this.Codigo_pro.Name = "Codigo_pro";
            this.Codigo_pro.Visible = false;
            // 
            // Nombre_pro
            // 
            this.Nombre_pro.HeaderText = "Nombre";
            this.Nombre_pro.Name = "Nombre_pro";
            // 
            // Descripcion_pro
            // 
            this.Descripcion_pro.HeaderText = "Descripcion";
            this.Descripcion_pro.Name = "Descripcion_pro";
            // 
            // Valor_pro
            // 
            this.Valor_pro.HeaderText = "Valor";
            this.Valor_pro.Name = "Valor_pro";
            // 
            // Cantidad_pro
            // 
            this.Cantidad_pro.HeaderText = "Cantidad";
            this.Cantidad_pro.Name = "Cantidad_pro";
            // 
            // btnConsultar1
            // 
            this.btnConsultar1.Location = new System.Drawing.Point(199, 98);
            this.btnConsultar1.Name = "btnConsultar1";
            this.btnConsultar1.Size = new System.Drawing.Size(104, 23);
            this.btnConsultar1.TabIndex = 6;
            this.btnConsultar1.Text = "Consultar";
            this.btnConsultar1.UseVisualStyleBackColor = true;
            this.btnConsultar1.Click += new System.EventHandler(this.btnConsultar1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Productos:";
            // 
            // paneliminar
            // 
            this.paneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneliminar.BackgroundImage")));
            this.paneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paneliminar.Controls.Add(this.comProducto);
            this.paneliminar.Controls.Add(this.Bteliminar);
            this.paneliminar.Controls.Add(this.label14);
            this.paneliminar.Location = new System.Drawing.Point(26, 50);
            this.paneliminar.Name = "paneliminar";
            this.paneliminar.Size = new System.Drawing.Size(597, 309);
            this.paneliminar.TabIndex = 16;
            this.paneliminar.Visible = false;
            // 
            // comProducto
            // 
            this.comProducto.FormattingEnabled = true;
            this.comProducto.Location = new System.Drawing.Point(174, 41);
            this.comProducto.Name = "comProducto";
            this.comProducto.Size = new System.Drawing.Size(220, 27);
            this.comProducto.TabIndex = 7;
            // 
            // Bteliminar
            // 
            this.Bteliminar.Location = new System.Drawing.Point(199, 103);
            this.Bteliminar.Name = "Bteliminar";
            this.Bteliminar.Size = new System.Drawing.Size(104, 23);
            this.Bteliminar.TabIndex = 6;
            this.Bteliminar.Text = "Eliminar";
            this.Bteliminar.UseVisualStyleBackColor = true;
            this.Bteliminar.Click += new System.EventHandler(this.Bteliminar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(62, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "Productos:";
            // 
            // panelModific
            // 
            this.panelModific.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelModific.BackgroundImage")));
            this.panelModific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelModific.Controls.Add(this.txtProduc);
            this.panelModific.Controls.Add(this.cambios);
            this.panelModific.Controls.Add(this.txvalor);
            this.panelModific.Controls.Add(this.texcodigo);
            this.panelModific.Controls.Add(this.texdescrip);
            this.panelModific.Controls.Add(this.label10);
            this.panelModific.Controls.Add(this.label9);
            this.panelModific.Controls.Add(this.label7);
            this.panelModific.Controls.Add(this.btconsultar);
            this.panelModific.Controls.Add(this.label6);
            this.panelModific.Location = new System.Drawing.Point(26, 50);
            this.panelModific.Name = "panelModific";
            this.panelModific.Size = new System.Drawing.Size(600, 306);
            this.panelModific.TabIndex = 14;
            this.panelModific.Visible = false;
            this.panelModific.Paint += new System.Windows.Forms.PaintEventHandler(this.panelModific_Paint);
            // 
            // txtProduc
            // 
            this.txtProduc.FormattingEnabled = true;
            this.txtProduc.Location = new System.Drawing.Point(163, 19);
            this.txtProduc.Name = "txtProduc";
            this.txtProduc.Size = new System.Drawing.Size(215, 27);
            this.txtProduc.TabIndex = 16;
            // 
            // cambios
            // 
            this.cambios.Location = new System.Drawing.Point(162, 246);
            this.cambios.Name = "cambios";
            this.cambios.Size = new System.Drawing.Size(198, 39);
            this.cambios.TabIndex = 15;
            this.cambios.Text = "Guardar cambios";
            this.cambios.UseVisualStyleBackColor = true;
            this.cambios.Click += new System.EventHandler(this.cambios_Click);
            // 
            // txvalor
            // 
            this.txvalor.Location = new System.Drawing.Point(158, 202);
            this.txvalor.Name = "txvalor";
            this.txvalor.Size = new System.Drawing.Size(220, 26);
            this.txvalor.TabIndex = 13;
            // 
            // texcodigo
            // 
            this.texcodigo.Location = new System.Drawing.Point(159, 127);
            this.texcodigo.Name = "texcodigo";
            this.texcodigo.Size = new System.Drawing.Size(219, 26);
            this.texcodigo.TabIndex = 12;
            // 
            // texdescrip
            // 
            this.texdescrip.Location = new System.Drawing.Point(158, 167);
            this.texdescrip.Name = "texdescrip";
            this.texdescrip.Size = new System.Drawing.Size(220, 26);
            this.texdescrip.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Codigo:";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // btconsultar
            // 
            this.btconsultar.Location = new System.Drawing.Point(199, 74);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.Size = new System.Drawing.Size(104, 36);
            this.btconsultar.TabIndex = 6;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.UseVisualStyleBackColor = true;
            this.btconsultar.Click += new System.EventHandler(this.btnConsultar1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Productos:";
            // 
            // paneIngresar
            // 
            this.paneIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneIngresar.BackgroundImage")));
            this.paneIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paneIngresar.Controls.Add(this.Nombre);
            this.paneIngresar.Controls.Add(this.TxNombre);
            this.paneIngresar.Controls.Add(this.texcodi);
            this.paneIngresar.Controls.Add(this.limpiar);
            this.paneIngresar.Controls.Add(this.Descripcion);
            this.paneIngresar.Controls.Add(this.btnguardar);
            this.paneIngresar.Controls.Add(this.Cantidad);
            this.paneIngresar.Controls.Add(this.texdescripcion);
            this.paneIngresar.Controls.Add(this.texvalor);
            this.paneIngresar.Controls.Add(this.textCantidad);
            this.paneIngresar.Controls.Add(this.Codigo);
            this.paneIngresar.Controls.Add(this.Valor);
            this.paneIngresar.Location = new System.Drawing.Point(26, 50);
            this.paneIngresar.Name = "paneIngresar";
            this.paneIngresar.Size = new System.Drawing.Size(600, 309);
            this.paneIngresar.TabIndex = 12;
            this.paneIngresar.Visible = false;
            this.paneIngresar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(86, 86);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(76, 19);
            this.Nombre.TabIndex = 12;
            this.Nombre.Text = "Nombre:";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(173, 79);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(205, 26);
            this.TxNombre.TabIndex = 11;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(702, 443);
            this.Controls.Add(this.Boxmenu);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Menu2;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Text = " Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.Boxmenu.ResumeLayout(false);
            this.Boxmenu.PerformLayout();
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.Tabla1.ResumeLayout(false);
            this.Tabla1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).EndInit();
            this.paneliminar.ResumeLayout(false);
            this.paneliminar.PerformLayout();
            this.panelModific.ResumeLayout(false);
            this.panelModific.PerformLayout();
            this.paneIngresar.ResumeLayout(false);
            this.paneIngresar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Valor;
        public System.Windows.Forms.TextBox texcodi;
        public System.Windows.Forms.TextBox texdescripcion;
        public System.Windows.Forms.TextBox texvalor;
        public System.Windows.Forms.TextBox textCantidad;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip Menu2;
        private System.Windows.Forms.ToolStripMenuItem consultrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosToolStripMenuItem;
        private System.Windows.Forms.Panel paneIngresar;
        public System.Windows.Forms.GroupBox Boxmenu;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnConsultar1;
        private System.Windows.Forms.Panel panelModific;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btconsultar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cambios;
        public System.Windows.Forms.TextBox txvalor;
        public System.Windows.Forms.TextBox texcodigo;
        public System.Windows.Forms.TextBox texdescrip;
        private System.Windows.Forms.Panel paneliminar;
        public System.Windows.Forms.Button Bteliminar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView Tabla2;
        public System.Windows.Forms.ToolStripMenuItem ingresarProducto;
        public System.Windows.Forms.ComboBox comProduc;
        public System.Windows.Forms.ComboBox comProducto;
        private System.Windows.Forms.Label Nombre;
        public System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_pro;
        public System.Windows.Forms.ComboBox txtProduc;
        public System.Windows.Forms.Panel Tabla1;
    }
}