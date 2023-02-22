using System;

namespace Naturvida
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.Vendedor = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Cant = new System.Windows.Forms.Label();
            this.Arti = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.Label();
            this.datatabla2 = new System.Windows.Forms.DataGridView();
            this.Codigopro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productopro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butTerminarFac = new System.Windows.Forms.Button();
            this.btAgregarPro = new System.Windows.Forms.Button();
            this.txFecha = new System.Windows.Forms.DateTimePicker();
            this.texTotalFac = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.ComboBox();
            this.txcantidad = new System.Windows.Forms.ComboBox();
            this.txarticulo = new System.Windows.Forms.ComboBox();
            this.txclient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSize = true;
            this.Vendedor.BackColor = System.Drawing.Color.Gainsboro;
            this.Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendedor.Location = new System.Drawing.Point(27, 59);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(84, 18);
            this.Vendedor.TabIndex = 0;
            this.Vendedor.Text = "Vendedor:";
            this.Vendedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Vendedor.Click += new System.EventHandler(this.label8_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Gainsboro;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(301, 56);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(59, 18);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "Fecha:";
            // 
            // Cant
            // 
            this.Cant.AutoSize = true;
            this.Cant.BackColor = System.Drawing.Color.Gainsboro;
            this.Cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cant.Location = new System.Drawing.Point(32, 190);
            this.Cant.Name = "Cant";
            this.Cant.Size = new System.Drawing.Size(79, 18);
            this.Cant.TabIndex = 2;
            this.Cant.Text = "Cantidad:";
            // 
            // Arti
            // 
            this.Arti.AutoSize = true;
            this.Arti.BackColor = System.Drawing.Color.Gainsboro;
            this.Arti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arti.Location = new System.Drawing.Point(41, 144);
            this.Arti.Name = "Arti";
            this.Arti.Size = new System.Drawing.Size(70, 18);
            this.Arti.TabIndex = 3;
            this.Arti.Text = "Articulo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(58, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = " ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(295, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "TotalFactura:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(218, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 24);
            this.label14.TabIndex = 6;
            this.label14.Text = "Facturacion";
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.BackColor = System.Drawing.Color.Gainsboro;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.Location = new System.Drawing.Point(48, 108);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(65, 18);
            this.client.TabIndex = 7;
            this.client.Text = "Cliente:";
            this.client.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.client.Click += new System.EventHandler(this.label15_Click);
            // 
            // datatabla2
            // 
            this.datatabla2.BackgroundColor = System.Drawing.Color.LightCyan;
            this.datatabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigopro,
            this.Productopro,
            this.Cantidadpro,
            this.Valorpro});
            this.datatabla2.GridColor = System.Drawing.Color.LightCyan;
            this.datatabla2.Location = new System.Drawing.Point(44, 243);
            this.datatabla2.Name = "datatabla2";
            this.datatabla2.Size = new System.Drawing.Size(449, 150);
            this.datatabla2.TabIndex = 8;
            // 
            // Codigopro
            // 
            this.Codigopro.HeaderText = "Codigo";
            this.Codigopro.Name = "Codigopro";
            // 
            // Productopro
            // 
            this.Productopro.HeaderText = "Producto";
            this.Productopro.Name = "Productopro";
            // 
            // Cantidadpro
            // 
            this.Cantidadpro.HeaderText = "Cantidad";
            this.Cantidadpro.Name = "Cantidadpro";
            // 
            // Valorpro
            // 
            this.Valorpro.HeaderText = "Valor";
            this.Valorpro.Name = "Valorpro";
            // 
            // butTerminarFac
            // 
            this.butTerminarFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTerminarFac.Location = new System.Drawing.Point(44, 398);
            this.butTerminarFac.Name = "butTerminarFac";
            this.butTerminarFac.Size = new System.Drawing.Size(165, 33);
            this.butTerminarFac.TabIndex = 9;
            this.butTerminarFac.Text = "Terminar Factura";
            this.butTerminarFac.UseVisualStyleBackColor = true;
            this.butTerminarFac.Click += new System.EventHandler(this.butTerminarFac_Click);
            // 
            // btAgregarPro
            // 
            this.btAgregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPro.Location = new System.Drawing.Point(390, 108);
            this.btAgregarPro.Name = "btAgregarPro";
            this.btAgregarPro.Size = new System.Drawing.Size(150, 30);
            this.btAgregarPro.TabIndex = 10;
            this.btAgregarPro.Text = "AgregarProducto";
            this.btAgregarPro.UseVisualStyleBackColor = true;
            this.btAgregarPro.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // txFecha
            // 
            this.txFecha.Location = new System.Drawing.Point(366, 56);
            this.txFecha.Name = "txFecha";
            this.txFecha.Size = new System.Drawing.Size(200, 20);
            this.txFecha.TabIndex = 11;
            // 
            // texTotalFac
            // 
            this.texTotalFac.Location = new System.Drawing.Point(409, 400);
            this.texTotalFac.Name = "texTotalFac";
            this.texTotalFac.Size = new System.Drawing.Size(125, 20);
            this.texTotalFac.TabIndex = 12;
            // 
            // txtVendedor
            // 
            this.txtVendedor.FormattingEnabled = true;
            this.txtVendedor.Location = new System.Drawing.Point(117, 56);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(172, 21);
            this.txtVendedor.TabIndex = 13;
            // 
            // txcantidad
            // 
            this.txcantidad.FormattingEnabled = true;
            this.txcantidad.Location = new System.Drawing.Point(117, 190);
            this.txcantidad.Name = "txcantidad";
            this.txcantidad.Size = new System.Drawing.Size(221, 21);
            this.txcantidad.TabIndex = 14;
            // 
            // txarticulo
            // 
            this.txarticulo.FormattingEnabled = true;
            this.txarticulo.Location = new System.Drawing.Point(117, 145);
            this.txarticulo.Name = "txarticulo";
            this.txarticulo.Size = new System.Drawing.Size(221, 21);
            this.txarticulo.TabIndex = 15;
            this.txarticulo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txclient
            // 
            this.txclient.FormattingEnabled = true;
            this.txclient.Location = new System.Drawing.Point(119, 105);
            this.txclient.Name = "txclient";
            this.txclient.Size = new System.Drawing.Size(219, 21);
            this.txclient.TabIndex = 16;
            // 
            // Factura
            // 
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(583, 433);
            this.Controls.Add(this.txclient);
            this.Controls.Add(this.txarticulo);
            this.Controls.Add(this.txcantidad);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.texTotalFac);
            this.Controls.Add(this.txFecha);
            this.Controls.Add(this.btAgregarPro);
            this.Controls.Add(this.butTerminarFac);
            this.Controls.Add(this.datatabla2);
            this.Controls.Add(this.client);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Arti);
            this.Controls.Add(this.Cant);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Vendedor);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button Agregar;
        public System.Windows.Forms.Button terminar;
        public System.Windows.Forms.TextBox txttotalfac;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtCantida;
        public System.Windows.Forms.ComboBox txtCliente;
        public System.Windows.Forms.ComboBox txtArticulo;
        public System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button butTerminarFac;
        public System.Windows.Forms.Button btAgregarPro;
        public System.Windows.Forms.TextBox texTotalFac;
        public System.Windows.Forms.ComboBox txtVendedor;
        public System.Windows.Forms.ComboBox txcantidad;
        public System.Windows.Forms.ComboBox txarticulo;
        public System.Windows.Forms.ComboBox txclient;
        public System.Windows.Forms.DateTimePicker txFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigopro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productopro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorpro;
        public System.Windows.Forms.Label Vendedor;
        public System.Windows.Forms.Label Cant;
        public System.Windows.Forms.Label Arti;
        public System.Windows.Forms.Label client;
        public System.Windows.Forms.DataGridView datatabla2;
    }
}