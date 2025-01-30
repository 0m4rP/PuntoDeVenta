namespace PuntoDeVentaSD
{
    partial class VentanaPrincipal
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.impVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_arc_Impuesto = new System.Windows.Forms.ToolStripTextBox();
            this.descuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_arc_Descuento = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Principal = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_ClienteBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Impuesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AddProd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(816, 524);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(115, 25);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.inventarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impVentaToolStripMenuItem,
            this.descuentoToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem2.Text = "Imp. Venta y descuentos";
            // 
            // impVentaToolStripMenuItem
            // 
            this.impVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_arc_Impuesto});
            this.impVentaToolStripMenuItem.Name = "impVentaToolStripMenuItem";
            this.impVentaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.impVentaToolStripMenuItem.Text = "Imp.Venta";
            // 
            // txt_arc_Impuesto
            // 
            this.txt_arc_Impuesto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_arc_Impuesto.Name = "txt_arc_Impuesto";
            this.txt_arc_Impuesto.Size = new System.Drawing.Size(100, 23);
            this.txt_arc_Impuesto.Text = "19";
            this.txt_arc_Impuesto.TextChanged += new System.EventHandler(this.ImpVentaYDescChanged);
            // 
            // descuentoToolStripMenuItem
            // 
            this.descuentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_arc_Descuento});
            this.descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            this.descuentoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.descuentoToolStripMenuItem.Text = "Descuento";
            // 
            // txt_arc_Descuento
            // 
            this.txt_arc_Descuento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_arc_Descuento.Name = "txt_arc_Descuento";
            this.txt_arc_Descuento.Size = new System.Drawing.Size(100, 23);
            this.txt_arc_Descuento.TextChanged += new System.EventHandler(this.ImpVentaYDescChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem3.Text = "Usuario";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            this.historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            this.historialDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.historialDeFacturasToolStripMenuItem.Text = "Historial de Facturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntoDeVentaSD.Properties.Resources.Captura_de_pantalla_2025_01_28_211700;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Principal
            // 
            this.dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Principal.Location = new System.Drawing.Point(183, 27);
            this.dgv_Principal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Principal.Name = "dgv_Principal";
            this.dgv_Principal.RowTemplate.Height = 24;
            this.dgv_Principal.Size = new System.Drawing.Size(748, 287);
            this.dgv_Principal.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(15, 191);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_ClienteBuscar
            // 
            this.txt_ClienteBuscar.Location = new System.Drawing.Point(15, 162);
            this.txt_ClienteBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ClienteBuscar.Name = "txt_ClienteBuscar";
            this.txt_ClienteBuscar.Size = new System.Drawing.Size(151, 22);
            this.txt_ClienteBuscar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "N° Factura";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 261);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.AllowDrop = true;
            this.txt_Cliente.Enabled = false;
            this.txt_Cliente.Location = new System.Drawing.Point(15, 318);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(151, 22);
            this.txt_Cliente.TabIndex = 10;
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Location = new System.Drawing.Point(672, 321);
            this.btn_Facturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(249, 129);
            this.btn_Facturar.TabIndex = 11;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 55);
            this.label5.TabIndex = 13;
            this.label5.Text = "0.00";
            // 
            // txt_Impuesto
            // 
            this.txt_Impuesto.AllowDrop = true;
            this.txt_Impuesto.Enabled = false;
            this.txt_Impuesto.Location = new System.Drawing.Point(12, 415);
            this.txt_Impuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Impuesto.Name = "txt_Impuesto";
            this.txt_Impuesto.Size = new System.Drawing.Size(151, 22);
            this.txt_Impuesto.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Imp. Venta";
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.AllowDrop = true;
            this.txt_Descuento.Enabled = false;
            this.txt_Descuento.Location = new System.Drawing.Point(12, 473);
            this.txt_Descuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(151, 22);
            this.txt_Descuento.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descuento";
            // 
            // txt_CodigoProducto
            // 
            this.txt_CodigoProducto.Location = new System.Drawing.Point(233, 340);
            this.txt_CodigoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CodigoProducto.Name = "txt_CodigoProducto";
            this.txt_CodigoProducto.Size = new System.Drawing.Size(151, 22);
            this.txt_CodigoProducto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Codigo de venta";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(429, 340);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(151, 22);
            this.txt_Cantidad.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Subtotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 39);
            this.label11.TabIndex = 23;
            this.label11.Text = "0.00";
            // 
            // btn_AddProd
            // 
            this.btn_AddProd.Location = new System.Drawing.Point(308, 385);
            this.btn_AddProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddProd.Name = "btn_AddProd";
            this.btn_AddProd.Size = new System.Drawing.Size(195, 38);
            this.btn_AddProd.TabIndex = 24;
            this.btn_AddProd.Text = "Agregar Producto";
            this.btn_AddProd.UseVisualStyleBackColor = true;
            this.btn_AddProd.Click += new System.EventHandler(this.btn_AddProd_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 562);
            this.Controls.Add(this.btn_AddProd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_CodigoProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Impuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ClienteBuscar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dgv_Principal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaPrincipal";
            this.Text = "Form2";
            this.TextChanged += new System.EventHandler(this.ImpVentaYDescChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Principal;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_ClienteBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Impuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodigoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_arc_Impuesto;
        private System.Windows.Forms.ToolStripMenuItem descuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_arc_Descuento;
        private System.Windows.Forms.ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddProd;
    }
}